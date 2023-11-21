namespace Hackathon.HackstreetBoys.WinForms;

partial class BrowserView
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
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserView));
        browser = new Microsoft.Web.WebView2.WinForms.WebView2();
        toolStripBrowser = new ToolStrip();
        tbtnBrowserBack = new ToolStripButton();
        tbtnBrowserForward = new ToolStripButton();
        tbtnBrowserHome = new ToolStripButton();
        tbtnBrowserRefresh = new ToolStripButton();
        statusStrip = new StatusStrip();
        tslblAddress = new ToolStripStatusLabel();
        ((System.ComponentModel.ISupportInitialize)browser).BeginInit();
        toolStripBrowser.SuspendLayout();
        statusStrip.SuspendLayout();
        SuspendLayout();
        // 
        // browser
        // 
        browser.AllowExternalDrop = true;
        browser.CreationProperties = null;
        browser.DefaultBackgroundColor = Color.White;
        browser.Dock = DockStyle.Fill;
        browser.Location = new Point(0, 43);
        browser.Name = "browser";
        browser.Size = new Size(816, 502);
        browser.TabIndex = 1;
        browser.ZoomFactor = 1D;
        browser.SourceChanged += browser_SourceChanged;
        // 
        // toolStripBrowser
        // 
        toolStripBrowser.GripStyle = ToolStripGripStyle.Hidden;
        toolStripBrowser.Items.AddRange(new ToolStripItem[] { tbtnBrowserBack, tbtnBrowserForward, tbtnBrowserHome, tbtnBrowserRefresh });
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
        // statusStrip
        // 
        statusStrip.Items.AddRange(new ToolStripItem[] { tslblAddress });
        statusStrip.Location = new Point(0, 545);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(816, 22);
        statusStrip.SizingGrip = false;
        statusStrip.TabIndex = 3;
        // 
        // tslblAddress
        // 
        tslblAddress.AutoToolTip = true;
        tslblAddress.Image = (Image)resources.GetObject("tslblAddress.Image");
        tslblAddress.ImageAlign = ContentAlignment.MiddleLeft;
        tslblAddress.IsLink = true;
        tslblAddress.Name = "tslblAddress";
        tslblAddress.Size = new Size(770, 17);
        tslblAddress.Spring = true;
        tslblAddress.Text = "Current address";
        tslblAddress.TextAlign = ContentAlignment.MiddleLeft;
        tslblAddress.ToolTipText = "Current address. Click to browse to this address in the default web browser.";
        tslblAddress.Click += tslblAddress_Click;
        // 
        // BrowserView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(browser);
        Controls.Add(toolStripBrowser);
        Controls.Add(statusStrip);
        Name = "BrowserView";
        Size = new Size(816, 567);
        Load += BrowserView_Load;
        ((System.ComponentModel.ISupportInitialize)browser).EndInit();
        toolStripBrowser.ResumeLayout(false);
        toolStripBrowser.PerformLayout();
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Microsoft.Web.WebView2.WinForms.WebView2 browser;
    private ToolStrip toolStripBrowser;
    private ToolStripButton tbtnBrowserBack;
    private ToolStripButton tbtnBrowserForward;
    private ToolStripButton tbtnBrowserHome;
    private ToolStripButton tbtnBrowserRefresh;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel tslblAddress;
}
