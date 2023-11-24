namespace Hackathon.HackstreetBoys.WinForms.CrashLogs;

partial class CrashLogsView
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
        pnlEventViewer = new SplitContainer();
        grdLogs = new DataGridView();
        colLogsTimestamp = new DataGridViewTextBoxColumn();
        colLogsCategory = new DataGridViewTextBoxColumn();
        colLogsMessage = new DataGridViewTextBoxColumn();
        txtMessage = new TextBox();
        ((System.ComponentModel.ISupportInitialize)pnlEventViewer).BeginInit();
        pnlEventViewer.Panel1.SuspendLayout();
        pnlEventViewer.Panel2.SuspendLayout();
        pnlEventViewer.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)grdLogs).BeginInit();
        SuspendLayout();
        // 
        // pnlEventViewer
        // 
        pnlEventViewer.Dock = DockStyle.Fill;
        pnlEventViewer.FixedPanel = FixedPanel.Panel2;
        pnlEventViewer.Location = new Point(0, 0);
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
        pnlEventViewer.Size = new Size(703, 507);
        pnlEventViewer.SplitterDistance = 312;
        pnlEventViewer.SplitterWidth = 8;
        pnlEventViewer.TabIndex = 3;
        // 
        // grdLogs
        // 
        grdLogs.AllowUserToAddRows = false;
        grdLogs.AllowUserToDeleteRows = false;
        grdLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        grdLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        grdLogs.Columns.AddRange(new DataGridViewColumn[] { colLogsTimestamp, colLogsCategory, colLogsMessage });
        grdLogs.Dock = DockStyle.Fill;
        grdLogs.Location = new Point(0, 0);
        grdLogs.Name = "grdLogs";
        grdLogs.ReadOnly = true;
        grdLogs.RowTemplate.Height = 25;
        grdLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grdLogs.Size = new Size(703, 312);
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
        txtMessage.ScrollBars = ScrollBars.Vertical;
        txtMessage.Size = new Size(703, 187);
        txtMessage.TabIndex = 0;
        // 
        // CrashLogsView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(pnlEventViewer);
        Name = "CrashLogsView";
        Size = new Size(703, 507);
        Load += CrashLogsView_Load;
        pnlEventViewer.Panel1.ResumeLayout(false);
        pnlEventViewer.Panel2.ResumeLayout(false);
        pnlEventViewer.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pnlEventViewer).EndInit();
        pnlEventViewer.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)grdLogs).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private SplitContainer pnlEventViewer;
    private DataGridView grdLogs;
    private TextBox txtMessage;
    private DataGridViewTextBoxColumn colLogsTimestamp;
    private DataGridViewTextBoxColumn colLogsCategory;
    private DataGridViewTextBoxColumn colLogsMessage;
}
