using Masa.Blazor;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using Volo.Abp.AspNetCore.Components.Web;
using Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Shared;
using Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Themes.MasaTheme.SideMenuLayouts.SideMenu;

namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Themes.MasaTheme.SideMenuLayouts;

public partial class SideMenuLayout
{
    [Inject] protected IAbpUtilsService UtilsService { get; set; }
    [Inject] protected MasaBlazor MasaBlazor { get; set; }

    [Inject] protected IOptions<MasaThemeOptions> Options { get; set; }

    private MainMenu? mainMenuRef;

    private bool CascadingIsDark { get; set; }

    private bool NavBarCollapsed { get; set; }
    private bool ExpandNav { get; set; }
    private bool MiniNav { get; set; }

    public void Dispose()
    {
    }
}