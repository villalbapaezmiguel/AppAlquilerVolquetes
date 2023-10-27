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
                if (listaCompra.Count >= 1)
                {
                    foreach (Compra item in listaCompra)
                    {
                        int posicion = this.dtgv_ListasCompras.Rows.Add();

                        this.dtgv_ListasCompras.Rows[posicion].Cells[0].Value = item.TipoVolquete.ToString();
                        this.dtgv_ListasCompras.Rows[posicion].Cells[1].Value = item.IdCompra.ToString();
                        this.dtgv_ListasCompras.Rows[posicion].Cells[2].Value = item.Precio.ToString();
                        this.dtgv_ListasCompras.Rows[posicion].Cells[3].Value = item.CantidadDias.ToString();
                        this.dtgv_ListasCompras.Rows[posicion].Cells[4].Value = item.CantidadVolquetes.ToString();
                        this.dtgv_ListasCompras.Rows[posicion].Cells[5].Value = item.FechaDeEntraga.ToString("d");
                        this.dtgv_ListasCompras.Rows[posicion].Cells[6].Value = item.HoraDeEntrega.ToString();
                        this.dtgv_ListasCompras.Rows[posicion].Cells[7].Value = item.Direccion.ToString();

                    }
                }

            }
            catch (Exception ex)
            {
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
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }
}
