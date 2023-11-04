namespace Hackathon.HackstreetBoys.WinForms;

public partial class ConfigView : UserControl
{
    public ConfigView()
    {
        InitializeComponent();
    }

    public required SiteDetails Details { get; init; }

    private void ConfigView_Load(object sender, EventArgs e)
    {
        label1.Text = Details.Directory;
    }
}
