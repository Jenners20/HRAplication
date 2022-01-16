using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacion.Controllers
{
    public class SalidasController : Controller
    {
        // GET: Salidas
        public ActionResult Inicio()
        {
            ViewBag.Empleados = Proceso_Nomina.ObtenerEmpleadodeNomina();
            return View();
        }

        public ActionResult Ver()
        {
            ViewBag.Empleados = CRUD_Empleados.ObtenerLista();
            ViewBag.Salidas = Proceso_Salida.ObtenerListadeSalidas();
            return View();
        }
        public ActionResult Crear(int id)
        {
            var Empleado = CRUD_Empleados.ObtenerEmpleadoPorID(id);
            ViewBag.Nombre = Empleado.Nombre + " " + Empleado.Apellido;
            ViewBag.Identificacion = id;
            ViewBag.Tipo = DatosGlobales.TipoSalidas;

            return View();
        }

        [HttpPost]
        public ActionResult crear(Salida salida)
        {
            Proceso_Salida.GuardarSalida(salida);

            return Redirect("~/Salidas/Inicio");
        }

    }
}