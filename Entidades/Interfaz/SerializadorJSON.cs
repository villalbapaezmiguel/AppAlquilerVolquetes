using Entidades.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaGenericos.Serializadores
{
    public class SerializadorJSON<T> : Serializador, ISerializable<T> where T : new() //tiene que tener si o si un construrctir vacio
    {
        public SerializadorJSON(string path) : base(path)
        {

        }

        public List<T> Deserializar()
        {

            return new List<T>();


        }

        public bool Serializar(List<T> datos)
        {
            return true;
        }
    }
}
