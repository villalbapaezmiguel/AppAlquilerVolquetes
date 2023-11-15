using Entidades.EntidadesUsuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesControl
{
    public sealed class UsuarioControl 
    {
        private static Usuario usuarioActual;
        private static Func<int,bool> delegadoExiteCompraDelUsuario = ExisteCompra_del_Usuario;

        public static bool ExisteCompra_del_Usuario(int idCompra)
        {
            foreach (Compra item in usuarioActual.ListaDeCompra)
            {
                if (item.IdCompra == idCompra)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Retorna la posicion del id en la lista , caso contrario retorna -1
        /// </summary>
        /// <param name="idCompra"></param>
        /// <returns></returns>
        public static int BuscarPorId_la_CompraDelUsuario(int idCompra)
        {
            if (idCompra != -1)
            {
                //Uso de delegados
                if (delegadoExiteCompraDelUsuario(idCompra))
                {
                    for (int i = 0; i < usuarioActual.ListaDeCompra.Count; i++)
                    {
                        if (idCompra == usuarioActual.ListaDeCompra[i].IdCompra)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }

        public static bool ModificarPorId_CompraDelUsuario(Compra? compra)
        {
            int posicion;
            if (compra is not null)
            {
                posicion = BuscarPorId_la_CompraDelUsuario(compra.IdCompra);
                if (posicion != -1)
                {
                    usuarioActual.ListaDeCompra[posicion] = compra;
                    return true;
                }
            }
            return false;
        }

        //
        public static bool AgregarUsuario(Usuario nuevoUsuario)
        {
            if(nuevoUsuario is not null)
            {
                if(!ExisteUsuario(nuevoUsuario.NombreUsuario))
                {
                    ControlApp.ControlAgregarUsuario(nuevoUsuario);
                    return true;
                }
            }
            return false;
        }

        public static bool ExisteUsuario( string nombreUsuario)
        {
            try
            {
                bool exite = ControlApp.GetListaUsuarios.Any(usuario => usuario.NombreUsuario == nombreUsuario);
                return exite;

            }
            catch (Exception)
            {

                throw;
            }
        }

        #region Geters y Seters

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
                foreach(Usuario usuario in ControlApp.GetListaUsuarios) 
                {
                    Usuario AuxUsuario = new(usuario.NombreUsuario, usuario.Clave, usuario.Telefono, usuario.Nombre, usuario.Apellido, usuario.Dni, usuario.IdUsuario);
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
                foreach (Compra item in usuarioActual.ListaDeCompra)
                {
                    Compra AuxUsuario = new(item.TipoVolquete, item.NombreDeUsuario, item.CantidadVolquetes, item.CantidadDias, item.FechaDeEntraga, item.HoraDeEntrega, item.Direccion, item.Precio, item.IdCompra);
                    nuevaLista.Add(AuxUsuario);
                }
                return nuevaLista;
            }
        }

        #endregion
        public static bool AgregarListaCompra(List<Compra> lista)
        {
            if (lista is not null)
            {
                foreach (Compra item in lista)
                {
                    usuarioActual.ListaDeCompra.Add(item);
                }
                return true;
            }
            return false;
        }

        public static Usuario? BuscarUsuarioPorClaveYNombreUsuario(string nombreUsuario,  string clave)
        {
            try
            {
                if (nombreUsuario != string.Empty && clave != string.Empty)
                {
                    if (ExisteUsuario(nombreUsuario))
                    {
                        foreach (Usuario auxItem in ControlApp.GetListaUsuarios)
                        {
                            if (auxItem.NombreUsuario == nombreUsuario && auxItem.Clave == clave)
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
            }
            catch (Exception)
            {

                throw;
            }


            return null;
        }




    }
}
