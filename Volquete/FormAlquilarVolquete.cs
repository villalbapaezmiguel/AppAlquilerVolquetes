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
    public partial class FormAlquilarVolquete : Form
    {
        List<Volquete>? listaVolquetes = null;
        Usuario auxUsuario = null;

        public FormAlquilarVolquete()
        {
            InitializeComponent();
        }
        public FormAlquilarVolquete(List<Volquete> volquetes, Usuario auxUsuario) : this()
        {
            this.listaVolquetes = volquetes;
            this.auxUsuario = auxUsuario;
        }

        private void pic_CerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void FormAlquilarVolquete_Load(object sender, EventArgs e)
        {
            //lbl_Fecha.Text += DateTime.Today.Date.ToString("d");
            //lbl_PrecioDelProducto.Text = (0).ToString("C");
            CargarMarcaDeVolquetesCbox(ControlApp.listaVolquetes);
            CargarMaterialesCbox();
            CargarMedioDePago();
            CargarModelosVolquetesCamion();
        }


        private void CargarMedioDePago()
        {
            /*
            this.cbox_TipoDePago.Items.Add("Tarjeta");
            this.cbox_TipoDePago.Items.Add("Efectivo");*/
        }

        private void CargarMaterialesCbox()
        {
            /*
            this.cbox_Material.Items.Add(EMaterial.plasticoResistente.ToString());
            this.cbox_Material.Items.Add(EMaterial.acero.ToString());*/
        }

        private void CargarMarcaDeVolquetesCbox(List<Volquete> listaVolquetes)
        {
            /*
            foreach (VolqueteCamion item in listaVolquetes)
            {
                cbox_ListaVolquetes.Items.Add(item.Marca.ToString());
            }*/

        }
        private void CargarModelosVolquetesCamion()
        {
            /*
            foreach (VolqueteCamion item in ControlApp.listaVolquetes)
            {
                this.cbox_ModeloVolquete.Items.Add(item.Modelo.ToString());
            }*/

        }



        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            /*
            string marca = "ninguna";
            string material = "x";
            string modelo = "x";
            int diasDeArrienda = 0;
            string tipoDePago = "ninguna";
            float precioTotal = float.Parse(lbl_PrecioDelProducto.Text);


            if (cbox_ListaVolquetes.SelectedIndex != -1)
            {
                marca = this.cbox_ListaVolquetes.SelectedIndex.ToString();
            }
            else
            {
                this.cbox_ListaVolquetes.Focus();
                MessageBox.Show("Le falto seleccionar una marca de volquete");
            }

            if (rdl_Contendor.Checked == true && this.cbox_Material.Visible == true)
            {
                if (cbox_Material.SelectedIndex != -1)
                {
                    material = this.cbox_Material.Text;
                }
                else
                {
                    MessageBox.Show("Le falto seleccionar El material del volquete");
                }
            }

            if (rdl_Camion.Checked == true && this.cbox_ModeloVolquete.Visible == true)
            {
                if (this.cbox_ModeloVolquete.SelectedIndex != -1)
                {
                    modelo = this.cbox_ModeloVolquete.Text;
                }
                else
                {
                    MessageBox.Show("Le falto seleccionar El Modelo del volquete");
                }
            }

            if (this.numUD_Cantidad.Value >= 5)
            {
                diasDeArrienda = (int)this.numUD_Cantidad.Value;
            }
            else
            {
                MessageBox.Show("Son 5 dias como minimo");
            }

            if (this.cbox_TipoDePago.SelectedIndex != -1)
            {
                tipoDePago = this.cbox_TipoDePago.Text;
            }
            else
            {
                this.cbox_TipoDePago.Focus();
                MessageBox.Show("Seleccione un medio de pago");
            }
            AlquilerVolquete alquilerVolquete = new AlquilerVolquete(marca, material, modelo, diasDeArrienda, ETipoDePago.Tarjeta, precioTotal);
            this.auxUsuario.ListaAlquilados.Add(alquilerVolquete);
            Refrezcar();
            */
        }

        private void Refrezcar()
        {
            /*
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.auxUsuario.ListaAlquilados;
            this.dtg_HistorialCompras.DataSource = bindingSource;*/
        }

    }
}
