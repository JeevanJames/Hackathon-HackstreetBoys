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
        IEnumerable<string> configFiles = Directory
            .EnumerateFiles(Details.Directory, "*.json", SearchOption.TopDirectoryOnly);
        foreach (string configFile in configFiles)
            tsLstConfigFiles.Items.Add(Path.GetRelativePath(Details.Directory, configFile));
        if (tsLstConfigFiles.Items.Count > 0)
            tsLstConfigFiles.SelectedIndex = 0;
    }

    private void tsLstConfigFiles_SelectedIndexChanged(object sender, EventArgs e)
    {
        string filePath = Path.Combine(Details.Directory, (string)tsLstConfigFiles.SelectedItem);
        string content = File.ReadAllText(filePath);
        txtContent.Text = content;
    }

    private void tsBtnSave_Click(object sender, EventArgs e)
    {
        string filePath = Path.Combine(Details.Directory, (string)tsLstConfigFiles.SelectedItem);
        File.WriteAllText(filePath, txtContent.Text);
    }
}
