﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.EntidadesUsuarios
{
    [Serializable]
    [XmlInclude(typeof(Compra))]
    [XmlInclude(typeof(Usuario))]
    [XmlInclude(typeof(Volquete))]
    [XmlInclude(typeof(Admin))]
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private double dni;

        public Persona()
        {

        }
        public Persona(string nombre , string apellido , double dni )
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public double Dni { get => dni; set => dni = value; }


        public virtual string ToString()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.Append($"Nombre {Nombre} | Apellido {Apellido} | DNI {Dni}");
            return informacion.ToString();
        }
    }
}
