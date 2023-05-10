﻿using Localization.Resources.AbpUi;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace Zyknow.Abp.MasaUI.Components;

public partial class EntityActions<TItem>
{
    [Inject] public IStringLocalizer<AbpUiResource> UiLocalizer { get; set; }

    [Parameter] public string ToggleColor { get; set; } = StyleColor.Primary;

    [Parameter] public string ToggleText { get; set; }

    [Parameter] public RenderFragment ChildContent { get; set; }

    [Parameter] public ActionType Type { get; set; } = ActionType.Dropdown;

    [Parameter] public bool Disabled { get; set; }

    [Parameter] public TItem Item { get; set; }

    protected override void OnInitialized()
    {
        ToggleText = UiLocalizer["Actions"];
    }
}