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
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

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
                    string rutaCarpeta = @"C:\Users\villa\Desktop\PracticaLaboDos\AppAlquilerVolquetes\Volquete\Archivos\DatosUsuario";
                    string nombreDeCarpeta = @$"\Compras del Usuario {UsuarioControl.GetUsuario.Nombre}";
                    string path = rutaCarpeta + nombreDeCarpeta;


                    if (Directory.Exists(path))
                    {
                        MessageBox.Show("Tiene datos guardados");
                        string rutaXML = path +@$"\{UsuarioControl.GetUsuario.Nombre}.xml";
                        string rutaJSON = path + @$"\{UsuarioControl.GetUsuario.Nombre}.json";
                        
                        if(File.Exists(rutaXML) && File.Exists(rutaJSON)) 
                        {
                            UsuarioControl.SetUsuario = Serializar.DeserializarXML_UsuarioDeArchivo(rutaXML);
                            
                        }
                        else
                        {
                            MessageBox.Show("Tenes carpeta pero no archivos json y xml", "Advertencia");
                        }
                    }
                    else
                    {


                        MessageBox.Show("NO TIENE DATOS GUARDADOS");

                    }


                    MessageBox.Show($"Bienvenido {UsuarioControl.GetUsuario.Nombre} ", "Bienvenido !!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FormMenu formMenu = new FormMenu();
                    formMenu.Show();
                    this.Hide();
                }
                else
                {
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

        private void VaciarTxtLogin()
        {
            this.txt_Clave.Text = string.Empty;
            this.txt_Correo.Text = string.Empty;
        }

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

                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Admin_Click(object sender, EventArgs e)
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
    }
}
