using Entidades.EntidadesUsuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.EntidadesControl
{
    public class Serializar
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

        public static Usuario DeserializarUsuarioDeArchivo(string rutaArchivo)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Usuario));

            using (StreamReader reader = new StreamReader(rutaArchivo))
            {
                return (Usuario)serializer.Deserialize(reader);
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

        public static bool CrearDirectorioParaUsuario(string ruta)
        {
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
                Console.WriteLine("Se creo un nuevo directorio...");
                return true;
            }
            else
            {
                Console.WriteLine("Ese directorio ya existe...");
            }
            return false;
        }

        public static bool SobrescribirTodoElArchivo(string ruta, string contenido)
        {
            if (ruta != string.Empty && contenido != string.Empty)
            {
                try
                {
                    using (StreamWriter streamWriter = new StreamWriter(ruta))
                    {
                        streamWriter.WriteLine("-----------Se sobrescribio..");
                        streamWriter.WriteLine(contenido);

                        return true;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            return false;
        }


        public static bool EscribirArchivo(string ruta, string contenido)
        {
            if (ruta != string.Empty && contenido != string.Empty)
            {
                try
                {
                    using (StreamWriter streamWriter = new StreamWriter(ruta, true))
                    {
                        streamWriter.WriteLine("-----------");
                        streamWriter.WriteLine(contenido);

                        return true;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            return false;
        }


        public static bool CrearArchivo(string ruta, string contenido)
        {
            if (ruta != string.Empty && contenido != string.Empty)
            {
                try
                {
                    using (StreamWriter streamWriter = new StreamWriter(ruta))
                    {
                        streamWriter.WriteLine(contenido);
                        streamWriter.Close();//cierra el archivo
                        streamWriter.Dispose();//libera la memoria para la cual fue usada
                        return true;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
            return false;
        }


        public static string LeerArchivo(string ruta)
        {
            string lecturaReader;
            if (ruta != string.Empty)
            {
                try
                {
                    using (StreamReader streamReader = new StreamReader(ruta))
                    {
                        lecturaReader = streamReader.ReadToEnd();//lee todo el archivo que existe
                        return lecturaReader;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
            return string.Empty;
        }


    }
}
