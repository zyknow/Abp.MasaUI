using JetBrains.Annotations;
using Volo.Abp;

namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Toolbars;

public class ToolbarItem
{
    private Type _componentType;

    public ToolbarItem([NotNull] Type componentType, int order = 0)
    {
        Order = order;
        ComponentType = Check.NotNull(componentType, nameof(componentType));
    }

    public Type ComponentType
    {
        get => _componentType;
        set => _componentType = Check.NotNull(value, nameof(value));
    }

    public int Order { get; set; }
}