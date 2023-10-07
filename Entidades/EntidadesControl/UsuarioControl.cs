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
