using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace CapaPresentacion.Controllers
{
    public class EmpleadosController : Controller
    {
        // GET: Empleados
        public ActionResult Inicio()
        {
            ViewBag.Empleados = CRUD_Empleados.ObtenerLista();

            return View();
        }


        public ActionResult Crear()
        {
            ViewBag.Departamentos = CRUD_Departamentos.ObtenerLista();
            ViewBag.Cargos = CRUD_Cargos.ObtenerLista();
            
            return View();
        }

        [HttpPost]
        public ActionResult Crear(Empleado empleado)
        {

            CRUD_Empleados.Crear(empleado);

            return Redirect("Inicio");
        }

        public ActionResult Editar(int ID)
        {

            Empleado empleado = CRUD_Empleados.ObtenerEmpleadoPorID(ID);
            ViewBag.Departamentos = CRUD_Departamentos.ObtenerLista();
            ViewBag.Cargos = CRUD_Cargos.ObtenerLista();

            return View(empleado);
        }

        [HttpPost]
        public ActionResult Editar(Empleado empleado)
        {

            CRUD_Empleados.Actualizar(empleado);

            return Redirect("~/Empleados/Inicio");
        }

        public ActionResult Eliminar(int ID)
        {
            Empleado empleado = CRUD_Empleados.ObtenerEmpleadoPorID(ID);

            return View(empleado);
        }

        public ActionResult Eliminacion(int ID)
        {
            CRUD_Empleados.Eliminar(ID);

            return Redirect("~/Empleados/Inicio");
        }
    }
}