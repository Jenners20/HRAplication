using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacion.Controllers
{
    public class PermisosController : Controller
    {
        // GET: Permisos
        public ActionResult Inicio()
        {
            ViewBag.Empleados = Proceso_Nomina.ObtenerEmpleadodeNomina();

            return View();
        }

        public ActionResult Ver()
        {
            ViewBag.Empleados = CRUD_Empleados.ObtenerLista();
            ViewBag.Permisos = Proceso_Permisos.ObtenerListadePermisos();
            return View();
        }

        public ActionResult Crear(int id)
        {
            var Empleado = CRUD_Empleados.ObtenerEmpleadoPorID(id);
            ViewBag.Nombre = Empleado.Nombre + " " + Empleado.Apellido;
            ViewBag.Identificacion = id;
            return View();
        }

        [HttpPost]
        public ActionResult crear(Permiso permiso)
        {
            Proceso_Permisos.GuardarPermiso(permiso);

            return Redirect("~/Permisos/Inicio");
        }


    }
}