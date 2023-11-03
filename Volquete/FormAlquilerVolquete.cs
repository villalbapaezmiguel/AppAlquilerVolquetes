using Entidades;
using Entidades.EntidadesControl;
using Entidades.EntidadesUsuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private List<Compra> listaCompra = new List<Compra>();
        Compra? nuevaCompra = null;
        public FormAlquilerVolquete()
        {
            InitializeComponent();
            CargarDTGListaCompra(listaCompra);
        }

        private void FormAlquilerVolquete_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCmBoxTiposDeVolquetes();
                CargarCmBoxHorariosDeEntrega();
               
                this.lbl_Precio.Text = precioActual.ToString("C");
                if (this.listaCompra.Count >= 1)
                {
                    this.btn_Comprar.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void pic_CerrarFormulario_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                DialogResult = DialogResult.OK;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void CargarDTGListaCompra(List<Compra> listaCompra)
        {
            try
            {
                if (listaCompra.Count >= 1)
                {
                    //this.dtgv_Compra.DataSource = listaCompra;

                    foreach (Compra item in listaCompra)
                    {
                        int posicion = this.dtgv_Compra.Rows.Add();

                        this.dtgv_Compra.Rows[posicion].Cells[0].Value = UsuarioControl.GetUsuario.NombreUsuario;
                        this.dtgv_Compra.Rows[posicion].Cells[1].Value = item.CantidadVolquetes.ToString();
                        this.dtgv_Compra.Rows[posicion].Cells[2].Value = item.CantidadDias.ToString();
                        this.dtgv_Compra.Rows[posicion].Cells[3].Value = item.FechaDeEntraga.ToString("d");
                        this.dtgv_Compra.Rows[posicion].Cells[4].Value = item.HoraDeEntrega.ToString();
                        this.dtgv_Compra.Rows[posicion].Cells[5].Value = item.Direccion.ToString();
                        this.dtgv_Compra.Rows[posicion].Cells[6].Value = item.Precio.ToString();
                        this.dtgv_Compra.Rows[posicion].Cells[7].Value = item.TipoVolquete.ToString();
                        this.dtgv_Compra.Rows[posicion].Cells[8].Value = item.IdCompra.ToString();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private bool CargarDTGV(Compra nuevaCompra)
        {
            try
            {
                if (nuevaCompra is not null)
                {
                    int posicionParaAgregar = this.dtgv_Compra.Rows.Add();


                    this.dtgv_Compra.Rows[posicionParaAgregar].Cells[0].Value = UsuarioControl.GetUsuario.NombreUsuario;
                    this.dtgv_Compra.Rows[posicionParaAgregar].Cells[1].Value = nuevaCompra.CantidadVolquetes.ToString();
                    this.dtgv_Compra.Rows[posicionParaAgregar].Cells[2].Value = nuevaCompra.CantidadDias.ToString();
                    this.dtgv_Compra.Rows[posicionParaAgregar].Cells[3].Value = nuevaCompra.FechaDeEntraga.ToString("d");
                    this.dtgv_Compra.Rows[posicionParaAgregar].Cells[4].Value = nuevaCompra.HoraDeEntrega.ToString();
                    this.dtgv_Compra.Rows[posicionParaAgregar].Cells[5].Value = nuevaCompra.Direccion.ToString();
                    this.dtgv_Compra.Rows[posicionParaAgregar].Cells[6].Value = nuevaCompra.Precio.ToString();
                    this.dtgv_Compra.Rows[posicionParaAgregar].Cells[7].Value = nuevaCompra.TipoVolquete.ToString();
                    this.dtgv_Compra.Rows[posicionParaAgregar].Cells[8].Value = nuevaCompra.IdCompra.ToString();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                foreach (Volquete item in AdminControl.GetListaVolquete)
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
            try
            {
                this.cmbox_Tipo.SelectedIndex = -1;
                this.cmbox_Horario.SelectedIndex = -1;
                this.numUD_Dias.Text = (1).ToString();
                this.numUD_Cantidad.Text = (1).ToString();
                this.txt_Direccion.Text = string.Empty;
                this.lbl_Precio.Text = (0).ToString("C");
                this.txt_FechaDeEntrga.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {

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

                    this.nuevaCompra = new Compra(tipoVolquete, UsuarioControl.GetUsuario.Nombre, cantidadVolquetes, cantidadDias, this.fecha, horaDeEntrega, direccion, precio, ControlApp.NuevoIdCompra());
                    this.listaCompra.Add(nuevaCompra);
                    this.dtgv_Compra.DataSource = this.listaCompra;
                    RefrezcarDTG();
                    LimpiarFormularioAlquiler();
                    this.btn_Comprar.Enabled = true;
                    MessageBox.Show("Agregado con exitooo", "Excelente", MessageBoxButtons.OK);

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

        private void RefrezcarDTG()
        {
            try
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = this.listaCompra;
                this.dtgv_Compra.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.posicionDTG != -1)
                {
                    this.btn_Agregar.Enabled = true;
                    this.btn_Comprar.Enabled = true;
                    this.btn_Eliminar.Enabled = true;
                    this.btn_Modificar.Enabled = false;

                    try
                    {
                        if (this.cmbox_Tipo.SelectedIndex != -1 &&
                            this.numUD_Dias.Value >= 1 &&
                            this.numUD_Cantidad.Value >= 1 &&
                            this.txt_FechaDeEntrga.Text != string.Empty &&
                            this.cmbox_Horario.SelectedIndex != -1 &&
                            this.txt_Direccion.Text != string.Empty)
                        {

                            string cadenaTipo = this.cmbox_Tipo.Text;
                            string cadenaPrecio = this.lbl_Precio.Text;
                            string cadenaDias = this.numUD_Dias.Value.ToString();
                            string cadenaCantidad = this.numUD_Cantidad.Value.ToString();
                            string cadenaFechaDeEntrega = this.txt_FechaDeEntrga.Text;
                            string cadenaHoraDeEntrega = this.cmbox_Horario.Text;
                            string cadenaDireccion = this.txt_Direccion.Text;
                            string cadenaId = this.dtgv_Compra.Rows[this.posicionDTG].Cells[8].Value.ToString();


                            string formato = "dd/MM/yyyy";
                            DateTime nuevaFecha = DateTime.ParseExact(cadenaFechaDeEntrega, formato, CultureInfo.InvariantCulture);
                            Compra nuevaCompra = null;
                            try
                            {
                                int cantidad = int.Parse(cadenaCantidad);
                                int dias = int.Parse(cadenaDias);
                                cadenaPrecio = cadenaPrecio.Replace("$", "");
                                float precio;
                                //el problema esta aca , no se parsea bien 

                                if (float.TryParse(cadenaPrecio, out precio))
                                {

                                }

                                int idCompra = int.Parse(cadenaId);
                                nuevaCompra = new(cadenaTipo, UsuarioControl.GetUsuario.Nombre, cantidad, dias,
                                    nuevaFecha, cadenaHoraDeEntrega, cadenaDireccion, precio, idCompra);


                                if (nuevaCompra is not null)
                                {
                                    if (CompraControl.ModificarPorId(nuevaCompra, this.listaCompra))
                                    {
                                        CargarListaModificadaDTGV(this.posicionDTG, nuevaCompra);
                                        LimpiarFormularioAlquiler();
                                        MessageBox.Show("Se modifico con exito", "Operacion exitosa !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error con el objeto : " + ex.Message);

                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void CargarListaModificadaDTGV(int posicionDTGV, Compra auxCompra)
        {
            try
            {
                this.dtgv_Compra.Rows[posicionDTGV].Cells[1].Value = auxCompra.CantidadVolquetes;
                this.dtgv_Compra.Rows[posicionDTGV].Cells[2].Value = auxCompra.CantidadDias;
                this.dtgv_Compra.Rows[posicionDTGV].Cells[3].Value = auxCompra.FechaDeEntraga;
                this.dtgv_Compra.Rows[posicionDTGV].Cells[4].Value = auxCompra.HoraDeEntrega;
                this.dtgv_Compra.Rows[posicionDTGV].Cells[5].Value = auxCompra.Direccion;
                this.dtgv_Compra.Rows[posicionDTGV].Cells[6].Value = auxCompra.Precio;
                this.dtgv_Compra.Rows[posicionDTGV].Cells[7].Value = auxCompra.TipoVolquete;
                this.dtgv_Compra.Rows[posicionDTGV].Cells[8].Value = auxCompra.IdCompra;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int posicionCompra;
                LimpiarFormularioAlquiler();
                posicionCompra = int.Parse(this.lbl_Id.Text);

                if (CompraControl.EliminarCompra(posicionCompra,this.listaCompra))//verificar como lo elimina
                {
                    RefrezcarDTG();
                    MessageBox.Show("Se elimino con exito!!!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("NO se pudo eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex);
            }
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
                    this.btn_Comprar.Enabled = false;

                    int cantidad = (int)this.dtgv_Compra.Rows[this.posicionDTG].Cells[1].Value;
                    int dias = (int)this.dtgv_Compra.Rows[this.posicionDTG].Cells[2].Value;
                    DateTime fechaDeEntrega = (DateTime)this.dtgv_Compra.Rows[this.posicionDTG].Cells[3].Value;
                    string horaDeEntrega = (string)this.dtgv_Compra.Rows[this.posicionDTG].Cells[4].Value;
                    string direccion = (string)this.dtgv_Compra.Rows[this.posicionDTG].Cells[5].Value;
                    float precio = (float)this.dtgv_Compra.Rows[this.posicionDTG].Cells[6].Value;
                    string tipo = (string)this.dtgv_Compra.Rows[this.posicionDTG].Cells[7].Value;
                    int id = (int)this.dtgv_Compra.Rows[this.posicionDTG].Cells[8].Value;

                    this.cmbox_Tipo.Text = tipo;
                    this.lbl_Precio.Text = precio.ToString();
                    this.txt_FechaDeEntrga.Text = dias.ToString();
                    this.numUD_Cantidad.Text = cantidad.ToString();
                    this.txt_FechaDeEntrga.Text = fechaDeEntrega.ToString("d");
                    this.cmbox_Horario.Text = horaDeEntrega;
                    this.txt_Direccion.Text = direccion;
                    this.lbl_Id.Text = id.ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private float ActulizarPrecioActual(float precioActual, int cantidadVolquetes, int cantidadDias)
        {
            return (float)(precioActual * cantidadDias * cantidadVolquetes);

        }
        private void numUD_Dias_Click(object sender, EventArgs e)
        {

            try
            {
                float precio;
                if ((int)numUD_Cantidad.Value >= 1 || (int)numUD_Dias.Value >= 1)
                {
                    precio = ActulizarPrecioActual(this.precioActual, (int)numUD_Cantidad.Value, (int)numUD_Dias.Value);
                    this.lbl_Precio.Text = precio.ToString("C");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void cmbox_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Volquete? auxVolquete = VolqueteControl.EncontrarVolquetePorTipo(this.cmbox_Tipo.Text);
                if (auxVolquete is not null)
                {
                    this.lbl_Precio.Text = auxVolquete.Precio.ToString("C");
                    this.precioActual = (float)auxVolquete.Precio;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_SeleccionarFecha_Click(object sender, EventArgs e)
        {
            try
            {
                int dia = (int)this.mthCalendar_FechaDeEntrega.SelectionStart.Day;
                int mes = (int)this.mthCalendar_FechaDeEntrega.SelectionStart.Month;
                int anio = (int)this.mthCalendar_FechaDeEntrega.SelectionStart.Year;
                this.fecha = new DateTime(anio, mes, dia);

                this.txt_FechaDeEntrga.Text = this.fecha.ToString("d");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            try
            {
                this.btn_Comprar.Enabled = false;
                this.btn_Eliminar.Enabled = false;
                this.btn_Modificar.Enabled = false;

                string rutaCarpeta = @"C:\Users\villa\Desktop\PracticaLaboDos\AppAlquilerVolquetes\Volquete\Archivos\DatosUsuario\";
                string nombreDeCarpeta = @$"\Compras del Usuario {UsuarioControl.GetUsuario.Nombre}";
                string path = rutaCarpeta + nombreDeCarpeta;

                if (CompraControl.AgregarListaCompra(this.listaCompra))
                {
                    if (UsuarioControl.AgregarListaCompra(this.listaCompra))
                    {
                        string rutaXML = path + @$"\{UsuarioControl.GetUsuario.Nombre}.xml";
                        string rutaJSON = path + @$"\{UsuarioControl.GetUsuario.Nombre}.json";

                        LimpiarFormularioAlquiler();
                        
                        Archivo.CrearDirectorioYArchivo(path, $"Compras de {UsuarioControl.GetUsuario.Nombre}" + ".txt", UsuarioControl.GetUsuario.ToString());
                        //path += @$"\{UsuarioControl.GetUsuario.Nombre}.xml";
                        
                        Serializar.SerializarComprasAUsuario(rutaXML, UsuarioControl.GetUsuario);
                        Serializar.SerializarJSON_Usuario(rutaJSON, UsuarioControl.GetUsuario);

                        AdminControl.AgregarListaDeCompraUsuario(UsuarioControl.GetUsuario.ListaDeCompra);
                        this.listaCompra.Clear();
                        RefrezcarDTG();
                        MessageBox.Show("La compra fue un exitooo", "Excelente", MessageBoxButtons.OK);
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
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
