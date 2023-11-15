using Entidades.Interfaz;
using System.Xml.Serialization;

namespace ConsolaGenericos.Serializadores
{
    public class SerializadorXML<T> : Serializador, ISerializable<T> where T : new() //tiene que tener si o si un construrctir vacio
    {
        //La herencia es para utilizar la propiedad Path
        public SerializadorXML(string path) : base(path)
        {

        }

        public List<T> Deserializar()
        {
            var lista = new List<T>();

            using (var sw = new StreamReader(Path))
            {
                if (sw is not null)
                {
                    var xml = new XmlSerializer(typeof(List<T>));
                    var listaDeserializada = xml.Deserialize(sw);

                    if (listaDeserializada is not null)
                    {
                        lista = (List<T>)listaDeserializada;
                    }
                }
            }

            return lista;
        }

        public bool Serializar(List<T> datos)
        {
            using (var sw = new StreamWriter(Path))
            {
                if (sw is not null)
                {
                    var xml = new XmlSerializer((typeof(List<T>)));
                    xml.Serialize(sw, datos);
                }
            }


            return true;
        }
    }
}
