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
    public sealed class CompraControl
    {
        private static List<Compra> listaCompras = new List<Compra>();

        #region ABM de compras
        /// <summary>
        /// Retorna la posicion del id en la lista , caso contrario retorna -1
        /// </summary>
        /// <param name="idCompra"></param>
        /// <returns></returns>
        public static int BuscarPorIdUsuarioCompra(int idCompra)
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
        public static bool EliminarCompra(int idCompra)
        {
            int posicion;
            if (idCompra != -1)
            {
                posicion = BuscarPorIdUsuarioCompra(idCompra);
                if (posicion != -1)
                {
                    listaCompras.RemoveAt(posicion);
                    //usuarioActual.ListaDeCompra.RemoveAt(posicion);

                    return true;
                }
            }
            return false;
        }


        public static bool AgregarListaDeComprasBD(List<Compra> lista)
        {
            if (lista is not null)
            {
                foreach (Compra item in lista)
                {
                    listaCompras.Add(item);
                    CompraBD.GuardarDB(item);
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
                    Compra AuxUsuario = new(item.TipoVolquete, item.NombreDeUsuario, item.CantidadVolquetes, item.CantidadDias, item.FechaDeEntraga, item.HoraDeEntrega, item.Direccion, item.Precio, item.IdCompra, item.IdUsuario);
                    nuevaLista.Add(AuxUsuario);
                }
                return nuevaLista;
            }
        }
        #endregion

        #region Sobrecarga de ABM

        public static int BuscarPorIdUsuarioCompra(int idCompra , List<Compra> listaAux)
        {
            if (idCompra != -1)
            {
                if (ExisteCompra(idCompra,listaAux))
                {
                    for (int i = 0; i < listaAux.Count; i++)
                    {
                        if (idCompra == listaAux[i].IdCompra)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }
        public static bool EliminarCompra(int idCompra, List<Compra> listaAux)
        {
            int posicion;
            if (idCompra != -1)
            {
                posicion = BuscarPorIdUsuarioCompra(idCompra, listaAux);
                if (posicion != -1)
                {
                    listaAux.RemoveAt(posicion);

                    return true;
                }
            }
            return false;
        }

        public static bool ModificarPorId(Compra? compra, List<Compra> listaAux)
        {
            int posicion;
            if (compra is not null)
            {
                posicion = BuscarPorId(compra.IdCompra, listaAux);
                if (posicion != -1)
                {
                    listaAux[posicion] = compra;
                    return true;
                }

            }
            return false;
        }

        public static int BuscarPorId(int idCompra, List<Compra> listaAux)
        {
            if (idCompra != -1)
            {
                if (ExisteCompra(idCompra, listaAux))
                {
                    for (int i = 0; i < listaAux.Count; i++)
                    {
                        if (idCompra == listaAux[i].IdCompra)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }

        public static bool ExisteCompra(int idCompra, List<Compra> listaAux)
        {
            foreach (Compra item in listaAux)
            {
                if (item.IdCompra == idCompra)
                {
                    return true;
                }
            }
            return false;
        }


        #endregion




    }
}
