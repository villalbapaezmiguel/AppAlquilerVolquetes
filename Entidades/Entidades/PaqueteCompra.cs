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
    public class PaqueteCompra : IPaqueteCompras
    {
        private int idUsuario;
        private List<int> listaIdCompra;
        private float precioTotal;
        public PaqueteCompra()
        {
            listaIdCompra = new List<int>();
        }
        public PaqueteCompra(int idUsuario, List<int> listaIdCompra, float precioTotal):this()
        {
            this.idUsuario = idUsuario;
            this.listaIdCompra = listaIdCompra;
            this.precioTotal = precioTotal;
        }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
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
                    paquete.idUsuario = UsuarioControl.GetUsuario.IdUsuario;
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
