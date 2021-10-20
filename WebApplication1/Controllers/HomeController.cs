using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["Autorizado"] != null)
            {
                return View();
            }
            else
            {
                Response.Redirect("/Login/Index");
                return null;
            }
        }

        public ActionResult Veiculo()
        {
            ViewBag.Title = "Vende-se";
            ViewBag.Message = "Lista de Veículos";
            if(Session["Autorizado"] != null) 
            {
                var lista = Veiculos.GetCarros();
                ViewBag.Lista = lista;
                return View();
            }
            else
            {
                Response.Redirect("/Login/Index");
                return null;
            }           
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Titulo da pagina Contact";
            ViewBag.Message = "Seus Contatos";
            if (Session["Autorizado"] != null)
            {
                return View();
            }
            else
            {
                Response.Redirect("/Login/Index");
                return null;
            }
        }
    }
}