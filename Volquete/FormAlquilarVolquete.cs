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
        private int posicionDTG;
        private Compra auxCompra = null;
        public FormAlquilarVolquete()
        {
            InitializeComponent();

        }
        public FormAlquilarVolquete(List<Volquete> volquetes, Usuario auxUsuario) : this()
        {
            this.listaVolquetes = volquetes;
            this.auxUsuario = auxUsuario;
        }
        private void FormAlquilarVolquete_Load(object sender, EventArgs e)
        {
            //lbl_Fecha.Text += DateTime.Today.Date.ToString("d");
            this.lbl_PrecioDelProducto.Text = (0).ToString("C");

            //
            CargarCmBoxTiposDeVolquetes();
            CargarCmBoxHorariosDeEntrega();
            this.btn_Eliminar.Enabled = false;
            CargarDTGListaCompra(UsuarioControl.GetListaComprasUsuario);


        }

        private void pic_CerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
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


        private void LimpiarFormularioAlquiler()
        {
            this.cmBox_TiposVolquetes.SelectedIndex = -1;
            this.cmBox_HoraDeEntrega.SelectedIndex = -1;
            this.numUD_CantidadDias.Value = 1;
            this.numUD_CantidadVolquetes.Value = 1;
            this.txt_Direccion.Text = string.Empty;
            this.lbl_PrecioDelProducto.Text = (0).ToString("C");
            this.txt_FechaDeEntrega.Text = "Año/Mes/Dia";
            this.btn_Eliminar.Enabled = true;

        }

        private void CargarDTGListaCompra(List<Compra> listaCompra)
        {
            if(listaCompra.Count >= 1)
            {
                foreach(Compra item in listaCompra)
                {
                    int posicion = this.dtg_ListaDeVolquetes.Rows.Add();

                    this.dtg_ListaDeVolquetes.Rows[posicion].Cells[0].Value = item.TipoVolquete.ToString();
                    this.dtg_ListaDeVolquetes.Rows[posicion].Cells[1].Value = item.Precio.ToString();
                    this.dtg_ListaDeVolquetes.Rows[posicion].Cells[2].Value = item.CantidadDias.ToString();
                    this.dtg_ListaDeVolquetes.Rows[posicion].Cells[3].Value = item.CantidadVolquetes.ToString();
                    this.dtg_ListaDeVolquetes.Rows[posicion].Cells[4].Value = item.FechaDeEntraga.ToString();
                    this.dtg_ListaDeVolquetes.Rows[posicion].Cells[5].Value = item.HoraDeEntrega.ToString();
                    this.dtg_ListaDeVolquetes.Rows[posicion].Cells[6].Value = item.Direccion.ToString();
                    this.dtg_ListaDeVolquetes.Rows[posicion].Cells[7].Value = item.IdCompra.ToString();

                }
            }
        }


        private bool CargarDTGV(Compra nuevaCompra)
        {
            if (nuevaCompra is not null)
            {
                int posicionParaAgregar = this.dtg_ListaDeVolquetes.Rows.Add();

                this.dtg_ListaDeVolquetes.Rows[posicionParaAgregar].Cells[0].Value = nuevaCompra.TipoVolquete.ToString();
                this.dtg_ListaDeVolquetes.Rows[posicionParaAgregar].Cells[1].Value = nuevaCompra.Precio.ToString();
                this.dtg_ListaDeVolquetes.Rows[posicionParaAgregar].Cells[2].Value = nuevaCompra.CantidadDias.ToString();
                this.dtg_ListaDeVolquetes.Rows[posicionParaAgregar].Cells[3].Value = nuevaCompra.CantidadVolquetes.ToString();
                this.dtg_ListaDeVolquetes.Rows[posicionParaAgregar].Cells[4].Value = nuevaCompra.FechaDeEntraga.ToString("d");
                this.dtg_ListaDeVolquetes.Rows[posicionParaAgregar].Cells[5].Value = nuevaCompra.HoraDeEntrega.ToString();
                this.dtg_ListaDeVolquetes.Rows[posicionParaAgregar].Cells[6].Value = nuevaCompra.Direccion.ToString();
                this.dtg_ListaDeVolquetes.Rows[posicionParaAgregar].Cells[7].Value = nuevaCompra.IdCompra.ToString();
                return true;
            }
            return false;
        }


        private void btn_AgregarALaLista_Click(object sender, EventArgs e)
        {
            try
            {
                Compra? nuevaCompra = null;
                string? horaDeEntrega;
                string direccion;
                string? tipoVolquete;
                int cantidadDias = (int)numUD_CantidadDias.Value;
                int cantidadVolquetes = (int)numUD_CantidadVolquetes.Value;
                float precioActual = ActulizarPrecioActual(this.precioActual, (int)numUD_CantidadVolquetes.Value, (int)numUD_CantidadDias.Value);


                if (this.cmBox_HoraDeEntrega.SelectedIndex != -1 && txt_Direccion.Text != string.Empty && this.cmBox_TiposVolquetes.SelectedIndex != -1)
                {
                    horaDeEntrega = this.cmBox_HoraDeEntrega.SelectedItem.ToString();
                    direccion = txt_Direccion.Text;
                    tipoVolquete = this.cmBox_TiposVolquetes.SelectedItem.ToString();

                    nuevaCompra = new Compra(tipoVolquete, UsuarioControl.GetUsuario.Nombre, cantidadVolquetes, cantidadDias, this.fecha, horaDeEntrega, direccion, precioActual, ControlApp.NuevoId());
                    if (CompraControl.AgregarCompra(ref nuevaCompra))
                    {
                        bool compraExitosa = UsuarioControl.AgregarCompra(ref nuevaCompra);
                        if (compraExitosa )
                        {
                            CargarDTGListaCompra(UsuarioControl.GetListaComprasUsuario);
                            MessageBox.Show("La compra fue un exitooo");
                            LimpiarFormularioAlquiler();

                        }
                        else
                        {
                            MessageBox.Show("Error, no se pudo agregar la compra al usuario");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error, no se pudo agregar la compra");
                    }
                }
                else
                {
                    MessageBox.Show("ocurio un error, hay campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btn_HacerCompra_Click(object sender, EventArgs e)
        {
            //generar un ticket , json y XML

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
            this.btn_Eliminar.Visible = false;
            this.dtg_ListaDeVolquetes.Visible = false;
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
            this.btn_Eliminar.Visible = true;
            this.dtg_ListaDeVolquetes.Visible = true;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {



            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex);
            }
        }


        private void dtg_ListaDeVolquetes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.posicionDTG = e.RowIndex;

                if (this.posicionDTG != -1)
                {
                    this.btn_Modificar.Visible = true;
                    this.btn_AgregarALaLista.Visible = false;
                    string tipo = (string)this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[0].Value;
                    string precio = (string)this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[1].Value;
                    string dias = (string)this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[2].Value;
                    string cantidad = (string)this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[3].Value;
                    string fechaDeEntrega = (string)this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[4].Value;
                    string horaDeEntrega = (string)this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[5].Value;
                    string direccion = (string)this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[6].Value;
                    string id = (string)this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[7].Value;

                    this.cmBox_TiposVolquetes.Text = tipo;
                    this.lbl_PrecioDelProducto.Text = precio;
                    this.numUD_CantidadDias.Text = dias;
                    this.numUD_CantidadVolquetes.Text = cantidad;
                    this.txt_FechaDeEntrega.Text = fechaDeEntrega;
                    this.cmBox_HoraDeEntrega.Text = horaDeEntrega;
                    this.txt_Direccion.Text = direccion;
                    this.lbl_IdCompra.Text = id;
                    


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

            if (this.posicionDTG != -1)
            {
                this.btn_Modificar.Visible = false;
                this.btn_AgregarALaLista.Visible = true;

                string? tipo = this.cmBox_TiposVolquetes.SelectedItem.ToString();
                string precio = this.lbl_PrecioDelProducto.Text;
                string dias = this.numUD_CantidadDias.Value.ToString();
                string cantidad = this.numUD_CantidadVolquetes.Value.ToString();
                string fechaDeEntrega = this.txt_FechaDeEntrega.Text;
                string? horaDeEntrega = this.cmBox_HoraDeEntrega.SelectedItem.ToString();
                string direccion = this.txt_Direccion.Text;
                


                string id = (string)this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[7].Value;

                int encontrarId = int.Parse(id);
                this.auxCompra = CompraControl.EncontrarCompraPorID(encontrarId);

                if(this.auxCompra is not null)
                {
                    if(CompraControl.ModificarPorId(auxCompra) && UsuarioControl.ModificarPorId(auxCompra))
                    {
                        //CargarDTGListaCompra(UsuarioControl.GetListaComprasUsuario);

                        this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[0].Value = tipo;
                        this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[1].Value = precio;
                        this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[2].Value = dias;
                        this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[3].Value = cantidad;
                        this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[4].Value = fechaDeEntrega;
                        this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[5].Value = horaDeEntrega;
                        this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[6].Value = direccion;
                        this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[7].Value = id;
                        MessageBox.Show("Se modifico con exito");
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el id del la compra ");
                    }
                }
                else
                {
                    MessageBox.Show("El objeto es null");
                }

            }
            else
            {
                MessageBox.Show("NO selecciono un campo");
            }
           


                LimpiarFormularioAlquiler();
        }
    }
}
