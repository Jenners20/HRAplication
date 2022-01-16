using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CRUD_Cargos 
    {
        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public static bool Crear(Cargo cargo)
        {
            bool confirmacion = false;

            if (PeticionesCRUD.CrearCargo(cargo))
            {
                confirmacion = true;
            }

            return confirmacion;
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public static List<Cargo> ObtenerLista()
        {
            List<Cargo> ListadeCargos = PeticionesCRUD.ObtenerCargos();

            return ListadeCargos;
        }

        public static Cargo ObtenerCargoPorID(int ID)
        {
            return PeticionesCRUD.ObtenerCargoPorID(ID);
        }

        public static bool ActualizarCargo(Cargo cargo)
        {
            bool confirmacion = false;

            if (PeticionesCRUD.ActualizarCargo(cargo))
            {
                confirmacion = true;
            }

            return confirmacion;
        }

        public static bool Eliminarcargo(int ID)
        {
            bool confirmacion = false;

            if (PeticionesCRUD.EliminarCargo(ID))
            {
                confirmacion = true;
            }

            return confirmacion;
        }

    }
}
