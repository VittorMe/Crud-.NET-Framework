using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "VeiculosSalvar",
                "Veiculos/Salvar",
                new { Controller = "Veiculos", action = "Salvar" }
            );

            routes.MapRoute(
                "VeiculosExcluir",
                "Veiculos/Excluir/:id",
                new { Controller = "Veiculos", action = "Excluir", id = 0 }
            );

            routes.MapRoute(
                "VeiculosAlterar",
                "Veiculos/Alterar/:id",
                new { Controller = "Veiculos", action = "Alterar", id = 0 }
            );

            routes.MapRoute(
                "VeiculosAdicionar",
                "Veiculos/Adicionar",
                new { Controller = "Veiculos", action = "Adicionar" }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
