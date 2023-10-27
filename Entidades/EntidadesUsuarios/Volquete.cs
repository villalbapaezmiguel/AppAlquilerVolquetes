using System.IO.Pipes;
using System.Text;

namespace Entidades
{
    [Serializable]
    public class Volquete
    {
        private float precio;
        private string tipoVolquete;
        private float capacidad;
        private string observacion;
        private int id;

        private Volquete()
        {

        }

        public Volquete(string tipoVolquete , float precio , float capacidad , string observacion, int id):this()
        {
            this.tipoVolquete = tipoVolquete;
            this.precio = precio;
            this.capacidad = capacidad;
            this.observacion = observacion;
            this.id = id;
        }

        public float Precio { get => precio; set => precio = value; }
        public string TipoVolquete { get => tipoVolquete; set => tipoVolquete = value; }
        public float Capacidad { get => capacidad; set => capacidad = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            StringBuilder informacion = new StringBuilder();

            informacion.AppendLine($"Tipo de Volquete : {TipoVolquete}");
            informacion.AppendLine($"Precio : {Precio}");
            informacion.AppendLine($"Capacidad : {Capacidad}");
            informacion.AppendLine($"Observacion : {Observacion}");
            informacion.AppendLine($"Observacion : {Id}");
            

            return informacion.ToString();
        }
    }
}