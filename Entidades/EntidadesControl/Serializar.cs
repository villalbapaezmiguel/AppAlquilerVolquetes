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
        public static void EscribirXMLCompras(string ruta, List<Compra> lista)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                XmlSerializer serializar = new XmlSerializer(typeof(List<Compra>));
                serializar.Serialize(streamWriter, lista);
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
