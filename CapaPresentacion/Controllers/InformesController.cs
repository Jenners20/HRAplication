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
    public class InformesController : Controller
    {
        // GET: Informes
        public ActionResult Inicio()
        {
            ViewBag.Departamentos = CRUD_Departamentos.ObtenerLista();
            ViewBag.Empleados = CRUD_Empleados.ObtenerLista();

            return View();
        }

       public ActionResult EmpleadosInactivos()
        {
            ViewBag.Empleados = Informes.ObtenerListadeEmpleadosInactivos();
            ViewBag.Departamentos = CRUD_Departamentos.ObtenerLista();
            ViewBag.Cargos = CRUD_Cargos.ObtenerLista();


            return View();
        }

        public ActionResult Cargos()
        {
            ViewBag.Cargos = CRUD_Cargos.ObtenerLista();

            return View();
        }

        public ActionResult Departamentos()
        {
            ViewBag.Departamentos = CRUD_Departamentos.ObtenerLista();

            return View();
        }

        [HttpPost]
        public ActionResult Nomina(InformeNomina nomina)
        {
            ViewBag.Nominas = Informes.ObtenerlistadeNomina(nomina);

            ViewBag.Meses = DatosGlobales.Meses;

            return View();
        }

        [HttpPost]
        public ActionResult EmpleadosActivos(InformeEmpleado empleado)
        {

            ViewBag.Empleados = Informes.ObtenerlistadeEmpleadosActivos(empleado);
            ViewBag.Departamentos = CRUD_Departamentos.ObtenerLista();
            ViewBag.Cargos = CRUD_Cargos.ObtenerLista();

            return View();
        }

        [HttpPost]
        public ActionResult Entradas(InformeMes x)
        {

            ViewBag.Empleados = Informes.ObtenerListaDeEmpleadoPorMes(x);
            ViewBag.Departamentos = CRUD_Departamentos.ObtenerLista();
            ViewBag.Cargos = CRUD_Cargos.ObtenerLista();
            return View();
        }

        [HttpPost]
        public ActionResult Salidas(InformeMes x)
        {
            ViewBag.Salidas = Informes.ObtenerSalidasDeEmpleadoPorMes(x);
            ViewBag.Empleados = CRUD_Empleados.ObtenerLista();
            ViewBag.Meses = DatosGlobales.Meses;

            return View();
        }

        [HttpPost]
        public ActionResult Permisos(InformeEmpleado emple)
        {

            ViewBag.Permisos = Informes.ObtenerPermisosPorEmpleado(emple);
            ViewBag.Empleados = CRUD_Empleados.ObtenerLista();

            return View();
        }
    }
}