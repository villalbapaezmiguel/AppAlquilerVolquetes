using Entidades;
using Entidades.EntidadesControl;
using Entidades.EntidadesUsuarios;
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
        private Usuario usuario;
        public FormPerfilUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void panel_PefilUsuario_Paint(object sender, PaintEventArgs e)
        {


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

                CargarDTGListaCompra(UsuarioControl.GetUsuario.ListaDeCompra);

            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                UsuarioControl.GetUsuario.NombreUsuario,
                DateTime.Now,
                ex.Message,
                "FormPerfilUsuario",
                "private void FormPerfilUsuario_Load(object sender, EventArgs e)");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }
}
