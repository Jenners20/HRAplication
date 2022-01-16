using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class Proceso_Salida
    {
        public static List<Salida> ObtenerListadeSalidas()
        {
            return PeticionesProcesos.ObtenerListadeSalidas();
        }

        public static void GuardarSalida(Salida salida)
        {
            PeticionesProcesos.AgregarSalida(salida);
        }

    }
}
