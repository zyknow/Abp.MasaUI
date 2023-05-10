using JetBrains.Annotations;
using Volo.Abp;

namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.PageToolbars;

public class PageToolbarContributionContext
{
    public PageToolbarContributionContext(
        [NotNull] IServiceProvider serviceProvider)
    {
        ServiceProvider = Check.NotNull(serviceProvider, nameof(serviceProvider));
        Items = new PageToolbarItemList();
    }

    [NotNull] public IServiceProvider ServiceProvider { get; }

    [NotNull] public PageToolbarItemList Items { get; }
}