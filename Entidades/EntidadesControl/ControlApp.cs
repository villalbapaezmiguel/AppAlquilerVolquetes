using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
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
        public static void HarcodeoUsuariosYVolquetes()
        {
            ControlAgregarUsuario(new Usuario("a", "a", 1234, "Miguel", "Villalba", 23451, ControlApp.NuevoIdUsuario()));
            AdminControl.AgregarAdministrador(new Admin("Migue", "Villalba", (double)1234,"a"));

            VolqueteControl.AgregarVolquete(new Volquete("Pequeño",(float)1700,(float)1.5,"Todo tipo de materiales", NuevoIdVolquete()));
            VolqueteControl.AgregarVolquete(new Volquete("Mediano",(float)2000, (float)3,"Todo tipo de materiales", NuevoIdVolquete()));
            VolqueteControl.AgregarVolquete(new Volquete("Estandar", (float)2500, (float)6,"Todo tipo de materiales", NuevoIdVolquete()));
            VolqueteControl.AgregarVolquete(new Volquete("Grande", (float)3100, (float)10, "Solo materiales livianos", NuevoIdVolquete()));
            VolqueteControl.AgregarVolquete(new Volquete("Super Grande", (float)3900, (float)12,"Solo materiales livianos", NuevoIdVolquete()));
        }


        public static void ControlAgregarUsuario(Usuario nuevoUsuario)
        {
            if (nuevoUsuario is not null)
            {
                listaUsuarios.Add(nuevoUsuario);
                AdminControl.AgrergarUsuario(nuevoUsuario);  
            }
        }

        public static void ControlAgregarVolquete(Volquete volquete)
        {
            if(volquete is not null)
            {
                listaVolquetes.Add(volquete);
            }
        }




        public static List<Usuario> GetListaUsuarios
        {
            get
            {
                List<Usuario> nuevaLista = new();
                foreach (Usuario usuario in listaUsuarios)
                {
                    Usuario AuxUsuario = new (usuario.NombreUsuario, usuario.Clave, usuario.Telefono, usuario.Nombre, usuario.Apellido, usuario.Dni,usuario.IdUsuario);
                    List<Compra> comprasAux = new List<Compra>();

                    foreach (Compra itemCompra in usuario.ListaDeCompra)
                    {
                        Compra compraAux = new Compra(itemCompra.TipoVolquete, itemCompra.NombreDeUsuario, itemCompra.CantidadVolquetes, itemCompra.CantidadDias, itemCompra.FechaDeEntraga, itemCompra.HoraDeEntrega, itemCompra.Direccion, itemCompra.Precio,itemCompra.IdCompra);
                        comprasAux.Add(compraAux);
                    }
                    AuxUsuario.ListaDeCompra = comprasAux;
                    nuevaLista.Add(AuxUsuario);
                }
                return nuevaLista;
            }
        }

        public static List<Admin> GetListaAdmin
        {
            get
            {
                return listaAdministradores;                
            }
        }



        public static bool ControlGuardarDatosUsuaurio(Usuario usuario)
        {
            if(usuario is not null)
            {
                for (int i = 0; i < listaUsuarios.Count; i++)
                {
                    if (listaUsuarios[i] == usuario)
                    {
                        listaUsuarios[i] = usuario;
                        return true;
                    }
                }
            }
            return false;
        }


    }
}
