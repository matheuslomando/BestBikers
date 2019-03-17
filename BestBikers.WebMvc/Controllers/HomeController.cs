using BestBikers.Entidades.Model;
using BestBikers.Repositorios.Contexto;
using BestBikers.Repositorios.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BestBikers.WebMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var repo = new MotosRepositorio(new BestBikersContext());
            List<Moto> motos = repo.ObterTodas();

            return View(motos);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}