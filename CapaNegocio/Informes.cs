using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Informes
    {
        public static List<Empleado> ObtenerListadeEmpleadosInactivos()
        {
            return PeticionesInformes.ObtenerListaDeEmpleadosInactivos();
        }

        public static List<TotalNomina> ObtenerlistadeNomina(InformeNomina nomina)
        {
            return PeticionesInformes.ObtenerListaDeNomina(nomina);
        }

        public static List<Empleado> ObtenerlistadeEmpleadosActivos(InformeEmpleado empleado)
        {
            return PeticionesInformes.ObtenerListaDeEmpleadosActivos(empleado);
        }


        public static List<Empleado> ObtenerListaDeEmpleadoPorMes(InformeMes mes)
        {
            return PeticionesInformes.ObtenerEntradasdeEmpleadosActivoPorMes(mes);
        }

        public static List<Salida> ObtenerSalidasDeEmpleadoPorMes(InformeMes mes)
        {

            return PeticionesInformes.ObtenerSalidasDeEmpleadosPorMes(mes);
        }
        

        public static List<Permiso> ObtenerPermisosPorEmpleado(InformeEmpleado empleado)
        {
            return PeticionesInformes.ObtenerPermisosPorEmpleado(empleado);
        }

    }
}
