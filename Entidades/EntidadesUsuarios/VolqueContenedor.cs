using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.EntidadesUsuarios;

namespace Entidades
{
    public class VolqueContenedor:Volquete
    {
        private int idVolqueteContenedor;
        private bool esCajaAbierta;
        private bool esBasculante;
        private string material;

        public VolqueContenedor(string marca , float altura, float largo, float ancho, float precio , int diasDeArrienda)
            :base(marca,altura,largo,ancho,precio,diasDeArrienda)
        {
            this.esCajaAbierta = false;
            this.esBasculante = false;
            this.material = "Plastico";
        }

        public VolqueContenedor(string marca, float altura, float largo, float ancho, float precio, int diasDeArrienda,bool esCajaAbierta, bool esBasculante, string material, int idVolqueteContenedor)
            :this(marca,altura,largo,ancho,precio,diasDeArrienda)
        {
            this.material = material;
            this.esCajaAbierta = esCajaAbierta;
            this.esBasculante = esBasculante;
            this.idVolqueteContenedor = idVolqueteContenedor;
        }

        public bool EsCajaAbierta { get => esCajaAbierta; set => esCajaAbierta = value; }
        public bool EsBasculante { get => esBasculante; set => esBasculante = value; }
        public string Material { get => material; set => material = value; }
        public int IdVolqueteContenedor { get => idVolqueteContenedor; set => idVolqueteContenedor = value; }

        public static bool operator == (VolqueContenedor vC1 , VolqueContenedor vC2)
        {
            return (vC1.Marca == vC2.Marca && vC1.idVolqueteContenedor == vC2.idVolqueteContenedor);
        }
        public static bool operator != (VolqueContenedor vC1 , VolqueContenedor vC2)
        {
            return !(vC1 == vC2);
        }

    }
}
