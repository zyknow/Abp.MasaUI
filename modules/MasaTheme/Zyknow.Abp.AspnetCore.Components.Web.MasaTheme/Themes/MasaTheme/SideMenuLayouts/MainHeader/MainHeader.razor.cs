using Microsoft.AspNetCore.Components;
using Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Shared.Localization;

namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Themes.MasaTheme.SideMenuLayouts.MainHeader;

public partial class MainHeader
{
    public MainHeader()
    {
        LocalizationResource = typeof(MasaResource);
    }

    [Parameter] public EventCallback OnToggle { get; set; }

    public void Dispose()
    {
    }
}