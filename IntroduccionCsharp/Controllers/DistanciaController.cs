using IntroduccionCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionCsharp.Controllers
{
    public class DistanciaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Distancia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Distancia(Distancia d)
        {
            d.Calcular();

            return View(d);
        }
    }
}