using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Winx.Models;
using Winx.Services;

namespace Winx.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IWinxService _WinxService;

    public HomeController(ILogger<HomeController> logger, IWinxService WinxService)
    {
        _logger = logger;
        _WinxService = _WinxService;
    }

    public IActionResult Index(string personagem)
    {
        var persos = _WinxService.GetWinxDto();
        ViewData["filter"] = string.IsNullOrEmpty(personagem) ? "all" : personagem;
        return View(persos);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id 
        ?? HttpContext.TraceIdentifier });
    }
}
