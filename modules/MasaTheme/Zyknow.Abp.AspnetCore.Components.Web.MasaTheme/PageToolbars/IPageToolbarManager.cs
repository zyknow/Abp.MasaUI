namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.PageToolbars;

public interface IPageToolbarManager
{
    Task<PageToolbarItem[]> GetItemsAsync(PageToolbar toolbar);
}