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
        grdInfo = new PropertyGrid();
        SuspendLayout();
        // 
        // grdInfo
        // 
        grdInfo.Dock = DockStyle.Fill;
        grdInfo.Location = new Point(0, 0);
        grdInfo.Name = "grdInfo";
        grdInfo.Size = new Size(629, 492);
        grdInfo.TabIndex = 0;
        // 
        // IisInfoView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(grdInfo);
        Name = "IisInfoView";
        Size = new Size(629, 492);
        Load += IisInfoView_Load;
        ResumeLayout(false);
    }

    #endregion

    private PropertyGrid grdInfo;
}
