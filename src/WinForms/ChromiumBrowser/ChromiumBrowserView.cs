using System.Diagnostics;

using CefSharp;

namespace Hackathon.HackstreetBoys.WinForms.ChromiumBrowser;

public partial class ChromiumBrowserView : UserControl
{
    public ChromiumBrowserView()
    {
        InitializeComponent();
    }

    public required SiteDetails Details { get; init; }

    private void BrowserView_Load(object sender, EventArgs e)
    {
        GoHome();
    }

    private void tbtnBrowserBack_Click(object sender, EventArgs e)
    {
        browser.Back();
    }

    private void tbtnBrowserForward_Click(object sender, EventArgs e)
    {
        browser.Forward();
    }

    private void tbtnBrowserHome_Click(object sender, EventArgs e)
    {
        GoHome();
    }

    private void tbtnBrowserRefresh_Click(object sender, EventArgs e)
    {
        browser.Refresh();
    }

    private void tbtnBrowserDevTools_Click(object sender, EventArgs e)
    {
        browser.ShowDevTools();
    }

    private void tlblTitle_Click(object sender, EventArgs e)
    {
        Process.Start(new ProcessStartInfo(browser.Address) { UseShellExecute = true });
    }

    private void browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
    {
        DoInvoke(() => tsProgress.Visible = e.IsLoading);
    }

    private void browser_TitleChanged(object sender, TitleChangedEventArgs e)
    {
        DoInvoke(() => tlblTitle.Text = e.Title);
    }

    private void browser_StatusMessage(object sender, StatusMessageEventArgs e)
    {
        DoInvoke(() => tslblStatus.Text = e.Value);
    }

    private void browser_AddressChanged(object sender, AddressChangedEventArgs e)
    {
        DoInvoke(() => txtAddress.Text = e.Address);
    }

    private void GoHome()
    {
        browser.LoadUrl(Details.Url);
    }

    private void DoInvoke(Action action)
    {
        //If you are planning on using a similar function in your own code then please be sure to
        //have a quick read over https://stackoverflow.com/questions/1874728/avoid-calling-invoke-when-the-control-is-disposed
        //No action
        if (Disposing || IsDisposed || !IsHandleCreated)
            return;

        if (InvokeRequired)
            BeginInvoke(action);
        else
            action.Invoke();
    }
}
