using System.Diagnostics;

using Microsoft.Web.Administration;

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

    private void browser_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
    {
        tsProgress.Visible = true;
    }

    private void browser_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
    {
        tsProgress.Visible = false;
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

    private void tslblAddress_Click(object sender, EventArgs e)
    {
        Process.Start(new ProcessStartInfo(browser.Source.AbsoluteUri) { UseShellExecute = true });
    }

    private async void tbtnBrowserDevTools_Click(object sender, EventArgs e)
    {
        await browser.EnsureCoreWebView2Async();
        browser.CoreWebView2.OpenDevToolsWindow();
        browser.CoreWebView2.OpenTaskManagerWindow();
    }

    private void GoHome()
    {
        browser.Source = new Uri(Details.Url, UriKind.Absolute);
    }
}
