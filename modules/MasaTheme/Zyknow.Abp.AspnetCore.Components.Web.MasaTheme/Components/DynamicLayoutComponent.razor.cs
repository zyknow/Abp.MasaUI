using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;

namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Components;

public partial class DynamicLayoutComponent : ComponentBase
{
    [Inject] protected IOptions<AbpDynamicLayoutComponentOptions> AbpDynamicLayoutComponentOptions { get; set; }
}