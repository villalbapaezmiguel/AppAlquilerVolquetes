using Entidades;
using Entidades.EntidadesControl;
using Entidades.EntidadesUsuarios;
using Entidades.Excepciones;
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

                    List<T> datosDeserializados = JsonSerializer.Deserialize<List<T>>(json);

                    return datosDeserializados;
                }
                else
                {
                    return new List<T>();
                }
            }
            catch (ExcepcionSerializacion ex)
            {
                throw new ExcepcionSerializacion("Error durante la serializacion ", ex);
               
            }
        }
        public bool Serializar(T datos)
        {
            try
            {
                List<T> listaDeseriazado;

                if (File.Exists(Path))
                {
                    string jsonDeserializado = File.ReadAllText(Path);

                    // Verificar si el JSON es vacío
                    if (!string.IsNullOrEmpty(jsonDeserializado))
                    {
                        listaDeseriazado = JsonSerializer.Deserialize<List<T>>(jsonDeserializado);
                    }
                    else
                    {
                        listaDeseriazado = new List<T>();
                    }
                }
                else
                {
                    listaDeseriazado = new List<T>();
                }

                listaDeseriazado.Add(datos);

                // Serializar la lista a formato JSON
                string jsonActualizado = JsonSerializer.Serialize(listaDeseriazado);

                // Usar StreamWriter para escribir en el archivo
                using (var sw = new StreamWriter(Path))
                {
                    sw.WriteLine(jsonActualizado);
                }

                return true;
            }
            catch (ExcepcionSerializacion ex)
            {
                throw new ExcepcionSerializacion("Error durante la serializacion ", ex);
            }
        }

        public bool AgregarObjeto(T nuevoObjeto)
        {
            try
            {
                List<T> datosDeserializados;

                // Si el archivo existe, leer su contenido
                if (File.Exists(Path))
                {
                    // Leer todo el contenido del archivo
                    string json = File.ReadAllText(Path);

                    // Deserializar la cadena JSON a una lista de objetos
                    datosDeserializados = JsonSerializer.Deserialize<List<T>>(json);
                }
                else
                {
                    // Si el archivo no existe, crear una nueva lista
                    datosDeserializados = new List<T>();
                }

                // Agregar el nuevo objeto a la lista
                datosDeserializados.Add(nuevoObjeto);

                // Serializar la lista actualizada a formato JSON
                string jsonActualizado = JsonSerializer.Serialize(datosDeserializados);

                // Usar StreamWriter para escribir en el archivo
                using (var sw = new StreamWriter(Path))
                {
                    sw.WriteLine(jsonActualizado);
                }

                return true;
            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                    "Admin",
                    DateTime.Now,
                    ex.Message,
                    "SerializadorJSON",
                    "public bool AgregarObjeto(T nuevoObjeto)");
                return false;
            }
        }


        public bool Serializar(List<T> listaDatos)
        {
            try
            {
                List<T> listaDeserializado;

                if (File.Exists(Path))
                {
                    string jsonDeseriazado = File.ReadAllText(Path);

                    listaDeserializado = JsonSerializer.Deserialize<List<T>>(jsonDeseriazado);
                }
                else
                {
                    listaDeserializado = new List<T>();
                }

                foreach(T item in listaDatos)
                {
                    listaDeserializado.Add(item);
                }


                // Serializar la lista a formato JSON
                string jsonActualizado = JsonSerializer.Serialize(listaDeserializado);

                // Usar StreamWriter para escribir en el archivo
                using (var sw = new StreamWriter(Path))
                {
                    sw.WriteLine(jsonActualizado);
                }

                return true;
            }
            catch (ExcepcionSerializacion ex)
            {
                throw new ExcepcionSerializacion("Error durante la serializacion ", ex);
            }
        }
    }
}
