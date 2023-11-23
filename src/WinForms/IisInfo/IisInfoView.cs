using Microsoft.Web.Administration;

using Application = Microsoft.Web.Administration.Application;

namespace Hackathon.HackstreetBoys.WinForms.IisInfo;

public partial class IisInfoView : UserControl
{
    public IisInfoView()
    {
        InitializeComponent();
    }

    public required SiteDetails Details { get; init; }

    private void IisInfoView_Load(object sender, EventArgs e)
    {
        using ServerManager manager = new();

        Site site = manager.Sites[Details.Site];
        Application application = site.Applications["/"];
        string appPoolName = application.ApplicationPoolName;
        ApplicationPool appPool = manager.ApplicationPools[appPoolName];

        ListViewGroup grpSite = lstInfo.Groups.Add("grpSite", "Web Site");
        AddInfos(grpSite, new()
        {
            ["Name"] = site.Name,
            ["Schemes"] = () => string.Join(',', site.Bindings.Select(b => b.Protocol)),
            ["State"] = site.State,
            ["Log Directory"] = site.LogFile.Directory,
            ["ID"] = site.Id,
            ["Server Auto Start"] = site.ServerAutoStart,
        });

        ListViewGroup grpSiteLimits = lstInfo.Groups.Add("grpSiteLimits", "Web Site (Limits)");
        AddInfos(grpSiteLimits, new()
        {
            ["Connection Timeout"] = site.Limits.ConnectionTimeout.ToString("g"),
            ["Max Bandwidth"] = site.Limits.MaxBandwidth.ToString("N"),
            ["Max Connections"] = site.Limits.MaxConnections.ToString("D"),
            ["Max URL Segments"] = site.Limits.MaxUrlSegments.ToString("D"),
        });

        ListViewGroup grpAppPool = lstInfo.Groups.Add("grpAppPool", "Application Pool");
        AddInfos(grpAppPool, new()
        {
            ["Name"] = appPool.Name,
            ["State"] = appPool.State,
            ["Managed Pipeline Mode"] = appPool.ManagedPipelineMode,
            ["Managed Runtime Version"] = appPool.ManagedRuntimeVersion,
            ["Start Mode"] = appPool.StartMode,
        });

        ListViewGroup grpAppPoolProcessModel =
            lstInfo.Groups.Add("grpAppPoolProcessModel", "Application Pool (Process Model)");
        AddInfos(grpAppPoolProcessModel, new()
        {
            ["Identity Type"] = appPool.ProcessModel.IdentityType,
            ["Idle Timeout"] = appPool.ProcessModel.IdleTimeout.ToString("g"),
            ["Idle Timeout Action"] = appPool.ProcessModel.IdleTimeoutAction,
            ["Load User Profile"] = appPool.ProcessModel.LoadUserProfile,
            ["Max Processes"] = appPool.ProcessModel.MaxProcesses,
            ["Ping Interval"] = appPool.ProcessModel.PingInterval.ToString("g"),
            ["Ping Response Time"] = appPool.ProcessModel.PingResponseTime.ToString("g"),
            ["Ping Enabled"] = appPool.ProcessModel.PingingEnabled,
            ["User Name"] = appPool.ProcessModel.UserName,
            ["Startup Time Limit"] = appPool.ProcessModel.StartupTimeLimit.ToString("g"),
            ["Shutdown Time Limit"] = appPool.ProcessModel.ShutdownTimeLimit.ToString("g"),
        });

        //lstInfo.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
        lstInfo.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
    }

    private void AddInfos(ListViewGroup group, Dictionary<string, object?> infos)
    {
        foreach ((string name, object? value) in infos)
        {
            ListViewItem item = new(name) { Group = group };
            string strValue = value switch
            {
                null => "[NULL]",
                Func<string> func => func(),
                _ => value.ToString() ?? "[NULL]"
            };
            item.SubItems.Add(strValue);
            lstInfo.Items.Add(item);
        }
    }
}
