using System.Reflection;

namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Routing;

public class AbpRouterOptions
{
    public AbpRouterOptions()
    {
        AdditionalAssemblies = new RouterAssemblyList();
    }

    public Assembly AppAssembly { get; set; }

    public RouterAssemblyList AdditionalAssemblies { get; }
}