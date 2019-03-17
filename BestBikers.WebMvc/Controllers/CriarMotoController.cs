using BestBikers.Aplicacao.Logic;
using BestBikers.Entidades.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BestBikers.WebMvc.Controllers
{
    public class CriarMotoController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var moto = new Moto();

            moto.Marca = "Yamaha";


            return View(moto);
        }

        [HttpPost]
        public ActionResult Index(Moto moto)
        {
            var app = new CriarMotoAplicacao();

            if (app.GravarMotoNova(moto))
            {
                return RedirectToAction("Index", "Home");
            }

            return View(moto);
        }
    }
}