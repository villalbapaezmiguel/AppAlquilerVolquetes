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
        public static bool AgregarCompra(ref Compra compra)
        {
            if (compra is not null)
            {
                if (!ExisteCompra(compra.IdCompra))
                {
                    listaCompras.Add(compra);
                    return true;
                }
            }
            return false;
        }

        public static bool ExisteCompra(int idCompra)
        {
            foreach (Compra item in listaCompras)
            {
                if(item.IdCompra == idCompra)
                {
                    return true;
                }
            }
            return false;
            /*
            bool existe = listaCompras.Any(compra => compra.IdCompra == idCompra);
            return existe;*/
        }

        public static Compra? EncontrarCompraPorID(int idCompraPorID)
        {
            if (idCompraPorID != -1)
            {
                foreach (Compra item in GetListaCompras)
                {
                    if (item.IdCompra == idCompraPorID)
                    {
                        return item;
                    }
                }
            }
            return null;
        }


        public static List<Compra> GetListaCompras
        {
            get
            {
                List<Compra> nuevaLista = new();
              
                foreach (Compra item in listaCompras)
                {
                    Compra AuxUsuario = new(item.TipoVolquete , item.NombreDeUsuario,item.CantidadVolquetes,item.CantidadDias,item.FechaDeEntraga,item.HoraDeEntrega,item.Direccion,item.Precio, item.IdCompra);
                    nuevaLista.Add(AuxUsuario);
                }
                return nuevaLista;
            }
        }


    }
}
