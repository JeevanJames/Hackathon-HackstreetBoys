namespace Hackathon.HackstreetBoys.WinForms;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        MenuStrip menuMain;
        ToolStripMenuItem menuMainFile;
        ToolStripSeparator miSeparatorFile1;
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        ToolStripMenuItem menuMainSite;
        miFileLoadSite = new ToolStripMenuItem();
        miFileExit = new ToolStripMenuItem();
        miSiteRestart = new ToolStripMenuItem();
        miSiteRecycleAppPool = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        miSiteExplore = new ToolStripMenuItem();
        miSiteExploreLogs = new ToolStripMenuItem();
        miSiteBrowse = new ToolStripMenuItem();
        menuMainView = new ToolStripMenuItem();
        miViewConfig = new ToolStripMenuItem();
        miViewLogging = new ToolStripMenuItem();
        miViewEvents = new ToolStripMenuItem();
        miViewBrowser = new ToolStripMenuItem();
        miViewIisInfo = new ToolStripMenuItem();
        toolbarMain = new ToolStrip();
        tbtnMainLoadSite = new ToolStripButton();
        toolStripSeparator2 = new ToolStripSeparator();
        tbtnMainRestartSite = new ToolStripButton();
        tbtnMainRecycleAppPool = new ToolStripButton();
        toolbarNavigation = new ToolStrip();
        tsNavConfig = new ToolStripButton();
        tsNavLogging = new ToolStripButton();
        tsNavEventViewer = new ToolStripButton();
        tsNavBrowse = new ToolStripButton();
        tsNavInfo = new ToolStripButton();
        pnlView = new Panel();
        statusBar = new StatusStrip();
        lblStatusSiteName = new ToolStripStatusLabel();
        lblStatusAppPool = new ToolStripStatusLabel();
        lblStatusDirectory = new ToolStripStatusLabel();
        lblStatusUrl = new ToolStripStatusLabel();
        lblStatusLogDirectory = new ToolStripStatusLabel();
        lblViewHeader = new Label();
        menuMain = new MenuStrip();
        menuMainFile = new ToolStripMenuItem();
        miSeparatorFile1 = new ToolStripSeparator();
        menuMainSite = new ToolStripMenuItem();
        menuMain.SuspendLayout();
        toolbarMain.SuspendLayout();
        toolbarNavigation.SuspendLayout();
        statusBar.SuspendLayout();
        SuspendLayout();
        // 
        // menuMain
        // 
        menuMain.Items.AddRange(new ToolStripItem[] { menuMainFile, menuMainSite, menuMainView });
        menuMain.Location = new Point(0, 0);
        menuMain.Name = "menuMain";
        menuMain.Size = new Size(800, 24);
        menuMain.TabIndex = 0;
        menuMain.Text = "Main menu";
        // 
        // menuMainFile
        // 
        menuMainFile.DropDownItems.AddRange(new ToolStripItem[] { miFileLoadSite, miSeparatorFile1, miFileExit });
        menuMainFile.Name = "menuMainFile";
        menuMainFile.Size = new Size(37, 20);
        menuMainFile.Text = "&File";
        // 
        // miFileLoadSite
        // 
        miFileLoadSite.Name = "miFileLoadSite";
        miFileLoadSite.Size = new Size(131, 22);
        miFileLoadSite.Text = "Load &Site...";
        miFileLoadSite.Click += miFileLoadSite_Click;
        // 
        // miSeparatorFile1
        // 
        miSeparatorFile1.Name = "miSeparatorFile1";
        miSeparatorFile1.Size = new Size(128, 6);
        // 
        // miFileExit
        // 
        miFileExit.Image = (Image)resources.GetObject("miFileExit.Image");
        miFileExit.Name = "miFileExit";
        miFileExit.Size = new Size(131, 22);
        miFileExit.Text = "E&xit";
        miFileExit.Click += miFileExit_Click;
        // 
        // menuMainSite
        // 
        menuMainSite.DropDownItems.AddRange(new ToolStripItem[] { miSiteRestart, miSiteRecycleAppPool, toolStripSeparator1, miSiteExplore, miSiteExploreLogs, miSiteBrowse });
        menuMainSite.Name = "menuMainSite";
        menuMainSite.Size = new Size(38, 20);
        menuMainSite.Text = "&Site";
        // 
        // miSiteRestart
        // 
        miSiteRestart.Image = (Image)resources.GetObject("miSiteRestart.Image");
        miSiteRestart.Name = "miSiteRestart";
        miSiteRestart.ShortcutKeys = Keys.F5;
        miSiteRestart.Size = new Size(306, 22);
        miSiteRestart.Text = "Restart Site";
        miSiteRestart.Click += miSiteRestart_Click;
        // 
        // miSiteRecycleAppPool
        // 
        miSiteRecycleAppPool.Image = (Image)resources.GetObject("miSiteRecycleAppPool.Image");
        miSiteRecycleAppPool.Name = "miSiteRecycleAppPool";
        miSiteRecycleAppPool.ShortcutKeys = Keys.Control | Keys.F5;
        miSiteRecycleAppPool.Size = new Size(306, 22);
        miSiteRecycleAppPool.Text = "Recycle Application Pool";
        miSiteRecycleAppPool.Click += miSiteRecycleAppPool_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(303, 6);
        // 
        // miSiteExplore
        // 
        miSiteExplore.Name = "miSiteExplore";
        miSiteExplore.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D;
        miSiteExplore.Size = new Size(306, 22);
        miSiteExplore.Text = "&Explore Directory";
        miSiteExplore.Click += miSiteExplore_Click;
        // 
        // miSiteExploreLogs
        // 
        miSiteExploreLogs.Name = "miSiteExploreLogs";
        miSiteExploreLogs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.L;
        miSiteExploreLogs.Size = new Size(306, 22);
        miSiteExploreLogs.Text = "Explorer Log Directory";
        miSiteExploreLogs.Click += miSiteExploreLogs_Click;
        // 
        // miSiteBrowse
        // 
        miSiteBrowse.Name = "miSiteBrowse";
        miSiteBrowse.ShortcutKeys = Keys.Control | Keys.Shift | Keys.B;
        miSiteBrowse.Size = new Size(306, 22);
        miSiteBrowse.Text = "&Browse Site in Default Browser";
        miSiteBrowse.Click += miSiteBrowse_Click;
        // 
        // menuMainView
        // 
        menuMainView.DropDownItems.AddRange(new ToolStripItem[] { miViewConfig, miViewLogging, miViewEvents, miViewBrowser, miViewIisInfo });
        menuMainView.Name = "menuMainView";
        menuMainView.Size = new Size(44, 20);
        menuMainView.Text = "&View";
        // 
        // miViewConfig
        // 
        miViewConfig.Name = "miViewConfig";
        miViewConfig.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D1;
        miViewConfig.Size = new Size(241, 22);
        miViewConfig.Tag = "1";
        miViewConfig.Text = "&Configuration";
        miViewConfig.Click += menuView_Click;
        // 
        // miViewLogging
        // 
        miViewLogging.Name = "miViewLogging";
        miViewLogging.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D2;
        miViewLogging.Size = new Size(241, 22);
        miViewLogging.Tag = "2";
        miViewLogging.Text = "&Logging";
        miViewLogging.Click += menuView_Click;
        // 
        // miViewEvents
        // 
        miViewEvents.Name = "miViewEvents";
        miViewEvents.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D3;
        miViewEvents.Size = new Size(241, 22);
        miViewEvents.Tag = "3";
        miViewEvents.Text = "&Event Viewer Logs";
        miViewEvents.Click += menuView_Click;
        // 
        // miViewBrowser
        // 
        miViewBrowser.Name = "miViewBrowser";
        miViewBrowser.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D4;
        miViewBrowser.Size = new Size(241, 22);
        miViewBrowser.Tag = "4";
        miViewBrowser.Text = "&Browser";
        miViewBrowser.Click += menuView_Click;
        // 
        // miViewIisInfo
        // 
        miViewIisInfo.Name = "miViewIisInfo";
        miViewIisInfo.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D5;
        miViewIisInfo.Size = new Size(241, 22);
        miViewIisInfo.Tag = "5";
        miViewIisInfo.Text = "IIS Information";
        miViewIisInfo.Click += menuView_Click;
        // 
        // toolbarMain
        // 
        toolbarMain.GripStyle = ToolStripGripStyle.Hidden;
        toolbarMain.Items.AddRange(new ToolStripItem[] { tbtnMainLoadSite, toolStripSeparator2, tbtnMainRestartSite, tbtnMainRecycleAppPool });
        toolbarMain.Location = new Point(0, 24);
        toolbarMain.Name = "toolbarMain";
        toolbarMain.Size = new Size(800, 33);
        toolbarMain.TabIndex = 1;
        // 
        // tbtnMainLoadSite
        // 
        tbtnMainLoadSite.AutoSize = false;
        tbtnMainLoadSite.Image = (Image)resources.GetObject("tbtnMainLoadSite.Image");
        tbtnMainLoadSite.ImageTransparentColor = Color.Magenta;
        tbtnMainLoadSite.Name = "tbtnMainLoadSite";
        tbtnMainLoadSite.Size = new Size(84, 30);
        tbtnMainLoadSite.Text = "Load Site...";
        tbtnMainLoadSite.ToolTipText = "Load another site...";
        tbtnMainLoadSite.Click += miFileLoadSite_Click;
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(6, 33);
        // 
        // tbtnMainRestartSite
        // 
        tbtnMainRestartSite.AutoSize = false;
        tbtnMainRestartSite.DisplayStyle = ToolStripItemDisplayStyle.Image;
        tbtnMainRestartSite.Image = (Image)resources.GetObject("tbtnMainRestartSite.Image");
        tbtnMainRestartSite.ImageTransparentColor = Color.Magenta;
        tbtnMainRestartSite.Name = "tbtnMainRestartSite";
        tbtnMainRestartSite.Size = new Size(30, 30);
        tbtnMainRestartSite.Text = "Restart Site";
        tbtnMainRestartSite.Click += miSiteRestart_Click;
        // 
        // tbtnMainRecycleAppPool
        // 
        tbtnMainRecycleAppPool.AutoSize = false;
        tbtnMainRecycleAppPool.DisplayStyle = ToolStripItemDisplayStyle.Image;
        tbtnMainRecycleAppPool.Image = (Image)resources.GetObject("tbtnMainRecycleAppPool.Image");
        tbtnMainRecycleAppPool.ImageTransparentColor = Color.Magenta;
        tbtnMainRecycleAppPool.Name = "tbtnMainRecycleAppPool";
        tbtnMainRecycleAppPool.Size = new Size(30, 30);
        tbtnMainRecycleAppPool.Text = "Recycle Application Pool";
        tbtnMainRecycleAppPool.Click += miSiteRecycleAppPool_Click;
        // 
        // toolbarNavigation
        // 
        toolbarNavigation.BackColor = SystemColors.ControlDark;
        toolbarNavigation.Dock = DockStyle.Left;
        toolbarNavigation.GripStyle = ToolStripGripStyle.Hidden;
        toolbarNavigation.Items.AddRange(new ToolStripItem[] { tsNavConfig, tsNavLogging, tsNavEventViewer, tsNavBrowse, tsNavInfo });
        toolbarNavigation.Location = new Point(0, 57);
        toolbarNavigation.Name = "toolbarNavigation";
        toolbarNavigation.Size = new Size(41, 368);
        toolbarNavigation.TabIndex = 2;
        toolbarNavigation.Text = "Configuration";
        // 
        // tsNavConfig
        // 
        tsNavConfig.AutoSize = false;
        tsNavConfig.DisplayStyle = ToolStripItemDisplayStyle.Image;
        tsNavConfig.Image = (Image)resources.GetObject("tsNavConfig.Image");
        tsNavConfig.ImageTransparentColor = Color.Magenta;
        tsNavConfig.Name = "tsNavConfig";
        tsNavConfig.Size = new Size(40, 40);
        tsNavConfig.Tag = "1";
        tsNavConfig.Text = "Configuration";
        tsNavConfig.Click += menuView_Click;
        // 
        // tsNavLogging
        // 
        tsNavLogging.AutoSize = false;
        tsNavLogging.DisplayStyle = ToolStripItemDisplayStyle.Image;
        tsNavLogging.Image = (Image)resources.GetObject("tsNavLogging.Image");
        tsNavLogging.ImageTransparentColor = Color.Magenta;
        tsNavLogging.Name = "tsNavLogging";
        tsNavLogging.Size = new Size(40, 40);
        tsNavLogging.Tag = "2";
        tsNavLogging.Text = "Logging";
        tsNavLogging.Click += menuView_Click;
        // 
        // tsNavEventViewer
        // 
        tsNavEventViewer.AutoSize = false;
        tsNavEventViewer.DisplayStyle = ToolStripItemDisplayStyle.Image;
        tsNavEventViewer.Image = (Image)resources.GetObject("tsNavEventViewer.Image");
        tsNavEventViewer.ImageTransparentColor = Color.Magenta;
        tsNavEventViewer.Name = "tsNavEventViewer";
        tsNavEventViewer.Size = new Size(40, 40);
        tsNavEventViewer.Tag = "3";
        tsNavEventViewer.Text = "Event Viewer";
        tsNavEventViewer.ToolTipText = "Event Viewer";
        tsNavEventViewer.Click += menuView_Click;
        // 
        // tsNavBrowse
        // 
        tsNavBrowse.AutoSize = false;
        tsNavBrowse.DisplayStyle = ToolStripItemDisplayStyle.Image;
        tsNavBrowse.Image = (Image)resources.GetObject("tsNavBrowse.Image");
        tsNavBrowse.ImageTransparentColor = Color.Magenta;
        tsNavBrowse.Name = "tsNavBrowse";
        tsNavBrowse.Size = new Size(40, 40);
        tsNavBrowse.Tag = "4";
        tsNavBrowse.Text = "Browse";
        tsNavBrowse.Click += menuView_Click;
        // 
        // tsNavInfo
        // 
        tsNavInfo.AutoSize = false;
        tsNavInfo.CheckOnClick = true;
        tsNavInfo.DisplayStyle = ToolStripItemDisplayStyle.Image;
        tsNavInfo.Image = (Image)resources.GetObject("tsNavInfo.Image");
        tsNavInfo.ImageTransparentColor = Color.Magenta;
        tsNavInfo.Name = "tsNavInfo";
        tsNavInfo.Size = new Size(40, 40);
        tsNavInfo.Tag = "5";
        tsNavInfo.Text = "IIS Information";
        tsNavInfo.Click += menuView_Click;
        // 
        // pnlView
        // 
        pnlView.BorderStyle = BorderStyle.Fixed3D;
        pnlView.Dock = DockStyle.Fill;
        pnlView.Location = new Point(41, 92);
        pnlView.Name = "pnlView";
        pnlView.Size = new Size(759, 333);
        pnlView.TabIndex = 3;
        // 
        // statusBar
        // 
        statusBar.Items.AddRange(new ToolStripItem[] { lblStatusSiteName, lblStatusAppPool, lblStatusDirectory, lblStatusUrl, lblStatusLogDirectory });
        statusBar.Location = new Point(0, 425);
        statusBar.Name = "statusBar";
        statusBar.ShowItemToolTips = true;
        statusBar.Size = new Size(800, 25);
        statusBar.TabIndex = 4;
        // 
        // lblStatusSiteName
        // 
        lblStatusSiteName.AutoToolTip = true;
        lblStatusSiteName.BorderSides = ToolStripStatusLabelBorderSides.Right;
        lblStatusSiteName.BorderStyle = Border3DStyle.Etched;
        lblStatusSiteName.Name = "lblStatusSiteName";
        lblStatusSiteName.Size = new Size(63, 20);
        lblStatusSiteName.Text = "Site name";
        lblStatusSiteName.ToolTipText = "Site name. Click to copy to clipboard.";
        // 
        // lblStatusAppPool
        // 
        lblStatusAppPool.BorderSides = ToolStripStatusLabelBorderSides.Right;
        lblStatusAppPool.BorderStyle = Border3DStyle.Etched;
        lblStatusAppPool.Image = (Image)resources.GetObject("lblStatusAppPool.Image");
        lblStatusAppPool.Name = "lblStatusAppPool";
        lblStatusAppPool.Size = new Size(115, 20);
        lblStatusAppPool.Text = "Application Pool";
        lblStatusAppPool.ToolTipText = "Application pool";
        // 
        // lblStatusDirectory
        // 
        lblStatusDirectory.BorderSides = ToolStripStatusLabelBorderSides.Right;
        lblStatusDirectory.BorderStyle = Border3DStyle.Etched;
        lblStatusDirectory.Image = (Image)resources.GetObject("lblStatusDirectory.Image");
        lblStatusDirectory.Name = "lblStatusDirectory";
        lblStatusDirectory.Size = new Size(75, 20);
        lblStatusDirectory.Text = "Directory";
        lblStatusDirectory.TextAlign = ContentAlignment.MiddleLeft;
        lblStatusDirectory.ToolTipText = "Site directory. Click to explore.";
        lblStatusDirectory.Click += miSiteExplore_Click;
        // 
        // lblStatusUrl
        // 
        lblStatusUrl.BorderSides = ToolStripStatusLabelBorderSides.Right;
        lblStatusUrl.BorderStyle = Border3DStyle.Etched;
        lblStatusUrl.Image = (Image)resources.GetObject("lblStatusUrl.Image");
        lblStatusUrl.IsLink = true;
        lblStatusUrl.LinkBehavior = LinkBehavior.AlwaysUnderline;
        lblStatusUrl.Name = "lblStatusUrl";
        lblStatusUrl.Size = new Size(48, 20);
        lblStatusUrl.Text = "URL";
        lblStatusUrl.ToolTipText = "Site URL. Click to open in the default browser.";
        lblStatusUrl.Click += miSiteBrowse_Click;
        // 
        // lblStatusLogDirectory
        // 
        lblStatusLogDirectory.AutoToolTip = true;
        lblStatusLogDirectory.Image = (Image)resources.GetObject("lblStatusLogDirectory.Image");
        lblStatusLogDirectory.Name = "lblStatusLogDirectory";
        lblStatusLogDirectory.Size = new Size(97, 20);
        lblStatusLogDirectory.Text = "Log Directory.";
        lblStatusLogDirectory.ToolTipText = "Log directory. Click to explore.";
        lblStatusLogDirectory.Click += miSiteExploreLogs_Click;
        // 
        // lblViewHeader
        // 
        lblViewHeader.BackColor = SystemColors.Highlight;
        lblViewHeader.Dock = DockStyle.Top;
        lblViewHeader.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        lblViewHeader.ForeColor = SystemColors.HighlightText;
        lblViewHeader.Location = new Point(41, 57);
        lblViewHeader.Name = "lblViewHeader";
        lblViewHeader.Padding = new Padding(5);
        lblViewHeader.Size = new Size(759, 35);
        lblViewHeader.TabIndex = 5;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(pnlView);
        Controls.Add(lblViewHeader);
        Controls.Add(toolbarNavigation);
        Controls.Add(toolbarMain);
        Controls.Add(menuMain);
        Controls.Add(statusBar);
        MainMenuStrip = menuMain;
        Name = "MainForm";
        Text = "DOP Troubleshooter";
        Load += MainForm_Load;
        menuMain.ResumeLayout(false);
        menuMain.PerformLayout();
        toolbarMain.ResumeLayout(false);
        toolbarMain.PerformLayout();
        toolbarNavigation.ResumeLayout(false);
        toolbarNavigation.PerformLayout();
        statusBar.ResumeLayout(false);
        statusBar.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ToolStripMenuItem miFileExit;
    private ToolStrip toolbarMain;
    private ToolStrip toolbarNavigation;
    private ToolStripButton tsNavConfig;
    private ToolStripButton tsNavLogging;
    private ToolStripButton tsNavBrowse;
    private Panel pnlView;
    private StatusStrip statusBar;
    private ToolStripStatusLabel lblStatusSiteName;
    private ToolStripStatusLabel lblStatusDirectory;
    private ToolStripStatusLabel lblStatusUrl;
    private ToolStripButton tbtnMainLoadSite;
    private ToolStripMenuItem miFileLoadSite;
    private ToolStripMenuItem miSiteExplore;
    private ToolStripMenuItem miSiteBrowse;
    private ToolStripMenuItem miSiteExploreLogs;
    private ToolStripStatusLabel lblStatusLogDirectory;
    private ToolStripButton tsNavEventViewer;
    private ToolStripStatusLabel lblStatusAppPool;
    private ToolStripMenuItem miSiteRestart;
    private ToolStripMenuItem miSiteRecycleAppPool;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripButton tbtnMainRestartSite;
    private ToolStripButton tbtnMainRecycleAppPool;
    private ToolStripMenuItem menuMainView;
    private ToolStripMenuItem miViewConfig;
    private ToolStripMenuItem miViewLogging;
    private ToolStripMenuItem miViewEvents;
    private ToolStripMenuItem miViewBrowser;
    private ToolStripMenuItem miViewIisInfo;
    private ToolStripButton tsNavInfo;
    private Label lblViewHeader;
}
