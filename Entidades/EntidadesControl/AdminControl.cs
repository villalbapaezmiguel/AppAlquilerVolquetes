using Entidades.EntidadesBD;
using Entidades.EntidadesUsuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesControl
{
    public sealed class AdminControl
    {
        public static Admin adminActual = new Admin();






        public static void AgregarAdministrador(Admin nuevoAdmin)
        {
            if (adminActual is not null)
            {
                ControlApp.listaAdministradores.Add(nuevoAdmin);
            }
        }
        
        #region Usuario

        public static void GuardarDatosUsuario(Usuario usuario)
        {
            if (adminActual is not null)
            {
                for (int i = 0; i < adminActual.ListaUsuarios.Count; i++)
                {
                    if (adminActual.ListaUsuarios[i].IdUsuario == usuario.IdUsuario)
                    {
                        adminActual.ListaUsuarios[i] = usuario;
                        break;
                    }
                }
            }
        }

        public static void AgregarListaDeCompraUsuario(List<Compra> listaCompraUsuario)
        {
            if (listaCompraUsuario is not null)
            {
                foreach (Compra item in listaCompraUsuario)
                {
                    adminActual.ListaCompra.Add(item);
                }
            }
        }

        public static void AgrergarUsuario(Usuario nuevoUsuario)
        {
            if (nuevoUsuario is not null)
            {
                adminActual.ListaUsuarios.Add(nuevoUsuario);
                ControlApp.listaUsuarios.Add(nuevoUsuario);
            }
        }

        public static bool EliminarUsuario(int idUsuario)
        {
            int posicion = BuscarPorIdLaPosiconDelUsuario(idUsuario);
            if (posicion != -1)
            {
                adminActual.ListaUsuarios.RemoveAt(posicion);
                UsuarioBD.EliminarDB(idUsuario);
                return true;
            }
            return false;
        }

        public static bool ModificarUsuario(Usuario usuario)
        {
            if (usuario is not null)
            {
                int posicion = BuscarPorIdLaPosiconDelUsuario(usuario.IdUsuario);
                if (posicion != -1)
                {
                    adminActual.ListaUsuarios[posicion] = usuario;
                    UsuarioBD.ModificarDB(usuario);
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Busca por el ID del usuario y devuelve su posicion en la lista
        /// </summary>
        /// <param name="idCompra"></param>
        /// <returns></returns>
        public static int BuscarPorIdLaPosiconDelUsuario(int idCompra)
        {
            if (idCompra != -1)
            {
                if (ExisteUsuario(idCompra))
                {
                    for (int i = 0; i < adminActual.ListaUsuarios.Count; i++)
                    {
                        if (idCompra == adminActual.ListaUsuarios[i].IdUsuario)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }

        public static Usuario BuscarPorIdUsuario(int idUsuario)
        {
            
            if(idUsuario != -1)
            {
                if(ExisteUsuario(idUsuario))
                {
                    foreach(Usuario item in adminActual.ListaUsuarios)
                    {
                        if(item.IdUsuario == idUsuario)
                        {
                            return item;        
                        }
                    }
                }
            }
            return null;
        }


        public static bool ExisteUsuario(int idUsuario)
        {
            foreach (Usuario item in adminActual.ListaUsuarios)
            {
                if (item.IdUsuario == idUsuario)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Volquete

        public static void AgrergarVolquete(Volquete nuevoVolquete)
        {
            if (nuevoVolquete is not null)
            {
                adminActual.ListaVolquete.Add(nuevoVolquete);
                ControlApp.listaVolquetes.Add(nuevoVolquete);
            }
        }

        public static bool EliminarVolquete(int idVolquete)
        {
            int posicion = BuscarPorIdVolquete(idVolquete);
            if (posicion != -1)
            {
                adminActual.ListaVolquete.RemoveAt(posicion);
                VolqueteBD.EliminarDB(idVolquete);
                return true;
            }
            return false;
        }

        public static bool ModificarVolquete(Volquete volquete)
        {
            if (volquete is not null)
            {
                int posicion = BuscarPorIdVolquete(volquete.Id);
                if (posicion != -1)
                {
                    adminActual.ListaVolquete[posicion] = volquete;
                    return true;
                }
            }

            return false;
        }

        public static int BuscarPorIdVolquete(int idCompra)
        {
            if (idCompra != -1)
            {
                if (ExisteVolquete(idCompra))
                {
                    for (int i = 0; i < adminActual.ListaVolquete.Count; i++)
                    {
                        if (idCompra == adminActual.ListaVolquete[i].Id)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }

        public static bool ExisteVolquete(int idVolquete)
        {
            foreach (Volquete item in adminActual.ListaVolquete)
            {
                if (item.Id == idVolquete)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Geters y Seters

        public static List<Volquete> GetListaVolquete
        {
            get
            {
                return VolqueteBD.LeerDB();
            }
        }
        public static List<Volquete> SetListaVolquete
        {
            set
            {
                adminActual.ListaVolquete = value;
            }
        }


        public static List<Usuario> GetListaUsuario
        {
            get
            {
                return UsuarioBD.LeerDB();
            }
        }
        public static List<Usuario> SetUsuario
        {
            set
            {
                adminActual.ListaUsuarios = value;
            }
        }
        public static List<Compra> GetListaComprasUsuario
        {
            get
            {
                return adminActual.ListaCompra;
            }
            set
            {
                adminActual.ListaCompra = value;
            }
        }


        #endregion

    }
}
