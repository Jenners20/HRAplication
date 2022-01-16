using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class PeticionesCRUD
    {
        // Peticiones Cargos
        #region Cargos
        public static List<Cargo> ObtenerCargos()
        {

            RecursosHumanosEntities Data = new RecursosHumanosEntities();
          
            return Data.Cargos.ToList();

        }

        public static bool CrearCargo(Cargo cargo)
        {
            bool confirmacion = false;

            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            try
            {
                Data.Cargos.Add(cargo);
                Data.SaveChanges();
                confirmacion = true;
            }
            catch
            {

            }

            return confirmacion;
        }

        public static Cargo ObtenerCargoPorID(int ID)
        {

            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            return Data.Cargos.Find(ID);

        }


        public static bool ActualizarCargo(Cargo cargo)
        {
            bool confirmacion = false;

            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            try
            {
                Cargo NewCargo = Data.Cargos.First(a => a.ID == cargo.ID);
                NewCargo.Nombre = cargo.Nombre;
                Data.SaveChanges();
                confirmacion = true;
            }
            catch
            {

            }

            return confirmacion;
        }


        public static bool EliminarCargo(int ID)
        {
            bool Confirmacion = false;

            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            try
            {
                Cargo cargo = Data.Cargos.Find(ID);
                Data.Cargos.Remove(cargo);
                Data.SaveChanges();
                Confirmacion = true;
            }
            catch
            {

            }
            return Confirmacion;


        }

        #endregion

        #region Departamentos
        public static List<Departamento> ObtenerDepartamentos()
        {

            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            return Data.Departamentos.ToList();

        }

        public static bool CrearDepartamento(Departamento departamento)
        {
            bool confirmacion = false;

            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            try
            {
                Data.Departamentos.Add(departamento);
                Data.SaveChanges();
                confirmacion = true;
            }
            catch
            {

            }

            return confirmacion;
        }

        public static Departamento ObtenerDepartamentoPorID(int ID)
        {

            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            return Data.Departamentos.Find(ID);

        }


        public static bool ActualizarDepartamento(Departamento departamento)
        {
            bool confirmacion = false;

            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            try
            {
                Departamento NewDepartamento = Data.Departamentos.First(a => a.ID == departamento.ID);
                NewDepartamento.Nombre = departamento.Nombre;
                NewDepartamento.Codigo = departamento.Codigo;
                Data.SaveChanges();
                confirmacion = true;
            }
            catch
            {

            }

            return confirmacion;
        }


        public static bool EliminarDepartamento(int ID)
        {
            bool Confirmacion = false;

            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            try
            {
                Departamento departamento = Data.Departamentos.Find(ID);
                Data.Departamentos.Remove(departamento);
                Data.SaveChanges();
                Confirmacion = true;
            }
            catch
            {

            }
            return Confirmacion;


        }

        #endregion

        #region Empleados
        public static List<Empleado> ObtenerEmpleados()
        {

            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            return Data.Empleados.ToList();

        }

        public static bool CrearEmpleado(Empleado empleado)
        {
            bool confirmacion = false;

            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            try
            {
                Data.Empleados.Add(empleado);
                Data.SaveChanges();
                confirmacion = true;
            }
            catch
            {

            }

            return confirmacion;
        }

        public static Empleado ObtenerEmpleadoPorID(int ID)
        {

            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            return Data.Empleados.Find(ID);

        }


        public static bool ActualizarEmpleado(Empleado empleado)
        {
            bool confirmacion = false;

            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            try
            {
                Empleado NewEmpleado = Data.Empleados.First(a => a.ID == empleado.ID);
                NewEmpleado.Nombre = empleado.Nombre;
                NewEmpleado.Codigo = empleado.Codigo;
                NewEmpleado.Apellido = empleado.Apellido;
                NewEmpleado.Cargo = empleado.Cargo;
                NewEmpleado.Departamento = empleado.Departamento;
                NewEmpleado.Estatus = empleado.Estatus;
                NewEmpleado.FechadeIngreso = empleado.FechadeIngreso;
                NewEmpleado.Salario = empleado.Salario;
                NewEmpleado.Telefono = empleado.Telefono;
                Data.SaveChanges();
                confirmacion = true;
            }
            catch
            {

            }

            return confirmacion;
        }


        public static bool EliminarEmpleado(int ID)
        {
            bool Confirmacion = false;

            RecursosHumanosEntities Data = new RecursosHumanosEntities();

            try
            {
                Empleado empleado = Data.Empleados.Find(ID);
                Data.Empleados.Remove(empleado);
                Data.SaveChanges();
                Confirmacion = true;
            }
            catch
            {

            }
            return Confirmacion;


        }



        #endregion


    }
}
