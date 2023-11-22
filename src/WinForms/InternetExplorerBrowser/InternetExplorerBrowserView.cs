namespace Hackathon.HackstreetBoys.WinForms.InternetExplorerBrowser;
public partial class InternetExplorerBrowserView : UserControl
{
    private readonly WebBrowser _browser;

    public InternetExplorerBrowserView()
    {
        InitializeComponent();

        _browser = new WebBrowser();

        SuspendLayout();
        _browser.Dock = DockStyle.Fill;
        _browser.ScriptErrorsSuppressed = true;
        pnlBrowser.Controls.Add(_browser);
        ResumeLayout();
    }

    public required SiteDetails Details { get; init; }

    private void InternetExplorerBrowserView_Load(object sender, EventArgs e)
    {
        _browser.Navigate(Details.Url);
    }
}
