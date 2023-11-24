using Entidades;
using Entidades.ClasesEventos;
using Entidades.EntidadesControl;
using Entidades.EntidadesUsuarios;
using Entidades.Interfaz;
using System.IO;
using System.Text;
using Vista;

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
            try
            {
                AgrandarYAchicarMenu();

            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                UsuarioControl.GetUsuario.NombreUsuario,
                DateTime.Now,
                ex.Message,
                "FormMenu",
                "private void pic_Menu_Click(object sender, EventArgs e)");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AgrandarYAchicarMenu()
        {
            try
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
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                UsuarioControl.GetUsuario.NombreUsuario,
                DateTime.Now,
                ex.Message,
                "FormMenu",
                "private void AgrandarYAchicarMenu()");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaCarpeta = ControlApp.rutaCarpetaArchivos;
                string nombreDeCarpeta = @$"\Carpeta del admin";
                string path = rutaCarpeta + nombreDeCarpeta;
                string rutaJSON = path + @$"\ListaUsuarios.json";


                if (MessageBox.Show("Desea cerrar la aplicacion??", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                    FormLogin formLogin = new FormLogin();
                    formLogin.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                UsuarioControl.GetUsuario.NombreUsuario,
                DateTime.Now,
                ex.Message,
                "FormMenu",
                "private void pic_Cerrar_Click(object sender, EventArgs e)");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pic_Agrandar_Click(object sender, EventArgs e)
        {
            try
            {
                posicionX = this.Location.X;
                posicionY = this.Location.Y;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.pic_Agrandar.Visible = false;
                this.pic_Restaurar.Visible = true;

            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                UsuarioControl.GetUsuario.NombreUsuario,
                DateTime.Now,
                ex.Message,
                "FormMenu",
                "private void pic_Agrandar_Click(object sender, EventArgs e)");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pic_Minizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;

            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                UsuarioControl.GetUsuario.NombreUsuario,
                DateTime.Now,
                ex.Message,
                "FormMenu",
                "private void pic_Minizar_Click(object sender, EventArgs e)");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pic_Restaurar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Size = new Size(870, 440);
                this.Location = new Point(posicionX, posicionY);
                this.pic_Agrandar.Visible = true;
                this.pic_Minizar.Visible = true;
                this.pic_Restaurar.Visible = false;

            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                UsuarioControl.GetUsuario.NombreUsuario,
                DateTime.Now,
                ex.Message,
                "FormMenu",
                "private void pic_Restaurar_Click(object sender, EventArgs e)");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void AbrirFormEnPanelContenedor(object formHijo)
        {
            try
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
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                UsuarioControl.GetUsuario.NombreUsuario,
                DateTime.Now,
                ex.Message,
                "FormMenu",
                "private void AbrirFormEnPanelContenedor(object formHijo)");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Usuario_Click(object sender, EventArgs e)
        {

            try
            {
                AbrirFormEnPanelContenedor(new FormAlquilerVolquete());

            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                UsuarioControl.GetUsuario.NombreUsuario,
                DateTime.Now,
                ex.Message,
                "FormMenu",
                "private void btn_Usuario_Click(object sender, EventArgs e)");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanelContenedor(new FormPerfilUsuario(UsuarioControl.GetUsuario));
            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                UsuarioControl.GetUsuario.NombreUsuario,
                DateTime.Now,
                ex.Message,
                "FormMenu",
                "private void button1_Click(object sender, EventArgs e)");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Alquilar_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanelContenedor(new FormPrecioCapacidades(UsuarioControl.GetUsuario));
            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                UsuarioControl.GetUsuario.NombreUsuario,
                DateTime.Now,
                ex.Message,
                "FormMenu",
                " private void btn_Alquilar_Click(object sender, EventArgs e)");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            try
            {
                lbl_TituloSaludo.Text = $"Hola {UsuarioControl.GetUsuario.Nombre} {UsuarioControl.GetUsuario.Apellido} !!!";
                FondoColor(sender, e);
                /*
                Reloj reloj = new Reloj();

                reloj.segundoCambio += ActualizarHora;
                reloj.Iniciar();*/

            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                UsuarioControl.GetUsuario.NombreUsuario,
                DateTime.Now,
                ex.Message,
                "FormMenu",
                "private void FormMenu_Load(object sender, EventArgs e)");
            }
        }
        private void FondoColor(object sender, EventArgs e)
        {
            if (UsuarioControl.GetUsuario.ModoOscuro == true)
            {
                this.panel_Contenedor.BackColor = System.Drawing.Color.FromArgb(39, 55, 70);
                this.panel_Titulo.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
                this.panel_MenuVertical.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            }
            else
            {
                this.panel_Contenedor.BackColor = System.Drawing.Color.FromArgb(31, 97, 141);
                this.panel_Titulo.BackColor = System.Drawing.Color.FromArgb(40, 116, 166);
                this.panel_MenuVertical.BackColor = System.Drawing.Color.FromArgb(40, 116, 166);
            }

        }

        /*
        public void ActualizarHora(Reloj reloj)
        {
            if (lbl_Hora.InvokeRequired)
            {
                Action<Reloj> delegadoReloj = ActualizarHora;

                lbl_Hora.Invoke(delegadoReloj, reloj);
            }
            else
            {
                lbl_Hora.Text = reloj.ToString();
            }
        }*/


    }
}