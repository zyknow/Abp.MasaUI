namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Toolbars;

public interface IToolbarManager
{
    Task<Toolbar> GetAsync(string name);
}