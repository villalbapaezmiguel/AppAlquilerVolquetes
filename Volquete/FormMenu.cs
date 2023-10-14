using Entidades;
using Entidades.EntidadesControl;
using Entidades.EntidadesUsuarios;
using System.Text;

namespace Formulario
{
    public partial class FormMenu : Form
    {
        int posicionX;
        int posicionY;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void pic_Menu_Click(object sender, EventArgs e)
        {
            AgrandarYAchicarMenu();
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
                if(ControlApp.ControlGuardarDatosUsuaurio(UsuarioControl.GetUsuario))
                {
                    MessageBox.Show($"Se guardaron los cambios del Usuario {UsuarioControl.GetUsuario.NombreUsuario} Correctamente","Exitoso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show($"Error al guardar datos del Usuario {UsuarioControl.GetUsuario.NombreUsuario}....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
                FormLogin formLogin = new FormLogin();
                formLogin.ShowDialog();
            }
        }

        private void pic_Agrandar_Click(object sender, EventArgs e)
        {
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
            AbrirFormEnPanelContenedor(new FormAlquilarVolquete());
            //cambie usuario
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanelContenedor(new FormPerfilUsuario(UsuarioControl.GetUsuario));
            //cambie usuario
        }

        private void btn_Alquilar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanelContenedor(new FormABMVolqueteUsuario(UsuarioControl.GetUsuario));
            //cambie usuario
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            lbl_TituloSaludo.Text = $"Hola {UsuarioControl.GetUsuario.Nombre} {UsuarioControl.GetUsuario.Apellido} !!!";
        }
    }
}