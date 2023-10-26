using Entidades;
using Entidades.EntidadesControl;
using Entidades.EntidadesUsuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormAlquilerVolquete : Form
    {
        private int posicionDTG;
        private float precioActual = 0;
        private DateTime fecha;
        public FormAlquilerVolquete()
        {
            InitializeComponent();
            CargarDTGListaCompra(UsuarioControl.GetUsuario.ListaDeCompra);
        }

        private void FormAlquilerVolquete_Load(object sender, EventArgs e)
        {
            CargarCmBoxTiposDeVolquetes();
            CargarCmBoxHorariosDeEntrega();
            this.lbl_Precio.Text = precioActual.ToString("C");

        }
        private void pic_CerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }
        private void CargarDTGListaCompra(List<Compra> listaCompra)
        {
            if (listaCompra.Count >= 1)
            {
                this.dtgv_Compra.DataSource = listaCompra;
                /*
                foreach (Compra item in listaCompra)
                {
                    int posicion = this.dtgv_Compra.Rows.Add();


                    this.dtgv_Compra.Rows[posicion].Cells[0].Value = item.TipoVolquete.ToString();
                    this.dtgv_Compra.Rows[posicion].Cells[1].Value = item.IdCompra.ToString();
                    this.dtgv_Compra.Rows[posicion].Cells[2].Value = item.Precio.ToString();
                    this.dtgv_Compra.Rows[posicion].Cells[3].Value = item.CantidadDias.ToString();
                    this.dtgv_Compra.Rows[posicion].Cells[4].Value = item.CantidadVolquetes.ToString();
                    this.dtgv_Compra.Rows[posicion].Cells[5].Value = item.FechaDeEntraga.ToString("d");
                    this.dtgv_Compra.Rows[posicion].Cells[6].Value = item.HoraDeEntrega.ToString();
                    this.dtgv_Compra.Rows[posicion].Cells[7].Value = item.Direccion.ToString();

                }*/
            }
        }

        private bool CargarDTGV(Compra nuevaCompra)
        {
            if (nuevaCompra is not null)
            {
                int posicionParaAgregar = this.dtgv_Compra.Rows.Add();


                this.dtgv_Compra.Rows[posicionParaAgregar].Cells[0].Value = nuevaCompra.TipoVolquete.ToString();
                this.dtgv_Compra.Rows[posicionParaAgregar].Cells[1].Value = nuevaCompra.IdCompra.ToString();
                this.dtgv_Compra.Rows[posicionParaAgregar].Cells[2].Value = nuevaCompra.Precio.ToString();
                this.dtgv_Compra.Rows[posicionParaAgregar].Cells[3].Value = nuevaCompra.CantidadDias.ToString();
                this.dtgv_Compra.Rows[posicionParaAgregar].Cells[4].Value = nuevaCompra.CantidadVolquetes.ToString();
                this.dtgv_Compra.Rows[posicionParaAgregar].Cells[5].Value = nuevaCompra.FechaDeEntraga.ToString("d");
                this.dtgv_Compra.Rows[posicionParaAgregar].Cells[6].Value = nuevaCompra.HoraDeEntrega.ToString();
                this.dtgv_Compra.Rows[posicionParaAgregar].Cells[7].Value = nuevaCompra.Direccion.ToString();
                return true;
            }
            return false;
        }

        private void CargarCmBoxHorariosDeEntrega()
        {
            try
            {
                foreach (string horario in VolqueteControl.GetHorarios)
                {
                    this.cmbox_Horario.Items.Add(horario);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void CargarCmBoxTiposDeVolquetes()
        {
            try
            {
                foreach (Volquete item in VolqueteControl.GetListaVolquetes)
                {
                    this.cmbox_Tipo.Items.Add(item.TipoVolquete);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LimpiarFormularioAlquiler()
        {
            this.cmbox_Tipo.SelectedIndex = -1;
            this.cmbox_Horario.SelectedIndex = -1;
            this.numUD_Dias.Text = string.Empty;
            this.numUD_Cantidad.Text = string.Empty;
            this.txt_Direccion.Text = string.Empty;
            this.lbl_Precio.Text = (0).ToString("C");
            this.txt_FechaDeEntrga.Text = string.Empty;
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Compra? nuevaCompra = null;
                string? horaDeEntrega;
                string direccion;
                string? tipoVolquete;
                int cantidadDias = (int)numUD_Dias.Value;
                int cantidadVolquetes = (int)numUD_Cantidad.Value;
                float precio = ActulizarPrecioActual(this.precioActual, (int)numUD_Cantidad.Value, (int)numUD_Dias.Value);


                if (this.cmbox_Horario.SelectedIndex != -1 && txt_Direccion.Text != string.Empty && this.cmbox_Tipo.SelectedIndex != -1)
                {
                    horaDeEntrega = this.cmbox_Horario.SelectedItem.ToString();
                    direccion = txt_Direccion.Text;
                    tipoVolquete = this.cmbox_Tipo.SelectedItem.ToString();

                    nuevaCompra = new Compra(tipoVolquete, UsuarioControl.GetUsuario.Nombre, cantidadVolquetes, cantidadDias, this.fecha, horaDeEntrega, direccion, precio, ControlApp.NuevoIdCompra());
                    if (CompraControl.AgregarCompra(ref nuevaCompra))
                    {
                        bool compraExitosa = UsuarioControl.AgregarCompra(ref nuevaCompra);
                        if (compraExitosa)
                        {
                            this.dtgv_Compra.DataSource = UsuarioControl.GetListaComprasUsuario;
                            //CargarDTGV(nuevaCompra);
                            MessageBox.Show("La compra fue un exitooo", "Excelente", MessageBoxButtons.OK);
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

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

        }


        private void dtgv_Compra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.posicionDTG = e.RowIndex;

                if (this.posicionDTG != -1)
                {
                    this.btn_Modificar.Enabled = true;
                    this.btn_Eliminar.Enabled = true;
                    this.btn_Agregar.Enabled = false;
                    //this.btn_HacerCompra.Enabled = false;

                    string tipo = (string)this.dtgv_Compra.Rows[this.posicionDTG].Cells[0].Value;
                    string id = (string)this.dtgv_Compra.Rows[this.posicionDTG].Cells[1].Value;
                    string precio = (string)this.dtgv_Compra.Rows[this.posicionDTG].Cells[2].Value;
                    string dias = (string)this.dtgv_Compra.Rows[this.posicionDTG].Cells[3].Value;
                    string cantidad = (string)this.dtgv_Compra.Rows[this.posicionDTG].Cells[4].Value;
                    string fechaDeEntrega = (string)this.dtgv_Compra.Rows[this.posicionDTG].Cells[5].Value;
                    string horaDeEntrega = (string)this.dtgv_Compra.Rows[this.posicionDTG].Cells[6].Value;
                    string direccion = (string)this.dtgv_Compra.Rows[this.posicionDTG].Cells[7].Value;

                    this.cmbox_Tipo.Text = tipo;
                    this.lbl_Precio.Text = precio;
                    this.txt_FechaDeEntrga.Text = dias;
                    this.numUD_Cantidad.Text = cantidad;
                    this.txt_FechaDeEntrga.Text = fechaDeEntrega;
                    this.cmbox_Horario.Text = horaDeEntrega;
                    this.txt_Direccion.Text = direccion;
                    this.lbl_Id.Text = id;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pic_FechaDeEntrega_Click(object sender, EventArgs e)
        {

        }

        private float ActulizarPrecioActual(float precioActual, int cantidadVolquetes, int cantidadDias)
        {
            return (float)(precioActual * cantidadDias * cantidadVolquetes);
        }
        private void numUD_Dias_Click(object sender, EventArgs e)
        {
            float precio;
            if ((int)numUD_Cantidad.Value >= 1 || (int)numUD_Dias.Value >= 1)
            {
                precio = ActulizarPrecioActual(this.precioActual, (int)numUD_Cantidad.Value, (int)numUD_Dias.Value);
                this.lbl_Precio.Text = precio.ToString("C");
            }
        }

        private void cmbox_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Volquete? auxVolquete = VolqueteControl.EncontrarVolquetePorTipo(this.cmbox_Tipo.Text);
            if (auxVolquete is not null)
            {
                this.lbl_Precio.Text = auxVolquete.Precio.ToString("C");
                this.precioActual = (float)auxVolquete.Precio;
            }
        }

        private void btn_SeleccionarFecha_Click(object sender, EventArgs e)
        {
            int dia = (int)this.mthCalendar_FechaDeEntrega.SelectionStart.Day;
            int mes = (int)this.mthCalendar_FechaDeEntrega.SelectionStart.Month;
            int anio = (int)this.mthCalendar_FechaDeEntrega.SelectionStart.Year;
            this.fecha = new DateTime(anio, mes, dia);

            this.txt_FechaDeEntrga.Text = this.fecha.ToString("d");
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            //generar un ticket , json y XML
            string rutaCarpeta = @"C:\Users\villa\Desktop\PracticaLaboDos\AppAlquilerVolquetes\Volquete\Archivos\DatosUsuario\";
            string nombreDeCarpeta = @$"\Compras del Usuario {UsuarioControl.GetUsuario.Nombre}";
            string path = rutaCarpeta + nombreDeCarpeta;

            Archivo.CrearDirectorioYArchivo(path, $"Compras de {UsuarioControl.GetUsuario.Nombre}" + ".txt", UsuarioControl.GetUsuario.ToString());
            AdminControl.AgregarListaDeCompraUsuario(UsuarioControl.GetUsuario.ListaDeCompra);
        }
    }
}
