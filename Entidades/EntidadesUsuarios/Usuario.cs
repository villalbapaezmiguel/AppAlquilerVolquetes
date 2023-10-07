using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesUsuarios
{
    public class Usuario : Persona
    {
        private string nombreUsuario;
        private string clave;
        private List<Volquete> listaVolquete;
        private double telefono;

        public Usuario(string nombreUsuario , string clave , double telefono, string nombre , string apellido, double dni)
            :base(nombre,apellido,dni)
        {
            this.nombreUsuario = nombreUsuario;
            this.clave = clave;
            this.telefono = telefono;
            this.listaVolquete = new List<Volquete>();
        }

        public static bool operator ==(Usuario a, Usuario b)
        {
            if (a is not null && b is not null)
            {
                return a.nombreUsuario == b.nombreUsuario && a.clave == b.clave;
            }
            return false;
        }

        public static bool operator !=(Usuario a, Usuario b)
        {
            return !(a == b);
        }

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public List<Volquete> ListaVolquete { get => listaVolquete; set => listaVolquete = value; }
        public double Telefono { get => telefono; set => telefono = value; }

        public override string ToString()
        {
            StringBuilder infoUsuario = new StringBuilder();
            infoUsuario.AppendLine(base.ToString());
            infoUsuario.AppendLine($"Usuario {NombreUsuario}");
            infoUsuario.AppendLine($"Telefono {Telefono}");

            return infoUsuario.ToString();  
        }


    }
}
