namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.PageToolbars;

public interface IPageToolbarContributor
{
    Task ContributeAsync(PageToolbarContributionContext context);
}