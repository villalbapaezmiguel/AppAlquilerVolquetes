using Entidades;
using Entidades.EntidadesControl;
using Entidades.EntidadesUsuarios;
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

                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaCarpeta = @"C:\Users\villa\Desktop\PracticaLaboDos\AppAlquilerVolquetes\Volquete\Archivos\";
                string nombreDeCarpeta = @$"\Carpeta del admin {AdminControl.adminActual.Nombre}";
                string path = rutaCarpeta + nombreDeCarpeta;
                if (MessageBox.Show("Desea cerrar la aplicacion??", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (ControlApp.ControlGuardarDatosUsuaurio(UsuarioControl.GetUsuario))
                    {
                        /*NO reconoce el nombre del administrador 
                         ver el motivo y solucionarlo para poder crear archivos txt , xml y json para el administrador*/
                        Archivo.CrearDirectorioYArchivo(path, $"{AdminControl.adminActual.Nombre}" + ".txt", AdminControl.adminActual.ToString());
                        MessageBox.Show($"Se guardaron los cambios del Usuario {UsuarioControl.GetUsuario.NombreUsuario} Correctamente", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            catch (Exception ex)
            {

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
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Alquilar_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanelContenedor(new FormABMVolqueteUsuario(UsuarioControl.GetUsuario));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            lbl_TituloSaludo.Text = $"Hola {UsuarioControl.GetUsuario.Nombre} {UsuarioControl.GetUsuario.Apellido} !!!";
        }
    }
}