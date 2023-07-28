using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AcademiaCintia.Models;

namespace AcademiaCintia.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult SobreNos()
    {
        return View();
    }

    public IActionResult Horarios()
    {
        return View();
    }

    public IActionResult Modalidades()
    {
        return View();
    }

    public IActionResult NossoTime()
    {
        return View();
    }

    public IActionResult TesteIMC()
    {
        return View();
    }

    public IActionResult Galeria()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
