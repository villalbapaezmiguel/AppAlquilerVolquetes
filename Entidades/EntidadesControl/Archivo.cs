using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesControl
{
    public sealed class Archivo
    {
        public static void CrearDirectorioYArchivo(string directorio, string nombreArchivo, string contenido)
        {

            try
            {
                Directorio.CrearDirectorio(directorio);

                // Construir la ruta completa del archivo.
                string rutaCompleta = Path.Combine(directorio, nombreArchivo);



                // Verificar si el archivo existe; si existe, abrirlo y escribir en él.
                if (File.Exists(rutaCompleta))
                {
                    using (StreamWriter writer = File.AppendText(rutaCompleta))
                    {
                        writer.WriteLine(contenido);
                    }
                }
                else
                {
                    // Si el archivo no existe, crearlo y escribir en él.
                    using (StreamWriter writer = File.CreateText(rutaCompleta))
                    {
                        writer.WriteLine(contenido);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }
    }
}
