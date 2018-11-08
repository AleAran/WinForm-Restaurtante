using Restaurante.DAL;
using Restaurante.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BLL
{
    public class EmpleadoBLL
    {
        public List<Empleado> ObtenerEmpleados()
        {
            //"Intento" hacer las operaciones que se encuentran dentro del bloque try
            try
            {
                EmpleadoDAL empleadoDAL = new EmpleadoDAL();
                return empleadoDAL.ObtenerEmpleados();
            }
            catch  //Esto se ejecuta si se produce algun error dentro del bloque try
            {
                //Aca puedo guardar un log de que hubo un error
                throw;
            }
            
        }

        public void Guardar(Empleado empleado)
        {
            // Validacion de negocio para que se guarden solo los usuarios validos
            if(empleado.Nombre=="" || empleado.Apellido=="" || empleado.DNI<0)
            {
                //Si no pasa la validaciòn de negocio, "tiro" una excepciòn a quien llamo el metodo Guardar
                throw new RestauranteValidacionException();
            }

            //"Intento" hacer las operaciones que se encuentran dentro del bloque try
            try
            {
                EmpleadoDAL empleadoDAL = new EmpleadoDAL();
                empleadoDAL.Guardar(empleado);
            }
            catch //Esto se ejecuta si se produce algun error dentro del bloque try
            {
                //Aca puedo guardar un log de que hubo un error
                throw;
            }

        }

        public void Editar(Empleado empleado)
        {
            EmpleadoDAL empleadoDAL = new EmpleadoDAL();
            empleadoDAL.Editar(empleado);
        }

        public void Borrar(Empleado empleado)
        {
            EmpleadoDAL empleadoDAL = new EmpleadoDAL();
            empleadoDAL.Borrar(empleado);
        }

        public int ObtenerCantidadEmpleados()
        {
            EmpleadoDAL empleadoDAL = new EmpleadoDAL();
            return empleadoDAL.ObtenerCantidadEmpleados();
        }
    }
}
