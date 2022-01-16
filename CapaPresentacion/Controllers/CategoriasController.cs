using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacion.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Mantenimiento()
        {
            return View();
        }

        public ActionResult Procesos()
        {
            return View();
        }

        public ActionResult Inicio()
        {
            return View();
        }
    }
}