namespace Hackathon.HackstreetBoys.WinForms;

partial class ConfigView
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
        ToolStrip toolStripConfig;
        ToolStripLabel tsLblChooseFile;
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigView));
        tsLstConfigFiles = new ToolStripComboBox();
        tsSep1 = new ToolStripSeparator();
        tsBtnSave = new ToolStripButton();
        txtContent = new TextBox();
        toolStripConfig = new ToolStrip();
        tsLblChooseFile = new ToolStripLabel();
        toolStripConfig.SuspendLayout();
        SuspendLayout();
        // 
        // toolStripConfig
        // 
        toolStripConfig.GripStyle = ToolStripGripStyle.Hidden;
        toolStripConfig.Items.AddRange(new ToolStripItem[] { tsLblChooseFile, tsLstConfigFiles, tsSep1, tsBtnSave });
        toolStripConfig.Location = new Point(0, 0);
        toolStripConfig.Name = "toolStripConfig";
        toolStripConfig.Size = new Size(718, 25);
        toolStripConfig.TabIndex = 0;
        // 
        // tsLblChooseFile
        // 
        tsLblChooseFile.Name = "tsLblChooseFile";
        tsLblChooseFile.Size = new Size(64, 22);
        tsLblChooseFile.Text = "Config File";
        // 
        // tsLstConfigFiles
        // 
        tsLstConfigFiles.DropDownStyle = ComboBoxStyle.DropDownList;
        tsLstConfigFiles.DropDownWidth = 150;
        tsLstConfigFiles.Name = "tsLstConfigFiles";
        tsLstConfigFiles.Size = new Size(150, 25);
        tsLstConfigFiles.SelectedIndexChanged += tsLstConfigFiles_SelectedIndexChanged;
        // 
        // tsSep1
        // 
        tsSep1.Name = "tsSep1";
        tsSep1.Size = new Size(6, 25);
        // 
        // tsBtnSave
        // 
        tsBtnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
        tsBtnSave.Image = (Image)resources.GetObject("tsBtnSave.Image");
        tsBtnSave.ImageTransparentColor = Color.Magenta;
        tsBtnSave.Name = "tsBtnSave";
        tsBtnSave.Size = new Size(23, 22);
        tsBtnSave.Text = "Save";
        tsBtnSave.ToolTipText = "Save changes";
        tsBtnSave.Click += tsBtnSave_Click;
        // 
        // txtContent
        // 
        txtContent.AcceptsReturn = true;
        txtContent.AcceptsTab = true;
        txtContent.Cursor = Cursors.IBeam;
        txtContent.Dock = DockStyle.Fill;
        txtContent.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        txtContent.Location = new Point(0, 25);
        txtContent.Multiline = true;
        txtContent.Name = "txtContent";
        txtContent.ScrollBars = ScrollBars.Both;
        txtContent.Size = new Size(718, 408);
        txtContent.TabIndex = 1;
        txtContent.WordWrap = false;
        // 
        // ConfigView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(txtContent);
        Controls.Add(toolStripConfig);
        Name = "ConfigView";
        Size = new Size(718, 433);
        Load += ConfigView_Load;
        toolStripConfig.ResumeLayout(false);
        toolStripConfig.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ToolStripComboBox tsLstConfigFiles;
    private ToolStripSeparator tsSep1;
    private ToolStripButton tsBtnSave;
    private TextBox txtContent;
}
