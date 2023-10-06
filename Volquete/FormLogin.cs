using Entidades;
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
    public partial class FormLogin : Form
    {
        List<Usuario> listaUsuarios;
        public Usuario usuario;
        public FormLogin()
        {
            InitializeComponent();
        }
        public FormLogin(Usuario usuario) : this()
        {
            this.usuario = usuario;
        }
        public FormLogin(List<Usuario> lista) : this()
        {
            this.listaUsuarios = lista;
        }

        private void pic_CerrarFormulario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea cerrar??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if(txt_Correo.Text == string.Empty && txt_Clave.Text == string.Empty)
            {
                txt_Correo.Focus();
                txt_Clave.Focus();
                MessageBox.Show("Falto rellenar el correo y la clave", "Advertencia", MessageBoxButtons.OK);

            }
            else if(txt_Clave.Text == string.Empty)
            {
                txt_Clave.Focus();
                MessageBox.Show("Falto rellenar la clave", "Advertencia", MessageBoxButtons.OK);
            }
            else if(txt_Correo.Text == string.Empty)
            {
                txt_Correo.Focus();
                MessageBox.Show("Falto rellenar el correo", "Advertencia", MessageBoxButtons.OK);
            }


            Usuario? auxUsuario = ControlApp.EncontrarUsuarioPorCorreoYClave(txt_Correo.Text, txt_Clave.Text);
            if (auxUsuario is not null)
            {
                if (ControlApp.ExisteUsuario(auxUsuario))
                {
                    MessageBox.Show($"Bienvenido {auxUsuario.Nombre} {auxUsuario.Apellido}", "Bienvenido !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMenu formMenu = new FormMenu(auxUsuario);
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
            else
            {
                MessageBox.Show("No se encontro el usuario");
                this.txt_Correo.Focus();
                VaciarTxtLogin();
            }

        }

        private void VaciarTxtLogin()
        {
            this.txt_Clave.Text = string.Empty;
            this.txt_Correo.Text = string.Empty;
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            FormRegistrar formRegistrar = new FormRegistrar(ControlApp.IntanciarUsuarios());
            formRegistrar.Show();
            this.Hide();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {

            /*            FormAdministrador formAdministrador = new FormAdministrador();
                        formAdministrador.Show();
                        this.Hide();
            */
        }
    }
}
