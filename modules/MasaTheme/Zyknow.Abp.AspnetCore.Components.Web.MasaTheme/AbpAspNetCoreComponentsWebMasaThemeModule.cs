using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;
using Volo.Abp.VirtualFileSystem;
using Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Layout;
using Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Routing;
using Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Shared;
using Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Shared.Localization;
using Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Toolbars;
using Zyknow.Abp.MasaUI;

namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme;

[DependsOn(
    typeof(AbpMasaBlazorUiModule),
    typeof(AbpAutoMapperModule),
    typeof(AbpUiNavigationModule),
    typeof(AbpVirtualFileSystemModule)
)]
public class AbpAspNetCoreComponentsWebMasaThemeModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options => { options.FileSets.AddEmbedded<AbpAspNetCoreComponentsWebMasaThemeModule>(); });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<MasaResource>("en")
                .AddVirtualJson("Shared/Localization/Masa");
        });
        
        context.Services.AddAutoMapperObjectMapper<AbpAspNetCoreComponentsWebMasaThemeModule>();
        ConfigureRouterOptions();
        ConfigurePageHeaderOptions();
        ConfigureMasaStyles();
    }

    private void ConfigureRouterOptions()
    {
        Configure<AbpRouterOptions>(options => { options.AdditionalAssemblies.Add(typeof(AbpAspNetCoreComponentsWebMasaThemeModule).Assembly); });
    }

    private void ConfigureMasaStyles()
    {
        Configure<MasaThemeOptions>(o =>
        {
            o.Styles[MasaStyleNames.Light] =
                new MasaThemeStyle(L("Theme:" + MasaStyleNames.Light), "bi bi-sun-fill");

            o.Styles[MasaStyleNames.Dark] =
                new MasaThemeStyle(L("Theme:" + MasaStyleNames.Dark), "bi bi-moon-fill");
        });
    }

    private void ConfigurePageHeaderOptions()
    {
        Configure<PageHeaderOptions>(options =>
        {
            options.RenderPageTitle = false;
            options.RenderBreadcrumbs = false;
            options.RenderToolbar = false;
        });
    }

    private static LocalizableString L(string key)
    {
        return LocalizableString.Create<MasaResource>(key);
    }
}