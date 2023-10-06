using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.EntidadesUsuarios;

namespace Formulario
{
    public partial class FormABMVolqueteUsuario : Form
    {
        public Usuario usuarioAuxiliar;
        private string tipoVolquete = "ninguna";
        public FormABMVolqueteUsuario()
        {
            InitializeComponent();
        }

        public FormABMVolqueteUsuario(Usuario usuario) : this()
        {
            this.usuarioAuxiliar = usuario;

        }

        private void pic_CerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void CargarCmBoxVolqueteCamion()
        {
            this.cmBox_Industrial.DataSource = ControlApp.GetMarcasVolquetesCamion;
        }
        private void CargarCmBoxVolqueteConteiner()
        {
            //this.cmBox_Particular.DataSource = ControlApp.listaVolquetes;
        }

        private void panel_ContenedorVolquetes_Paint(object sender, PaintEventArgs e)
        {


        }

        private void FormABMVolqueteUsuario_Load(object sender, EventArgs e)
        {
            CargarCmBoxVolqueteCamion();
            CargarCmBoxVolqueteConteiner();

            if (this.rdb_Industrial.Checked == true)
            {
                this.cmBox_Particular.Visible = false;
                this.cmBox_Industrial.Visible = true;
            }
            else if (this.rdb_Particular.Checked == true)
            {
                this.cmBox_Industrial.Visible = false;
                this.cmBox_Particular.Visible = true;

            }
        }
    }
}
