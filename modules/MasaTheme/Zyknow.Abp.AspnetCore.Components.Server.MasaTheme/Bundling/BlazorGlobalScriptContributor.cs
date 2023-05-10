using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Zyknow.Abp.AspnetCore.Components.Server.MasaTheme.Bundling;

public class BlazorGlobalScriptContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.AddIfNotContains("/_framework/blazor.server.js");
        context.Files.AddIfNotContains("/_content/BlazorComponent/js/blazor-component.js");
    }
}