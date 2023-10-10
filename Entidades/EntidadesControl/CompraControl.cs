using Entidades.EntidadesUsuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesControl
{
    public sealed class CompraControl
    {
        private static List<Compra> listaCompras = new List<Compra>();
        private static int id = 0;

        private static int NuevoId()
        {
            return id ++;
        }
        public static bool AgregarCompra(ref Compra compra)
        {
            if (compra is not null)
            {
                if (!ExisteCompra(compra.IdCompra))//problemas con los id , hay que solucionarlo
                {
                    listaCompras.Add(compra);
                    compra.IdCompra = NuevoId();
                    return true;
                }
            }
            return false;
        }

        public static bool ExisteCompra(int idCompra)
        {
            bool existe = listaCompras.Any(compra => compra.IdCompra == idCompra);
            return existe;
        }
        public static List<Compra> GetListaCompras
        {
            get
            {
                List<Compra> nuevaLista = new();
              
                foreach (Compra item in listaCompras)
                {
                    Compra AuxUsuario = new(item.TipoVolquete , item.NombreDeUsuario,item.CantidadVolquetes,item.CantidadDias,item.FechaDeEntraga,item.HoraDeEntrega,item.Direccion,item.Precio);
                    nuevaLista.Add(AuxUsuario);
                }
                return nuevaLista;
            }
        }


    }
}
