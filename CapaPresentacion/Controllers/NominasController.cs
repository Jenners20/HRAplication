using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacion.Controllers
{
    public class NominasController : Controller
    {
        // GET: Nominas
        public ActionResult Inicio()
        {
            ViewBag.TotaldeNominas = Proceso_Nomina.ObtenerlistadeTotaldeNomina();
            ViewBag.Meses = DatosGlobales.Meses;
            return View();
        }

        public ActionResult Calcular()
        {
            ViewBag.Total = Proceso_Nomina.ObtenerTotaldeNomina();
            ViewBag.Empleados = Proceso_Nomina.ObtenerEmpleadodeNomina();
            ViewBag.Meses = DatosGlobales.Meses;
            return View();
        }


        public ActionResult Calcularr()
        {
            Proceso_Nomina.GuardarTotaldeNomina();

            return Redirect("~/Nominas/Inicio");
        }

    }
}