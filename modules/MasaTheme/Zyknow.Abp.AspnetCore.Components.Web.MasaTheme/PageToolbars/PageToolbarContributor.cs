namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.PageToolbars;

public abstract class PageToolbarContributor : IPageToolbarContributor
{
    public abstract Task ContributeAsync(PageToolbarContributionContext context);
}