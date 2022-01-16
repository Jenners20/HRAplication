using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Proceso_Nomina 
    {
 
        public static List<Empleado> ObtenerEmpleadodeNomina()
        {
            return PeticionesProcesos.ObtenerEmpleadosdeNomina();
        }


        public static decimal? ObtenerTotaldeNomina()
        {
            return PeticionesProcesos.ObtenerTotaldeNomina();
        }

        public static void GuardarTotaldeNomina()
        {
            PeticionesProcesos.AgregarNomina();
        }


        public static List<TotalNomina> ObtenerlistadeTotaldeNomina()
        {

            return PeticionesProcesos.ObtenerListadeTotaldeNominas();
        }


    }

   

}
