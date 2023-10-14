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
        private static int idCompra = 0;
        private static int idUsuario = 0;
        

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
            VolqueteControl.AgregarVolquete(new Volquete("Pequeño",10000,(float)1.5,"Todo tipo de materiales"));
            VolqueteControl.AgregarVolquete(new Volquete("Mediano",15000, (float)3,"Todo tipo de materiales"));
            VolqueteControl.AgregarVolquete(new Volquete("Estandar",25000, (float)6,"Todo tipo de materiales"));
            VolqueteControl.AgregarVolquete(new Volquete("Grande",30000, (float)10,"Todo tipo de materiales"));
            VolqueteControl.AgregarVolquete(new Volquete("Super Grande",40000, (float)12,"Todo tipo de materiales"));
        }


        public static void ControlAgregarUsuario(Usuario nuevoUsurio)
        {
            if (nuevoUsurio is not null)
            {
                listaUsuarios.Add(nuevoUsurio);
            }
        }

        public static List<Usuario> GetListaUsuarios
        {
            get
            {
                List<Usuario> nuevaLista = new();
                foreach (Usuario usuario in listaUsuarios)
                {
                    Usuario AuxUsuario = new(usuario.NombreUsuario, usuario.Clave, usuario.Telefono, usuario.Nombre, usuario.Apellido, usuario.Dni,usuario.IdUsuario);
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
                foreach (Compra item in UsuarioControl.GetListaComprasUsuario)
                {
                    Compra AuxUsuario = new(item.TipoVolquete, item.NombreDeUsuario, item.CantidadVolquetes, item.CantidadDias, item.FechaDeEntraga, item.HoraDeEntrega, item.Direccion, item.Precio, item.IdCompra);
                    nuevaLista.Add(AuxUsuario);
                }
                return nuevaLista;
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
