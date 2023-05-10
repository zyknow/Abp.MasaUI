using Microsoft.AspNetCore.Components;
using Volo.Abp.AspNetCore.Components.Web.Security;
using Volo.Abp.UI.Navigation;

namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Themes.MasaTheme.SideMenuLayouts.SideMenu;

public partial class MainMenu
{
    [Inject] protected IMenuManager MenuManager { get; set; }


    [Inject] protected ApplicationConfigurationChangedService ApplicationConfigurationChangedService { get; set; }

    protected ApplicationMenu Menu { get; set; }
    private bool expandNav { get; set; } = true;
    private bool miniNav { get; set; } = false;

    public void Dispose()
    {
    }

    public async void OnToggle()
    {
        if (MasaBlazor.Breakpoint.Mobile)
        {
            expandNav = !expandNav;
        }
        else
        {
            miniNav = !miniNav;
        }
        await InvokeAsync(StateHasChanged);
    }


    protected override async Task OnInitializedAsync()
    {
        Menu = await MenuManager.GetMainMenuAsync();
        ApplicationConfigurationChangedService.Changed += ApplicationConfigurationChanged;
    }

    private async void ApplicationConfigurationChanged()
    {
        Menu = await MenuManager.GetMainMenuAsync();
        await InvokeAsync(StateHasChanged);
    }

}