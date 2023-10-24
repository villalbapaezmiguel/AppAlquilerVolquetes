using Entidades;
using Entidades.EntidadesControl;
using Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormAdmin : Form
    {
        private int posicionDTG;
        private string botonSeleccionado;
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();

        }

        private void btn_Volquetes_Click(object sender, EventArgs e)
        {
            this.dtgv_Datos.DataSource = ControlApp.listaVolquetes;
            this.panel_Volquete.Visible = true;
            this.panel_Compra.Visible = false;
            this.panel_Usuario.Visible = false;
            this.botonSeleccionado = "Volquete";

        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            this.dtgv_Datos.DataSource = ControlApp.GetListaUsuarios;
            this.panel_Volquete.Visible = false;
            this.panel_Compra.Visible = false;
            this.panel_Usuario.Visible = true;
            this.botonSeleccionado = "Usuario";
        }

        private void btn_Compras_Click(object sender, EventArgs e)
        {
            this.panel_Volquete.Visible = false;
            this.panel_Compra.Visible = true;
            this.panel_Usuario.Visible = false;
            this.botonSeleccionado = "Compra";
            this.dtgv_Datos.DataSource = AdminControl.GetListaComprasUsuario;


        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void CargarTexbox(string seleccion, int posicionDTG)
        {
            switch (seleccion)
            {
                case "Usuario":
                    string nombreUsuario = (string)this.dtgv_Datos.Rows[posicionDTG].Cells[0].Value;
                    string clave = (string)this.dtgv_Datos.Rows[posicionDTG].Cells[1].Value;
                    double telefono = (double)this.dtgv_Datos.Rows[posicionDTG].Cells[2].Value;
                    int id = (int)this.dtgv_Datos.Rows[posicionDTG].Cells[3].Value;
                    string nombre = (string)this.dtgv_Datos.Rows[posicionDTG].Cells[4].Value;
                    string apellido = (string)this.dtgv_Datos.Rows[posicionDTG].Cells[5].Value;
                    double dni = (double)this.dtgv_Datos.Rows[posicionDTG].Cells[6].Value;

                    this.txt_UsuarioNombreUsuario.Text = nombreUsuario;
                    this.txt_UsuarioClave.Text = clave;
                    this.txt_UsuarioTelefono.Text = telefono.ToString();
                    this.txt_UsuarioNombre.Text = nombre;
                    this.txt_UsuarioApellido.Text = apellido;
                    this.txt_UsuarioDni.Text = dni.ToString();
                    this.txt_UsuarioId.Text = id.ToString();

                    break;

                case "Volquete":

                    float precio = (float)this.dtgv_Datos.Rows[posicionDTG].Cells[0].Value;
                    string tipoVolquete = (string)this.dtgv_Datos.Rows[posicionDTG].Cells[1].Value;
                    float capacidad = (float)this.dtgv_Datos.Rows[posicionDTG].Cells[2].Value;
                    string observacion = (string)this.dtgv_Datos.Rows[posicionDTG].Cells[3].Value;

                    this.txt_VolquetePrecio.Text = precio.ToString();
                    this.txt_VolqueteTipoVolquete.Text = tipoVolquete.ToString();
                    this.txt_VolqueteCapacidad.Text = capacidad.ToString();
                    this.txt_VolqueteObservacion.Text = observacion.ToString();


                    break;

                case "Compra":
                    string nombreDeUsuario = (string)this.dtgv_Datos.Rows[posicionDTG].Cells[0].Value;
                    int cantidadVolquetes = (int)this.dtgv_Datos.Rows[posicionDTG].Cells[1].Value;
                    int cantidadDias = (int)this.dtgv_Datos.Rows[posicionDTG].Cells[2].Value;
                    DateTime fechaDeEntraga = (DateTime)this.dtgv_Datos.Rows[posicionDTG].Cells[3].Value;
                    string horaDeEntrega = (string)this.dtgv_Datos.Rows[posicionDTG].Cells[4].Value;
                    string direccion = (string)this.dtgv_Datos.Rows[posicionDTG].Cells[5].Value;
                    float precio_Compra = (float)this.dtgv_Datos.Rows[posicionDTG].Cells[6].Value;
                    string volquete = (string)this.dtgv_Datos.Rows[posicionDTG].Cells[7].Value;
                    int id_compra = (int)this.dtgv_Datos.Rows[posicionDTG].Cells[8].Value;

                    this.txt_CompraVolquete.Text = volquete;
                    this.txt_CompraUsuario.Text = nombreDeUsuario;
                    this.txt_CompraCantidad.Text = cantidadVolquetes.ToString();
                    this.txt_CompraDias.Text = cantidadDias.ToString();
                    this.txt_CompraFechaDeEntrga.Text = fechaDeEntraga.ToString("D");
                    this.txt_CompraHorario.Text = horaDeEntrega;
                    this.txt_CompraDIreccion.Text = direccion;
                    this.txt_CompraPrecioCompra.Text = precio_Compra.ToString();
                    this.txt_CompraIdCompra.Text = id_compra.ToString();



                    break;

            }

        }




        private void dtgv_Datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.posicionDTG = e.RowIndex;
                if (this.posicionDTG != -1)
                {
                    CargarTexbox(this.botonSeleccionado, this.posicionDTG);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message} ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
