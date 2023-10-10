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
    public partial class FormAlquilarVolquete : Form
    {
        List<Volquete>? listaVolquetes = null;
        Usuario auxUsuario = null;
        private float precioActual = 0;
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
            this.lbl_PrecioDelProducto.Text = (0).ToString("C");

            //
            CargarCmBoxTiposDeVolquetes();
            CargarCmBoxHorariosDeEntrega();


        }

        private void CargarCmBoxTiposDeVolquetes()
        {
            foreach (Volquete item in VolqueteControl.GetListaVolquetes)
            {
                this.cmBox_TiposVolquetes.Items.Add(item.TipoVolquete);
            }
        }

        private void CargarCmBoxHorariosDeEntrega()
        {
            foreach (string horario in VolqueteControl.GetHorarios)
            {
                this.cmBox_HoraDeEntrega.Items.Add(horario);
            }
        }



        private void Refrezcar()
        {

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = UsuarioControl.GetListaComprasUsuario;
            this.dtg_ListaDeVolquetes.DataSource = bindingSource;
        }

        private void btn_AgregarALaLista_Click(object sender, EventArgs e)
        {
            string? horaDeEntrega = this.cmBox_HoraDeEntrega.SelectedItem.ToString();
            int cantidadDias = (int)numUD_CantidadDias.Value;
            int cantidadVolquetes = (int)numUD_CantidadVolquetes.Value;
            string direccion = txt_Direccion.Text;
            string? tipoVolquete = this.cmBox_TiposVolquetes.SelectedItem.ToString();
            float precioActual = (float)this.precioActual;

            //validar horaDeEntrega , tipoVolquete

            Compra nuevaCompra = new Compra(tipoVolquete, UsuarioControl.GetUsuario.Nombre, cantidadVolquetes, cantidadDias, new DateTime(10, 12, 2), horaDeEntrega, direccion, precioActual);
            if (CompraControl.AgregarCompra(ref nuevaCompra))
            {
                bool compraExitosa = UsuarioControl.AgregarCompra(nuevaCompra);
                if(compraExitosa) 
                {
                    MessageBox.Show("La compra fue un exitooo");
                    
                    this.cmBox_TiposVolquetes.SelectedIndex = -1;
                    this.cmBox_HoraDeEntrega.SelectedIndex = -1;
                    this.numUD_CantidadDias.Value = 1;
                    this.numUD_CantidadVolquetes.Value = 1;
                    this.txt_Direccion.Text = string.Empty;
                    this.dtg_ListaDeVolquetes.DataSource = CompraControl.GetListaCompras;
                    Refrezcar();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error en la compra");
                }
            }
            else
            {
                MessageBox.Show("ocurio un error");
            }


        }

        private void btn_HacerCompra_Click(object sender, EventArgs e)
        {


        }

        private void pic_Calendario_Click(object sender, EventArgs e)
        {

        }


        private void cmBox_TiposVolquetes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Volquete? auxVolquete = VolqueteControl.EncontrarVolquetePorTipo(this.cmBox_TiposVolquetes.Text);
            if (auxVolquete is not null)
            {
                this.lbl_PrecioDelProducto.Text = $"{(float)auxVolquete.Precio}";
                this.precioActual = (float)auxVolquete.Precio;
            }
            //aca hay un error
        }


        private float ActulizarPrecioActual(float precioActual, int cantidadDias)
        {
            return (float)precioActual * cantidadDias;
        }

        private void numUD_CantidadDias_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numUD_CantidadDias.Value > 1)
            {
                this.lbl_PrecioDelProducto.Text = $"{ActulizarPrecioActual(this.precioActual, (int)numUD_CantidadDias.Value)}";
            }
        }
    }
}
