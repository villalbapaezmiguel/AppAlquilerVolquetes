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

namespace Formulario
{
    public partial class FormRegistrar : Form
    {
        private List<Usuario> listaUsuario;
        public FormRegistrar()
        {
            InitializeComponent();
            this.listaUsuario = UsuarioControl.GetListaUsuarios;
        }


        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Usuario nuevo = new Usuario(txt_NombreUsuario.Text,
                txt_Clave.Text,
                double.Parse(txt_NumeroDeTelefono.Text),
                txt_Apellido.Text,
                txt_NombreUsuario.Text,
                double.Parse(txt_DNI.Text),
                ControlApp.NuevoIdUsuario());

            if (!UsuarioControl.ExisteUsuario(txt_NombreUsuario.Text))
            {
                if (UsuarioControl.AgregarUsuario(nuevo))
                {
                    MessageBox.Show("Se agrego corrctamente", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //UsuarioControl.SetUsuario = nuevo;
                    this.Close();
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                }
                else
                {
                    MessageBox.Show("Se agrego corrctamente", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Se agrego corrctamente", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
