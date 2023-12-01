using Entidades.EntidadesControl;
using Entidades.EntidadesUsuarios;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    [Serializable]
    public class PaqueteCompra : IPaqueteCompras
    {
        private int idPaqueteCompra;
        private List<int> listaIdCompra;
        private float precioTotal;
        //mostrar lo paquetes de compras que se fueron hacienod por el usuario

        public PaqueteCompra()
        {
            listaIdCompra = new List<int>();
        }
        public PaqueteCompra(int idPaqueteCompra, List<int> listaIdCompra, float precioTotal):this()
        {
            this.idPaqueteCompra = idPaqueteCompra;
            this.listaIdCompra = listaIdCompra;
            this.precioTotal = precioTotal;
        }
        public int IdPaqueteCompra { get => idPaqueteCompra; set => idPaqueteCompra = value; }
        public List<int> ListaIdCompra { get => listaIdCompra; set => listaIdCompra = value; }
        public float PrecioTotal { get => precioTotal; set => precioTotal = value; }


        public PaqueteCompra ObtenerPaquete(List<Compra> lista , float precioTotal)
        {
            try
            {
                if(lista is not null)
                {
                    PaqueteCompra paquete = new PaqueteCompra();

                    foreach(Compra itemCompra in lista) 
                    {
                        paquete.listaIdCompra.Add(itemCompra.IdCompra);
                                    
                    }
                    paquete.idPaqueteCompra = UsuarioControl.GetUsuario.IdUsuario;
                    paquete.precioTotal = precioTotal;
                    return paquete;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public float ObtenerPrecioTotal(List<Compra> lista)
        {
            try
            {
                float precioTotal = 0;
                if(lista is not null)
                {
                    foreach(Compra itemCompra in lista)
                    {
                        precioTotal += itemCompra.Precio;
                    }
                    return precioTotal;
                }

                return -1;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
