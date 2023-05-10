using JetBrains.Annotations;

namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme;

public class AbpDynamicLayoutComponentOptions
{
    public AbpDynamicLayoutComponentOptions()
    {
        Components = new Dictionary<Type, IDictionary<string, object>>();
    }

    [NotNull] public Dictionary<Type, IDictionary<string, object>> Components { get; set; }
}