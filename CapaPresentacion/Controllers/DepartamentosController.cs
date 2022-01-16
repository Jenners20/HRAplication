using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacion.Controllers
{
    public class DepartamentosController : Controller
    {
        // GET: Departamentos
        public ActionResult Inicio()
        {
            ViewBag.Departamentos = CRUD_Departamentos.ObtenerLista();

            return View();
        }


        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(Departamento departamento)
        {
            CRUD_Departamentos.Crear(departamento);

            return Redirect("Inicio");
        }

        public ActionResult Editar(int ID)
        {

            Departamento departamento = CRUD_Departamentos.ObtenerDepartamentosPorID(ID);

            return View(departamento);
        }

        [HttpPost]
        public ActionResult Editar(Departamento departamento)
        {

            CRUD_Departamentos.Actualizar(departamento);

            return Redirect("~/Departamentos/Inicio");
        }

        public ActionResult Eliminar(int ID)
        {
            Departamento departamento = CRUD_Departamentos.ObtenerDepartamentosPorID(ID);

            return View(departamento);
        }

        public ActionResult Eliminacion(int ID)
        {
            CRUD_Departamentos.Eliminar(ID);

            return Redirect("~/Departamentos/Inicio");
        }

    }
}