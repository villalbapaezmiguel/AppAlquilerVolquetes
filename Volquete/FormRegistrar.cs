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
    public partial class FormRegistrar : Form
    {
        private List<Usuario> listaUsuario;
        public FormRegistrar(List<Usuario> listaUsuario)
        {
            InitializeComponent();
            this.listaUsuario = listaUsuario;
        }


        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
        
        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            DateTime fecha = cal_FechaDeNacimiento.SelectionStart;

            Usuario nuevo = new Usuario(txt_Correo.Text,
                txt_Clave.Text,
                txt_Nombre.Text,
                txt_Apellido.Text,
                int.Parse(txt_Edad.Text),
                fecha);

            if (!ControlApp.ExisteUsuario(nuevo))
            {
                if (ControlApp.AgregarUsuario(nuevo))
                {
                    MessageBox.Show("Se agrego corrctamente", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    FormLogin formLogin = new FormLogin(nuevo);
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
