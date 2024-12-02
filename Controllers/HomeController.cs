using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ayuda_22_11_JJOO.Models;

namespace Ayuda_22_11_JJOO.Controllers;

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

    public IActionResult Deportes()
    {
        ViewBag.ListaDeportes = BD.ListarDeportes();
        return View();
    }

    public IActionResult VerDetalleDeporte(int idDeporte)
    {
        ViewBag.Deporte = BD.VerInfoDeporte(idDeporte);
        ViewBag.ListaDeportistas = BD.ListarDeportistasPorDeporte(idDeporte);
        return View();
    }

    public IActionResult VerDetalleDeportista(int idDeportista)
    {
        ViewBag.Deportista = BD.VerInfoDeportista(idDeportista);
        return View();
    }

    public IActionResult EliminarDeportista(int idDeportista)
    {
        //LA VIEW DEBE VOLVER AL DEPORTE DEL DEPORTISTA ELIMINADO
        int idDeporteElim = BD.VerInfoDeportista(idDeportista).IdDeportes;
        int DeportistasEliminados = BD.EliminarDeportista(idDeportista);
        return RedirectToAction("VerDetalleDeporte", new{idDeporte = idDeporteElim});
    }

    public IActionResult AgregarDeportista()
    {
        ViewBag.Paises = BD.ListarPaises();
        ViewBag.Deportes = BD.ListarDeportes();
        return View();
    }

    public IActionResult GuardarDeportista(string apellido, string nombre, DateTime fechaNacimiento, string foto, int idPais, int idDeporte)
    {
        BD.AgregarDeportista(apellido, nombre, fechaNacimiento, foto, idPais, idDeporte);
        return RedirectToAction("Index");
    }
}
