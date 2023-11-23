using Entidades.EntidadesBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesUsuarios
{
    [Serializable]
    public class Admin : Persona
    {
        private List<Compra> listaCompra = new List<Compra>();
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private List<Volquete> listaVolquete = new List<Volquete>();
        private string clave;

        public Admin() 
        {
            
        }
        public List<Compra> ListaCompra { get => CompraBD.LeerDB(); set => listaCompra = value; }
        public List<Usuario> ListaUsuarios { get => listaUsuarios; set => listaUsuarios = value; }
        public List<Volquete> ListaVolquete { get => ControlApp.GetListaVolquetes; set => listaVolquete = value; }

        private string ComprasHechas()
        {
            StringBuilder informacionCompra = new StringBuilder();
            foreach (Compra item in listaCompra)
            {
                informacionCompra.AppendLine(item.ToString());
            }

            return informacionCompra.ToString();
        }

        private string UsuariosInscriptos()
        {
            StringBuilder informacionUsuario = new StringBuilder();
            foreach (Usuario item in listaUsuarios)
            {
                informacionUsuario.AppendLine(item.ToString());
            }
            return informacionUsuario.ToString();
        }
        private string VolquetesAgregados()
        {
            StringBuilder informacionVolquete = new StringBuilder();
            foreach (Volquete item in listaVolquete)
            {
                informacionVolquete.AppendLine(item.ToString());
            }

            return informacionVolquete.ToString();
        }

        public override string ToString()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine(base.ToString());
            informacion.AppendLine("Lista de compras :");
            informacion.AppendLine(ComprasHechas());
            informacion.AppendLine("Usuarios inscriptos : ");
            informacion.AppendLine(UsuariosInscriptos());
            informacion.AppendLine("Lista de Volquetes agregados :");
            informacion.AppendLine(VolquetesAgregados());


            return informacion.ToString();
        }

    }
}
