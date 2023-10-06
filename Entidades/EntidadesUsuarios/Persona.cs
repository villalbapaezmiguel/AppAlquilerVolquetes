using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesUsuarios
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private DateTime fechaDeNacimiento;

        public Persona()
        {

        }
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public Persona(string nombre, string apellido) : this(nombre)
        {
            this.apellido = apellido;
        }

        public Persona(string nombre, string apellido, int edad) : this(nombre, apellido)
        {
            this.edad = edad;
        }

        public Persona(string nombre, string apellido, int edad, DateTime fechaDeNacimiento)
            : this(nombre, apellido, edad)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }



    }
}
