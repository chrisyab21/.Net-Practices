using manejoPresupuesto.Models;
using Microsoft.AspNetCore.Mvc;

namespace manejoPresupuesto.Controllers
{
    public class TiposCuentasController: Controller
    {

         public IActionResult Crear()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Crear(TipoCuenta Tipo)
        {
            if (!ModelState.IsValid)
            {

                return View(Tipo);
            }

            return View();
        }
    }
}
