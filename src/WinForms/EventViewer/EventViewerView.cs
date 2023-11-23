using System.Diagnostics;

namespace Hackathon.HackstreetBoys.WinForms.EventViewer;

public partial class EventViewerView : UserControl
{
    public EventViewerView()
    {
        InitializeComponent();
    }

    public required SiteDetails Details { get; init; }

    private void EventViewerView_Load(object sender, EventArgs e)
    {
        RefreshLogs();
    }

    private void tbtnRefresh_Click(object sender, EventArgs e)
    {
        RefreshLogs();
    }

    private void RefreshLogs()
    {
        grdLogs.Rows.Clear();

        // Get data
        using EventLog log = new("Application");

        IEnumerable<EventLogEntry> logs = log.Entries.Cast<EventLogEntry>();
        if (!string.IsNullOrWhiteSpace(ttxtSources.Text))
        {
            string[] sources =
                ttxtSources.Text.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            if (sources.Length > 0)
                logs = logs.Where(e => sources.Any(s => e.Source.Contains(s, StringComparison.OrdinalIgnoreCase)));
        }

        logs = logs.Take(100).OrderByDescending(e => e.TimeWritten);

        // Set up cell styles
        DataGridViewCellStyle errorStyle = new() { BackColor = Color.Red };
        DataGridViewCellStyle warningStyle = new() { BackColor = Color.Yellow };
        DataGridViewCellStyle infoStyle = new() { BackColor = Color.Green, ForeColor = Color.White };

        foreach (EventLogEntry entry in logs)
        {
            int newLineIndex = entry.Message.IndexOfAny(new[] { '\n', '\r' });
            string messageSummary = newLineIndex < 0 ? entry.Message : entry.Message[..newLineIndex];

            DataGridViewCellStyle style = entry.EntryType switch
            {
                EventLogEntryType.Error or EventLogEntryType.FailureAudit => errorStyle,
                EventLogEntryType.Warning => warningStyle,
                EventLogEntryType.Information or EventLogEntryType.SuccessAudit => infoStyle,
                _ => throw new ArgumentOutOfRangeException(),
            };

            DataGridViewRow row = new() { Tag = entry.Message };
            row.Cells.AddRange(
                new DataGridViewTextBoxCell { Value = entry.TimeWritten.ToString("s"), Style = style },
                new DataGridViewTextBoxCell { Value = entry.EntryType, Style = style },
                new DataGridViewTextBoxCell { Value = entry.Source, Style = style },
                new DataGridViewTextBoxCell { Value = messageSummary, Style = style });
            grdLogs.Rows.Add(row);
        }
    }

    private void grdLogs_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
        txtMessage.Clear();

        DataGridViewRow row = grdLogs.Rows[e.RowIndex];
        if (row.Tag is string message)
            txtMessage.Text = message;
    }
}
