using Microsoft.AspNetCore.Mvc;
using GarageMVC.Models;

namespace GarageMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly Garage miGaraje;

        public HomeController()
        {
            
            miGaraje = new Garage(
                numeroGaraje: 1,
                descripcion: "Garaje de Mike Joseph Contreras Aguilar",
                capacidadEspacios: 20
            );

            
            var auto1 = new Auto(1, "Ferrari", "HUE-1560");
            var auto2 = new Auto(2, "Nissan", "HSE-8679");
            var auto3 = new Auto(3, "Toyota", "HTU-3134");

            miGaraje.ingresarAuto(auto1);
            miGaraje.ingresarAuto(auto2);
            miGaraje.ingresarAuto(auto3);
        }

        public IActionResult Index()
        {
            
            return View(miGaraje);
        }
    }
}