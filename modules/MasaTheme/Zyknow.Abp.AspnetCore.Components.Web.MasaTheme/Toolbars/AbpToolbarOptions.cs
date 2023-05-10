using JetBrains.Annotations;

namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Toolbars;

public class AbpToolbarOptions
{
    public AbpToolbarOptions()
    {
        Contributors = new List<IToolbarContributor>();
    }

    [NotNull] public List<IToolbarContributor> Contributors { get; }
}