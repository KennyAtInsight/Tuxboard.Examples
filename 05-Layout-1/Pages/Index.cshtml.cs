﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using System.Net;
using Layout_1.Pages.Shared.Components.SimpleLayoutDialog;
using Tuxboard.Core.Configuration;
using Tuxboard.Core.Domain.Entities;
using Tuxboard.Core.Infrastructure.Interfaces;
using Tuxboard.Core.Infrastructure.Models;

namespace Layout_1.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IDashboardService _service;
    private readonly TuxboardConfig _config;

    public Dashboard Dashboard { get; set; } = null!;

    public IndexModel(
        ILogger<IndexModel> logger,
        IDashboardService service,
        IOptions<TuxboardConfig> options)
    {
        _logger = logger;
        _service = service;
        _config = options.Value;
    }

    public async Task OnGet()
    {
        Dashboard = await _service.GetDashboardAsync(_config);
    }

    public async Task<IActionResult> OnPostSaveWidgetPosition([FromBody] PlacementParameter model)
    {
        var placement = await _service.SaveWidgetPlacementAsync(model);

        if (placement == null)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError,
                $"Widget Placement (id:{model.PlacementId}) was NOT saved.");
        }

        return new OkObjectResult("Widget Placement was saved.");
    }

    public async Task<IActionResult> OnPostRefresh()
    {
        var dashboard = await _service.GetDashboardAsync(_config);

        return ViewComponent("tuxboardtemplate", dashboard);
    }

    /* Dialogs */
    public async Task<IActionResult> OnPostSimpleLayoutDialog()
    {
        var dashboard = await _service.GetDashboardAsync(_config);
        var layouts = dashboard.GetCurrentTab().GetLayouts().FirstOrDefault();
        var currentLayoutType = layouts?.LayoutRows?.FirstOrDefault()?.LayoutTypeId;

        var layoutTypes = await _service.GetLayoutTypesAsync();
        var result = layoutTypes.Select(e => e.ToDto(currentLayoutType)).ToList();

        return ViewComponent("simplelayoutdialog", result);
    }

    public async Task<IActionResult> OnPostSaveSimpleLayout([FromBody] string newLayoutId)
    {
        var dashboard = await _service.GetDashboardAsync(_config);

        var layouts = dashboard.GetCurrentTab().GetLayouts().FirstOrDefault();
        var currentLayoutType = layouts?.LayoutRows?.FirstOrDefault()?.LayoutTypeId;

        var layoutTypes = await _service.GetLayoutTypesAsync();
        var result = layoutTypes.Select(e => e.ToDto(currentLayoutType)).ToList();
        
        return ViewComponent("simplelayoutdialog", result);
    }
}