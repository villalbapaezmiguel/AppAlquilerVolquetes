using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesUsuarios
{
    [Serializable]
    public class Usuario : Persona
    {
        private string nombreUsuario;
        private string clave;
        private List<Compra> listaDeCompra;
        private double telefono;
        private int idUsuario;

        public Usuario()
        {

        }

        public Usuario(string nombreUsuario , string clave , double telefono, string nombre , string apellido, double dni , int id)
            :base(nombre,apellido,dni)
        {
            this.nombreUsuario = nombreUsuario;
            this.clave = clave;
            this.telefono = telefono;
            this.listaDeCompra = new List<Compra>();
            this.idUsuario = id;
        }

        public static bool operator ==(Usuario a, Usuario b)
        {
            if (a is not null && b is not null)
            {
                return a.nombreUsuario == b.nombreUsuario && a.clave == b.clave && a.IdUsuario == b.IdUsuario;
            }
            return false;
        }

        public static bool operator !=(Usuario a, Usuario b)
        {
            return !(a == b);
        }

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public List<Compra> ListaDeCompra { get => listaDeCompra; set => listaDeCompra = value; }
        public double Telefono { get => telefono; set => telefono = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        private string ComprasHechas()
        {
            StringBuilder informacionCompra = new StringBuilder();
            foreach(Compra item in listaDeCompra)
            {
                informacionCompra.AppendLine(item.ToString());
            }

            return informacionCompra.ToString();
        }


        public override string ToString()
        {
            StringBuilder infoUsuario = new StringBuilder();
            infoUsuario.AppendLine(base.ToString());
            infoUsuario.AppendLine($"Usuario {NombreUsuario} | Id {IdUsuario} | Telefono {Telefono}");
            infoUsuario.Append("Lista de compra : ");
            infoUsuario.AppendLine($"{ComprasHechas()}");
            infoUsuario.AppendLine("-----------------------------------");

            return infoUsuario.ToString();  
        }


    }
}
