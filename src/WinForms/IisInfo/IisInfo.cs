using System.ComponentModel;

using Microsoft.Web.Administration;

namespace Hackathon.HackstreetBoys.WinForms.IisInfo;

public sealed class IisInfo
{
    [Category("Site")]
    [Description("The name of the web site")]
    public string? Name { get; set; }

    public IisInfoBindings[]? Schemes { get; set; }

    [Bindable(true)] [Browsable(true)] public string? LogFile { get; set; }

    [Category(Categories.ApplicationPool)] public ObjectState State { get; set; }
    [Category(Categories.ApplicationPool)] public bool AutoStart { get; set; }
    [Category(Categories.ApplicationPool), Bindable(true), Browsable(true)] public ApplicationPoolCpu? Cpu { get; set; }
    [Category(Categories.ApplicationPool)] public bool Enable32BitAppOnWin64 { get; set; }
}

public sealed class IisInfoBindings
{
    public string? Scheme { get; set; }

    public int Port { get; set; } = 80;

    public string? Dns { get; set; }

    public override string ToString() => $"{Scheme}://{Dns}:{Port}";
}

public static class Categories
{
    public const string ApplicationPool = "Application Pool";
}
