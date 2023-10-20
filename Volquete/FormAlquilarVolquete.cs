using Entidades;
using Entidades.EntidadesControl;
using Entidades.EntidadesUsuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Formulario
{
    public partial class FormAlquilarVolquete : Form
    {
        private float precioActual = 0;
        private DateTime fecha;
        private int posicionDTG;
        private Compra auxCompra = null;

        public FormAlquilarVolquete()
        {
            InitializeComponent();
            CargarDTGListaCompra(UsuarioControl.GetUsuario.ListaDeCompra);

        }
        private void FormAlquilarVolquete_Load(object sender, EventArgs e)
        {
            //lbl_Fecha.Text += DateTime.Today.Date.ToString("d");
            this.lbl_PrecioDelProducto.Text = (0).ToString("C");

            //
            CargarCmBoxTiposDeVolquetes();
            CargarCmBoxHorariosDeEntrega();
            this.btn_Eliminar.Enabled = false;
            this.btn_Modificar.Enabled = false;
            this.cmBox_TiposVolquetes.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmBox_HoraDeEntrega.DropDownStyle = ComboBoxStyle.DropDownList;
            this.txt_FechaDeEntrega.ReadOnly = true;
            this.txt_FechaDeEntrega.Enabled = false;

        }

        private void pic_CerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }


        private void CargarCmBoxTiposDeVolquetes()
        {
            try
            {
                foreach (Volquete item in VolqueteControl.GetListaVolquetes)
                {
                    this.cmBox_TiposVolquetes.Items.Add(item.TipoVolquete);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CargarCmBoxHorariosDeEntrega()
        {
            try
            {
                foreach (string horario in VolqueteControl.GetHorarios)
                {
                    this.cmBox_HoraDeEntrega.Items.Add(horario);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.btn_Eliminar.Visible = true;
            this.btn_Modificar.Visible = true;

        }

        private void CargarDTGListaCompra(List<Compra> listaCompra)
        {
            if (listaCompra.Count >= 1)
            {
                foreach (Compra item in listaCompra)
                {
                    int posicion = this.dtg_ListaDeVolquetes.Rows.Add();

                    this.dtg_ListaDeVolquetes.Rows[posicion].Cells[0].Value = item.TipoVolquete.ToString();
                    this.dtg_ListaDeVolquetes.Rows[posicion].Cells[1].Value = item.IdCompra.ToString();
                    this.dtg_ListaDeVolquetes.Rows[posicion].Cells[2].Value = item.Precio.ToString();
                    this.dtg_ListaDeVolquetes.Rows[posicion].Cells[3].Value = item.CantidadDias.ToString();
                    this.dtg_ListaDeVolquetes.Rows[posicion].Cells[4].Value = item.CantidadVolquetes.ToString();
                    this.dtg_ListaDeVolquetes.Rows[posicion].Cells[5].Value = item.FechaDeEntraga.ToString("d");
                    this.dtg_ListaDeVolquetes.Rows[posicion].Cells[6].Value = item.HoraDeEntrega.ToString();
                    this.dtg_ListaDeVolquetes.Rows[posicion].Cells[7].Value = item.Direccion.ToString();

                }
            }
        }


        private bool CargarDTGV(Compra nuevaCompra)
        {
            if (nuevaCompra is not null)
            {
                int posicionParaAgregar = this.dtg_ListaDeVolquetes.Rows.Add();

                this.dtg_ListaDeVolquetes.Rows[posicionParaAgregar].Cells[0].Value = nuevaCompra.TipoVolquete.ToString();
                this.dtg_ListaDeVolquetes.Rows[posicionParaAgregar].Cells[1].Value = nuevaCompra.IdCompra.ToString();
                this.dtg_ListaDeVolquetes.Rows[posicionParaAgregar].Cells[2].Value = nuevaCompra.Precio.ToString();
                this.dtg_ListaDeVolquetes.Rows[posicionParaAgregar].Cells[3].Value = nuevaCompra.CantidadDias.ToString();
                this.dtg_ListaDeVolquetes.Rows[posicionParaAgregar].Cells[4].Value = nuevaCompra.CantidadVolquetes.ToString();
                this.dtg_ListaDeVolquetes.Rows[posicionParaAgregar].Cells[5].Value = nuevaCompra.FechaDeEntraga.ToString("d");
                this.dtg_ListaDeVolquetes.Rows[posicionParaAgregar].Cells[6].Value = nuevaCompra.HoraDeEntrega.ToString();
                this.dtg_ListaDeVolquetes.Rows[posicionParaAgregar].Cells[7].Value = nuevaCompra.Direccion.ToString();
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
                float precio = ActulizarPrecioActual(this.precioActual, (int)numUD_CantidadVolquetes.Value, (int)numUD_CantidadDias.Value);


                if (this.cmBox_HoraDeEntrega.SelectedIndex != -1 && txt_Direccion.Text != string.Empty && this.cmBox_TiposVolquetes.SelectedIndex != -1)
                {
                    horaDeEntrega = this.cmBox_HoraDeEntrega.SelectedItem.ToString();
                    direccion = txt_Direccion.Text;
                    tipoVolquete = this.cmBox_TiposVolquetes.SelectedItem.ToString();

                    nuevaCompra = new Compra(tipoVolquete, UsuarioControl.GetUsuario.Nombre, cantidadVolquetes, cantidadDias, this.fecha, horaDeEntrega, direccion, precio, ControlApp.NuevoIdCompra());
                    if (CompraControl.AgregarCompra(ref nuevaCompra))
                    {
                        bool compraExitosa = UsuarioControl.AgregarCompra(ref nuevaCompra);
                        if (compraExitosa)
                        {
                            CargarDTGV(nuevaCompra);
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

        private string ObtenerListaDeCompras(List<Compra> listaCompras)
        {
            StringBuilder informacionCompra = new  StringBuilder();
            try
            {
                foreach(Compra compra in listaCompras)
                {
                    informacionCompra.AppendLine(compra.ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"ERRO : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return informacionCompra.ToString();

        }

        private void btn_HacerCompra_Click(object sender, EventArgs e)
        {
            //generar un ticket , json y XML
            string rutaCarpeta = @"C:\Users\villa\Desktop\PracticaLaboDos\AppAlquilerVolquetes\Volquete\Archivos\XML\";
            //string nombre = @"\Compras.xml";
            string path = rutaCarpeta + UsuarioControl.GetUsuario.NombreUsuario;

            string informacion;
                    informacion = ObtenerListaDeCompras(UsuarioControl.GetUsuario.ListaDeCompra);
                    path += @"\"+UsuarioControl.GetUsuario.NombreUsuario +".txt";
            /*error a la hora de crear archivos y de directorios*/
            try
            {
                if(Serializar.CrearDirectorioParaUsuario(path))
                {
                    if (Serializar.CrearArchivo(path, informacion))
                    {
                        MessageBox.Show("Archivo creado con exito");
                        Serializar.EscribirXMLCompras(path, UsuarioControl.GetUsuario.ListaDeCompra);
                    }
                    else
                    {
                        if(Serializar.EscribirArchivo(path, informacion))
                        {
                            Serializar.EscribirXMLCompras(path, UsuarioControl.GetUsuario.ListaDeCompra);
                            MessageBox.Show($"Se escribio con exito el archivo ya existe");
                        }
                        else
                        {
                            MessageBox.Show($"Error , No se pudo escribir en el archivo existente");
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Error , ese directorio ya existe");
                    if (Serializar.EscribirArchivo(path, informacion))
                    {
                        Serializar.EscribirXMLCompras(path, UsuarioControl.GetUsuario.ListaDeCompra);
                        MessageBox.Show($"Se escribio con exito el archivo ya existe");
                    }
                    else
                    {
                        MessageBox.Show($"Error , No se pudo escribir en el archivo existente");
                    }
                }

                /*
                Serializar.EscribirXMLCompras(path, ControlApp.GetListaComprasUsuario);
                MessageBox.Show("Compra exitosa");*/
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error : {ex.Message}");
                
            }

        }

        private void cmBox_TiposVolquetes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Volquete? auxVolquete = VolqueteControl.EncontrarVolquetePorTipo(this.cmBox_TiposVolquetes.Text);
            if (auxVolquete is not null)
            {
                this.lbl_PrecioDelProducto.Text = auxVolquete.Precio.ToString("C");
                this.precioActual = (float)auxVolquete.Precio;
            }
            //aca hay un error
        }


        private float ActulizarPrecioActual(float precioActual, int cantidadVolquetes, int cantidadDias)
        {
            return (float)(precioActual * cantidadDias * cantidadVolquetes);
        }

        private void numUD_CantidadVolquetes_Click(object sender, EventArgs e)
        {
            float precio;
            if ((int)numUD_CantidadDias.Value >= 1 || (int)numUD_CantidadVolquetes.Value >= 1)
            {
                precio = ActulizarPrecioActual(this.precioActual, (int)numUD_CantidadVolquetes.Value, (int)numUD_CantidadDias.Value);
                this.lbl_PrecioDelProducto.Text = precio.ToString("C");
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
            this.lbl_IdCompra.Visible = false;
            this.lblId.Visible = false;
            this.btn_Modificar.Visible = false;
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
            this.lbl_IdCompra.Visible = true;
            this.lblId.Visible = true;
            this.btn_Modificar.Visible = true;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int posicionCompra;
                this.dtg_ListaDeVolquetes.Rows.RemoveAt(this.posicionDTG);
                LimpiarFormularioAlquiler();
                posicionCompra = int.Parse(lbl_IdCompra.Text);
                if (UsuarioControl.EliminarCompra(posicionCompra))
                {
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


        private void dtg_ListaDeVolquetes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.posicionDTG = e.RowIndex;

                if (this.posicionDTG != -1)
                {
                    this.btn_Modificar.Enabled = true;
                    this.btn_Eliminar.Enabled = true;
                    this.btn_AgregarALaLista.Enabled = false;
                    this.btn_HacerCompra.Enabled = false;

                    string tipo = (string)this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[0].Value;
                    string id = (string)this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[1].Value;
                    string precio = (string)this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[2].Value;
                    string dias = (string)this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[3].Value;
                    string cantidad = (string)this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[4].Value;
                    string fechaDeEntrega = (string)this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[5].Value;
                    string horaDeEntrega = (string)this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[6].Value;
                    string direccion = (string)this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[7].Value;

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
                this.btn_Modificar.Enabled = false;
                this.btn_AgregarALaLista.Enabled = true;
                this.btn_HacerCompra.Enabled = true;
                this.btn_Eliminar.Enabled = false;
                try
                {
                    if (this.cmBox_TiposVolquetes.SelectedIndex != -1 &&
                        this.numUD_CantidadDias.Value >= 1 &&
                        this.numUD_CantidadVolquetes.Value >= 1 &&
                        this.txt_FechaDeEntrega.Text != string.Empty &&
                        this.cmBox_HoraDeEntrega.SelectedIndex != -1 &&
                        this.txt_Direccion.Text != string.Empty)
                    {

                        string cadenaTipo = this.cmBox_TiposVolquetes.Text;
                        string cadenaPrecio = this.lbl_PrecioDelProducto.Text;
                        string cadenaDias = this.numUD_CantidadDias.Value.ToString();
                        string cadenaCantidad = this.numUD_CantidadVolquetes.Value.ToString();
                        string cadenaFechaDeEntrega = this.txt_FechaDeEntrega.Text;
                        string cadenaHoraDeEntrega = this.cmBox_HoraDeEntrega.Text;
                        string cadenaDireccion = this.txt_Direccion.Text;
                        string cadenaId = (string)this.dtg_ListaDeVolquetes.Rows[this.posicionDTG].Cells[1].Value;


                        string formato = "dd/MM/yyyy";
                        DateTime nuevaFecha = DateTime.ParseExact(cadenaFechaDeEntrega, formato, CultureInfo.InvariantCulture);
                        Compra nuevaCompra = null;
                        try
                        {
                            int cantidad = int.Parse(cadenaCantidad);
                            int dias = int.Parse(cadenaDias);
                            cadenaPrecio = cadenaPrecio.Replace("$", "");
                            float precio;//el problema esta aca , no se parsea bien 

                            if (float.TryParse(cadenaPrecio, out precio))
                            {
                                
                            }

                            int idCompra = int.Parse(cadenaId);

                            nuevaCompra = new(cadenaTipo, UsuarioControl.GetUsuario.Nombre, cantidad, dias,
                                nuevaFecha, cadenaHoraDeEntrega, cadenaDireccion, precio, idCompra);


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error con el objeto : " +ex.Message);       
    
                        }


                        if (nuevaCompra is not null)
                        {
                            if (CompraControl.ModificarPorId(nuevaCompra) && UsuarioControl.ModificarPorId(nuevaCompra))
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
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("NO selecciono un campo");
            }
        }

        private void CargarListaModificadaDTGV(int posicionDTGV, Compra auxCompra)
        {

            this.dtg_ListaDeVolquetes.Rows[posicionDTGV].Cells[0].Value = auxCompra.TipoVolquete;
            this.dtg_ListaDeVolquetes.Rows[posicionDTGV].Cells[1].Value = auxCompra.IdCompra;
            this.dtg_ListaDeVolquetes.Rows[posicionDTGV].Cells[2].Value = auxCompra.Precio;
            this.dtg_ListaDeVolquetes.Rows[posicionDTGV].Cells[3].Value = auxCompra.CantidadDias;
            this.dtg_ListaDeVolquetes.Rows[posicionDTGV].Cells[4].Value = auxCompra.CantidadVolquetes;
            this.dtg_ListaDeVolquetes.Rows[posicionDTGV].Cells[5].Value = auxCompra.FechaDeEntraga;
            this.dtg_ListaDeVolquetes.Rows[posicionDTGV].Cells[6].Value = auxCompra.HoraDeEntrega;
            this.dtg_ListaDeVolquetes.Rows[posicionDTGV].Cells[7].Value = auxCompra.Direccion;

        }


    }
}
