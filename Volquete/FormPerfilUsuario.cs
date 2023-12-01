using ConsolaGenericos.Serializadores;
using Entidades;
using Entidades.Entidades;
using Entidades.EntidadesBD;
using Entidades.EntidadesControl;
using Entidades.EntidadesUsuarios;
using Entidades.Excepciones;
using Entidades.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FormPerfilUsuario : Form
    {
        bool modo ;
        Action delCargarPaquetesCompra;

        public FormPerfilUsuario(ref bool modoOscuro)
        {
            InitializeComponent();
            this.modo = modoOscuro;
        }


        private void pic_CerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDTGListaCompra(List<Compra> listaCompra)
        {
            try
            {
                this.dtgv_Compra.DataSource = listaCompra;
            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                UsuarioControl.GetUsuario.NombreUsuario,
                DateTime.Now,
                ex.Message,
                "FormPerfilUsuario",
                "private void CargarDTGListaCompra(List<Compra> listaCompra)");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void FormPerfilUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                this.lbl_Nombre.Text += $"{UsuarioControl.GetUsuario.Nombre}";
                this.lbl_Apellido.Text += $"{UsuarioControl.GetUsuario.Apellido}";
                this.lbl_Telefono.Text += $"{UsuarioControl.GetUsuario.Telefono}";
                this.lbl_Usuario.Text += $"{UsuarioControl.GetUsuario.NombreUsuario}";
                this.lbl_Id.Text += $"{UsuarioControl.GetUsuario.IdUsuario}";
                FondoColor(sender, e);
                delCargarPaquetesCompra = CargarPaqueteCompras;


                //CargarDTGListaCompra(UsuarioControl.GetUsuario.ListaDeCompra);

                CargarDTGListaCompra(CompraBD.LeerPorIdUsuario(UsuarioControl.GetUsuario.IdUsuario));
                delCargarPaquetesCompra();
            }
            catch (ExceptionBaseDatos ex)
            {
                if(MessageBox.Show("Desea notificar este inconveniente ??", "Error inesperado..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                    UsuarioControl.GetUsuario.NombreUsuario,
                    DateTime.Now,
                    ex.Error().ToString(),
                    "FormPerfilUsuario",
                    "private void FormPerfilUsuario_Load(object sender, EventArgs e)");
                    MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }

        private void pic_ModoPredetermiado_Click(object sender, EventArgs e)
        {
            this.pic_ModoOscuro.Visible = true;
            this.pic_ModoPredetermiado.Visible = false;
            this.panel_DatosUsuario.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.panel_ContenedorVolquetes.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.panel_PefilUsuario.BackColor = System.Drawing.Color.SteelBlue;
            UsuarioControl.GetUsuario.ModoOscuro = false;
            this.modo = false;
        }

        private void FondoColor(object sender, EventArgs e)
        {
            if (UsuarioControl.GetUsuario.ModoOscuro == true)
            {
                pic_ModoOscuro_Click(sender, e);
            }
            else
            {
                pic_ModoPredetermiado_Click(sender, e);
            }
        }

        private void pic_ModoOscuro_Click(object sender, EventArgs e)
        {
            this.pic_ModoOscuro.Visible = false;
            this.pic_ModoPredetermiado.Visible = true;

            this.panel_DatosUsuario.BackColor = System.Drawing.Color.FromArgb(33, 47, 61);
            this.panel_ContenedorVolquetes.BackColor = System.Drawing.Color.FromArgb(33, 47, 61);
            this.panel_PefilUsuario.BackColor = System.Drawing.Color.FromArgb(33, 47, 61);
            UsuarioControl.GetUsuario.ModoOscuro = true;
            this.modo = true;

        }


        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.lbl_TituloListaDeCompras.Text = "HISTORIAL DE COMPRAS";
            this.btn_Atras.Visible = false;
            this.btn_Siguiente.Visible = true;
            this.dtg_PaquetesDeCompra.Visible = false;
        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            this.lbl_TituloListaDeCompras.Text = "HISTORIAL DE PACKS DE COMPRA";
            this.btn_Atras.Visible = true;
            this.btn_Siguiente.Visible = false;
            this.dtg_PaquetesDeCompra.Visible =  true;
            //this.dtg_PaquetesDeCompra.DataSource =  
        }

        public void CargarPaqueteCompras()
        {
            List<PaqueteCompra> listaGeneralDePaquetes = new List<PaqueteCompra>();
            SerializadorJSON<PaqueteCompra> serializadorJSON = new SerializadorJSON<PaqueteCompra>(ControlApp.rutaCarpetaArchivoPaqueteCompras+ UsuarioControl.GetUsuario.NombreUsuario + ".json");
            listaGeneralDePaquetes = serializadorJSON.Deserializar();            
            List<int> listaIdCompras = new List<int>();

            foreach(PaqueteCompra item in listaGeneralDePaquetes)
            {
                foreach(int itemIdCompra in item.ListaIdCompra)
                {
                    listaIdCompras.Add(itemIdCompra);
                }
            }
            this.dtg_PaquetesDeCompra.DataSource = listaGeneralDePaquetes;
            /*mostrar la lista de los parquetes en el dtg del perfil de usaurio 
             usa delegados action , func y predicate*/
            


            

        }
    }
}
