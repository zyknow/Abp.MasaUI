﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.PageToolbars;

public class SimplePageToolbarContributor : IPageToolbarContributor
{
    public SimplePageToolbarContributor(
        Type componentType,
        Dictionary<string, object> arguments = null,
        int order = 0,
        string requiredPolicyName = null)
    {
        ComponentType = componentType;
        Arguments = arguments;
        Order = order;
        RequiredPolicyName = requiredPolicyName;
    }

    public Type ComponentType { get; }

    public Dictionary<string, object> Arguments { get; set; }

    public int Order { get; }

    public string RequiredPolicyName { get; }

    public async Task ContributeAsync(PageToolbarContributionContext context)
    {
        if (await ShouldAddComponentAsync(context)) context.Items.Add(new PageToolbarItem(ComponentType, Arguments, Order));
    }

    protected virtual async Task<bool> ShouldAddComponentAsync(PageToolbarContributionContext context)
    {
        if (RequiredPolicyName != null)
        {
            var authorizationService = context.ServiceProvider.GetRequiredService<IAuthorizationService>();
            if (!await authorizationService.IsGrantedAsync(RequiredPolicyName)) return false;
        }

        return true;
    }
}