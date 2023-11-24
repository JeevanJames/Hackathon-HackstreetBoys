namespace Hackathon.HackstreetBoys.WinForms.CrashLogs;

public partial class CrashLogsView : UserControl
{
    public CrashLogsView()
    {
        InitializeComponent();
    }

    public required SiteDetails Details { get; init; }

    private void CrashLogsView_Load(object sender, EventArgs e)
    {
        foreach (CrashLogsData data in CrashLogsData.DemoData)
        {
            DataGridViewRow row = new() { Tag = data.FullError };
            row.Cells.AddRange(
                new DataGridViewTextBoxCell { Value = data.Timestamp },
                new DataGridViewTextBoxCell { Value = data.Category },
                new DataGridViewTextBoxCell { Value = data.Error });
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
