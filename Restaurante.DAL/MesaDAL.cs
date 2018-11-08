using Restaurante.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.DAL
{
    //Comentarios de cada uno de los metodos en EmpleadoDAL
    public class MesaDAL
    {
        private SqlConnection conexion;
        public MesaDAL()
        {
            conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Restaurante;Trusted_Connection=True;");
        }

        public void Guardar(Mesa mesa)
        {
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand("INSERT INTO mesas (nombre) VALUES ('" + mesa.Nombre + "')", conexion);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch
            {
                throw;
            }            
        }

        public void Editar(Mesa mesa)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand("UPDATE mesas SET nombre='" + mesa.Nombre + "' WHERE Id=" + mesa.Id, conexion);
            command.ExecuteNonQuery();
            conexion.Close();
        }

        public void Borrar(Mesa mesa)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand("DELETE mesas WHERE Id='" + mesa.Id + "'", conexion);
            command.ExecuteNonQuery();
            conexion.Close();
        }

        public List<Mesa> ObtenerMesas()
        {
            List<Mesa> resultado = new List<Mesa>();
            conexion.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM mesas", conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Mesa mesa = new Mesa();

                mesa.Id = reader.GetInt32(0);
                mesa.Nombre = reader.GetString(1);

                resultado.Add(mesa);
            }
            reader.Close();

            conexion.Close();
            return resultado;
        }

        public int ObtenerCantidadMesas()
        {
            conexion.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM mesas", conexion);
            int total = Convert.ToInt32(command.ExecuteScalar());
            conexion.Close();
            return total;
        }
    }
}
