using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class PeticionesProcesos
    {

        #region Nominas

        public static List<Empleado> ObtenerEmpleadosdeNomina()
        {


            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            var Lista = Data.Empleados.Where(a => a.Estatus == true).ToList();


            return Lista;

        }


        public static decimal? ObtenerTotaldeNomina()
        {
            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            var x = Data.Empleados.Sum(a => a.Salario);

            return x;
        }

        public static List<TotalNomina> ObtenerListadeTotaldeNominas()
        {
            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            return Data.TotalNominas.ToList();
        }

        public static bool AgregarNomina()
        {
            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            var Verficar = Data.TotalNominas.Where(a => a.Fecha.Value.Year == DateTime.Now.Year && a.Fecha.Value.Month == DateTime.Now.Month).ToList();


            if (Verficar.Count() > 0)
            {

                foreach (var x in Verficar)
                {
                    Data.TotalNominas.Remove(x);
                }
            }

            TotalNomina nomina = new TotalNomina() { Fecha = DateTime.Now, MontoTotal = ObtenerTotaldeNomina() };

            Data.TotalNominas.Add(nomina);

            Data.SaveChanges();

            return true;

        }

        #endregion

        #region Salidas
        public static List<Salida> ObtenerListadeSalidas()
        {
            RecursosHumanosEntities data = new RecursosHumanosEntities();

            return data.Salidas.ToList();
        }

        public static void AgregarSalida(Salida salida)
        {
            RecursosHumanosEntities data = new RecursosHumanosEntities();

            Empleado empleado = data.Empleados.Find(salida.Empleado);
            empleado.Estatus = false;

            data.Salidas.Add(salida);

            data.SaveChanges();


        }

        #endregion

        #region Vacaciones
        public static List<Vacacione> ObtenerListadeVacaciones()
        {
            RecursosHumanosEntities data = new RecursosHumanosEntities();

            return data.Vacaciones.ToList();
        }

        public static void AgregarVacaciones(Vacacione vacacione)
        {
            RecursosHumanosEntities data = new RecursosHumanosEntities();

            data.Vacaciones.Add(vacacione);

            data.SaveChanges();


        }
        #endregion

        #region Permisos
        public static List<Permiso> ObtenerListadePermisos()
        {
            RecursosHumanosEntities data = new RecursosHumanosEntities();

            return data.Permisos.ToList();
        }

        public static void AgregarPermiso(Permiso permiso)
        {
            RecursosHumanosEntities data = new RecursosHumanosEntities();

            data.Permisos.Add(permiso);
            data.SaveChanges();


        }
        #endregion

        #region Licencias
        public static List<Licencia> ObtenerListadeLicencias()
        {
            RecursosHumanosEntities data = new RecursosHumanosEntities();

            return data.Licencias.ToList();
        }

        public static void AgregarLicencia(Licencia licencia)
        {
            RecursosHumanosEntities data = new RecursosHumanosEntities();

            data.Licencias.Add(licencia);
            data.SaveChanges();


        }
        #endregion

    }
}
