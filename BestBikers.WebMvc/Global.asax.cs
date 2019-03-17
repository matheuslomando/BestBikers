using BestBikers.Repositorios.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BestBikers.WebMvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Database.SetInitializer(new MyInitializer());
        }
    }


    public class MyInitializer : DropCreateDatabaseAlways<BestBikersContext>
    {
        protected override void Seed(BestBikersContext context)
        {
            //context.Guerreiros.Add(new Dominio.Entidades.Guerreiro()
            //{
            //    Nome = "Goku",
            //    Poder = "80001"
            //});

            //context.Guerreiros.Add(new Dominio.Entidades.Guerreiro()
            //{
            //    Nome = "Piccolo",
            //    Poder = "6999"
            //});
        }
    }
}
