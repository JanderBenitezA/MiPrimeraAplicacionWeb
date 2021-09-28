using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiPrimeraAplicacionWeb.Models;

namespace MiPrimeraAplicacionWeb.Controllers
{
    public class RepasoHTMLController : Controller
    {
        // GET: RepasoHTML
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tabla()
        {
            return View();
        }
        public ActionResult DropDownList()
        {
            return View();
        }

        public ActionResult TablaJS()
        {
            return View();
        }

        public JsonResult ListarPersonas()
        {

            List<Persona> ListaPersonas = new List<Persona>
            {
                new Persona { idPersona=1, Nombre="Jander", Apellido="Benitez" },
                new Persona { idPersona=2, Nombre="Soraya", Apellido="Velez" },
                new Persona { idPersona=3, Nombre="Sergio", Apellido="Presiga" }
            };

            return Json(ListaPersonas, JsonRequestBehavior.AllowGet);
            
            /* El navegador retorna 
            [{"idPersona":1,"Nombre":"Jander","Apellido":"Benitez"},
            {"idPersona":2,"Nombre":"Soraya","Apellido":"Velez"},
            {"idPersona":3,"Nombre":"Sergio","Apellido":"Presiga"}]
            */    
        }
    }
}