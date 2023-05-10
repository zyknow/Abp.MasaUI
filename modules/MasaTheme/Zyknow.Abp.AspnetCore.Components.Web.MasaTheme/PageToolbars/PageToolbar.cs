namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.PageToolbars;

public class PageToolbar
{
    public PageToolbar()
    {
        Contributors = new PageToolbarContributorList();
    }

    public PageToolbarContributorList Contributors { get; set; }
}