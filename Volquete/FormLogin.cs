using ConsolaGenericos.Serializadores;
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
using Vista;

namespace Formulario
{
    public partial class FormLogin : Form
    {
        

        public FormLogin()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Maneja el evento de clic en el icono de cerrar formulario.
        /// Muestra un mensaje de advertencia para confirmar el cierre de la aplicación.
        /// Si el usuario confirma, cierra la aplicación.
        /// Si ocurre una excepción durante el proceso, se guarda un registro de error y se muestra un mensaje de error.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void pic_CerrarFormulario_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro desea cerrar??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                UsuarioControl.GetUsuario.Nombre,
                DateTime.Now,
                "Al querer cerrar la app",
                "FormLogin",
                "private void pic_CerrarFormulario_Click(object sender, EventArgs e)");

                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        /// <summary>
        /// Maneja el evento de clic en el botón "Ingresar" del formulario de inicio de sesión.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (txt_Correo.Text == string.Empty && txt_Clave.Text == string.Empty)
            {
                txt_Correo.Focus();
                txt_Clave.Focus();
                MessageBox.Show("Falto rellenar el correo y la clave", "Advertencia", MessageBoxButtons.OK);

            }
            else if (txt_Clave.Text == string.Empty)
            {
                txt_Clave.Focus();
                MessageBox.Show("Falto rellenar la clave", "Advertencia", MessageBoxButtons.OK);
            }
            else if (txt_Correo.Text == string.Empty)
            {
                txt_Correo.Focus();
                MessageBox.Show("Falto rellenar el correo", "Advertencia", MessageBoxButtons.OK);
            }

            try
            {
                Usuario? auxUsuario = UsuarioControl.BuscarUsuarioPorClaveYNombreUsuario(txt_Correo.Text, txt_Clave.Text);
                if (auxUsuario is not null)
                {
                    UsuarioControl.SetUsuario = auxUsuario;

                    MessageBox.Show($"Bienvenido {UsuarioControl.GetUsuario.Nombre} ", "Bienvenido !!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FormMenu formMenu = new FormMenu();
                    formMenu.Show();
                    this.Hide();
                }
                else if (this.txt_Correo.Text == "admin" && this.txt_Clave.Text == "admin")//crar un if para validar el ingreso de un administrador
                {

                    try
                    {
                        FormAdmin formAdmin = new FormAdmin();
                        formAdmin.Show();
                        this.Hide();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                    "Desconocido...",
                    DateTime.Now,
                    "Al querer logearse",
                    "FormLogin",
                    "private void btn_Ingresar_Click(object sender, EventArgs e)");


                    MessageBox.Show("No se encontro el usuario");
                    this.txt_Correo.Focus();
                    VaciarTxtLogin();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
        /// <summary>
        /// Vacía los campos de correo y clave.
        /// </summary>
        private void VaciarTxtLogin()
        {
            this.txt_Clave.Text = string.Empty;
            this.txt_Correo.Text = string.Empty;
        }
        /// <summary>
        /// Abre el formulario de registro al hacer clic en el botón correspondiente.
        /// </summary>
        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                FormRegistrar formRegistrar = new FormRegistrar();
                formRegistrar.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Desconocido...",
                DateTime.Now,
                "Al querer registrarse",
                "FormLogin",
                "private void btn_Registrar_Click(object sender, EventArgs e)");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Llena los campos de correo y clave con las credenciales de administrador al hacer clic en el botón correspondiente.
        /// </summary>
        private void btn_Admin_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_Correo.Text = "admin";
                this.txt_Clave.Text = "admin";

            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Desconocido...",
                DateTime.Now,
                "Al querer ingresar como admin",
                "FormLogin",
                "private void btn_Admin_Click(object sender, EventArgs e)");

                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
