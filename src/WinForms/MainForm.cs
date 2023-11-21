using System.Diagnostics;

using Hackathon.HackstreetBoys.WinForms.EventViewer;
using Hackathon.HackstreetBoys.WinForms.IisInfo;

using Microsoft.Web.Administration;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

using Application = System.Windows.Forms.Application;

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

    private void miSiteRestart_Click(object sender, EventArgs e)
    {
        using ServerManager manager = new();
        Site site = manager.Sites[_details.Site];
        site.Stop();
        site.Start();
    }

    private void miSiteRecycleAppPool_Click(object sender, EventArgs e)
    {
        using ServerManager manager = new();
        string appPoolName = manager.Sites[_details.Site].Applications["/"].ApplicationPoolName;
        manager.ApplicationPools[appPoolName].Recycle();
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

    private void menuView_Click(object sender, EventArgs e)
    {
        ActivateNavView(sender);
    }

    private bool LoadSite()
    {
        using SelectSiteDialog dlgSelectSite = new();
        if (dlgSelectSite.ShowDialog(this) == DialogResult.Cancel)
            return false;

        //TODO: Check if the selected site is the same as the active site.

        _details = dlgSelectSite.GetResult();

        lblStatusSiteName.Text = _details.Site;
        lblStatusAppPool.Text = _details.AppPool;
        lblStatusDirectory.Text = _details.Directory;
        lblStatusUrl.Text = _details.Url;
        lblStatusLogDirectory.Text = _details.LogDirectory;

        ActivateFirstNavView();

        return true;
    }

    private void ActivateNavView(object sender)
    {
        var control = (ToolStripItem)sender;
        string index = (string)control.Tag;

        if (_currentView is not null)
        {
            pnlView.Controls.RemoveAt(0);
            _currentView.Dispose();
            _currentView = null;
        }

        _currentView = index switch
        {
            "1" => new ConfigView { Details = _details },
            "2" => new LoggingView { Details = _details },
            "3" => new EventViewerView(),
            "4" => new BrowserView { Details = _details },
            "5" => new IisInfoView(),
            _ => throw new InvalidOperationException($"Unrecognized navigation button {index}."),
        };

        _currentView.Dock = DockStyle.Fill;
        pnlView.Controls.Add(_currentView);

        lblViewHeader.Text = control.Text;

        foreach (ToolStripMenuItem menu in menuMainView.DropDownItems.OfType<ToolStripMenuItem>())
            menu.Checked = string.Equals(index, (string)menu.Tag);

        foreach (ToolStripButton btn in toolbarNavigation.Items.OfType<ToolStripButton>())
            btn.Checked = string.Equals(index, (string)btn.Tag);
    }

    private void ActivateFirstNavView()
    {
        ActivateNavView(menuMainView.DropDownItems.OfType<ToolStripMenuItem>().First());
    }
}
