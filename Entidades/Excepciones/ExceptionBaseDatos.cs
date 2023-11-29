using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ExceptionBaseDatos : Exception , IExcepciones
    {
        Object objetoError;
        public ExceptionBaseDatos(string mensaje): base(mensaje)
        {
            this.objetoError = objetoError;
        }

        public object Error()
        {
            return objetoError;
        }



    }
}
