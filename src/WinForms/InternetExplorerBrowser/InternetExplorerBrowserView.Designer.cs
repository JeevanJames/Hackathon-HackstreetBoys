namespace Hackathon.HackstreetBoys.WinForms.InternetExplorerBrowser;

partial class InternetExplorerBrowserView
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
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(InternetExplorerBrowserView));
        toolStripBrowser = new ToolStrip();
        tbtnBrowserBack = new ToolStripButton();
        tbtnBrowserForward = new ToolStripButton();
        tbtnBrowserHome = new ToolStripButton();
        tbtnBrowserRefresh = new ToolStripButton();
        toolStripSeparator1 = new ToolStripSeparator();
        tbtnBrowserDevTools = new ToolStripButton();
        pnlBrowser = new Panel();
        toolStripBrowser.SuspendLayout();
        SuspendLayout();
        // 
        // toolStripBrowser
        // 
        toolStripBrowser.GripStyle = ToolStripGripStyle.Hidden;
        toolStripBrowser.Items.AddRange(new ToolStripItem[] { tbtnBrowserBack, tbtnBrowserForward, tbtnBrowserHome, tbtnBrowserRefresh, toolStripSeparator1, tbtnBrowserDevTools });
        toolStripBrowser.Location = new Point(0, 0);
        toolStripBrowser.Name = "toolStripBrowser";
        toolStripBrowser.Size = new Size(700, 43);
        toolStripBrowser.Stretch = true;
        toolStripBrowser.TabIndex = 3;
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
        // 
        // pnlBrowser
        // 
        pnlBrowser.Dock = DockStyle.Fill;
        pnlBrowser.Location = new Point(0, 43);
        pnlBrowser.Name = "pnlBrowser";
        pnlBrowser.Size = new Size(700, 457);
        pnlBrowser.TabIndex = 4;
        // 
        // InternetExplorerBrowserView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(pnlBrowser);
        Controls.Add(toolStripBrowser);
        Name = "InternetExplorerBrowserView";
        Size = new Size(700, 500);
        Load += InternetExplorerBrowserView_Load;
        toolStripBrowser.ResumeLayout(false);
        toolStripBrowser.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ToolStrip toolStripBrowser;
    private ToolStripButton tbtnBrowserBack;
    private ToolStripButton tbtnBrowserForward;
    private ToolStripButton tbtnBrowserHome;
    private ToolStripButton tbtnBrowserRefresh;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripButton tbtnBrowserDevTools;
    private Panel pnlBrowser;
}
