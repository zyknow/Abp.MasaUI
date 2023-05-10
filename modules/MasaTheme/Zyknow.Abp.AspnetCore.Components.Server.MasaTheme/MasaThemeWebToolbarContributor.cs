using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Zyknow.Abp.AspnetCore.Components.Server.MasaTheme.Themes.MasaTheme;
using Zyknow.Abp.AspnetCore.Components.Web.MasaTheme;
using Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Toolbars;

namespace Zyknow.Abp.AspnetCore.Components.Server.MasaTheme;

public class MasaThemeWebToolbarContributor : IToolbarContributor
{
    public Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
    {
        if (context.Toolbar.Name == StandardToolbars.Main)
        {
            var options = context.ServiceProvider.GetRequiredService<IOptions<MasaThemeBlazorOptions>>().Value;

            context.Toolbar.Items.Add(new ToolbarItem(typeof(LanguageSwitch)));
            context.Toolbar.Items.Add(new ToolbarItem(typeof(LoginDisplay)));
        }

        return Task.CompletedTask;
    }
}