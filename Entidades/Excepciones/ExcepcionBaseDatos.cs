using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ExcepcionBaseDatos : Exception
    {
        public ExcepcionBaseDatos()
        {
        }

        public ExcepcionBaseDatos(string mesaje)
            : base(mesaje)
        {

        }

        public ExcepcionBaseDatos(string mesaje, Exception ex)
            : base(mesaje, ex)
        {
        }

    }
}
