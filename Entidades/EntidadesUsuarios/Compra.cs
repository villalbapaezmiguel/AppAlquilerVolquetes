using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesUsuarios
{
    [Serializable]//es  serializable
    public class Compra
    {
        private string tipoVolquete;
        private string nombreDeUsuario;
        private int cantidadVolquetes;
        private int cantidadDias;
        private DateTime fechaDeEntraga;
        private string horaDeEntrega;
        private string direccion;
        private float precio;
        private int idCompra ;
        public Compra()
        {

        }
        public Compra(string volquete, string nombreDeUsuario, int cantidadVolquetes, int cantidadDias, DateTime fechaDeEntraga, string horaDeEntrega, string direccion, float precio, int id) : this()
        {
            this.tipoVolquete = volquete;
            this.nombreDeUsuario = nombreDeUsuario;
            this.cantidadVolquetes = cantidadVolquetes;
            this.cantidadDias = cantidadDias;
            this.fechaDeEntraga = fechaDeEntraga;
            this.horaDeEntrega = horaDeEntrega;
            this.direccion = direccion;
            this.precio = precio;
            this.idCompra = id;
        }

        public string NombreDeUsuario { get => nombreDeUsuario; set => nombreDeUsuario = value; }
        public int CantidadVolquetes { get => cantidadVolquetes; set => cantidadVolquetes = value; }
        public int CantidadDias { get => cantidadDias; set => cantidadDias = value; }
        public DateTime FechaDeEntraga { get => fechaDeEntraga; set => fechaDeEntraga = value; }
        public string HoraDeEntrega { get => horaDeEntrega; set => horaDeEntrega = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public float Precio { get => precio; set => precio = value; }
        public string TipoVolquete { get => tipoVolquete; set => tipoVolquete = value; }
        public int IdCompra { get => idCompra; set => idCompra = value; }



    }
}
