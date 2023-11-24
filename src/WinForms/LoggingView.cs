using System.Text.Json;
using System.Text.Json.Serialization;

namespace Hackathon.HackstreetBoys.WinForms;

public partial class LoggingView : UserControl
{
    public LoggingView()
    {
        InitializeComponent();
    }

    public required SiteDetails Details { get; init; }

    private async void LoggingView_Load(object sender, EventArgs e)
    {
        tabsLogging.TabPages.Remove(tabLoggingException);
        await RefreshView();
    }

    private async void tbtnLoggingRefresh_Click(object sender, EventArgs e)
    {
        await RefreshView();
    }

    private async void tbtnLoggingReset_Click(object sender, EventArgs e)
    {
        tbtnLoggingError.Checked = true;
        tbtnLoggingWarning.Checked = true;
        tbtnLoggingInfo.Checked = true;
        tbtnLoggingDebug.Checked = false;

        ttxtLoggingSource.Text = string.Empty;
        ttxtLoggingMessage.Text = string.Empty;

        await RefreshView();
    }

    private void tbtnLoggingLevel_Click(object sender, EventArgs e)
    {
        if (!tbtnLoggingError.Checked && !tbtnLoggingWarning.Checked &&
            !tbtnLoggingInfo.Checked && !tbtnLoggingDebug.Checked)
        {
            ((ToolStripButton)sender).Checked = true;
        }
    }

    private void gridLogs_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
        gridProperties.Rows.Clear();

        DataGridViewRow row = gridLogs.Rows[e.RowIndex];
        if (row.Tag is LogEntry { AdditionalProperties: { } properties } entry)
        {
            foreach ((string propertyName, object propertyValue) in properties)
            {
                DataGridViewRow propertyRow = new();
                propertyRow.Cells.AddRange(
                    new DataGridViewTextBoxCell { Value = propertyName },
                    new DataGridViewTextBoxCell { Value = propertyValue?.ToString() ?? "[NULL]" });
                gridProperties.Rows.Add(propertyRow);
            }

            txtLoggingMessage.Text = entry.Message;

            txtLoggingException.Text = entry.Exception ?? string.Empty;

            if (string.IsNullOrWhiteSpace(entry.Exception))
            {
                if (tabsLogging.TabPages.ContainsKey(tabLoggingException.Name))
                    tabsLogging.TabPages.Remove(tabLoggingException);
            }
            else
            {
                if (!tabsLogging.TabPages.ContainsKey(tabLoggingException.Name))
                    tabsLogging.TabPages.Add(tabLoggingException);
            }
        }
    }

    private async Task RefreshView()
    {
        // Reset controls
        gridLogs.Rows.Clear();

        DirectoryInfo directory = new(Details.LogDirectory);
        if (!directory.Exists)
            return;
        FileInfo? logFile = directory.GetFiles("*.txt", SearchOption.TopDirectoryOnly)
            .MaxBy(file => file.CreationTime);
        if (logFile is null)
            return;

        List<string> sources = new();

        await using FileStream logStream = new(logFile.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        using StreamReader reader = new(logStream);
        string? line = await reader.ReadLineAsync();
        while (line is not null)
        {
            LogEntry? entry = JsonSerializer.Deserialize<LogEntry>(line);
            if (entry is null)
            {
                throw new InvalidOperationException($"""
                    Cannot read the following line from the log file:
                    {line}
                    """);
            }

            bool display = entry.ActualLevel switch
            {
                "ERROR" => tbtnLoggingError.Checked,
                "WARN" => tbtnLoggingWarning.Checked,
                "INFO" => tbtnLoggingInfo.Checked,
                "DEBUG" => tbtnLoggingDebug.Checked,
                _ => false,
            };

            if (display && entry.Source is not null && !string.IsNullOrWhiteSpace(ttxtLoggingSource.Text))
                display = display && entry.Source.Contains(ttxtLoggingSource.Text, StringComparison.OrdinalIgnoreCase);

            if (display && !string.IsNullOrWhiteSpace(ttxtLoggingMessage.Text))
                display = display && entry.Message.Contains(ttxtLoggingMessage.Text, StringComparison.OrdinalIgnoreCase);

            if (display)
            {
                if (!sources.Exists(s => entry.Source is not null && s.Equals(entry.Source, StringComparison.OrdinalIgnoreCase)))
                    sources.Add(entry.Source!);

                DataGridViewRow row = new() { Tag = entry };
                row.Cells.AddRange(
                    new DataGridViewTextBoxCell { Value = entry.Timestamp.ToLocalTime().ToString("s") },
                    new DataGridViewTextBoxCell { Value = entry.ActualLevel },
                    new DataGridViewTextBoxCell { Value = entry.Source },
                    new DataGridViewTextBoxCell { Value = entry.Message });
                gridLogs.Rows.Add(row);
            }

            line = await reader.ReadLineAsync();
        }

        ttxtLoggingSource.AutoCompleteCustomSource.Clear();
        ttxtLoggingSource.AutoCompleteCustomSource.AddRange(sources.OrderBy(s => s).ToArray());
    }
}

public sealed class LogEntry
{
    [JsonPropertyName("@t")]
    public DateTimeOffset Timestamp { get; set; }

    [JsonPropertyName("@l")]
    public string? Level { get; set; }

    public string ActualLevel =>
        Level switch
        {
            null when Exception is not null => "ERROR",
            null => "INFO",
            _ => Level.ToUpperInvariant()
        };

    [JsonPropertyName("@m")]
    public required string Message { get; set; }

    [JsonPropertyName("SourceContext")]
    public string? Source { get; set; }

    [JsonPropertyName("@x")]
    public string? Exception { get; set; }

    [JsonExtensionData]
    public Dictionary<string, object>? AdditionalProperties { get; set; }
}
