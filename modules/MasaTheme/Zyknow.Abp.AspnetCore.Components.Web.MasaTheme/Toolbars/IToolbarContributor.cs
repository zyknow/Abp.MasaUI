namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Toolbars;

public interface IToolbarContributor
{
    Task ConfigureToolbarAsync(IToolbarConfigurationContext context);
}