using ConsolaGenericos.Serializadores;
using Entidades;
using Entidades.Entidades;
using Entidades.EntidadesBD;
using Entidades.EntidadesControl;
using Entidades.EntidadesUsuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormInformacionPaqueteCompra : Form
    {
        private int idPaquete;
        Func<int,List<Compra>> delegadoObtenerListaCompra;

        public FormInformacionPaqueteCompra(int idPaquete)
        {
            InitializeComponent();
            this.idPaquete = idPaquete;
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<Compra> ObtenerlistaComprasPorIdPaquete(int idPaquete) 
        {
            List<PaqueteCompra> listaGeneralDePaquetes = new List<PaqueteCompra>();
            SerializadorJSON<PaqueteCompra> serializadorJSON = new SerializadorJSON<PaqueteCompra>(ControlApp.rutaCarpetaArchivoPaqueteCompras + UsuarioControl.GetUsuario.NombreUsuario + ".json");
            listaGeneralDePaquetes = serializadorJSON.Deserializar();
            List<int> listaIdCompra = new List<int>();
            
            foreach(PaqueteCompra item in  listaGeneralDePaquetes)
            {
                if(item.IdPaqueteCompra == idPaquete)
                {
                    foreach(int itemIdCompra in item.ListaIdCompra)
                    {
                        listaIdCompra.Add(itemIdCompra);
                    }
                }
            }

            List<Compra> nuevaListaCompra = new List<Compra>();
            foreach(int idCompra in listaIdCompra)
            {
                Compra aux = CompraBD.LeerPorIdCompra(idCompra);
                nuevaListaCompra.Add(aux);
            }

            return nuevaListaCompra;

        }

        private void FormInformacionPaqueteCompra_Load(object sender, EventArgs e)
        {
            delegadoObtenerListaCompra = ObtenerlistaComprasPorIdPaquete;

            List<Compra> listaCompra = new List<Compra>();
            listaCompra = delegadoObtenerListaCompra(this.idPaquete);
            this.dtgv_Datos.DataSource = listaCompra;
        }
    }
}
