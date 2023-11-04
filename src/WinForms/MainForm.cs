using System.Diagnostics;

namespace Hackathon.HackstreetBoys.WinForms;

public partial class MainForm : Form
{
    private UserControl? _currentView;
    private SiteDetails _details = null!;

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        if (!LoadSite())
            Application.Exit();
    }

    private void miFileExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void miFileLoadSite_Click(object sender, EventArgs e)
    {
        LoadSite();
    }

    private void toolboxNavigation_Click(object sender, EventArgs e)
    {
        if (sender is not ToolStripButton button)
            throw new InvalidOperationException("Clicked item is not a tool strip button");
        ActivateNavView(button);
    }

    private bool LoadSite()
    {
        using SelectSiteDialog dlgSelectSite = new();
        if (dlgSelectSite.ShowDialog(this) == DialogResult.Cancel)
            return false;

        //TODO: Check if the selected site is the same as the active site.

        _details = dlgSelectSite.GetResult();

        lblStatusSiteName.Text = _details.Site;
        lblStatusDirectory.Text = _details.Directory;
        lblStatusUrl.Text = _details.Url;
        lblStatusLogDirectory.Text = _details.LogDirectory;

        ActivateFirstNavView();

        return true;
    }

    private void ActivateNavView(ToolStripButton navButton)
    {
        if (_currentView is not null)
        {
            pnlView.Controls.RemoveAt(0);
            _currentView.Dispose();
            _currentView = null;
        }

        _currentView = navButton.Name switch
        {
            nameof(tsNavConfig) => new ConfigView { Details = _details },
            nameof(tsNavLogging) => new LoggingView(),
            nameof(tsNavBrowse) => new BrowserView(),
            _ => throw new InvalidOperationException($"Unrecognized navigation button {navButton.Name}."),
        };
        _currentView.Dock = DockStyle.Fill;
        pnlView.Controls.Add(_currentView);

        foreach (ToolStripButton btn in toolbarNavigation.Items.OfType<ToolStripButton>())
            btn.Checked = false;
        navButton.Checked = true;
    }

    private void ActivateFirstNavView()
    {
        ActivateNavView(toolbarNavigation.Items.OfType<ToolStripButton>().First());
    }

    private void miSiteExplore_Click(object sender, EventArgs e)
    {
        Process.Start("explorer.exe", _details.Directory);
    }

    private void miSiteExploreLogs_Click(object sender, EventArgs e)
    {
        Process.Start("explorer.exe", _details.LogDirectory);
    }

    private void miSiteBrowse_Click(object sender, EventArgs e)
    {
        Process.Start(new ProcessStartInfo(_details.Url) { UseShellExecute = true });
    }
}
