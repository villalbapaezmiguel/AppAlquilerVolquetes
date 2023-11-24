using Entidades.EntidadesUsuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesControl
{
    public sealed class UsuarioBD
    {
        static string conxionString;
        static SqlCommand command;
        static SqlConnection connection;
        static int id;

        public static int IdActual { get => id; set => id = value; }

        public static int NuevoIdDB()
        {
            return IdActual + 1;
        }


        static UsuarioBD()
        {
            conxionString = @"Data Source =.\SQLEXPRESS;Initial Catalog=APP_VOLQUETES;Integrated Security = true ;";
            command  = new SqlCommand();
            connection = new SqlConnection(conxionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text; 
        
        }

        public static void ModificarDB(Usuario usuario)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE USUARIO SET NOMBRE_USUARIO = @nombreUsuario ,CLAVE = @clave, TELEFONO = @telefono,NOMBRE = @nombre,APELLIDO = @apellido ,DNI = @dni , COLOR = @ModoOscuro WHERE ID_USUARIO = @idUsuario";
                command.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("@clave", usuario.Clave);
                command.Parameters.AddWithValue("@telefono", usuario.Telefono);
                command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                command.Parameters.AddWithValue("@dni", usuario.Dni);
                command.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);
                command.Parameters.AddWithValue("@ModoOscuro", usuario.ModoOscuro);
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


        public static void GuardarDB(Usuario usuario)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO USUARIO (NOMBRE_USUARIO,CLAVE, TELEFONO,NOMBRE,APELLIDO,DNI,COLOR) VALUES (@nombreUsuario,@clave,@telefono,@nombre,@apellido,@dni,@modoOscuro)";
                command.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("@clave", usuario.Clave);
                command.Parameters.AddWithValue("@telefono", usuario.Telefono);
                command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                command.Parameters.AddWithValue("@dni", usuario.Dni);
                //command.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);
                command.Parameters.AddWithValue("@modoOscuro", usuario.ModoOscuro);
                //command.Parameters.AddWithValue("@idCompra", usuario.IdCompra);
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
                command.CommandText = $"DELETE FROM USUARIO WHERE ID_USUARIO = @id ";
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

        public static List<Usuario> LeerDB()
        {
            List<Usuario> listaUsuario = new List<Usuario>();

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM USUARIO ";
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read()) 
                {
                    IdActual = int.Parse(reader["ID_USUARIO"].ToString());

                    

                    listaUsuario.Add(new Usuario(
                    reader["NOMBRE_USUARIO"].ToString(),
                    reader["CLAVE"].ToString(),
                    int.Parse(reader["TELEFONO"].ToString()),
                    reader["NOMBRE"].ToString(),
                    reader["APELLIDO"].ToString(),
                    double.Parse(reader["DNI"].ToString()),
                    int.Parse(reader["ID_USUARIO"].ToString()),
                    reader.GetBoolean(7)
                    
                    ));
                }

                return listaUsuario;
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
