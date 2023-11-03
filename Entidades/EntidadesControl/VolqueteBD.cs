using Entidades.EntidadesUsuarios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesControl
{
    public sealed class VolqueteBD
    {
        static string conxionString;
        static SqlCommand command;
        static SqlConnection connection;

        static VolqueteBD()
        {
            conxionString = @"Data Source =.\SQLEXPRESS;Initial Catalog=APP_VOLQUETES;Integrated Security = true ;";
            command = new SqlCommand();
            connection = new SqlConnection(conxionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

        }

        public static void ModificarDB(Volquete volquete)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE VOLQUETE SET TIPO = @tipo ,PRECIO = @precio, CAPACIDAD = @capacidad,OBSERVACION = @observacion WHERE ID_VOLQUETE = {volquete.Id}";
                command.Parameters.AddWithValue("@tipo", volquete.TipoVolquete);
                command.Parameters.AddWithValue("@precio", volquete.Precio);
                command.Parameters.AddWithValue("@capacidad", volquete.Capacidad);
                command.Parameters.AddWithValue("@observacion", volquete.Observacion);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }


        public static void GuardarDB(Volquete volquete)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO VOLQUETE (TIPO,PRECIO,CAPACIDAD,OBSERVACION ) VALUES (@tipo,@precio,@capacidad,@observacion)";
                command.Parameters.AddWithValue("@tipo", volquete.TipoVolquete);
                command.Parameters.AddWithValue("@precio", volquete.Precio);
                command.Parameters.AddWithValue("@capacidad", volquete.Capacidad);
                command.Parameters.AddWithValue("@observacion", volquete.Observacion);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void EliminarDB(int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM USUARIO WHRE ID_USUARIO = @id ";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Volquete> LeerDB()
        {
            List<Volquete> listaVolquete = new List<Volquete>();

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM VOLQUETE ";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listaVolquete.Add(new Volquete(
                        reader["TIPO"].ToString(),
                        float.Parse(reader["PRECIO"].ToString()),
                        float.Parse(reader["CAPACIDAD"].ToString()),
                        reader["OBSERVACION"].ToString(),
                        int.Parse(reader["ID_VOLQUETE"].ToString())));
                }

                return listaVolquete;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }

        }


    }
}
