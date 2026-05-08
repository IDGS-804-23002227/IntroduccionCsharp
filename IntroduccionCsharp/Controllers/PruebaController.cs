using IntroduccionCsharp.Models;
using IntroduccionCsharp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionCsharp.Controllers
{
    public class PruebaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Suma()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Suma(string x, String y, String r1)
        {
            int res = Convert.ToInt16(x) + Convert.ToInt16(y);
            ViewBag.Res = Convert.ToString(res);
            return View();
        }

        public ActionResult Calculos(OperasBas op)
        {
            op.Suma();


            return View(op);
        }


        public ActionResult MuestraPeliculas()
        {
            var peliculasService = new PeliculaService();
            var model = peliculasService.ObtenerPelicula();

            return View(model);

        }


    }
}
