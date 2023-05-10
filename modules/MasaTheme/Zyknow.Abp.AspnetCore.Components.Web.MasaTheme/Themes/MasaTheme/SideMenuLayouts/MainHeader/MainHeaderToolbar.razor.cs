using Microsoft.AspNetCore.Components;
using Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Toolbars;

namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Themes.MasaTheme.SideMenuLayouts.MainHeader;

public partial class MainHeaderToolbar
{
    [Inject] private IToolbarManager ToolbarManager { get; set; }

    private List<RenderFragment> ToolbarItemRenders { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        var toolbar = await ToolbarManager.GetAsync(StandardToolbars.Main);

        foreach (var item in toolbar.Items)
        {
            ToolbarItemRenders.Add(builder =>
            {
                builder.OpenComponent(0, item.ComponentType);
                builder.CloseComponent();
            });
        }
    }
}