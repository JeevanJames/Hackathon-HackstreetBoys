using System.Diagnostics;

namespace Hackathon.HackstreetBoys.WinForms;
public partial class BrowserView : UserControl
{
    public BrowserView()
    {
        InitializeComponent();
    }

    public required SiteDetails Details { get; init; }

    private void BrowserView_Load(object sender, EventArgs e)
    {
        GoHome();
    }

    private void browser_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
    {
        tslblAddress.Text = browser.Source.ToString();
    }

    private void tbtnBrowserBack_Click(object sender, EventArgs e)
    {
        browser.GoBack();
    }

    private void tbtnBrowserForward_Click(object sender, EventArgs e)
    {
        browser.GoForward();
    }

    private void tbtnBrowserHome_Click(object sender, EventArgs e)
    {
        GoHome();
    }

    private void tbtnBrowserRefresh_Click(object sender, EventArgs e)
    {
        browser.Refresh();
    }

    private void GoHome()
    {
        browser.Source = new Uri(Details.Url, UriKind.Absolute);
    }

    private void tslblAddress_Click(object sender, EventArgs e)
    {
        Process.Start(new ProcessStartInfo(browser.Source.AbsoluteUri) { UseShellExecute = true });
    }
}
