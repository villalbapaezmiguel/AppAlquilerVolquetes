using Entidades.EntidadesUsuarios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesBD
{
    public sealed class CompraBD
    {
        static string conxionString;
        static SqlCommand command;
        static SqlConnection connection;

        static CompraBD()
        {
            conxionString = @"Data Source =.\SQLEXPRESS;Initial Catalog=APP_VOLQUETES;Integrated Security = true ;";
            command = new SqlCommand();
            connection = new SqlConnection(conxionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

        }

        public static void ModificarDB(Compra compra)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE COMPRA SET VOLQUETE = @volquete ,NOMBRE_USUARIO = @nombreUsuario, CANTIDAD = @cantidad,DIAS = @dias,FECHA_DE_ENTREGA = @fechaDeEntrega ,HORA_ENTREGA = @horaDeEntrega , DIRECCION = @direccion, PRECIO = @precio  WHERE ID:COMPRA = @id";
                command.Parameters.AddWithValue("@volquete", compra.TipoVolquete);
                command.Parameters.AddWithValue("@nombreUsuario", compra.NombreDeUsuario);
                command.Parameters.AddWithValue("@cantidad", compra.CantidadVolquetes);
                command.Parameters.AddWithValue("@dias", compra.CantidadDias);
                command.Parameters.AddWithValue("@fechaDeEntrega", compra.FechaDeEntraga);
                command.Parameters.AddWithValue("@horaDeEntrega", compra.HoraDeEntrega);
                command.Parameters.AddWithValue("@direccion", compra.Direccion);
                command.Parameters.AddWithValue("@precio", compra.Precio);
                command.Parameters.AddWithValue("@id", compra.IdCompra);
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


        public static void GuardarDB(Compra compra)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO COMPRA (VOLQUETE,NOMBRE_USUARIO, CANTIDAD,DIAS,FECHA_DE_ENTREGA,HORA_ENTREGA,DIRECCION,PRECIO) VALUES (@volquete,@nombreUsuario,@cantidad,@dias,@fechaDeEntrega,@horaDeEntrega,@direccion,@precio)";
            
                command.Parameters.AddWithValue("@volquete", compra.TipoVolquete);
                command.Parameters.AddWithValue("@nombreUsuario", compra.NombreDeUsuario);
                command.Parameters.AddWithValue("@cantidad", compra.CantidadVolquetes);
                command.Parameters.AddWithValue("@dias", compra.CantidadDias);
                command.Parameters.AddWithValue("@fechaDeEntrega", compra.FechaDeEntraga);
                command.Parameters.AddWithValue("@horaDeEntrega", compra.HoraDeEntrega);
                command.Parameters.AddWithValue("@direccion", compra.Direccion);
                command.Parameters.AddWithValue("@precio", compra.Precio);
                //command.Parameters.AddWithValue("@id", compra.IdCompra);
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
                command.CommandText = $"DELETE FROM COMPRA WHRE ID_COMPRA = @id ";
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
                    if(DateTime.TryParse(reader["FECHA_DE_ENTREGA"].ToString() , out DateTime fecha))
                    {
                        listaCompra.Add(new Compra
                            (
                            reader["VOLQUETE"].ToString(),
                            reader["NOMBRE_USUARIO"].ToString(),
                            int.Parse(reader["CANTIDAD"].ToString()),
                            int.Parse(reader["DIAS"].ToString()),
                            fecha,
                            reader["HORA_ENTREGA"].ToString(),
                            reader["DIRECCION"].ToString(),
                            float.Parse(reader["PRECIO"].ToString()),
                            int.Parse(reader["ID_COMPRA"].ToString())
                            ));
                    }
                }

                return listaCompra;
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
