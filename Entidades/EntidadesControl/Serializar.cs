using Entidades.EntidadesUsuarios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.EntidadesControl
{
    public sealed class Serializar
    {

        public static void EscribirXMLListaCompras(string ruta, List<Compra> lista)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    XmlSerializer serializar = new XmlSerializer(typeof(List<Compra>));
                    serializar.Serialize(streamWriter, lista);
                }

            }
            catch (Exception )
            {

                throw;
            }
        }

        public static void SerializarComprasAUsuario(string rutaArchivo , Usuario usuario)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Usuario));

            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                serializer.Serialize(writer, usuario);
            }
        }


        public static void SerializarJSON_Usuario(string rutaArchivo ,Usuario usuario)
        {
            try
            {
                string json = JsonSerializer.Serialize(usuario);
                File.WriteAllText(rutaArchivo, json);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void  SerializarJSON_ListaUsuario(string rutaArchivo , List<Usuario> lista)
        {
            try
            {
                string json = JsonSerializer.Serialize(lista);
                File.WriteAllText(rutaArchivo, json);

            }
            catch (Exception)
            {

                throw;
            }
        }


        public static Usuario DeserializarJSON_Usuario(string rutaArchivo)
        {
            try
            {
                string json = File.ReadAllText(rutaArchivo);
                if(!string.IsNullOrEmpty(json))
                {
                    List<Usuario> lista = JsonSerializer.Deserialize<List<Usuario>>(json);

                    if(lista is not null)
                    {
                        return lista[0];
                    }
                    //Usuario usuarioAux = JsonSerializer.Deserialize<Usuario>(json);

                }
                return null;
            }
            catch (JsonException)
            {

                throw;
            }
        }

        public static List<Usuario> DeserializarJSON_ListaUsuario(string rutaArchivo)
        {
            try
            {
                if(File.Exists(rutaArchivo))
                {
                    string json = File.ReadAllText(rutaArchivo);

                    if(!string.IsNullOrEmpty(json))
                    {
                        List<Usuario> listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(json);
                        if(listaUsuarios is not null)
                        {
                            return listaUsuarios;
                        }
                        
                    }

                }
                return null;

            }
            catch (JsonException)
            {
                throw;
            }
        }


        public static Usuario DeserializarXML_UsuarioDeArchivo(string rutaArchivo)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Usuario));

                using (StreamReader reader = new StreamReader(rutaArchivo))
                {
                    return (Usuario)serializer.Deserialize(reader);
                }
            }
            catch (Exception)
            {

                throw;
            }


        }


        public static List<Compra> LeerXMLCompras(string path)
        {
            List<Compra> lista = null;
            using (StreamReader streamReader = new StreamReader(path))
            {
                XmlSerializer deSerializar = new XmlSerializer(typeof(List<Compra>));

                lista = (List<Compra>)deSerializar.Deserialize(streamReader);
            }
            return lista;
        }





    }
}
