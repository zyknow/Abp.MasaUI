using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Zyknow.Abp.AspnetCore.Components.Server.MasaTheme.Bundling;

public class MasaThemeStyleContributor : BundleContributor
{
    private const string RootPath = "/_content/Zyknow.Abp.AspnetCore.Components.Web.MasaTheme";

    public override Task ConfigureBundleAsync(BundleConfigurationContext context)
    {
        context.Files.AddIfNotContains($"{RootPath}/css/global-style.css");
        return Task.CompletedTask;
    }
}