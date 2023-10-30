using System.Diagnostics;
using System.Text.RegularExpressions;

using Microsoft.Web.Administration;

namespace Hackathon.HackstreetBoys.Cli;

[Command<IisCommand>("watch",
    HelpText = "Watches for changes to configuration in an IIS website and restarts the website.")]
public sealed class WatchCommand : Command
{
    private DateTimeOffset _lastChangedTimestamp = DateTimeOffset.MinValue;

    [Argument(Optional = false, Order = 0,
        HelpName = "website name",
        HelpText = "The name of the IIS website to watch. If --search is specified, this will be treated as a regular expression for finding the website.")]
    [Aargh.Transformers.ValidateStringLength(minLength: 1, maxLength: int.MaxValue)]
    public required string WebsiteName { get; set; }

    [Flag("search", "s",
        HelpText = "If specified, treats the website name as a regular expression pattern and displays all matching websites for you to select one.")]
    public bool Search { get; set; }

    protected override void HandleCommand()
    {
        using ServerManager manager = new();

        Site? site = Search
            ? PromptForSite(manager)
            : manager.Sites.FirstOrDefault(s => s.Name.Equals(WebsiteName, StringComparison.OrdinalIgnoreCase));

        if (site is null)
            throw new CliException("Could not find a matching site.");

        MarkupLineInterpolated($"Selected site: [{Cyan1}]{site.Name}[/]");

        string physicalPath = site.GetDirectory();
        MarkupLineInterpolated($"Physical path: [{Cyan1}]{physicalPath}[/]");

        Binding binding = site.Bindings.Count == 1
            ? site.Bindings[0]
            : site.Bindings.FirstOrDefault(b => b.Protocol.Equals("https", StringComparison.OrdinalIgnoreCase)) ??
              site.Bindings[0];
        string host = string.IsNullOrEmpty(binding.Host) ? "localhost" : binding.Host;
        string url = $"{binding.Protocol}://{host}:{binding.EndPoint.Port}";
        MarkupLineInterpolated($"URL: [{Cyan1}]{url}[/]");

        using FileSystemWatcher watcher = new(physicalPath, "*.json")
        {
            NotifyFilter = NotifyFilters.LastWrite,
            EnableRaisingEvents = true
        };
        watcher.Changed += (_, args) => OnConfigFileChanged(args.Name!, site);

        MarkupLineInterpolated($"Watching for config changes in [{Cyan1}]{site.Name}[/].");
        MarkupLineInterpolated($"[{Magenta1}]Ctrl+R[/] Force restart | [{Magenta1}]Ctrl+B[/] Browse | [{Magenta1}]Ctrl+O[/] Open Config | [{Magenta1}]Ctrl+Q[/] Stop watching");

        string? keysPressed;
        do
        {
            keysPressed = GetKeysPressed(System.Console.ReadKey(intercept: true));
            switch (keysPressed)
            {
                case "Ctrl+R":
                    MarkupInterpolated($"Forcing restart of site [{Cyan1}]{site.Name}[/]...");
                    site.Stop();
                    site.Start();
                    MarkupLineInterpolated($"[{Green}]Completed.[/]");
                    break;

                case "Ctrl+B":
                    try
                    {
                        ProcessStartInfo psi = new(url) { UseShellExecute = true, };
                        Process.Start(psi);
                    }
                    catch (Exception ex)
                    {
                        WriteException(ex);
                    }

                    break;

                case "Ctrl+O":
                    string[] configFiles = Directory.GetFiles(physicalPath, "*.json", SearchOption.TopDirectoryOnly);
                    string configFilePath = configFiles.Length == 1 ? configFiles[0] : PromptForConfigFile(configFiles);
                    ProcessStartInfo psi2 = new(configFilePath) { UseShellExecute = true, };
                    Process.Start(psi2);
                    break;
            }
        } while (keysPressed != "Ctrl+Q");
    }

    private static string GetKeysPressed(ConsoleKeyInfo keyInfo)
    {
        string keys = string.Empty;

        if (keyInfo.Modifiers != 0)
        {
            if ((keyInfo.Modifiers & ConsoleModifiers.Control) != 0)
                keys += "Ctrl+";
            if ((keyInfo.Modifiers & ConsoleModifiers.Alt) != 0)
                keys += "Alt+";
            if ((keyInfo.Modifiers & ConsoleModifiers.Shift) != 0)
                keys += "Shift+";
        }

        return keys + keyInfo.Key switch
        {
            ConsoleKey.Escape => "Esc",
            ConsoleKey.Enter => "Enter",
            _ => keyInfo.Key.ToString(),
        };
    }

    private void OnConfigFileChanged(string fileName, Site site)
    {
        DateTimeOffset currentTimestamp = DateTimeOffset.Now;
        TimeSpan difference = currentTimestamp.Subtract(_lastChangedTimestamp);

        if (difference.TotalMilliseconds > 500)
        {
            MarkupInterpolated($"[{Magenta1}][[{DateTimeOffset.Now:T}]][/] File [{Yellow1}]{fileName}[/] changed. Restarting... ");
            try
            {
                site.Stop();
                site.Start();
                MarkupLineInterpolated($"[{Green}]Completed.[/]");
            }
            catch (Exception ex)
            {
                MarkupLineInterpolated($"[{Red}]Errored![/]");
                WriteException(ex);
            }
        }

        _lastChangedTimestamp = currentTimestamp;
    }

    private Site? PromptForSite(ServerManager manager)
    {
        Regex siteNamePattern = new(WebsiteName, RegexOptions.Compiled | RegexOptions.ExplicitCapture,
            TimeSpan.FromSeconds(1));
        List<Site> matchingSites = manager.Sites
            .Where(site => siteNamePattern.IsMatch(site.Name))
            .OrderBy(site => site.Name)
            .ToList();
        if (matchingSites.Count == 1)
            return matchingSites[0];
        return Prompt(new SelectionPrompt<Site>()
            .Title($"Found {matchingSites.Count} matching sites. Choose one:")
            .PageSize(10)
            .MoreChoicesText($"[{Grey}]Use up and down arrows to show more sites[/]")
            .AddChoices(matchingSites)
            .UseConverter(site => site.Name));
    }

    private string PromptForConfigFile(string[] configFiles)
    {
        return Prompt(new SelectionPrompt<string>()
            .Title("Choose config file to open:")
            .PageSize(10)
            .MoreChoicesText($"[{Grey}]Use up and down arrows to show more files[/]")
            .AddChoices(configFiles)
            .UseConverter(Path.GetFileName));
    }
}
