using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AcademiaCintia.Models;
using AcademiaCintia.ViewModels;
using AcademiaCintia.Data;

namespace AcademiaCintia.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        IndexVM index = new() {
            Professores = _context.Professores.ToList()
        };
        return View(index);
    }

    public IActionResult SobreNos()
    {
        SobreNosVM sobre = new() {
            Professores = _context.Professores.ToList(),
            Comentarios = _context.Comentarios.ToList()
        };
        return View(sobre);
    }

    public IActionResult Horarios()
    {
        return View();
    }

    public IActionResult Modalidades()
    {
        ModalidadesVM modalidades = new() {
            Modalidades = _context.Modalidades.ToList(),
        };
        return View(modalidades);
    }

    public IActionResult NossoTime()
    {
        NossoTimeVM nossoTime = new() {
            Professores = _context.Professores.ToList()
        };
        return View(nossoTime);
    }

    public IActionResult TesteIMC()
    {
        return View();
    }

    public IActionResult Galeria()
    {
        return View();
    }

    public IActionResult Contato()
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
