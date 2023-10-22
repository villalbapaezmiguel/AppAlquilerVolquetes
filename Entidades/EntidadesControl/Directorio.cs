using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Entidades.EntidadesControl
{
    public sealed class Directorio
    {
        public static void CrearDirectorio(string rutaDirectorio)
        {
            // Verificar si el directorio existe; si no, crearlo.
            if (!Directory.Exists(rutaDirectorio))
            {
                Directory.CreateDirectory(rutaDirectorio);
            }
        }




    }
}
