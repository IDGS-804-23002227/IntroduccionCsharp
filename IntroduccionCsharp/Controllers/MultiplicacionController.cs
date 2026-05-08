using IntroduccionCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionCsharp.Controllers
{
    public class MultiplicacionController : Controller
    {
        public ActionResult Multiplicacion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Multiplicacion(Multiplicacion m)
        {
            m.Calcular();

            return View(m);
        }
    }
}