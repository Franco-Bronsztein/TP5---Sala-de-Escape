using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_ESCAPE_ROOM.Models;

namespace TP_ESCAPE_ROOM.Controllers;

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

    public IActionResult Tutorial()
    {
        return View("Tutorial");
    }

    public IActionResult Comenzar()
    {
        return View("Sala" + escape.GetEstadoJuego());
    }

    [HttpPost]

    public IActionResult Habitacion(int sala,string clave)
    {
        
        if(sala != escape.GetEstadoJuego())
        {
            ViewBag.MensajeError = "Estas resolviendo una sala equivocada";
        }
        else 
        {
            bool sino = escape.ResolverSala(sala,clave);
            if (sino == false)
            {
                ViewBag.MensajeError = "Respuesta incorrecta";
            }
        }
        if (escape.GetEstadoJuego()>4) return View("victoria");
        
        return View("Sala"+escape.GetEstadoJuego());
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
