using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class PeticionesInformes
    {

        public static List<Empleado> ObtenerListaDeEmpleadosInactivos()
        {
            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            var Lista = Data.Empleados.Where(a => a.Estatus == false);

            return Lista.ToList();
        }


        public static List<TotalNomina> ObtenerListaDeNomina(InformeNomina nomina)
        {
            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            List<TotalNomina> Lista = new List<TotalNomina>();

            if(nomina.Año == null && nomina.Mes == null)
            {
                Lista = Data.TotalNominas.ToList();
            }
            else if(nomina.Año != null && nomina.Mes == null)
            {
                Lista = Data.TotalNominas.Where(a => a.Fecha.Value.Year == nomina.Año.Value.Year).ToList();
            }
            else if (nomina.Año == null && nomina.Mes != null)
            {
                Lista = Data.TotalNominas.Where(a => a.Fecha.Value.Month == nomina.Mes.Value.Month).ToList();
            }
            else
            {
                Lista = Data.TotalNominas.Where(a => a.Fecha.Value.Month == nomina.Mes.Value.Month && a.Fecha.Value.Year == nomina.Año.Value.Year).ToList();

            }

            return Lista;
        }

        public static List<Empleado> ObtenerListaDeEmpleadosActivos(InformeEmpleado empleado)
        {
            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            List<Empleado> Lista = new List<Empleado>();

            if (empleado.Nombre == null && empleado.Departamento == null)
            {
                Lista = Data.Empleados.Where(a => a.Estatus == true).ToList();
            }
            else if (empleado.Nombre != null && empleado.Departamento == null)
            {
                Lista = (from m in Data.Empleados
                              where m.Nombre.Contains(empleado.Nombre) && m.Estatus == true
                              select m).ToList();
            }
            else if (empleado.Nombre == null && empleado.Departamento != null)
            {
                Lista = Data.Empleados.Where(a => a.Departamento == empleado.Departamento && a.Estatus == true).ToList();
            }
            else
            {
                Lista = (from m in Data.Empleados
                         where m.Nombre.Contains(empleado.Nombre) && m.Estatus == true && m.Departamento == empleado.Departamento
                         select m).ToList();
            }

            return Lista;
        }


     public static List<Empleado> ObtenerEntradasdeEmpleadosActivoPorMes(InformeMes mes)
        {
            RecursosHumanosEntities data = new RecursosHumanosEntities();
            List<Empleado> Lista = new List<Empleado>();

            Lista = data.Empleados.Where(a => a.Estatus == true ).ToList();
            Lista = Lista.Where(a => a.FechadeIngreso.Value.Month == mes.Mes.Month).ToList();

            return Lista;

        }



        public static List<Salida> ObtenerSalidasDeEmpleadosPorMes(InformeMes mes)
        {

            RecursosHumanosEntities data = new RecursosHumanosEntities();
            List<Salida> Lista = new List<Salida>();

            Lista = data.Salidas.Where(a => a.FechadeSalida.Value.Month == mes.Mes.Month).ToList();

            return Lista;


        }


        public static List<Permiso> ObtenerPermisosPorEmpleado(InformeEmpleado empleado)
        {

            RecursosHumanosEntities data = new RecursosHumanosEntities();
            List<Permiso> Lista = new List<Permiso>();

            if (empleado.Departamento == null)
            {
                Lista = data.Permisos.ToList();
            }
            else
            {
                Lista = data.Permisos.Where(a => a.Empleado == empleado.Departamento).ToList();
            }


            return Lista;

        }

    }
}
