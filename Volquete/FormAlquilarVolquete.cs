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
        private DateTime fecha;
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

        private bool ValidarInputs(string? horaDeEntrega ,string direccion, string? tipoVolquete )
        {
            if( horaDeEntrega is not null  && direccion is not null && tipoVolquete is not null ) 
            {
                if(horaDeEntrega == string.Empty && direccion == string.Empty && tipoVolquete == string.Empty)
                {
                    MessageBox.Show("Error , varios campos sin vacios");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Error , Varios campos nulos");
            }
            return false;
        }


        private void btn_AgregarALaLista_Click(object sender, EventArgs e)
        {
            string? horaDeEntrega = "Vacio";
            string direccion = "Vacio";
            string? tipoVolquete = "Vacio";
            int cantidadDias = (int)numUD_CantidadDias.Value;
            int cantidadVolquetes = (int)numUD_CantidadVolquetes.Value;
            float precioActual = ActulizarPrecioActual(this.precioActual, (int)numUD_CantidadVolquetes.Value, (int)numUD_CantidadDias.Value);

            try//validar los inputs

            {
                
                ValidarInputs(this.cmBox_HoraDeEntrega.SelectedItem.ToString(), txt_Direccion.Text,
                this.cmBox_TiposVolquetes.SelectedItem.ToString());


                horaDeEntrega = this.cmBox_HoraDeEntrega.SelectedItem.ToString();
                direccion = txt_Direccion.Text;
                tipoVolquete = this.cmBox_TiposVolquetes.SelectedItem.ToString();

                Compra nuevaCompra = new Compra(tipoVolquete, UsuarioControl.GetUsuario.Nombre, cantidadVolquetes, cantidadDias, this.fecha, horaDeEntrega, direccion, precioActual, ControlApp.NuevoId());
                if (CompraControl.AgregarCompra(ref nuevaCompra))
                {
                    bool compraExitosa = UsuarioControl.AgregarCompra(ref nuevaCompra);
                    if (compraExitosa)
                    {
                        MessageBox.Show("La compra fue un exitooo");

                        this.cmBox_TiposVolquetes.SelectedIndex = -1;
                        this.cmBox_HoraDeEntrega.SelectedIndex = -1;
                        this.numUD_CantidadDias.Value = 1;
                        this.numUD_CantidadVolquetes.Value = 1;
                        this.txt_Direccion.Text = string.Empty;
                        this.lbl_PrecioDelProducto.Text = (0).ToString("C");
                        this.txt_FechaDeEntrega.PlaceholderText = "Año/Mes/Dia";
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btn_HacerCompra_Click(object sender, EventArgs e)
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


        private float ActulizarPrecioActual(float precioActual, int cantidadVolquetes, int cantidadDias)
        {
            return (float)precioActual * cantidadDias * cantidadVolquetes;
        }

        private void numUD_CantidadVolquetes_Click(object sender, EventArgs e)
        {
            if ((int)numUD_CantidadDias.Value > 1 || (int)numUD_CantidadVolquetes.Value > 1)
            {
                this.lbl_PrecioDelProducto.Text = $"{ActulizarPrecioActual(this.precioActual, (int)numUD_CantidadVolquetes.Value, (int)numUD_CantidadDias.Value)}";
            }
        }

        private void pic_FechaDeEntrega_Click(object sender, EventArgs e)
        {
            this.panel_Fecha.Visible = true;
            this.pic_FechaDeEntrega.Visible = false;
            this.lbl_Titulo.Text = "Seleccione una fecha";
            this.pic_CerrarFormulario.Visible = false;
        }

        private void btn_FechaSeleccionada_Click_1(object sender, EventArgs e)
        {
            this.panel_Fecha.Visible = false;
            int dia = (int)this.mth_Canlendario.SelectionStart.Day;
            int mes = (int)this.mth_Canlendario.SelectionStart.Month;
            int anio = (int)this.mth_Canlendario.SelectionStart.Year;
            this.fecha = new DateTime(anio, mes, dia);
            this.lbl_Titulo.Text = "Solicitar Volquete";
            this.pic_CerrarFormulario.Visible = true;
            this.pic_FechaDeEntrega.Visible = true;
            this.txt_FechaDeEntrega.Text = fecha.ToString("d");

        }
    }
}
