using Microsoft.Web.Administration;

namespace Hackathon.HackstreetBoys.Cli;

internal static class IisExtensions
{
    internal static string GetDirectory(this Site site)
    {
        Application rootApplication = site.Applications["/"];
        VirtualDirectory rootVdir = rootApplication.VirtualDirectories["/"];
        return rootVdir.PhysicalPath;
    }
}
