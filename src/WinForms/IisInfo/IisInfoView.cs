using System.ComponentModel;

using Microsoft.Web.Administration;

namespace Hackathon.HackstreetBoys.WinForms.IisInfo;

public partial class IisInfoView : UserControl
{
    public IisInfoView()
    {
        InitializeComponent();
    }

    private void IisInfoView_Load(object sender, EventArgs e)
    {
        using ServerManager manager = new();

        grdInfo.SelectedObject = new IisInfo
        {
            Name = "MyWebSite",
            Description = "My web site's application pool",
            Schemes = new[]
            {
                new IisInfoBindings
                {
                    Scheme = "https",
                    Dns = "myapp.com",
                    Port = 443,
                },
                new IisInfoBindings
                {
                    Scheme = "http",
                    Dns = "myapp.com",
                    Port = 8080,
                }
            },
            LogFile = manager.Sites[0].State.ToString(),
        };
    }
}

public sealed class IisInfo
{
    [Category("Site")]
    [Description("The name of the web site")]
    public string? Name { get; set; }

    [Category("Application Pool")]
    [Description("The name of the application pool")]
    public string? Description { get; set; }

    public IisInfoBindings[]? Schemes { get; set; }

    [Bindable(true)]
    [Browsable(true)]
    public string? LogFile { get; set; }
}

public sealed class IisInfoBindings
{
    public string? Scheme { get; set; }

    public int Port { get; set; } = 80;

    public string? Dns { get; set; }

    public override string ToString() => $"{Scheme}://{Dns}:{Port}";
}
