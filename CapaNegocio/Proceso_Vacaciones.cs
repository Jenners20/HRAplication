using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Proceso_Vacaciones
    {
        public static List<Vacacione> ObtenerListaDeVacaciones()
        {
            return PeticionesProcesos.ObtenerListadeVacaciones();
        }

        public static void GuardarVacaciones(Vacacione vacacione)
        {
            PeticionesProcesos.AgregarVacaciones(vacacione);
        }
    }
}
