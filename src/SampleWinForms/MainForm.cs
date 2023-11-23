namespace SampleWinForms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
    }

    private void btnGo_Click(object sender, EventArgs e)
    {
        browser.LoadUrl(txtAddress.Text);
    }

    private void browser_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
    {
        DoInvoke(() => progress.Visible = e.IsLoading);
    }

    public void DoInvoke(Action action)
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

    private void browser_StatusMessage(object sender, CefSharp.StatusMessageEventArgs e)
    {
        DoInvoke(() => lblStatus.Text = e.Value);
    }

    private void browser_TitleChanged(object sender, CefSharp.TitleChangedEventArgs e)
    {
        DoInvoke(() => Text = e.Title);
    }
}
