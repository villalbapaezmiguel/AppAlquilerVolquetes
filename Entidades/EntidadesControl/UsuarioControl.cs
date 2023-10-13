using Entidades.EntidadesUsuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesControl
{
    public sealed class UsuarioControl 
    {
        private static List<Usuario> listaUsuarios = new List<Usuario>();
        private static Usuario usuarioActual;
        private static List<Compra> listaCompras = new List<Compra>();
        

        public static bool ExisteCompra(int idCompra)
        {
            foreach (Compra item in listaCompras)
            {
                if (item.IdCompra == idCompra)
                {
                    return true;
                }
            }
            return false;
            /*
            bool existe = listaCompras.Any(compra => compra.IdCompra == idCompra);
            return existe;*/
        }

        /// <summary>
        /// Retorna la posicion del id en la lista , caso contrario retorna -1
        /// </summary>
        /// <param name="idCompra"></param>
        /// <returns></returns>
        public static int BuscarPorId(int idCompra)
        {
            if (idCompra != -1)
            {
                if (ExisteCompra(idCompra))
                {
                    for (int i = 0; i < listaCompras.Count; i++)
                    {
                        if (idCompra == listaCompras[i].IdCompra)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }

        public static bool ModificarPorId(Compra? compra)
        {
            int posicion;
            if (compra is not null)
            {
                posicion = BuscarPorId(compra.IdCompra);
                if (posicion != -1)
                {
                    listaCompras[posicion] = compra;
                    return true;
                }

            }
            return false;
        }


        public static bool AgregarUsuario(Usuario nuevoUsurio)
        {
            if(nuevoUsurio is not null)
            {
                if(!ExisteUsuario(nuevoUsurio.NombreUsuario))
                {
                    listaUsuarios.Add(nuevoUsurio);
                    return true;
                }
            }
            return false;
        }

        public static bool ExisteUsuario( string nombreUsuario)
        {
            


            bool exite = listaUsuarios.Any(usuario => usuario.NombreUsuario == nombreUsuario);
            return exite;
        }

        public static Usuario GetUsuario
        {
            get
            {
                return usuarioActual;
            }
        }
        public static Usuario SetUsuario
        {
            set
            {
                usuarioActual = value;
            }
        }

        public static List<Usuario> GetListaUsuarios
        {
            get
            {
                List<Usuario> nuevaLista = new();
                foreach(Usuario usuario in listaUsuarios) 
                {
                    Usuario AuxUsuario = new(usuario.NombreUsuario, usuario.Clave, usuario.Telefono, usuario.Nombre, usuario.Apellido, usuario.Dni);
                    nuevaLista.Add(AuxUsuario);
                }
                return nuevaLista;
            }
        }

        public static List<Compra> GetListaComprasUsuario
        {
            get
            {
                List<Compra> nuevaLista = new();
                foreach (Compra item in listaCompras)
                {
                    Compra AuxUsuario = new(item.TipoVolquete, item.NombreDeUsuario, item.CantidadVolquetes, item.CantidadDias, item.FechaDeEntraga, item.HoraDeEntrega, item.Direccion, item.Precio, item.IdCompra);
                    nuevaLista.Add(AuxUsuario);
                }
                return nuevaLista;
            }
        }

        public static bool AgregarCompra(ref Compra compra)
        {
            if(compra is not null)
            {
                listaCompras.Add(compra);
                return true;
            }
            return false;
        }



        public static Usuario? BuscarUsuarioPorClaveYNombreUsuario(string nombreUsuario,  string clave)
        {
            if(nombreUsuario != string.Empty && clave != string.Empty)
            {
                if(ExisteUsuario(nombreUsuario)) 
                {
                    foreach(Usuario auxItem in GetListaUsuarios)
                    {
                        if(auxItem.NombreUsuario == nombreUsuario && auxItem.Clave == clave) 
                        {
                            return auxItem;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }

            return null;
        }




    }
}
