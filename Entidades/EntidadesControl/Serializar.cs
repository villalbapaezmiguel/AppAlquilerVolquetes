using ConsolaGenericos.Serializadores;
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




    }
}
