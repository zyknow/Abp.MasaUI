using JetBrains.Annotations;
using Volo.Abp.Localization;

namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Shared;

public class MasaThemeStyle
{
    public MasaThemeStyle(LocalizableString displayName, [CanBeNull] string icon = null)
    {
        DisplayName = displayName;
        Icon = icon;
    }

    public LocalizableString DisplayName { get; set; }

    [CanBeNull] public string Icon { get; set; }
}