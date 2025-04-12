using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nope.clases
{
    public class Crud
    {
        string connectionString = "Server=MSI\\SQLEXPRESS01;Database=UMG;Integrated Security=True; TrustServerCertificate=True; ";
        public string MostrarCarnet(string carnet)
        {
            string nombre = "No existe";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"Select * from tb_alumnos where carnet = '{carnet}'";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        nombre = reader["estudiante"].ToString();

                    }
                }
                catch (Exception)
                {
                    nombre = "Error";
                    
                }
                connection.Close();
            }
            return nombre;
        }

        public string MostrarSeccion(string carnet)
        {
            string seccion = "No existe";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"Select * from tb_alumnos where carnet = '{carnet}'";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        seccion = reader["seccion"].ToString();

                    }
                }

                catch (Exception)
                {
                    seccion = "Error";
             
                }
                connection.Close();
            }
            return seccion;
        }


        public string MostrarCorreo(string carnet)
        {
            string correo = "No existe";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"Select * from tb_alumnos where carnet = '{carnet}'";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        correo = reader["email"].ToString();

                    }
                }

                catch (Exception)
                {
                    correo = "Error";
                  
                }
                connection.Close();
            }
            return correo;
        }
        public string AgregarAlumno(string carnet, string nombre, string email, string seccion)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Insert into tb_alumnos (carnet, estudiante, email, seccion) values(@carnet, @nombre, @email, @seccion)";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@seccion", seccion);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return "Registros insertados existosamente";
                }

                catch (Exception ex)
                {
                    return "Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message;
                }
                connection.Close();
            }
        }
        public void ActualizarAlumno()
        {
            Console.WriteLine("Carnet a modificar:");
            string carnet = Console.ReadLine();
            Console.WriteLine("Nombre a modificar:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Email a modificar:");
            string email = Console.ReadLine();
            Console.WriteLine("Seccion a modificar: ");
            char seccion = Console.ReadKey().KeyChar;
            Console.WriteLine();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "update tb_alumnos set estudiante=@nombre, email=@email, seccion=@seccion where carnet = @carnet";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@seccion", seccion);

                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Registros actualizados existosamente");
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
                connection.Close();
            }
        }
    }
        }




