using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class CRUD_Empleados 
    {

        private static int GenerarCodigo()
        {
            Random random = new Random();
           int codigo = random.Next(100000, 999999);

            return codigo;
        }

        public static bool Crear(Empleado empleado)
        {
            bool confirmacion = false;
            empleado.Codigo = GenerarCodigo();

            if (PeticionesCRUD.CrearEmpleado(empleado))
            {
                confirmacion = true;
            }

            return confirmacion;
        }


        public static List<Empleado> ObtenerLista()
        {
            List<Empleado> ListadeEmpleados = PeticionesCRUD.ObtenerEmpleados();

            return ListadeEmpleados;
        }

        public static Empleado ObtenerEmpleadoPorID(int ID)
        {
            return PeticionesCRUD.ObtenerEmpleadoPorID(ID);
        }

        public static bool Actualizar(Empleado empleado)
        {
            bool confirmacion = false;

            if (PeticionesCRUD.ActualizarEmpleado(empleado))
            {
                confirmacion = true;
            }

            return confirmacion;
        }

        public static bool Eliminar(int ID)
        {
            bool confirmacion = false;

            if (PeticionesCRUD.EliminarEmpleado(ID))
            {
                confirmacion = true;
            }

            return confirmacion;
        }
    }
}
