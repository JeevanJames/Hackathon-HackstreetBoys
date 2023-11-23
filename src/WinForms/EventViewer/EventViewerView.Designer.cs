namespace Hackathon.HackstreetBoys.WinForms.EventViewer;

partial class EventViewerView
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
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(EventViewerView));
        txtEvents = new TextBox();
        toolStripEvents = new ToolStrip();
        ttxtSources = new ToolStripTextBox();
        tbtnRefresh = new ToolStripButton();
        toolStripEvents.SuspendLayout();
        SuspendLayout();
        // 
        // txtEvents
        // 
        txtEvents.BackColor = SystemColors.Info;
        txtEvents.Dock = DockStyle.Fill;
        txtEvents.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
        txtEvents.ForeColor = SystemColors.InfoText;
        txtEvents.Location = new Point(0, 25);
        txtEvents.Multiline = true;
        txtEvents.Name = "txtEvents";
        txtEvents.ReadOnly = true;
        txtEvents.ScrollBars = ScrollBars.Both;
        txtEvents.Size = new Size(600, 375);
        txtEvents.TabIndex = 0;
        txtEvents.WordWrap = false;
        // 
        // toolStripEvents
        // 
        toolStripEvents.GripStyle = ToolStripGripStyle.Hidden;
        toolStripEvents.Items.AddRange(new ToolStripItem[] { ttxtSources, tbtnRefresh });
        toolStripEvents.Location = new Point(0, 0);
        toolStripEvents.Name = "toolStripEvents";
        toolStripEvents.Size = new Size(600, 25);
        toolStripEvents.TabIndex = 1;
        toolStripEvents.Text = "toolStrip1";
        // 
        // ttxtSources
        // 
        ttxtSources.Name = "ttxtSources";
        ttxtSources.Size = new Size(200, 25);
        // 
        // tbtnRefresh
        // 
        tbtnRefresh.DisplayStyle = ToolStripItemDisplayStyle.Text;
        tbtnRefresh.Image = (Image)resources.GetObject("tbtnRefresh.Image");
        tbtnRefresh.ImageTransparentColor = Color.Magenta;
        tbtnRefresh.Name = "tbtnRefresh";
        tbtnRefresh.Size = new Size(50, 22);
        tbtnRefresh.Text = "&Refresh";
        tbtnRefresh.Click += tbtnRefresh_Click;
        // 
        // EventViewerView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(txtEvents);
        Controls.Add(toolStripEvents);
        Name = "EventViewerView";
        Size = new Size(600, 400);
        Load += EventViewerView_Load;
        toolStripEvents.ResumeLayout(false);
        toolStripEvents.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtEvents;
    private ToolStrip toolStripEvents;
    private ToolStripTextBox ttxtSources;
    private ToolStripButton tbtnRefresh;
}
