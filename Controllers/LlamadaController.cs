using DSWI_T1_RosalesGian.Dtos;
using DSWI_T1_RosalesGian.Services;
using Microsoft.AspNetCore.Mvc;

namespace DSWI_T1_RosalesGian.Controllers
{
    public class LlamadaController : Controller
    {
        private readonly ILlamadaService _llamadaService;

        public LlamadaController(ILlamadaService llamadaService)
        {
            _llamadaService = llamadaService;
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            ViewData["Instruccion"] = "Ingrese los minutos de la llamada";
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(LlamadaDto llamada)
        {
            if (llamada.Minutos <= 0)
            {
                ViewBag.Error = "La cantidad de minutos debe ser mayor a cero";
                return View(llamada);
            }

            double costoTotal = _llamadaService.CalcularCostoLlamada(llamada.Minutos);

            TempData["Minutos"] = llamada.Minutos.ToString();
            TempData["Costo"] = costoTotal.ToString();

            return RedirectToAction("Resultado");
        }

        [HttpGet]
        public IActionResult Resultado()
        {
            ViewBag.MinutosIngresados = TempData["Minutos"];
            ViewBag.CostoTotal = TempData["Costo"];
            return View();
        }
    }
}