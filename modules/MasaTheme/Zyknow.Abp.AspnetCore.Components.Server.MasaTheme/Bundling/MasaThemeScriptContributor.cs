using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Zyknow.Abp.AspnetCore.Components.Server.MasaTheme.Bundling;

public class MasaThemeScriptContributor : BundleContributor
{
    private const string RootPath = "/_content/Zyknow.Abp.AspnetCore.Components.Web.MasaTheme";

    public override void ConfigureBundle(BundleConfigurationContext context)
    {
    }
}