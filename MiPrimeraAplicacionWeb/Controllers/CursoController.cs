using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPrimeraAplicacionWeb.Controllers
{
    public class CursoController : Controller
    {
        // GET: Curso
        public ActionResult Index()
        {
            return View();
        }
        //Accion que muestra el mensaje.

        //public string Mensaje()
        //{
        //    return "Bienvenido al curso de ASP.NET";
        //}

        //Accion con parametro.
        //Desde la url se pasa así /Curso/MensajePersonalizado/?Nombre=Jander
        public string  MensajePersonalizado(string Nombre)
        {
            return "Bienvenido al curso de ASP.NET: " + Nombre;
        }

        public ActionResult Mensaje(string Nombre)
        {
            ViewBag.Nombre = Nombre;

            return View();
        }

        //Accion con  dos parametros
        //Desde la URL se pasa así /Curso/MensajePersonalizadoCompleto/?Nombre=Jander&Apellido=Benitez
        public string MensajePersonalizadoCompleto(string Nombre, string Apellido)
        {
            return "Bienvenido al curso de ASP.NET: " + Nombre + " " + Apellido;
        }

        public JsonResult listarCurso()
        {
            PruebaDataContext bd = new PruebaDataContext();
            var lista = bd.Cursos.Where(p => p.BHABILITADO.Equals(1)).Select(p => new { p.IIDCURSO, p.NOMBRE, p.DESCRIPCION }).ToList();
            // En la line anterior, se asigna consulta de linq a la variable lista.
            // En el select de linq, se hace el where, para seleccionar los activos (bhabilitado = 1) y en select se crea un nuevo objeto con las propiedades deseadas
            // se hace a traves de funciones flecha
           
            return Json(lista, JsonRequestBehavior.AllowGet);

            /*
            JSON que genera la consulta anterior.
            [{"IIDCURSO":1,"NOMBRE":"MATEMATICAS","DESCRIPCION":"CURSO DONDE SE VEN LAS OPERACIONES CON NUMEROS"},
            {"IIDCURSO":2,"NOMBRE":"LENGUAJES","DESCRIPCION":"CURSO DONDE SE VE LA SINTAXIS DEL ESPAÑOL"},
            {"IIDCURSO":3,"NOMBRE":"EDUCACION FISICA","DESCRIPCION":"DEPORTES Y EJERCITAR EL CUERPO"},
            {"IIDCURSO":4,"NOMBRE":"LITERATURA","DESCRIPCION":"OBRAS MAS IMPORTANTES DE LOS ESCRITORES MUNDIALES"},
            {"IIDCURSO":5,"NOMBRE":"COMPUTACION","DESCRIPCION":"DIVERTIDO"},
            {"IIDCURSO":6,"NOMBRE":"LINGUISTICA","DESCRIPCION":"CURSO FEO"}]

             */
        }
    }
}