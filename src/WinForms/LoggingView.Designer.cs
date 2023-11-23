namespace Hackathon.HackstreetBoys.WinForms;

partial class LoggingView
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
        ToolStrip toolStripLogging;
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggingView));
        SplitContainer pnlLogging;
        tbtnLoggingRefresh = new ToolStripButton();
        tbtnLoggingReset = new ToolStripButton();
        toolStripSeparator1 = new ToolStripSeparator();
        tbtnLoggingError = new ToolStripButton();
        tbtnLoggingWarning = new ToolStripButton();
        tbtnLoggingInfo = new ToolStripButton();
        tbtnLoggingDebug = new ToolStripButton();
        toolStripSeparator2 = new ToolStripSeparator();
        tlblLoggingSource = new ToolStripLabel();
        ttxtLoggingSource = new ToolStripTextBox();
        toolStripSeparator3 = new ToolStripSeparator();
        tlblLoggingMessage = new ToolStripLabel();
        ttxtLoggingMessage = new ToolStripTextBox();
        gridLogs = new DataGridView();
        gridLogsTimestamp = new DataGridViewTextBoxColumn();
        gridLogsLevel = new DataGridViewTextBoxColumn();
        gridLogsSource = new DataGridViewTextBoxColumn();
        gridLogsMessage = new DataGridViewTextBoxColumn();
        tabsLogging = new TabControl();
        tabLoggingProperties = new TabPage();
        gridProperties = new DataGridView();
        gridPropertiesName = new DataGridViewTextBoxColumn();
        gridPropertiesValue = new DataGridViewTextBoxColumn();
        tabLoggingMessage = new TabPage();
        txtLoggingMessage = new TextBox();
        tabLoggingException = new TabPage();
        txtLoggingException = new TextBox();
        toolStripLogging = new ToolStrip();
        pnlLogging = new SplitContainer();
        toolStripLogging.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pnlLogging).BeginInit();
        pnlLogging.Panel1.SuspendLayout();
        pnlLogging.Panel2.SuspendLayout();
        pnlLogging.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridLogs).BeginInit();
        tabsLogging.SuspendLayout();
        tabLoggingProperties.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridProperties).BeginInit();
        tabLoggingMessage.SuspendLayout();
        tabLoggingException.SuspendLayout();
        SuspendLayout();
        // 
        // toolStripLogging
        // 
        toolStripLogging.GripStyle = ToolStripGripStyle.Hidden;
        toolStripLogging.Items.AddRange(new ToolStripItem[] { tbtnLoggingRefresh, tbtnLoggingReset, toolStripSeparator1, tbtnLoggingError, tbtnLoggingWarning, tbtnLoggingInfo, tbtnLoggingDebug, toolStripSeparator2, tlblLoggingSource, ttxtLoggingSource, toolStripSeparator3, tlblLoggingMessage, ttxtLoggingMessage });
        toolStripLogging.Location = new Point(0, 0);
        toolStripLogging.Name = "toolStripLogging";
        toolStripLogging.RenderMode = ToolStripRenderMode.System;
        toolStripLogging.Size = new Size(901, 33);
        toolStripLogging.Stretch = true;
        toolStripLogging.TabIndex = 0;
        // 
        // tbtnLoggingRefresh
        // 
        tbtnLoggingRefresh.Image = (Image)resources.GetObject("tbtnLoggingRefresh.Image");
        tbtnLoggingRefresh.ImageTransparentColor = Color.Magenta;
        tbtnLoggingRefresh.Name = "tbtnLoggingRefresh";
        tbtnLoggingRefresh.Size = new Size(66, 30);
        tbtnLoggingRefresh.Text = "Refresh";
        tbtnLoggingRefresh.Click += tbtnLoggingRefresh_Click;
        // 
        // tbtnLoggingReset
        // 
        tbtnLoggingReset.Image = (Image)resources.GetObject("tbtnLoggingReset.Image");
        tbtnLoggingReset.ImageTransparentColor = Color.Magenta;
        tbtnLoggingReset.Name = "tbtnLoggingReset";
        tbtnLoggingReset.Size = new Size(55, 30);
        tbtnLoggingReset.Text = "Reset";
        tbtnLoggingReset.ToolTipText = "Reset";
        tbtnLoggingReset.Click += tbtnLoggingReset_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(6, 33);
        // 
        // tbtnLoggingError
        // 
        tbtnLoggingError.AutoSize = false;
        tbtnLoggingError.Checked = true;
        tbtnLoggingError.CheckOnClick = true;
        tbtnLoggingError.CheckState = CheckState.Checked;
        tbtnLoggingError.DisplayStyle = ToolStripItemDisplayStyle.Image;
        tbtnLoggingError.Image = (Image)resources.GetObject("tbtnLoggingError.Image");
        tbtnLoggingError.ImageTransparentColor = Color.Magenta;
        tbtnLoggingError.Name = "tbtnLoggingError";
        tbtnLoggingError.Size = new Size(30, 30);
        tbtnLoggingError.Text = "Error";
        tbtnLoggingError.Click += tbtnLoggingLevel_Click;
        // 
        // tbtnLoggingWarning
        // 
        tbtnLoggingWarning.AutoSize = false;
        tbtnLoggingWarning.Checked = true;
        tbtnLoggingWarning.CheckOnClick = true;
        tbtnLoggingWarning.CheckState = CheckState.Checked;
        tbtnLoggingWarning.DisplayStyle = ToolStripItemDisplayStyle.Image;
        tbtnLoggingWarning.Image = (Image)resources.GetObject("tbtnLoggingWarning.Image");
        tbtnLoggingWarning.ImageTransparentColor = Color.Magenta;
        tbtnLoggingWarning.Name = "tbtnLoggingWarning";
        tbtnLoggingWarning.Size = new Size(30, 30);
        tbtnLoggingWarning.Text = "Warning";
        tbtnLoggingWarning.Click += tbtnLoggingLevel_Click;
        // 
        // tbtnLoggingInfo
        // 
        tbtnLoggingInfo.AutoSize = false;
        tbtnLoggingInfo.Checked = true;
        tbtnLoggingInfo.CheckOnClick = true;
        tbtnLoggingInfo.CheckState = CheckState.Checked;
        tbtnLoggingInfo.DisplayStyle = ToolStripItemDisplayStyle.Image;
        tbtnLoggingInfo.Image = (Image)resources.GetObject("tbtnLoggingInfo.Image");
        tbtnLoggingInfo.ImageTransparentColor = Color.Magenta;
        tbtnLoggingInfo.Name = "tbtnLoggingInfo";
        tbtnLoggingInfo.Size = new Size(30, 30);
        tbtnLoggingInfo.Text = "Information";
        tbtnLoggingInfo.Click += tbtnLoggingLevel_Click;
        // 
        // tbtnLoggingDebug
        // 
        tbtnLoggingDebug.AutoSize = false;
        tbtnLoggingDebug.CheckOnClick = true;
        tbtnLoggingDebug.DisplayStyle = ToolStripItemDisplayStyle.Image;
        tbtnLoggingDebug.Image = (Image)resources.GetObject("tbtnLoggingDebug.Image");
        tbtnLoggingDebug.ImageTransparentColor = Color.Magenta;
        tbtnLoggingDebug.Name = "tbtnLoggingDebug";
        tbtnLoggingDebug.Size = new Size(30, 30);
        tbtnLoggingDebug.Text = "Diagnostic";
        tbtnLoggingDebug.Click += tbtnLoggingLevel_Click;
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(6, 33);
        // 
        // tlblLoggingSource
        // 
        tlblLoggingSource.Name = "tlblLoggingSource";
        tlblLoggingSource.Size = new Size(46, 30);
        tlblLoggingSource.Text = "Source:";
        // 
        // ttxtLoggingSource
        // 
        ttxtLoggingSource.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        ttxtLoggingSource.AutoCompleteSource = AutoCompleteSource.CustomSource;
        ttxtLoggingSource.Name = "ttxtLoggingSource";
        ttxtLoggingSource.Size = new Size(200, 33);
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Name = "toolStripSeparator3";
        toolStripSeparator3.Size = new Size(6, 33);
        // 
        // tlblLoggingMessage
        // 
        tlblLoggingMessage.Name = "tlblLoggingMessage";
        tlblLoggingMessage.Size = new Size(56, 30);
        tlblLoggingMessage.Text = "Message:";
        // 
        // ttxtLoggingMessage
        // 
        ttxtLoggingMessage.Name = "ttxtLoggingMessage";
        ttxtLoggingMessage.Size = new Size(200, 33);
        // 
        // pnlLogging
        // 
        pnlLogging.Dock = DockStyle.Fill;
        pnlLogging.FixedPanel = FixedPanel.Panel2;
        pnlLogging.Location = new Point(0, 33);
        pnlLogging.Name = "pnlLogging";
        pnlLogging.Orientation = Orientation.Horizontal;
        // 
        // pnlLogging.Panel1
        // 
        pnlLogging.Panel1.Controls.Add(gridLogs);
        // 
        // pnlLogging.Panel2
        // 
        pnlLogging.Panel2.Controls.Add(tabsLogging);
        pnlLogging.Size = new Size(901, 538);
        pnlLogging.SplitterDistance = 327;
        pnlLogging.SplitterWidth = 12;
        pnlLogging.TabIndex = 1;
        // 
        // gridLogs
        // 
        gridLogs.AllowUserToAddRows = false;
        gridLogs.AllowUserToDeleteRows = false;
        gridLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridLogs.Columns.AddRange(new DataGridViewColumn[] { gridLogsTimestamp, gridLogsLevel, gridLogsSource, gridLogsMessage });
        gridLogs.Dock = DockStyle.Fill;
        gridLogs.Location = new Point(0, 0);
        gridLogs.Name = "gridLogs";
        gridLogs.ReadOnly = true;
        gridLogs.RowTemplate.Height = 25;
        gridLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridLogs.Size = new Size(901, 327);
        gridLogs.TabIndex = 0;
        gridLogs.RowEnter += gridLogs_RowEnter;
        // 
        // gridLogsTimestamp
        // 
        gridLogsTimestamp.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        gridLogsTimestamp.HeaderText = "Timestamp";
        gridLogsTimestamp.Name = "gridLogsTimestamp";
        gridLogsTimestamp.ReadOnly = true;
        gridLogsTimestamp.Width = 91;
        // 
        // gridLogsLevel
        // 
        gridLogsLevel.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        gridLogsLevel.HeaderText = "Level";
        gridLogsLevel.Name = "gridLogsLevel";
        gridLogsLevel.ReadOnly = true;
        gridLogsLevel.Width = 59;
        // 
        // gridLogsSource
        // 
        gridLogsSource.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        gridLogsSource.HeaderText = "Source";
        gridLogsSource.Name = "gridLogsSource";
        gridLogsSource.ReadOnly = true;
        gridLogsSource.Width = 68;
        // 
        // gridLogsMessage
        // 
        gridLogsMessage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        gridLogsMessage.HeaderText = "Message";
        gridLogsMessage.Name = "gridLogsMessage";
        gridLogsMessage.ReadOnly = true;
        // 
        // tabsLogging
        // 
        tabsLogging.Alignment = TabAlignment.Bottom;
        tabsLogging.Controls.Add(tabLoggingProperties);
        tabsLogging.Controls.Add(tabLoggingMessage);
        tabsLogging.Controls.Add(tabLoggingException);
        tabsLogging.Dock = DockStyle.Fill;
        tabsLogging.Location = new Point(0, 0);
        tabsLogging.Multiline = true;
        tabsLogging.Name = "tabsLogging";
        tabsLogging.SelectedIndex = 0;
        tabsLogging.Size = new Size(901, 199);
        tabsLogging.TabIndex = 1;
        // 
        // tabLoggingProperties
        // 
        tabLoggingProperties.Controls.Add(gridProperties);
        tabLoggingProperties.Location = new Point(4, 4);
        tabLoggingProperties.Name = "tabLoggingProperties";
        tabLoggingProperties.Padding = new Padding(3);
        tabLoggingProperties.Size = new Size(893, 171);
        tabLoggingProperties.TabIndex = 0;
        tabLoggingProperties.Text = "Properties";
        tabLoggingProperties.UseVisualStyleBackColor = true;
        // 
        // gridProperties
        // 
        gridProperties.AllowUserToAddRows = false;
        gridProperties.AllowUserToDeleteRows = false;
        gridProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridProperties.Columns.AddRange(new DataGridViewColumn[] { gridPropertiesName, gridPropertiesValue });
        gridProperties.Dock = DockStyle.Fill;
        gridProperties.Location = new Point(3, 3);
        gridProperties.MultiSelect = false;
        gridProperties.Name = "gridProperties";
        gridProperties.ReadOnly = true;
        gridProperties.RowTemplate.Height = 25;
        gridProperties.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridProperties.Size = new Size(887, 165);
        gridProperties.TabIndex = 0;
        // 
        // gridPropertiesName
        // 
        gridPropertiesName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        gridPropertiesName.HeaderText = "Property";
        gridPropertiesName.Name = "gridPropertiesName";
        gridPropertiesName.ReadOnly = true;
        gridPropertiesName.Width = 77;
        // 
        // gridPropertiesValue
        // 
        gridPropertiesValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        gridPropertiesValue.HeaderText = "Value";
        gridPropertiesValue.Name = "gridPropertiesValue";
        gridPropertiesValue.ReadOnly = true;
        // 
        // tabLoggingMessage
        // 
        tabLoggingMessage.Controls.Add(txtLoggingMessage);
        tabLoggingMessage.Location = new Point(4, 4);
        tabLoggingMessage.Name = "tabLoggingMessage";
        tabLoggingMessage.Padding = new Padding(3);
        tabLoggingMessage.Size = new Size(893, 171);
        tabLoggingMessage.TabIndex = 1;
        tabLoggingMessage.Text = "Message";
        tabLoggingMessage.UseVisualStyleBackColor = true;
        // 
        // txtLoggingMessage
        // 
        txtLoggingMessage.Dock = DockStyle.Fill;
        txtLoggingMessage.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        txtLoggingMessage.Location = new Point(3, 3);
        txtLoggingMessage.Multiline = true;
        txtLoggingMessage.Name = "txtLoggingMessage";
        txtLoggingMessage.ReadOnly = true;
        txtLoggingMessage.ScrollBars = ScrollBars.Both;
        txtLoggingMessage.Size = new Size(887, 165);
        txtLoggingMessage.TabIndex = 0;
        txtLoggingMessage.WordWrap = false;
        // 
        // tabLoggingException
        // 
        tabLoggingException.Controls.Add(txtLoggingException);
        tabLoggingException.Location = new Point(4, 4);
        tabLoggingException.Name = "tabLoggingException";
        tabLoggingException.Padding = new Padding(3);
        tabLoggingException.Size = new Size(893, 171);
        tabLoggingException.TabIndex = 2;
        tabLoggingException.Text = "Exception";
        tabLoggingException.UseVisualStyleBackColor = true;
        // 
        // txtLoggingException
        // 
        txtLoggingException.Dock = DockStyle.Fill;
        txtLoggingException.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        txtLoggingException.Location = new Point(3, 3);
        txtLoggingException.Multiline = true;
        txtLoggingException.Name = "txtLoggingException";
        txtLoggingException.ReadOnly = true;
        txtLoggingException.ScrollBars = ScrollBars.Both;
        txtLoggingException.Size = new Size(887, 165);
        txtLoggingException.TabIndex = 0;
        txtLoggingException.WordWrap = false;
        // 
        // LoggingView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(pnlLogging);
        Controls.Add(toolStripLogging);
        Name = "LoggingView";
        Size = new Size(901, 571);
        Load += LoggingView_Load;
        toolStripLogging.ResumeLayout(false);
        toolStripLogging.PerformLayout();
        pnlLogging.Panel1.ResumeLayout(false);
        pnlLogging.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pnlLogging).EndInit();
        pnlLogging.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridLogs).EndInit();
        tabsLogging.ResumeLayout(false);
        tabLoggingProperties.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridProperties).EndInit();
        tabLoggingMessage.ResumeLayout(false);
        tabLoggingMessage.PerformLayout();
        tabLoggingException.ResumeLayout(false);
        tabLoggingException.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ToolStripButton tbtnLoggingError;
    private ToolStripButton tbtnLoggingWarning;
    private ToolStripButton tbtnLoggingInfo;
    private ToolStripButton tbtnLoggingDebug;
    private DataGridView gridLogs;
    private TabControl tabsLogging;
    private TabPage tabLoggingProperties;
    private TabPage tabLoggingMessage;
    private TextBox txtLoggingMessage;
    private DataGridViewTextBoxColumn gridLogsTimestamp;
    private DataGridViewTextBoxColumn gridLogsLevel;
    private DataGridViewTextBoxColumn gridLogsSource;
    private DataGridViewTextBoxColumn gridLogsMessage;
    private DataGridView gridProperties;
    private DataGridViewTextBoxColumn gridPropertiesName;
    private DataGridViewTextBoxColumn gridPropertiesValue;
    private TabPage tabLoggingException;
    private TextBox txtLoggingException;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripButton tbtnLoggingRefresh;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripLabel tlblLoggingSource;
    private ToolStripTextBox ttxtLoggingSource;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripLabel tlblLoggingMessage;
    private ToolStripTextBox ttxtLoggingMessage;
    private ToolStripButton tbtnLoggingReset;
}
