using JetBrains.Annotations;
using Volo.Abp;

namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Toolbars;

public class Toolbar
{
    public Toolbar([NotNull] string name)
    {
        Name = Check.NotNull(name, nameof(name));
        Items = new List<ToolbarItem>();
    }

    public string Name { get; }

    public List<ToolbarItem> Items { get; }
}