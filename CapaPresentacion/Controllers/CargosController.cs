using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacion.Controllers
{
    public class CargosController : Controller
    {
        // GET: Cargos
        public ActionResult Inicio()
        {
            ViewBag.Cargos = CRUD_Cargos.ObtenerLista();
           
            return View();
        }


        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(Cargo cargo)
        {
            CRUD_Cargos.Crear(cargo);

            return Redirect("Inicio");
        }

        public ActionResult Editar(int ID)
        {

            Cargo cargo = CRUD_Cargos.ObtenerCargoPorID(ID);

            return View(cargo);
        }

        [HttpPost]
        public ActionResult Editar(Cargo cargo)
        {

           CRUD_Cargos.ActualizarCargo(cargo);

            return Redirect("~/Cargos/Inicio");
        }

        public ActionResult Eliminar(int ID)
        {
            Cargo cargo = CRUD_Cargos.ObtenerCargoPorID(ID);

            return View(cargo);
        }

        public ActionResult Eliminacion(int ID)
        {
            CRUD_Cargos.Eliminarcargo(ID);

            return Redirect("~/Cargos/Inicio");
        }

    }
}