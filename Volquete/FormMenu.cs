using Entidades;
using Entidades.EntidadesUsuarios;
using System.Text;

namespace Formulario
{
    public partial class FormMenu : Form
    {
        int posicionX;
        int posicionY;
        private Usuario usuario;

        public FormMenu()
        {
            InitializeComponent();
            ControlApp.HarcadeoVolquetesCamion();
        }
        public FormMenu(Usuario usuario) : this()
        {
            this.usuario = usuario;
        }

        private void pic_Menu_Click(object sender, EventArgs e)
        {
            AgrandarYAchicarMenu();
        }
        private void AgrandarMenu()
        {
            this.panel_MenuVertical.Width = 180;
        }
        private void MinimizarMenu()
        {
            if (this.panel_MenuVertical.Width == 180)
            {
                this.panel_MenuVertical.Width = 70;
            }
        }
        private void AgrandarYAchicarMenu()
        {
            if (this.panel_MenuVertical.Width == 180)
            {
                this.panel_MenuVertical.Width = 70;
            }
            else
            {
                this.panel_MenuVertical.Width = 180;
            }
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar la aplicacion??", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                FormLogin formLogin = new FormLogin(ControlApp.listaUsuarios);
                formLogin.ShowDialog();
            }
        }

        private void pic_Agrandar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            posicionX = this.Location.X;
            posicionY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.pic_Agrandar.Visible = false;
            this.pic_Restaurar.Visible = true;

        }
        private void pic_Minizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pic_Restaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(870, 440);
            this.Location = new Point(posicionX, posicionY);
            this.pic_Agrandar.Visible = true;
            this.pic_Minizar.Visible = true;
            this.pic_Restaurar.Visible = false;

        }

        private void AbrirFormEnPanelContenedor(object formHijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
            {
                this.panel_Contenedor.Controls.RemoveAt(0);
            }
            Form? fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(fh);
            this.panel_Contenedor.Tag = fh;
            fh.Show();

        }

        private void btn_Usuario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanelContenedor(new FormAlquilarVolquete(ControlApp.listaVolquetes, usuario));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanelContenedor(new FormPerfilUsuario(this.usuario));
           
        }

        private void btn_Alquilar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanelContenedor(new FormABMVolqueteUsuario(usuario));
           
        }
    }
}