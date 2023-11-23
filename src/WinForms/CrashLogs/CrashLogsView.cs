namespace Hackathon.HackstreetBoys.WinForms.CrashLogs;

public partial class CrashLogsView : UserControl
{
    public CrashLogsView()
    {
        InitializeComponent();
    }

    public required SiteDetails Details { get; init; }
}
