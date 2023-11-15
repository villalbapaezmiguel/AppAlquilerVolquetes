using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaz
{
    public interface IUsuarioControl
    {
        public abstract bool ExisteCompra_del_Usuario(int idCompra);

    }
}
