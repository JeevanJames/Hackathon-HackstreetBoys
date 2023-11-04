namespace Hackathon.HackstreetBoys.WinForms;

partial class SelectSiteDialog
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        Panel pnlSiteFilter;
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectSiteDialog));
        btnCancel = new Button();
        btnRefresh = new Button();
        btnSelectSite = new Button();
        txtSiteFilter = new TextBox();
        lstSites = new ListView();
        pnlSiteFilter = new Panel();
        pnlSiteFilter.SuspendLayout();
        SuspendLayout();
        // 
        // pnlSiteFilter
        // 
        pnlSiteFilter.Controls.Add(btnCancel);
        pnlSiteFilter.Controls.Add(btnRefresh);
        pnlSiteFilter.Controls.Add(btnSelectSite);
        pnlSiteFilter.Controls.Add(txtSiteFilter);
        pnlSiteFilter.Dock = DockStyle.Top;
        pnlSiteFilter.Location = new Point(0, 0);
        pnlSiteFilter.Name = "pnlSiteFilter";
        pnlSiteFilter.Size = new Size(370, 76);
        pnlSiteFilter.TabIndex = 1;
        // 
        // btnCancel
        // 
        btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
        btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
        btnCancel.Location = new Point(260, 43);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(100, 23);
        btnCancel.TabIndex = 3;
        btnCancel.Text = "&Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        // 
        // btnRefresh
        // 
        btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
        btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
        btnRefresh.Location = new Point(120, 43);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(100, 23);
        btnRefresh.TabIndex = 2;
        btnRefresh.Text = "&Refresh";
        btnRefresh.UseVisualStyleBackColor = true;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // btnSelectSite
        // 
        btnSelectSite.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnSelectSite.Image = (Image)resources.GetObject("btnSelectSite.Image");
        btnSelectSite.ImageAlign = ContentAlignment.MiddleLeft;
        btnSelectSite.Location = new Point(10, 43);
        btnSelectSite.Name = "btnSelectSite";
        btnSelectSite.Size = new Size(100, 23);
        btnSelectSite.TabIndex = 1;
        btnSelectSite.Text = "&Select";
        btnSelectSite.Click += btnSelectSite_Click;
        // 
        // txtSiteFilter
        // 
        txtSiteFilter.Location = new Point(10, 10);
        txtSiteFilter.Name = "txtSiteFilter";
        txtSiteFilter.Size = new Size(350, 23);
        txtSiteFilter.TabIndex = 0;
        txtSiteFilter.TextChanged += txtSiteFilter_TextChanged;
        // 
        // lstSites
        // 
        lstSites.Dock = DockStyle.Fill;
        lstSites.Location = new Point(0, 76);
        lstSites.MultiSelect = false;
        lstSites.Name = "lstSites";
        lstSites.Size = new Size(370, 374);
        lstSites.Sorting = SortOrder.Ascending;
        lstSites.TabIndex = 2;
        lstSites.UseCompatibleStateImageBehavior = false;
        lstSites.View = View.List;
        lstSites.DoubleClick += lstSites_DoubleClick;
        // 
        // SelectSiteDialog
        // 
        AcceptButton = btnSelectSite;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btnCancel;
        ClientSize = new Size(370, 450);
        Controls.Add(lstSites);
        Controls.Add(pnlSiteFilter);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        KeyPreview = true;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "SelectSiteDialog";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Select Site";
        Load += SelectSiteDialog_Load;
        KeyDown += SelectSiteDialog_KeyDown;
        pnlSiteFilter.ResumeLayout(false);
        pnlSiteFilter.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button btnRefresh;
    private Button btnSelectSite;
    private TextBox txtSiteFilter;
    private Button btnCancel;
    private ListView lstSites;
}