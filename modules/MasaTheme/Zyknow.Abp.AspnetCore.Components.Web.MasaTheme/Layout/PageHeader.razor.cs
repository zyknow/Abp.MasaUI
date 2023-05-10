﻿using BlazorComponent;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.PageToolbars;

namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Layout;

public partial class PageHeader
{
    public PageHeader()
    {
        ToolbarItemRenders = new List<RenderFragment>();
    }

    [Inject] private IOptions<PageHeaderOptions> Options { get; set; }

    [Inject] public IPageToolbarManager PageToolbarManager { get; set; }

    [Parameter] public string Title { get; set; }

    [Parameter] public bool BreadcrumbShowHome { get; set; } = true;

    [Parameter] public bool BreadcrumbShowCurrent { get; set; } = true;

    [Parameter] public RenderFragment ChildContent { get; set; }

    [Parameter] public List<BreadcrumbItem> BreadcrumbItems { get; set; }

    [Parameter] public PageToolbar Toolbar { get; set; }

    protected List<RenderFragment> ToolbarItemRenders { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();
        if (Toolbar != null)
        {
            ToolbarItemRenders.Clear();
            foreach (var item in await PageToolbarManager.GetItemsAsync(Toolbar))
            {
                var sequence = 0;
                ToolbarItemRenders.Add(builder =>
                {
                    builder.OpenComponent(sequence, item.ComponentType);
                    if (item.Arguments != null)
                        foreach (var argument in item.Arguments)
                        {
                            sequence++;
                            builder.AddAttribute(sequence, argument.Key, argument.Value);
                        }

                    builder.CloseComponent();
                });
            }
        }
    }
}