namespace SampleWinForms;

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
        if (disposing && components != null)
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
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        browser = new CefSharp.WinForms.ChromiumWebBrowser();
        statusStrip1 = new StatusStrip();
        progress = new ToolStripProgressBar();
        lblStatus = new ToolStripStatusLabel();
        toolStrip1 = new ToolStrip();
        txtAddress = new ToolStripTextBox();
        btnGo = new ToolStripButton();
        statusStrip1.SuspendLayout();
        toolStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // browser
        // 
        browser.ActivateBrowserOnCreation = false;
        browser.Dock = DockStyle.Fill;
        browser.Location = new Point(0, 25);
        browser.Name = "browser";
        browser.Size = new Size(800, 403);
        browser.TabIndex = 0;
        browser.TitleChanged += browser_TitleChanged;
        browser.LoadingStateChanged += browser_LoadingStateChanged;
        browser.StatusMessage += browser_StatusMessage;
        // 
        // statusStrip1
        // 
        statusStrip1.Items.AddRange(new ToolStripItem[] { progress, lblStatus });
        statusStrip1.Location = new Point(0, 428);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(800, 22);
        statusStrip1.TabIndex = 1;
        statusStrip1.Text = "statusStrip1";
        // 
        // progress
        // 
        progress.Name = "progress";
        progress.Size = new Size(100, 16);
        progress.Style = ProgressBarStyle.Marquee;
        progress.Visible = false;
        // 
        // lblStatus
        // 
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(785, 17);
        lblStatus.Spring = true;
        lblStatus.Text = "toolStripStatusLabel1";
        // 
        // toolStrip1
        // 
        toolStrip1.Items.AddRange(new ToolStripItem[] { txtAddress, btnGo });
        toolStrip1.Location = new Point(0, 0);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new Size(800, 25);
        toolStrip1.TabIndex = 2;
        toolStrip1.Text = "toolStrip1";
        // 
        // txtAddress
        // 
        txtAddress.Name = "txtAddress";
        txtAddress.Size = new Size(300, 25);
        txtAddress.Text = "https://yahoo.com";
        // 
        // btnGo
        // 
        btnGo.DisplayStyle = ToolStripItemDisplayStyle.Text;
        btnGo.Image = (Image)resources.GetObject("btnGo.Image");
        btnGo.ImageTransparentColor = Color.Magenta;
        btnGo.Name = "btnGo";
        btnGo.Size = new Size(26, 22);
        btnGo.Text = "&Go";
        btnGo.Click += btnGo_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(browser);
        Controls.Add(toolStrip1);
        Controls.Add(statusStrip1);
        Name = "MainForm";
        Text = "Form1";
        Load += MainForm_Load;
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private CefSharp.WinForms.ChromiumWebBrowser browser;
    private StatusStrip statusStrip1;
    private ToolStripProgressBar progress;
    private ToolStripStatusLabel lblStatus;
    private ToolStrip toolStrip1;
    private ToolStripTextBox txtAddress;
    private ToolStripButton btnGo;
}
