using System.Text.Json;

using JsonCons.JsonPath;

using Microsoft.Web.Administration;

namespace Hackathon.HackstreetBoys.WinForms;

public partial class SelectSiteDialog : Form
{
    private readonly List<string> _sites = new();
    private bool _refreshingList;
    private SiteDetails? _details;

    public SelectSiteDialog()
    {
        InitializeComponent();
    }

    public SiteDetails GetResult()
    {
        return _details ?? throw new InvalidOperationException("Site details not available.");
    }

    private void SelectSiteDialog_Load(object sender, EventArgs e)
    {
        RefreshSites();
    }

    private void SelectSiteDialog_KeyDown(object sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.F3:
                txtSiteFilter.Focus();
                e.Handled = true;
                break;

            case Keys.Down when txtSiteFilter.Focused:
                lstSites.Focus();
                if (lstSites.SelectedItems.Count == 0 && lstSites.Items.Count > 0)
                    lstSites.Items[0].Selected = true;
                e.Handled = true;
                break;
        }
    }

    private void txtSiteFilter_TextChanged(object sender, EventArgs e)
    {
        if (_refreshingList)
            return;

        lstSites.BeginUpdate();
        try
        {
            lstSites.Items.Clear();

            IEnumerable<string> sites = _sites;
            if (txtSiteFilter.Text.Length > 0)
                sites = sites.Where(s => s.Contains(txtSiteFilter.Text, StringComparison.OrdinalIgnoreCase));

            foreach (string site in sites)
                lstSites.Items.Add(site);

            if (lstSites.Items.Count > 0)
                lstSites.Items[0].Selected = true;
        }
        finally
        {
            lstSites.EndUpdate();
        }
    }

    private void btnSelectSite_Click(object sender, EventArgs e)
    {
        if (lstSites.SelectedItems.Count == 0)
            return;

        UpdateResult(lstSites.SelectedItems[0].Text);

        DialogResult = DialogResult.OK;
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        RefreshSites();
    }

    private void lstSites_DoubleClick(object sender, EventArgs e)
    {
        if (lstSites.SelectedItems.Count > 0)
        {
            UpdateResult(lstSites.SelectedItems[0].Text);
            DialogResult = DialogResult.OK;
        }
    }

    private void RefreshSites()
    {
        using ServerManager manager = new();

        _refreshingList = true;
        lstSites.BeginUpdate();
        try
        {
            _sites.Clear();
            _sites.EnsureCapacity(manager.Sites.Count);
            _sites.AddRange(manager.Sites.Select(s => s.Name).OrderBy(s => s));

            txtSiteFilter.Clear();

            lstSites.Items.Clear();
            foreach (string site in _sites)
                lstSites.Items.Add(site);
        }
        finally
        {
            lstSites.EndUpdate();
            _refreshingList = false;
        }
    }

    private void UpdateResult(string siteName)
    {
        using ServerManager manager = new();

        Site site = manager.Sites[siteName];
        string appPool = site.Applications["/"].ApplicationPoolName;
        string directory = site.Applications["/"].VirtualDirectories["/"].PhysicalPath;

        _details = new SiteDetails(siteName,
            appPool,
            directory,
            GetLogDirectory(directory),
            GetUrl());

        string GetUrl()
        {
            Microsoft.Web.Administration.Binding binding = site.Bindings.Count == 1
                ? site.Bindings[0]
                : site.Bindings.FirstOrDefault(b => b.Protocol.Equals("https", StringComparison.OrdinalIgnoreCase)) ??
                  site.Bindings[0];
            string host = string.IsNullOrEmpty(binding.Host) ? "localhost" : binding.Host;
            return $"{binding.Protocol}://{host}:{binding.EndPoint.Port}";
        }

        static string GetLogDirectory(string directory)
        {
            string appSettingsPath = Path.Combine(directory, "appsettings.json");
            if (!File.Exists(appSettingsPath))
                return Path.Combine(directory, "Logs");

            string json = File.ReadAllText(appSettingsPath);
            using var jdoc = JsonDocument.Parse(json);

            JsonSelector selector = JsonSelector.Parse("$.DopLogging.Serilog.WriteTo[?(@.Name == 'File')].Args.Path");
            IList<JsonElement> matchingElements = selector.Select(jdoc.RootElement);
            if (matchingElements.Count == 0)
                return Path.Combine(directory, "Logs");

            return Path.Combine(directory, matchingElements[0].GetString() ?? "Logs");
        }
    }
}
