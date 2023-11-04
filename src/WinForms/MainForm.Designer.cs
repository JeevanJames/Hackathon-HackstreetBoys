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
        miSiteExplore = new ToolStripMenuItem();
        miSiteExploreLogs = new ToolStripMenuItem();
        miSiteBrowse = new ToolStripMenuItem();
        toolbarMain = new ToolStrip();
        btnToolbarLoadSite = new ToolStripButton();
        toolbarNavigation = new ToolStrip();
        tsNavConfig = new ToolStripButton();
        tsNavLogging = new ToolStripButton();
        tsNavBrowse = new ToolStripButton();
        pnlView = new Panel();
        statusBar = new StatusStrip();
        lblStatusSiteName = new ToolStripStatusLabel();
        lblStatusDirectory = new ToolStripStatusLabel();
        lblStatusUrl = new ToolStripStatusLabel();
        lblStatusLogDirectory = new ToolStripStatusLabel();
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
        menuMain.Items.AddRange(new ToolStripItem[] { menuMainFile, menuMainSite });
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
        menuMainSite.DropDownItems.AddRange(new ToolStripItem[] { miSiteExplore, miSiteExploreLogs, miSiteBrowse });
        menuMainSite.Name = "menuMainSite";
        menuMainSite.Size = new Size(38, 20);
        menuMainSite.Text = "&Site";
        // 
        // miSiteExplore
        // 
        miSiteExplore.Name = "miSiteExplore";
        miSiteExplore.Size = new Size(233, 22);
        miSiteExplore.Text = "&Explore Directory";
        miSiteExplore.Click += miSiteExplore_Click;
        // 
        // miSiteExploreLogs
        // 
        miSiteExploreLogs.Name = "miSiteExploreLogs";
        miSiteExploreLogs.Size = new Size(233, 22);
        miSiteExploreLogs.Text = "Explorer Log Directory";
        miSiteExploreLogs.Click += miSiteExploreLogs_Click;
        // 
        // miSiteBrowse
        // 
        miSiteBrowse.Name = "miSiteBrowse";
        miSiteBrowse.Size = new Size(233, 22);
        miSiteBrowse.Text = "&Browse Site in Default Browser";
        miSiteBrowse.Click += miSiteBrowse_Click;
        // 
        // toolbarMain
        // 
        toolbarMain.GripStyle = ToolStripGripStyle.Hidden;
        toolbarMain.Items.AddRange(new ToolStripItem[] { btnToolbarLoadSite });
        toolbarMain.Location = new Point(0, 24);
        toolbarMain.Name = "toolbarMain";
        toolbarMain.Size = new Size(800, 25);
        toolbarMain.TabIndex = 1;
        // 
        // btnToolbarLoadSite
        // 
        btnToolbarLoadSite.Image = (Image)resources.GetObject("btnToolbarLoadSite.Image");
        btnToolbarLoadSite.ImageTransparentColor = Color.Magenta;
        btnToolbarLoadSite.Name = "btnToolbarLoadSite";
        btnToolbarLoadSite.Size = new Size(84, 22);
        btnToolbarLoadSite.Text = "Load Site...";
        btnToolbarLoadSite.ToolTipText = "Load another site...";
        btnToolbarLoadSite.Click += miFileLoadSite_Click;
        // 
        // toolbarNavigation
        // 
        toolbarNavigation.BackColor = SystemColors.ControlDark;
        toolbarNavigation.Dock = DockStyle.Left;
        toolbarNavigation.GripStyle = ToolStripGripStyle.Hidden;
        toolbarNavigation.Items.AddRange(new ToolStripItem[] { tsNavConfig, tsNavLogging, tsNavBrowse });
        toolbarNavigation.Location = new Point(0, 49);
        toolbarNavigation.Name = "toolbarNavigation";
        toolbarNavigation.Size = new Size(41, 376);
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
        tsNavConfig.Text = "Configuration";
        tsNavConfig.Click += toolboxNavigation_Click;
        // 
        // tsNavLogging
        // 
        tsNavLogging.AutoSize = false;
        tsNavLogging.DisplayStyle = ToolStripItemDisplayStyle.Image;
        tsNavLogging.Image = (Image)resources.GetObject("tsNavLogging.Image");
        tsNavLogging.ImageTransparentColor = Color.Magenta;
        tsNavLogging.Name = "tsNavLogging";
        tsNavLogging.Size = new Size(40, 40);
        tsNavLogging.Text = "Logging";
        tsNavLogging.Click += toolboxNavigation_Click;
        // 
        // tsNavBrowse
        // 
        tsNavBrowse.AutoSize = false;
        tsNavBrowse.DisplayStyle = ToolStripItemDisplayStyle.Image;
        tsNavBrowse.Image = (Image)resources.GetObject("tsNavBrowse.Image");
        tsNavBrowse.ImageTransparentColor = Color.Magenta;
        tsNavBrowse.Name = "tsNavBrowse";
        tsNavBrowse.Size = new Size(40, 40);
        tsNavBrowse.Text = "Browse";
        tsNavBrowse.Click += toolboxNavigation_Click;
        // 
        // pnlView
        // 
        pnlView.BorderStyle = BorderStyle.Fixed3D;
        pnlView.Dock = DockStyle.Fill;
        pnlView.Location = new Point(41, 49);
        pnlView.Name = "pnlView";
        pnlView.Size = new Size(759, 376);
        pnlView.TabIndex = 3;
        // 
        // statusBar
        // 
        statusBar.Items.AddRange(new ToolStripItem[] { lblStatusSiteName, lblStatusDirectory, lblStatusUrl, lblStatusLogDirectory });
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
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(pnlView);
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
    private ToolStripButton btnToolbarLoadSite;
    private ToolStripMenuItem miFileLoadSite;
    private ToolStripMenuItem miSiteExplore;
    private ToolStripMenuItem miSiteBrowse;
    private ToolStripMenuItem miSiteExploreLogs;
    private ToolStripStatusLabel lblStatusLogDirectory;
}
