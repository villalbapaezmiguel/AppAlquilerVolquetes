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

        public static bool AgregarListaCompra(List<Compra> lista)
        {
            if(lista is not null)
            {
                foreach (Compra item in lista)
                {
                    listaCompras.Add(item);
                }
                return true;
            }
            return false;
        }

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
        /// <summary>
        /// Retorna la posicion del id en la lista , caso contrario retorna -1
        /// </summary>
        /// <param name="idCompra"></param>
        /// <returns></returns>
        public static int BuscarPorId(int idCompra)
        {
            if(idCompra != -1)
            {
                if(ExisteCompra(idCompra))
                {
                    for (int i = 0; i < listaCompras.Count; i++) 
                    {
                        if(idCompra == listaCompras[i].IdCompra)
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
            if(compra is not null )
            {
                posicion = BuscarPorId(compra.IdCompra);
                if(posicion != -1)
                {
                    listaCompras[posicion] = compra;
                    return true;
                }

            }        
            return false;
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
