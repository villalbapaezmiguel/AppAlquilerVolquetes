using Entidades.EntidadesUsuarios;
using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesBD
{
    public sealed class CompraBD
    {
        static string conxionString;
        static SqlCommand command;
        static SqlConnection connection;
        static int id;

        public static int IdActual { get => id; set => id = value; }

        static CompraBD()
        {
            conxionString = @"Data Source =.\SQLEXPRESS;Initial Catalog=APP_VOLQUETES;Integrated Security = true ;";
            command = new SqlCommand();
            connection = new SqlConnection(conxionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

        }

        public static List<Compra> LeerPorIdUsuario(int id)
        {
            List<Compra> listaCompra = new List<Compra>(); ;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM COMPRA WHERE ID_USUARIO = {id} ";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                         
                        if (DateTime.TryParse(reader["FECHA_DE_ENTREGA"].ToString(), out DateTime fecha))
                        {
                            listaCompra.Add(new Compra(
                            int.Parse(reader["CANTIDAD"].ToString()),
                            int.Parse(reader["DIAS"].ToString()),
                            fecha,
                            reader["HORA_ENTREGA"].ToString(),
                            reader["DIRECCION"].ToString(),
                            float.Parse(reader["PRECIO"].ToString()),
                            int.Parse(reader["ID_COMPRA"].ToString()),
                            int.Parse(reader["ID_USUARIO"].ToString()),
                            int.Parse(reader["ID_VOLQUETE"].ToString())
                            ));
                        }

                    }
                }
            }catch(ExceptionBaseDatos ex)
            {
                throw new Exception($"Error al leer por id el la tabla COMPRA {ex.Error().ToString()}");
            }
            finally
            {
                connection.Close();
            }
            return listaCompra;
        }

        public static Compra LeerPorIdCompra(int id)
        {
            
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM COMPRA WHERE ID_COMPRA = {id} ";
                Compra auxCompra;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        if (DateTime.TryParse(reader["FECHA_DE_ENTREGA"].ToString(), out DateTime fecha))
                        {
                            auxCompra = new Compra(
                            int.Parse(reader["CANTIDAD"].ToString()),
                            int.Parse(reader["DIAS"].ToString()),
                            fecha,
                            reader["HORA_ENTREGA"].ToString(),
                            reader["DIRECCION"].ToString(),
                            float.Parse(reader["PRECIO"].ToString()),
                            int.Parse(reader["ID_COMPRA"].ToString()),
                            int.Parse(reader["ID_USUARIO"].ToString()),
                            int.Parse(reader["ID_VOLQUETE"].ToString())
                            );
                            return auxCompra;
                        }
                    }
                }
            }
            catch (ExceptionBaseDatos ex)
            {
                throw new Exception($"Error al leer por id el la tabla COMPRA {ex.Error().ToString()}");
            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        public static void ModificarDB(Compra compra)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE COMPRA SET CANTIDAD = @cantidad,DIAS = @dias,FECHA_DE_ENTREGA = @fechaDeEntrega ,HORA_ENTREGA = @horaDeEntrega , DIRECCION = @direccion, PRECIO = @precio  WHERE ID:COMPRA = @id";
                command.Parameters.AddWithValue("@cantidad", compra.CantidadVolquetes);
                command.Parameters.AddWithValue("@dias", compra.CantidadDias);
                command.Parameters.AddWithValue("@fechaDeEntrega", compra.FechaDeEntraga);
                command.Parameters.AddWithValue("@horaDeEntrega", compra.HoraDeEntrega);
                command.Parameters.AddWithValue("@direccion", compra.Direccion);
                command.Parameters.AddWithValue("@precio", compra.Precio);
                command.Parameters.AddWithValue("@id", compra.IdCompra);
                command.ExecuteNonQuery();
            }
            catch (ExceptionBaseDatos ex)
            {
                throw new Exception($"Error al modificar la tabla COMPRA {ex.Error().ToString()}");
            }
            finally
            {
                connection.Close();
            }
        }


        public static void GuardarDB(Compra compra)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO COMPRA (CANTIDAD,DIAS,FECHA_DE_ENTREGA,HORA_ENTREGA,DIRECCION,PRECIO,ID_USUARIO,ID_VOLQUETE) VALUES (@cantidad,@dias,@fechaDeEntrega,@horaDeEntrega,@direccion,@precio,@idUsuario,@idVolquete)";
          
                command.Parameters.AddWithValue("@cantidad", compra.CantidadVolquetes);
                command.Parameters.AddWithValue("@dias", compra.CantidadDias);
                command.Parameters.AddWithValue("@fechaDeEntrega", compra.FechaDeEntraga);
                command.Parameters.AddWithValue("@horaDeEntrega", compra.HoraDeEntrega);
                command.Parameters.AddWithValue("@direccion", compra.Direccion);
                command.Parameters.AddWithValue("@precio", compra.Precio);
                command.Parameters.AddWithValue("@idUsuario", compra.IdUsuario);
                command.Parameters.AddWithValue("@idVolquete", compra.IdVolquete);
                command.ExecuteNonQuery();
            }
            catch (ExceptionBaseDatos ex)
            {
                throw new Exception($"Error al guardar la tabla COMPRA {ex.Error().ToString()}");
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
                command.CommandText = $"DELETE FROM COMPRA WHRE ID_COMPRA = @id ";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            catch (ExceptionBaseDatos ex)
            {
                throw new Exception($"Error al eliminar la tabla COMPRA {ex.Error().ToString()}");
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Compra> LeerDB()
        {
            List<Compra> listaCompra = new List<Compra>();

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM COMPRA ";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    IdActual = int.Parse(reader["ID_COMPRA"].ToString());
                    if (DateTime.TryParse(reader["FECHA_DE_ENTREGA"].ToString() , out DateTime fecha))
                    {
                        listaCompra.Add(new Compra
                            (
                            int.Parse(reader["CANTIDAD"].ToString()),
                            int.Parse(reader["DIAS"].ToString()),
                            fecha,
                            reader["HORA_ENTREGA"].ToString(),
                            reader["DIRECCION"].ToString(),
                            float.Parse(reader["PRECIO"].ToString()),
                            int.Parse(reader["ID_COMPRA"].ToString()),
                            int.Parse(reader["ID_USUARIO"].ToString()),
                            int.Parse(reader["ID_VOLQUETE"].ToString())
                            ));
                    }
                }

                return listaCompra;
            }
            catch (ExceptionBaseDatos ex)
            {
                throw new Exception($"Error al leer la tabla COMPRA {ex.Error().ToString()}");
            }
            finally
            {
                connection.Close();
            }

        }


    }
}
