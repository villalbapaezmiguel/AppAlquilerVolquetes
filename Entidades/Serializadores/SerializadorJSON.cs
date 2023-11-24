using Entidades;
using Entidades.EntidadesControl;
using Entidades.EntidadesUsuarios;
using Entidades.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsolaGenericos.Serializadores
{
    public class SerializadorJSON<T> : Serializador, ISerializable<T> where T : new() //tiene que tener si o si un construrctir vacio
    {
        public SerializadorJSON(string path) : base(path)
        {

        }

        public List<T> Deserializar()
        {
            try
            {
                if (File.Exists(Path))
                {
                    // Leer todo el contenido del archivo
                    string json = File.ReadAllText(Path);

                    // Deserializar la cadena JSON a una lista de objetos
                    List<T> datosDeserializados = JsonSerializer.Deserialize<List<T>>(json);

                    return datosDeserializados;
                }
                else
                {
                    return new List<T>();
                }
            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                 "Admin",
                 DateTime.Now,
                 ex.Message,
                 "SerializadorJSON",
                 "public List<T> Deserializar()");
                return new List<T>();
            }
        }
        public bool Serializar(T datos)
        {
            try
            {
                // Serializar la lista a formato JSON
                string json = JsonSerializer.Serialize(datos);

                // Usar StreamWriter para escribir en el archivo
                using (var sw = new StreamWriter(Path))
                {
                    sw.WriteLine(json);
                }

                return true;
            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Admin",
                DateTime.Now,
                ex.Message,
                "FormAdmin",
                "public bool Serializar(List<T> datos)");
                return false;
            }
        }
        public bool Serializar(List<T> datos)
        {
            try
            {
                // Serializar la lista a formato JSON
                string json = JsonSerializer.Serialize(datos);

                // Usar StreamWriter para escribir en el archivo
                using (var sw = new StreamWriter(Path))
                {
                    sw.Write(json);
                }

                return true;
            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Admin",
                DateTime.Now,
                ex.Message,
                "FormAdmin",
                "public bool Serializar(List<T> datos)");
                return false;
            }
        }
    }
}
