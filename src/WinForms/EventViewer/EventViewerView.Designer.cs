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
        toolStripEvents = new ToolStrip();
        ttxtSources = new ToolStripTextBox();
        tbtnRefresh = new ToolStripButton();
        pnlEventViewer = new SplitContainer();
        grdLogs = new DataGridView();
        colLogsTimestamp = new DataGridViewTextBoxColumn();
        colLogsCategory = new DataGridViewTextBoxColumn();
        colLogsSource = new DataGridViewTextBoxColumn();
        colLogsMessage = new DataGridViewTextBoxColumn();
        txtMessage = new TextBox();
        toolStripEvents.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pnlEventViewer).BeginInit();
        pnlEventViewer.Panel1.SuspendLayout();
        pnlEventViewer.Panel2.SuspendLayout();
        pnlEventViewer.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)grdLogs).BeginInit();
        SuspendLayout();
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
        // pnlEventViewer
        // 
        pnlEventViewer.Dock = DockStyle.Fill;
        pnlEventViewer.FixedPanel = FixedPanel.Panel2;
        pnlEventViewer.Location = new Point(0, 25);
        pnlEventViewer.Name = "pnlEventViewer";
        pnlEventViewer.Orientation = Orientation.Horizontal;
        // 
        // pnlEventViewer.Panel1
        // 
        pnlEventViewer.Panel1.Controls.Add(grdLogs);
        // 
        // pnlEventViewer.Panel2
        // 
        pnlEventViewer.Panel2.Controls.Add(txtMessage);
        pnlEventViewer.Size = new Size(600, 375);
        pnlEventViewer.SplitterDistance = 196;
        pnlEventViewer.SplitterWidth = 8;
        pnlEventViewer.TabIndex = 2;
        // 
        // grdLogs
        // 
        grdLogs.AllowUserToAddRows = false;
        grdLogs.AllowUserToDeleteRows = false;
        grdLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        grdLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        grdLogs.Columns.AddRange(new DataGridViewColumn[] { colLogsTimestamp, colLogsCategory, colLogsSource, colLogsMessage });
        grdLogs.Dock = DockStyle.Fill;
        grdLogs.Location = new Point(0, 0);
        grdLogs.Name = "grdLogs";
        grdLogs.ReadOnly = true;
        grdLogs.RowTemplate.Height = 25;
        grdLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grdLogs.Size = new Size(600, 196);
        grdLogs.TabIndex = 0;
        grdLogs.RowEnter += grdLogs_RowEnter;
        // 
        // colLogsTimestamp
        // 
        colLogsTimestamp.HeaderText = "Timestamp";
        colLogsTimestamp.Name = "colLogsTimestamp";
        colLogsTimestamp.ReadOnly = true;
        colLogsTimestamp.Width = 91;
        // 
        // colLogsCategory
        // 
        colLogsCategory.HeaderText = "Category";
        colLogsCategory.Name = "colLogsCategory";
        colLogsCategory.ReadOnly = true;
        colLogsCategory.Width = 80;
        // 
        // colLogsSource
        // 
        colLogsSource.HeaderText = "Source";
        colLogsSource.Name = "colLogsSource";
        colLogsSource.ReadOnly = true;
        colLogsSource.Width = 68;
        // 
        // colLogsMessage
        // 
        colLogsMessage.HeaderText = "Message";
        colLogsMessage.Name = "colLogsMessage";
        colLogsMessage.ReadOnly = true;
        colLogsMessage.Width = 78;
        // 
        // txtMessage
        // 
        txtMessage.Dock = DockStyle.Fill;
        txtMessage.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
        txtMessage.Location = new Point(0, 0);
        txtMessage.Multiline = true;
        txtMessage.Name = "txtMessage";
        txtMessage.ReadOnly = true;
        txtMessage.ScrollBars = ScrollBars.Both;
        txtMessage.Size = new Size(600, 171);
        txtMessage.TabIndex = 0;
        txtMessage.WordWrap = false;
        // 
        // EventViewerView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(pnlEventViewer);
        Controls.Add(toolStripEvents);
        Name = "EventViewerView";
        Size = new Size(600, 400);
        Load += EventViewerView_Load;
        toolStripEvents.ResumeLayout(false);
        toolStripEvents.PerformLayout();
        pnlEventViewer.Panel1.ResumeLayout(false);
        pnlEventViewer.Panel2.ResumeLayout(false);
        pnlEventViewer.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pnlEventViewer).EndInit();
        pnlEventViewer.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)grdLogs).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private ToolStrip toolStripEvents;
    private ToolStripTextBox ttxtSources;
    private ToolStripButton tbtnRefresh;
    private SplitContainer pnlEventViewer;
    private DataGridView grdLogs;
    private DataGridViewTextBoxColumn colLogsTimestamp;
    private DataGridViewTextBoxColumn colLogsCategory;
    private DataGridViewTextBoxColumn colLogsSource;
    private DataGridViewTextBoxColumn colLogsMessage;
    private TextBox txtMessage;
}
