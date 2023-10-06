using System.IO.Pipes;
using System.Text;

namespace Entidades
{
    public class Volquete
    {
        private string marca;
        private float altura;
        private float largo;
        private float ancho;
        private float precio;
        private int diasDeArriendo;

        private Volquete()
        {

        }
        public Volquete(string marca, float altura , float largo , float ancho, float precio , int diasDeArriendo):this()
        {
            this.marca = marca;
            this.altura = altura;
            this.largo = largo;
            this.ancho = ancho;
            this.precio = precio;
            this.diasDeArriendo = diasDeArriendo;
        }

        /// <summary>
        /// La cotizacion depende de la cantidad dias alquilados
        /// </summary>
        public float CotizarVolquete
        {
            get
            {
                return (float)this.precio * this.diasDeArriendo;
            }
        }
        public float MetrosCubicos 
        {
            get
            {
                return (float)this.largo * this.ancho * this.altura;
            }
        }
        public string Marca { get => marca; set => marca = value; }
        public float Altura { get => altura; set => altura = value; }
        public float Largo { get => largo; set => largo = value; }
        public float Ancho { get => ancho; set => ancho = value; }
        public float Precio { get => precio; set => precio = value; }
        public int DiasDeArriendo { get => diasDeArriendo; set => diasDeArriendo = value; }

        public string Mostrar()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Marca : {Marca}");
            informacion.AppendLine($"Altura : {Altura}");
            informacion.AppendLine($"Largo : {Largo}");
            informacion.AppendLine($"Ancho : {Ancho}");
            informacion.AppendLine($"Precio : {Precio}");
            informacion.AppendLine($"Dias de arriendo : {DiasDeArriendo}");
            informacion.AppendLine($"Metros cubicos : {MetrosCubicos}");

            return informacion.ToString();
        }
    }
}