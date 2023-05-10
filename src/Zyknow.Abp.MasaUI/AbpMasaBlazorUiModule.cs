﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Application;
using Volo.Abp.AspNetCore.Components.Web;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace Zyknow.Abp.MasaUI;

[DependsOn(
    typeof(AbpAspNetCoreComponentsWebModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
)]
public class AbpMasaBlazorUiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureMasaBlazor(context);
    }

    private void ConfigureMasaBlazor(ServiceConfigurationContext context)
    {
        context.Services.AddMasaBlazor();

        context.Services.AddSingleton(typeof(AbpBlazorMessageLocalizerHelper<>));
    }
}