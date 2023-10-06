using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.EntidadesUsuarios;

namespace Entidades
{
    public class VolqueteCamion:Volquete
    {
        private int idVolqueteCamion;
        private int cantidadRuedas;
        private bool cajaAbierta;
        private string modelo;
        private float precio;
        private int diasDeArriendo;

        
        public VolqueteCamion(string marca, float altura, float largo, float ancho, float precio , int diasDeArriendo)
            :base(marca,altura, largo, ancho, precio, diasDeArriendo)
        {
            this.modelo = "Estandar";
            this.cantidadRuedas = 6;
            this.cajaAbierta = true;
            this.diasDeArriendo = 7;
            this.precio = (float)10000;
        }

        public VolqueteCamion(string marca, float altura, float largo, float ancho, float precio, int diasDeArriendo , string modelo , int cantidadRuedas, bool cajaAbierta)
            :this(marca,altura,largo,ancho, precio,diasDeArriendo)
        {
            this.modelo = modelo;
            this.cantidadRuedas = cantidadRuedas;
            this.cajaAbierta = cajaAbierta;
        }

        public int CantidadRuedas { get => cantidadRuedas; set => cantidadRuedas = value; }
        public bool CajaAbierta { get => cajaAbierta; set => cajaAbierta = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int IdVolqueteCamion { get => idVolqueteCamion; set => idVolqueteCamion = value; }

        public static bool operator == (VolqueteCamion vc1, VolqueteCamion vc2)
        {
            return (vc1.Marca == vc2.Marca && vc1.Modelo == vc2.Modelo);
        }
        public static bool operator !=(VolqueteCamion vc1, VolqueteCamion vc2)
        {
            return !(vc1 == vc2);
        }
    }
}
