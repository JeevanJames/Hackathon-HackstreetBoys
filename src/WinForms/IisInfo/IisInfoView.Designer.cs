namespace Hackathon.HackstreetBoys.WinForms.IisInfo;

partial class IisInfoView
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
        lstInfo = new ListView();
        colProperty = new ColumnHeader();
        colValue = new ColumnHeader();
        SuspendLayout();
        // 
        // lstInfo
        // 
        lstInfo.Columns.AddRange(new ColumnHeader[] { colProperty, colValue });
        lstInfo.Dock = DockStyle.Fill;
        lstInfo.FullRowSelect = true;
        lstInfo.GridLines = true;
        lstInfo.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        lstInfo.Location = new Point(0, 0);
        lstInfo.MultiSelect = false;
        lstInfo.Name = "lstInfo";
        lstInfo.Size = new Size(629, 492);
        lstInfo.Sorting = SortOrder.Ascending;
        lstInfo.TabIndex = 0;
        lstInfo.UseCompatibleStateImageBehavior = false;
        lstInfo.View = View.Details;
        // 
        // colProperty
        // 
        colProperty.Text = "Property";
        colProperty.Width = 200;
        // 
        // colValue
        // 
        colValue.Text = "Value";
        colValue.Width = 200;
        // 
        // IisInfoView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lstInfo);
        Name = "IisInfoView";
        Size = new Size(629, 492);
        Load += IisInfoView_Load;
        ResumeLayout(false);
    }

    #endregion

    private ListView lstInfo;
    private ColumnHeader colProperty;
    private ColumnHeader colValue;
}
