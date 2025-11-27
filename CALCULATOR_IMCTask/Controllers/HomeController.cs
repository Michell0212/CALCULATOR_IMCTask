using Microsoft.AspNetCore.Mvc;
using CALCULATOR_IMCTask.Models;

namespace CALCULATOR_IMCTask.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult IMC()
        {
            return View();
        }

        [HttpPost]
        public IActionResult IMC(IMCModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            model.ResultadoIMC = model.Peso / (model.Altura * model.Altura);

            ViewBag.Mensaje = $"Hola {model.Nombre}, tu IMC es:";

            return View(model);
        }
    }
}