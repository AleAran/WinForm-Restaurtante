using Restaurante.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.DAL
{
    public class EmpleadoDAL
    {
        //Objeto utilizado para conectar con la base de datos.
        private SqlConnection conexion;

        public EmpleadoDAL()
        {
            //Conecto a la base de datos con el conection string proporcionado (Establece donde esta el motor de base de datos y que base de datos utilizar)
            //Ver https://www.connectionstrings.com/
            conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Restaurante;Trusted_Connection=True;");
        }

        public void Guardar(Empleado empleado)
        {
            //"Intento" hacer las operaciones que se encuentran dentro del bloque try
            try
            {
                //Abro la conexion con la base de datos.
                conexion.Open();
                //SQL Command es el objeto donde voy a indicar la "query" que quiero ejecutar en la base de datos
                //Es importante proporcionar como segundo parametro la conexion con la que quiero ejecutar la consulta
                SqlCommand command = new SqlCommand("INSERT INTO empleados (apellido,nombre,dni) VALUES ('" + empleado.Apellido + "','" + empleado.Nombre + "'," + empleado.DNI + ")", conexion);

                //Este metodo ejecuta la consulta sin esperar ningun resultado
                command.ExecuteNonQuery();
            }
            catch(Exception ex) //Esto se ejecuta si se produce algun error dentro del bloque try
            {
                //Aca puedo guardar un log de que hubo un error
                //para eso uso la variable "ex" que recibi en el catch
                //Y luego, envio una exception personalizada
                throw new RestauranteDataException("Error en la DB",ex);
            }
            finally
            {
                //Tengo que cerrar la conexion con la base de datos para evitar tener abiertas conexiones innecesarias
                //Debo cerrar la conexion, caso contrario queda abierta luego de ejecutar el metodo
                conexion.Close();
            }
            
        }

        public void Editar(Empleado empleado)
        {
            //Abro la conexion con la base de datos.
            conexion.Open();
            //SQL Command es el objeto donde voy a indicar la "query" que quiero ejecutar en la base de datos
            //Es importante proporcionar como segundo parametro la conexion con la que quiero ejecutar la consulta
            SqlCommand command = new SqlCommand("UPDATE empleados SET apellido='" + empleado.Apellido + "',nombre='" + empleado.Nombre + "',DNI='" + empleado.DNI + "' WHERE Id=" + empleado.Id, conexion);
            //Este metodo ejecuta la consulta sin esperar ningun resultado
            command.ExecuteNonQuery();
            //Tengo que cerrar la conexion con la base de datos para evitar tener abiertas conexiones innecesarias
            //Debo cerrar la conexion, caso contrario queda abierta luego de ejecutar el metodo
            conexion.Close();
        }

        public void Borrar(Empleado empleado)
        {
            //Abro la conexion con la base de datos.
            conexion.Open();
            //SQL Command es el objeto donde voy a indicar la "query" que quiero ejecutar en la base de datos
            //Es importante proporcionar como segundo parametro la conexion con la que quiero ejecutar la consulta
            SqlCommand command = new SqlCommand("DELETE empleados WHERE Id='" + empleado.Id + "'",conexion);
            //Este metodo ejecuta la consulta sin esperar ningun resultado
            command.ExecuteNonQuery();
            //Tengo que cerrar la conexion con la base de datos para evitar tener abiertas conexiones innecesarias
            //Debo cerrar la conexion, caso contrario queda abierta luego de ejecutar el metodo
            conexion.Close();
        }

        public List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> resultado = new List<Empleado>();
            //"Intento" hacer las operaciones que se encuentran dentro del bloque try
            try
            {
                //Abro la conexion con la base de datos.
                conexion.Open();
                //SQL Command es el objeto donde voy a indicar la "query" que quiero ejecutar en la base de datos
                //Es importante proporcionar como segundo parametro la conexion con la que quiero ejecutar la consulta
                SqlCommand command = new SqlCommand("SELECT * FROM empleados", conexion);
                //El metodo "ExecuteReader" ejecuta la consulta y nos devuelve un "puntero" al resultado
                SqlDataReader reader = command.ExecuteReader();

                //Mientras haya resultados en el puntero, lo avanzo y leo el siguiente resultado
                while (reader.Read())
                {
                    Empleado empleado = new Empleado();

                    //Los metodos "Get" son para obtener los datos de la columna actual
                    //Debo utilizar el get correspondiente al tipo de dato de la columna
                    //El parametro de los metodos get corresponde con el numero de columna iniciando en 0
                    empleado.Id = reader.GetInt32(0);
                    empleado.Apellido = reader.GetString(1);
                    empleado.Nombre = reader.GetString(2);
                    empleado.DNI = reader.GetInt32(3);

                    resultado.Add(empleado);
                }
                //Debo cerrar el reader ya que solo se permite tener un reader abierto por conexion
                reader.Close();
                //Tengo que cerrar la conexion con la base de datos para evitar tener abiertas conexiones innecesarias
                //Debo cerrar la conexion, caso contrario queda abierta luego de ejecutar el metodo
                conexion.Close();
            }
            catch //Esto se ejecuta si se produce algun error dentro del bloque try
            {
                //Envio una exception personalizada
                //Ojo! Estoy perdiendo informaciòn de donde se produjo
                //Deberia guardar informacion en un log
                throw new RestauranteDataException();
            }           
            
            return resultado;
        }

        public int ObtenerCantidadEmpleados()
        {
            //Abro la conexion con la base de datos.
            conexion.Open();
            //SQL Command es el objeto donde voy a indicar la "query" que quiero ejecutar en la base de datos
            //Es importante proporcionar como segundo parametro la conexion con la que quiero ejecutar la consulta
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM empleados",conexion);

            //El metodo "ExecuteScalar" devuelve como resultado el valor de la primera columna de la primer fila
            //En este caso, al tener solo un valor (El resultado del COUNT(*)), devuelve ese valor
            int total = Convert.ToInt32(command.ExecuteScalar());
            conexion.Close();
            return total;
        }
    }
}
