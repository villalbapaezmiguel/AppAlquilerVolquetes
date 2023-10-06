using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesUsuarios
{
    public class AlquilerVolquete
    {
        private string marca;
        private string maeterial;
        private string modelo;
        private int diasDeArriendo;
        private ETipoDePago tipoDePago;
        private float precioTotal;

        public AlquilerVolquete(string marca, string maeterial, string modelo, int diasDeArriendo, ETipoDePago tipoDePago, float precioTotal)
        {
            this.marca = marca;
            this.maeterial = maeterial;
            this.modelo = modelo;
            this.diasDeArriendo = diasDeArriendo;
            this.tipoDePago = tipoDePago;
            this.precioTotal = precioTotal;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Maeterial { get => maeterial; set => maeterial = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int DiasDeArriendo { get => diasDeArriendo; set => diasDeArriendo = value; }
        public ETipoDePago TipoDePago { get => tipoDePago; set => tipoDePago = value; }
        public float PrecioTotal { get => precioTotal; set => precioTotal = value; }



    }
}
