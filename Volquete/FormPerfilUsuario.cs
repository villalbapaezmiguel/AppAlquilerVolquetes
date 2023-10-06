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

        private void FormPerfilUsuario_Load(object sender, EventArgs e)
        {
            lbl_Nombre.Text += $" {usuario.Nombre}";
            lbl_Apellido.Text += $" {usuario.Apellido}";
            lbl_Edad.Text += $" {usuario.Edad}";
            lbl_FechaDeNacimiento.Text += $" {usuario.FechaDeNacimiento.Date}";
            lbl_Correo.Text += $" {usuario.Correo}";

            //this.dtg_ListaVolquetes.DataSource = usuario.ListaAlquilados;

        }
    }
}
