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
        private static Admin adminActual = new Admin();

        public static void AgregarAdministrador(Admin nuevoAdmin)
        {
            if(adminActual is not null) 
            {
                ControlApp.listaAdministradores.Add(nuevoAdmin);
            }
        }

        public static void GuardarDatosUsuario(Usuario usuario)
        {
            if (adminActual is not null) 
            {
                for (int i = 0; i < adminActual.ListaUsuarios.Count; i ++)
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
            if(listaCompraUsuario  is not null)
            {
                foreach(Compra item in listaCompraUsuario) 
                {
                    adminActual.ListaCompra.Add(item); 
                }
            }
        }

        public static void AgrergarUsuario(Usuario nuevoUsuario)
        {
            if(nuevoUsuario is not null)
            {
                adminActual.ListaUsuarios.Add(nuevoUsuario);
                ControlApp.listaUsuarios.Add(nuevoUsuario);
            }
        }

        public static bool EliminarUsuario(int idUsuario)
        {
            int posicion = BuscarPorIdUsuario(idUsuario);
            if(posicion != -1)
            {
                adminActual.ListaUsuarios.RemoveAt(posicion);
                return true;
            }
            return false;
        }

        public static bool ModificarUsuario(Usuario usuario)
        {
            if(usuario is not null)
            {
                int posicion = BuscarPorIdUsuario(usuario.IdUsuario);
                if( posicion != -1)
                {
                    adminActual.ListaUsuarios[posicion] = usuario;
                    return true;
                }
            }

            return false;
        }

        public static int BuscarPorIdUsuario(int idCompra)
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

        public static List<Usuario> GetListaUsuario
        {
            get
            {
                return adminActual.ListaUsuarios;
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

                /*
                List<Usuario> nuevaLista = new();
                foreach (Usuario item in adminActual.ListaUsuarios)
                {
                    Usuario AuxUsuario = new(item.NombreUsuario,item.Clave,item.Telefono,item.Nombre,item.Apellido,item.Dni,item.IdUsuario);
                    nuevaLista.Add(AuxUsuario);
                }
                return nuevaLista;*/
            }
            set
            {
                adminActual.ListaCompra = value;
            }


        }



    }
}
