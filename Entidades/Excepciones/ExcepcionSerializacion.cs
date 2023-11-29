using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ExcepcionSerializacion : Exception
    {
        public ExcepcionSerializacion()
        {

        }
        public ExcepcionSerializacion(string mensaje) : base(mensaje) 
        {
                
        
        }
        public ExcepcionSerializacion(string mensaje, Exception ex): base(mensaje, ex)
        {

        }



    }
}
