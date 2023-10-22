using Entidades;
using Entidades.EntidadesControl;
using Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();

        }

        private void HabilitarCampoVolquete()
        {
            this.txt_TipoVolquete.Visible = true;
            this.txt_Precio.Visible = true;
            this.txt_Observacion.Visible = true;
            this.txt_Capacidad.Visible = true;
        }

        private void DesabilitarCampoVolquete()
        {
            this.txt_TipoVolquete.Visible = false;
            this.txt_Precio.Visible = false;
            this.txt_Observacion.Visible = false;
            this.txt_Capacidad.Visible = false;
        }

        private void btn_Volquetes_Click(object sender, EventArgs e)
        {
            this.dtgv_Datos.DataSource = ControlApp.listaVolquetes;
            HabilitarCampoVolquete();

        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            this.dtgv_Datos.DataSource = ControlApp.GetListaUsuarios;
            DesabilitarCampoVolquete();
        }

        private void btn_Compras_Click(object sender, EventArgs e)
        {
            DesabilitarCampoVolquete();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
