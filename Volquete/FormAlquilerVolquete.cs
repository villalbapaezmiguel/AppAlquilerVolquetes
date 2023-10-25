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
        public FormAlquilerVolquete()
        {
            InitializeComponent();
            CargarDTGListaCompra(UsuarioControl.GetUsuario.ListaDeCompra);
        }

        private void FormAlquilerVolquete_Load(object sender, EventArgs e)
        {
            CargarCmBoxTiposDeVolquetes();
            CargarCmBoxHorariosDeEntrega();
            CargarCmboxSemanaMes();
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

                }
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

        private void CargarCmboxSemanaMes()
        {
            try
            {
                foreach (string horario in VolqueteControl.GetSemanaMes)
                {
                    this.cmbox_Semanas.Items.Add(horario);
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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

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
    }
}
