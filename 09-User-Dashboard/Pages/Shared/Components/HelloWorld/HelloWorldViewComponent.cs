﻿using Microsoft.AspNetCore.Mvc;
using Tuxboard.Core.Domain.Entities;
using Tuxboard.Core.Infrastructure.Models;

namespace _09_User_Dashboard.Pages.Shared.Components.HelloWorld;

[ViewComponent(Name = "helloworld")]
public class HelloWorldViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(WidgetPlacement placement)
    {
        var widgetModel = new WidgetModel { Placement = placement };

        return View(widgetModel);
    }
}