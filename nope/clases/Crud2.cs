using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nope.clases
{
    internal class Crud2
    {
        string connectionString = "Server=MSI\\SQLEXPRESS01;Database=UMG;Integrated Security=True; TrustServerCertificate=True; ";
        public string MostrarNota1(string carnet)
        {
            string nota1 = "Sin nota";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"Select * from tareas where carnet = '{carnet}'";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        nota1 = reader["nota1"].ToString();
                    }
                }
                catch (Exception)
                {
                    nota1 = "Error";
                }
                connection.Close();
            }
            return nota1;
        }

        public string MostrarNota2(string carnet)
        {
            string nota2 = "Sin nota";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"Select * from tareas where carnet = '{carnet}'";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        nota2 = reader["nota2"].ToString();
                    }
                }
                catch (Exception)
                {
                    nota2 = "Error";
                }
                connection.Close();
            }
            return nota2;
        }


        public string MostrarNota3(string carnet)
        {
            string nota3 = "Sin nota";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"Select * from tareas where carnet = '{carnet}'";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        nota3 = reader["nota3"].ToString();
                    }
                }
                catch (Exception)
                {
                    nota3 = "Error";
                }
                connection.Close();
            }
            return nota3;
        }

        public string MostrarNota4(string carnet)
        {
            string nota4 = "Sin nota";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"Select * from tareas where carnet = '{carnet}'";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        nota4 = reader["nota4"].ToString();
                    }
                }
                catch (Exception)
                {
                    nota4 = "Error";
                }
                connection.Close();
            }
            return nota4;
        }
        public string AgregarNotas(string carnet, string nota1, string nota2, string nota3, string nota4)
        {


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Insert into tareas (nota1, nota2, nota3, nota4) values(@nota1, @nota2, @nota3, @nota4) where carnet=@carnet";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nota1", nota1);
                    command.Parameters.AddWithValue("@nota2", nota2);
                    command.Parameters.AddWithValue("@nota3", nota3);
                    command.Parameters.AddWithValue("@nota4", nota4);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return "Notas insertados existosamente";
                }

                catch (Exception ex)
                {
                    return "Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message;
                }
                connection.Close();
            }
        }
        public string ActualizarNotas(string carnet, string nota1, string nota2, string nota3, string nota4)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "update tareas set nota1=@nota1, nota2=@nota2, nota3=@nota3, nota4=@nota4 where carnet = @carnet";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@nota1", nota1);
                    command.Parameters.AddWithValue("@nota2", nota2);
                    command.Parameters.AddWithValue("@nota3", nota3);
                    command.Parameters.AddWithValue("@nota4", nota4);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return "Notas actualizados existosamente";
                }

                catch (Exception ex)
                {
                    return "Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message;
                }
                connection.Close();
            }
        }
    }
}
