using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Proceso_Licencias
    {
        public static List<Licencia> ObtenerListadeLicencias()
        {
            return PeticionesProcesos.ObtenerListadeLicencias();
        }

        public static void GuardarLicencia(Licencia licencia)
        {
            PeticionesProcesos.AgregarLicencia(licencia);
        }
    }
}
