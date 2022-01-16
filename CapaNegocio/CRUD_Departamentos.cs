using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CRUD_Departamentos 
    {

        public static bool Crear(Departamento departamento)
        {
            bool confirmacion = false;

            if (PeticionesCRUD.CrearDepartamento(departamento))
            {
                confirmacion = true;
            }

            return confirmacion;
        }
   

        public static List<Departamento> ObtenerLista()
        {
            List<Departamento> ListadeDepartamentos = PeticionesCRUD.ObtenerDepartamentos();

            return ListadeDepartamentos;
        }

        public static Departamento ObtenerDepartamentosPorID(int ID)
        {
            return PeticionesCRUD.ObtenerDepartamentoPorID(ID);
        }

        public static bool Actualizar(Departamento departamento)
        {
            bool confirmacion = false;

            if (PeticionesCRUD.ActualizarDepartamento(departamento))
            {
                confirmacion = true;
            }

            return confirmacion;
        }

        public static bool Eliminar(int ID)
        {
            bool confirmacion = false;

            if (PeticionesCRUD.EliminarDepartamento(ID))
            {
                confirmacion = true;
            }

            return confirmacion;
        }
    }
}
