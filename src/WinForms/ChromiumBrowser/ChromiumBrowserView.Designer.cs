namespace Hackathon.HackstreetBoys.WinForms.ChromiumBrowser;

partial class ChromiumBrowserView
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(ChromiumBrowserView));
        toolStripBrowser = new ToolStrip();
        tbtnBrowserBack = new ToolStripButton();
        tbtnBrowserForward = new ToolStripButton();
        tbtnBrowserHome = new ToolStripButton();
        tbtnBrowserRefresh = new ToolStripButton();
        toolStripSeparator1 = new ToolStripSeparator();
        tbtnBrowserDevTools = new ToolStripButton();
        toolStripSeparator2 = new ToolStripSeparator();
        tlblTitle = new ToolStripLabel();
        statusStrip = new StatusStrip();
        tslblStatus = new ToolStripStatusLabel();
        tsProgress = new ToolStripProgressBar();
        browser = new CefSharp.WinForms.ChromiumWebBrowser();
        txtAddress = new TextBox();
        toolStripBrowser.SuspendLayout();
        statusStrip.SuspendLayout();
        SuspendLayout();
        // 
        // toolStripBrowser
        // 
        toolStripBrowser.GripStyle = ToolStripGripStyle.Hidden;
        toolStripBrowser.Items.AddRange(new ToolStripItem[] { tbtnBrowserBack, tbtnBrowserForward, tbtnBrowserHome, tbtnBrowserRefresh, toolStripSeparator1, tbtnBrowserDevTools, toolStripSeparator2, tlblTitle });
        toolStripBrowser.Location = new Point(0, 0);
        toolStripBrowser.Name = "toolStripBrowser";
        toolStripBrowser.Size = new Size(816, 43);
        toolStripBrowser.Stretch = true;
        toolStripBrowser.TabIndex = 2;
        // 
        // tbtnBrowserBack
        // 
        tbtnBrowserBack.AutoSize = false;
        tbtnBrowserBack.DisplayStyle = ToolStripItemDisplayStyle.Image;
        tbtnBrowserBack.Image = (Image)resources.GetObject("tbtnBrowserBack.Image");
        tbtnBrowserBack.ImageTransparentColor = Color.Magenta;
        tbtnBrowserBack.Name = "tbtnBrowserBack";
        tbtnBrowserBack.Size = new Size(40, 40);
        tbtnBrowserBack.Text = "Back";
        tbtnBrowserBack.Click += tbtnBrowserBack_Click;
        // 
        // tbtnBrowserForward
        // 
        tbtnBrowserForward.AutoSize = false;
        tbtnBrowserForward.DisplayStyle = ToolStripItemDisplayStyle.Image;
        tbtnBrowserForward.Image = (Image)resources.GetObject("tbtnBrowserForward.Image");
        tbtnBrowserForward.ImageTransparentColor = Color.Magenta;
        tbtnBrowserForward.Name = "tbtnBrowserForward";
        tbtnBrowserForward.Size = new Size(40, 40);
        tbtnBrowserForward.Text = "Forward";
        tbtnBrowserForward.Click += tbtnBrowserForward_Click;
        // 
        // tbtnBrowserHome
        // 
        tbtnBrowserHome.AutoSize = false;
        tbtnBrowserHome.DisplayStyle = ToolStripItemDisplayStyle.Image;
        tbtnBrowserHome.Image = (Image)resources.GetObject("tbtnBrowserHome.Image");
        tbtnBrowserHome.ImageTransparentColor = Color.Magenta;
        tbtnBrowserHome.Name = "tbtnBrowserHome";
        tbtnBrowserHome.Size = new Size(40, 40);
        tbtnBrowserHome.Text = "Home";
        tbtnBrowserHome.Click += tbtnBrowserHome_Click;
        // 
        // tbtnBrowserRefresh
        // 
        tbtnBrowserRefresh.AutoSize = false;
        tbtnBrowserRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
        tbtnBrowserRefresh.Image = (Image)resources.GetObject("tbtnBrowserRefresh.Image");
        tbtnBrowserRefresh.ImageTransparentColor = Color.Magenta;
        tbtnBrowserRefresh.Name = "tbtnBrowserRefresh";
        tbtnBrowserRefresh.Size = new Size(40, 40);
        tbtnBrowserRefresh.Text = "Refresh";
        tbtnBrowserRefresh.Click += tbtnBrowserRefresh_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(6, 43);
        // 
        // tbtnBrowserDevTools
        // 
        tbtnBrowserDevTools.AutoSize = false;
        tbtnBrowserDevTools.DisplayStyle = ToolStripItemDisplayStyle.Image;
        tbtnBrowserDevTools.Image = (Image)resources.GetObject("tbtnBrowserDevTools.Image");
        tbtnBrowserDevTools.ImageTransparentColor = Color.Magenta;
        tbtnBrowserDevTools.Name = "tbtnBrowserDevTools";
        tbtnBrowserDevTools.Size = new Size(40, 40);
        tbtnBrowserDevTools.Text = "Developer Tools";
        tbtnBrowserDevTools.ToolTipText = "Display developer tools";
        tbtnBrowserDevTools.Click += tbtnBrowserDevTools_Click;
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(6, 43);
        // 
        // tlblTitle
        // 
        tlblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        tlblTitle.IsLink = true;
        tlblTitle.Name = "tlblTitle";
        tlblTitle.Size = new Size(46, 40);
        tlblTitle.Text = "(Blank)";
        tlblTitle.Click += tlblTitle_Click;
        // 
        // statusStrip
        // 
        statusStrip.Items.AddRange(new ToolStripItem[] { tslblStatus, tsProgress });
        statusStrip.Location = new Point(0, 545);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(816, 22);
        statusStrip.SizingGrip = false;
        statusStrip.TabIndex = 3;
        // 
        // tslblStatus
        // 
        tslblStatus.Image = (Image)resources.GetObject("tslblStatus.Image");
        tslblStatus.ImageAlign = ContentAlignment.MiddleLeft;
        tslblStatus.IsLink = true;
        tslblStatus.Name = "tslblStatus";
        tslblStatus.Size = new Size(801, 17);
        tslblStatus.Spring = true;
        tslblStatus.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tsProgress
        // 
        tsProgress.Name = "tsProgress";
        tsProgress.Size = new Size(100, 16);
        tsProgress.Style = ProgressBarStyle.Marquee;
        tsProgress.Visible = false;
        // 
        // browser
        // 
        browser.ActivateBrowserOnCreation = false;
        browser.Dock = DockStyle.Fill;
        browser.Location = new Point(0, 66);
        browser.Name = "browser";
        browser.Size = new Size(816, 479);
        browser.TabIndex = 4;
        browser.AddressChanged += browser_AddressChanged;
        browser.TitleChanged += browser_TitleChanged;
        browser.LoadingStateChanged += browser_LoadingStateChanged;
        browser.StatusMessage += browser_StatusMessage;
        // 
        // txtAddress
        // 
        txtAddress.Dock = DockStyle.Top;
        txtAddress.Location = new Point(0, 43);
        txtAddress.Name = "txtAddress";
        txtAddress.ReadOnly = true;
        txtAddress.Size = new Size(816, 23);
        txtAddress.TabIndex = 5;
        // 
        // ChromiumBrowserView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(browser);
        Controls.Add(txtAddress);
        Controls.Add(toolStripBrowser);
        Controls.Add(statusStrip);
        Name = "ChromiumBrowserView";
        Size = new Size(816, 567);
        Load += BrowserView_Load;
        toolStripBrowser.ResumeLayout(false);
        toolStripBrowser.PerformLayout();
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private ToolStrip toolStripBrowser;
    private ToolStripButton tbtnBrowserBack;
    private ToolStripButton tbtnBrowserForward;
    private ToolStripButton tbtnBrowserHome;
    private ToolStripButton tbtnBrowserRefresh;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel tslblStatus;
    private ToolStripProgressBar tsProgress;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripButton tbtnBrowserDevTools;
    private CefSharp.WinForms.ChromiumWebBrowser browser;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripLabel tlblTitle;
    private TextBox txtAddress;
}
