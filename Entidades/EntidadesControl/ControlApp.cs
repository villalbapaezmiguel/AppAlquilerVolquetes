using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Entidades.EntidadesControl;
using Entidades.EntidadesUsuarios;

namespace Entidades
{
    public static class ControlApp
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>();
        public static List<Volquete> listaVolquetes = new List<Volquete>();
        public static List<Compra> listaDeCompras = new List<Compra>();//cada vez que el usuaurio termine de usar la app guardar todas sus compras aca
        public static List<Admin> listaAdministradores = new List<Admin>();
        

        private static int idCompra = 0;
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

        public static bool ControlGuardarDatosUsuaurio(Usuario usuario)
        {
            if(usuario is not null)
            {
                UsuarioBD.ModificarDB(usuario);
                return true;
            }

            return false;
        }


    }
}
