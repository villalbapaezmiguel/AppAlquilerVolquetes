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
        private string correo;
        private string clave;
        private List<Volquete> listaVolquete;
        private List<AlquilerVolquete> listaAlquilados;
        private Usuario(string nombre, string apellido, int edad, DateTime fechaDeNacimiento)
            : base(nombre, apellido, edad, fechaDeNacimiento)
        {
            listaVolquete = new List<Volquete>();
            listaAlquilados = new List<AlquilerVolquete>();
        }

        public Usuario(string correo, string clave, string nombre, string apellido, int edad, DateTime fechaDeNacimiento)
            : this(nombre, apellido, edad, fechaDeNacimiento)
        {
            this.correo = correo;
            this.clave = clave;
        }

        public static bool operator ==(Usuario a, Usuario b)
        {
            if (a is not null && b is not null)
            {
                return a.correo == b.correo && a.clave == b.clave;
            }
            return false;
        }

        public static bool operator !=(Usuario a, Usuario b)
        {
            return !(a == b);
        }

        public string Correo { get => correo; set => correo = value; }
        public string Clave { get => clave; set => clave = value; }
        public List<Volquete> ListaVolquete { get => listaVolquete; set => listaVolquete = value; }
        public List<AlquilerVolquete> ListaAlquilados { get => listaAlquilados; set => listaAlquilados = value; }

        public string Mostrar()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Nombre : {Nombre}");
            informacion.AppendLine($"Apellido : {Apellido}");
            informacion.AppendLine($"Edad : {Edad}");
            informacion.AppendLine($"Fecha de nacimiento : {FechaDeNacimiento}");
            informacion.AppendLine($"Correo : {correo}");


            return informacion.ToString();
        }


    }
}
