using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPrimeraAplicacionWeb.Controllers
{
    public class PeriodoController : Controller
    {
        // GET: Periodo
        public ActionResult IndexPeriodo()
        {
            return View();
        }
        //Accion que muestra el mensaje.
        public string Mensaje()
        {
            return "Bienvenido al curso de ASP.NET";
        }
        //Accion con parametro.
        //Desde la url se pasa así /Periodo/MensajePersonalizado/?Nombre=Jander
        public string MensajePersonalizado(string Nombre)
        {
            return "Bienvenido al curso de ASP.NET: "+Nombre;
        }

        //Accion con  dos parametros
        //Desde la URL se pasa así /Periodo/MensajePersonalizadoCompleto/?Nombre=Jander&Apellido=Benitez
        public string MensajePersonalizadoCompleto(string Nombre, string Apellido)
        {
            return "Bienvenido al curso de ASP.NET: " + Nombre +" "+Apellido;
        }
    }
}