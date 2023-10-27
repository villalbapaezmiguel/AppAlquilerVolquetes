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
using Entidades.EntidadesControl;
using Entidades.EntidadesUsuarios;

namespace Formulario
{
    public partial class FormABMVolqueteUsuario : Form
    {
        public Usuario usuarioAuxiliar;
        
        public FormABMVolqueteUsuario()
        {
            InitializeComponent();
        }

        public FormABMVolqueteUsuario(Usuario usuario) : this()
        {
            this.usuarioAuxiliar = usuario;

        }

        private void FormABMVolqueteUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboBoxVolquete();
                this.cmBox_Volquete.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void pic_CerrarFormulario_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CargarComboBoxVolquete()
        {
            try
            {
                foreach (Volquete item in VolqueteControl.GetListaVolquetes)
                {
                    this.cmBox_Volquete.Items.Add(item.TipoVolquete);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmBox_TiposVolquetes_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string tipo;
                if (this.cmBox_Volquete.SelectedIndex != -1)
                {
                    tipo = this.cmBox_Volquete.SelectedItem.ToString();
                    Volquete? aux = VolqueteControl.EncontrarVolquetePorTipo(tipo);
                    if (aux is not null)
                    {
                        this.lbl_Capacidad.Text = aux.Capacidad.ToString() + " m3";
                        this.lbl_Obeservaciones.Text = aux.Observacion.ToString();
                        this.lbl_Precio.Text = aux.Precio.ToString("C");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
