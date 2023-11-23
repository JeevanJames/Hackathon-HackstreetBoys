using System.Diagnostics;
using System.Text;

namespace Hackathon.HackstreetBoys.WinForms.EventViewer;

public partial class EventViewerView : UserControl
{
    public EventViewerView()
    {
        InitializeComponent();
    }

    private void EventViewerView_Load(object sender, EventArgs e)
    {
        RefreshLogs();
    }

    private void tbtnRefresh_Click(object sender, EventArgs e)
    {
        RefreshLogs(ttxtSources.Text);
    }

    private void RefreshLogs(string? sourcesStr = null)
    {
        StringBuilder sb = new();

        using EventLog log = new("Application");
        sb.AppendLine(log.Source);

        string[] sources = string.IsNullOrWhiteSpace(sourcesStr)
            ? Array.Empty<string>()
            : sourcesStr.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        if (sources.Length == 0)
            sources = Array.Empty<string>();

        IEnumerable<EventLogEntry> logs = log.Entries.Cast<EventLogEntry>();
        if (sources.Length > 0)
            logs = logs.Where(e => sources.Any(s => e.Source.Contains(s, StringComparison.OrdinalIgnoreCase)));
        logs = logs.Take(100);
        foreach (EventLogEntry entry in logs)
            sb.AppendLine($"[{entry.TimeWritten:s} {entry.EntryType}] {entry.InstanceId} | {entry.Source} | {entry.Message}");

        txtEvents.Text = sb.ToString();
    }
}
