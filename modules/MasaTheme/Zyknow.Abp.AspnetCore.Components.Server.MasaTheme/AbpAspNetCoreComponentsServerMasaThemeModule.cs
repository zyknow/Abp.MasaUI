using Volo.Abp.AspNetCore.Components.Server;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Modularity;
using Zyknow.Abp.AspnetCore.Components.Server.MasaTheme.Bundling;
using Zyknow.Abp.AspnetCore.Components.Web.MasaTheme;
using Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Toolbars;

namespace Zyknow.Abp.AspnetCore.Components.Server.MasaTheme;

[DependsOn(
    typeof(AbpAspNetCoreComponentsWebMasaThemeModule),
    typeof(AbpAspNetCoreComponentsServerModule),
    typeof(AbpAspNetCoreMvcUiBundlingModule)
)]
public class AbpAspNetCoreComponentsServerMasaThemeModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureBundling();
        ConfigureToolbarOptions();
    }

    private void ConfigureBundling()
    {
        Configure<AbpBundlingOptions>(options =>
        {
            options
                .StyleBundles
                .Add(BlazorStandardBundles.Styles.Global,
                    bundle => { bundle.AddContributors(typeof(BlazorGlobalStyleContributor)); });

            options
                .ScriptBundles
                .Add(BlazorStandardBundles.Scripts.Global,
                    bundle => { bundle.AddContributors(typeof(BlazorGlobalScriptContributor)); });

            options
                .StyleBundles
                .Add(MasaThemeBundles.Styles.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(BlazorStandardBundles.Styles.Global)
                        .AddContributors(typeof(MasaThemeStyleContributor));
                });

            options
                .ScriptBundles
                .Add(MasaThemeBundles.Scripts.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(BlazorStandardBundles.Scripts.Global)
                        .AddContributors(typeof(MasaThemeScriptContributor));
                });
        });
    }

    private void ConfigureToolbarOptions()
    {
        Configure<AbpToolbarOptions>(options => { options.Contributors.Add(new MasaThemeWebToolbarContributor()); });
    }
}