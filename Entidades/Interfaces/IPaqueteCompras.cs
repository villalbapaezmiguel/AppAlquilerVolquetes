using Entidades.Entidades;
using Entidades.EntidadesUsuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    interface IPaqueteCompras
    {
        PaqueteCompra ObtenerPaquete(List<Compra> lista, float precioTotal);
        float ObtenerPrecioTotal (List<Compra> lista);

    }
}
