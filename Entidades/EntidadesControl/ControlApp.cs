using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Entidades.EntidadesBD;
using Entidades.EntidadesControl;
using Entidades.EntidadesUsuarios;
using Microsoft.VisualBasic;

namespace Entidades
{
    public static class ControlApp
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>();
        public static List<Volquete> listaVolquetes = new List<Volquete>();
        public static List<Compra> listaDeCompras = new List<Compra>();//cada vez que el usuaurio termine de usar la app guardar todas sus compras aca
        public static List<Admin> listaAdministradores = new List<Admin>();
        public const string rutaCarpetaArchivos = @"C:\Users\villa\Desktop\PracticaLaboDos\AppAlquilerVolquetes\Volquete\Archivos\";
        public const string rutaCarpetaArchivoUsuario = @"C:\Users\villa\Desktop\PracticaLaboDos\AppAlquilerVolquetes\Volquete\Archivos\DatosUsuario\";
        public const string rutaCarpetaArchivoErrores = @"C:\Users\villa\Desktop\PracticaLaboDos\AppAlquilerVolquetes\Volquete\Archivos\ERRORES\";
        public const string rutaCapetaArchivoImprido = @"C:\Users\villa\Desktop\PracticaLaboDos\AppAlquilerVolquetes\Volquete\Archivos\Imprimidos\";
        public const string rutaCarpetaArchivoPaqueteCompras = @"C:\Users\villa\Desktop\PracticaLaboDos\AppAlquilerVolquetes\Volquete\Archivos\Lista de paquetes\";

        private static int idCompra = CompraBD.IdActual;
        private static int idUsuario = 0;
        private static int idVolquete = 0;


        public static int NuevoIdVolquete()
        {
            return idVolquete++;
        }
        public static int NuevoIdUsuario()
        {
            return idUsuario++;
        }

        public static int NuevoIdCompra()
        {
            return idCompra++;
        }

        public static void ControlGuardarError(string path , string nombreUsuario, DateTime fechaHora , string descripcion , string clase, string metodo)
        {
            try
            {
                StringBuilder informacionError = new StringBuilder();

                informacionError.AppendLine($"Fecha y hora del incidente : {fechaHora}");
                informacionError.AppendLine($"Descripcion : {descripcion}");
                informacionError.AppendLine($"Clase : {clase}");
                informacionError.AppendLine($"Metodo : {metodo}");
                informacionError.AppendLine($"Usuario : {nombreUsuario}");

                Archivo.CrearDirectorioYArchivo(path, $"Error.txt", informacionError.ToString());
            }
            catch (Exception)
            {

                throw;
            }

        }

        /*s, documentando fecha y hora
        del incidente, descripción, clase y método en donde ocurri*/
        public static void ControlAgregarUsuario(Usuario nuevoUsuario)
        {
            if (nuevoUsuario is not null)
            {
                UsuarioBD.GuardarDB(nuevoUsuario);                
            }
        }

        public static void ControlAgregarVolquete(Volquete volquete)
        {
            if(volquete is not null)
            {
                listaVolquetes.Add(volquete);
                VolqueteBD.GuardarDB(volquete);
            }
        }



        public static List<Volquete> GetListaVolquetes
        {

            get
            {
                try
                {
                    List<Volquete> nuevaLista = VolqueteBD.LeerDB();
                    return nuevaLista;
                }
                catch (Exception ex)
                {
                    ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                    "ControlAPP",
                    DateTime.Now,
                    ex.Message,
                    "ControlApp",
                    "public static List<Volquete> GetListaVolquetes");
                }
                return null;
            }
        }

        public static List<Usuario> GetListaUsuarios
        {
            
            get
            {
                try
                {
                    List<Usuario> nuevaLista = UsuarioBD.LeerDB();
                    return nuevaLista;
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        public static bool ControlGuardarDatosUsuario(Usuario usuario)
        {
            if(usuario is not null)
            {
                UsuarioBD.ModificarDB(usuario);
                ControlGuardarListaCompraUsuarioBD(usuario.ListaDeCompra);
                return true;
            }

            return false;
        }

        private static void ControlGuardarListaCompraUsuarioBD(List<Compra> lista)
        {
            if(lista is not null)
            {
                foreach(Compra compra in lista)
                {
                    CompraBD.GuardarDB(compra);
                }
            }
        }

    }
}
