using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Proceso_Permisos
    {
        public static List<Permiso> ObtenerListadePermisos()
        {
            return PeticionesProcesos.ObtenerListadePermisos();
        }

        public static void GuardarPermiso(Permiso permiso)
        {
            PeticionesProcesos.AgregarPermiso(permiso);
        }
    }
}
