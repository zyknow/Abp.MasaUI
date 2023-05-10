﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Volo.Abp.UI.Navigation;

namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Themes.MasaTheme.SideMenuLayouts.SideMenu;

public partial class MainMenuItem
{
    [Parameter] public ApplicationMenuItem MenuItem { get; set; }

    public bool IsSubMenuOpen { get; set; }

    protected override void OnInitialized()
    {
        NavigationManager.LocationChanged += OnLocationChanged;
    }

    private void ToggleSubMenu()
    {
        IsSubMenuOpen = !IsSubMenuOpen;
    }

    public void Dispose()
    {
        NavigationManager.LocationChanged -= OnLocationChanged;
    }

    private void OnLocationChanged(object sender, LocationChangedEventArgs e)
    {
        IsSubMenuOpen = false;
        InvokeAsync(StateHasChanged);
    }
}