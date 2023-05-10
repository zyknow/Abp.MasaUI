using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Zyknow.Abp.AspnetCore.Components.Server.MasaTheme.Bundling;

public class BlazorGlobalStyleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.AddIfNotContains("/_content/Masa.Blazor/css/masa-blazor.min.css");

        context.Files.Add("/_content/Zyknow.Abp.MasaUI/libs/font-awesome/css/font-awesome.min.css");
        context.Files.Add("/_content/Zyknow.Abp.MasaUI/libs/@mdi/font/css/materialdesignicons.min.css");
        context.Files.Add("/_content/Zyknow.Abp.MasaUI/libs/flag-icons/css/flag-icons.min.css");
    }
}