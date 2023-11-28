﻿using ConsolaGenericos.Serializadores;
using Entidades;
using Entidades.EntidadesBD;
using Entidades.EntidadesControl;
using Entidades.EntidadesUsuarios;
using Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
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
            try
            {
                this.Close();
                FormLogin formLogin = new FormLogin();
                formLogin.ShowDialog();
            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                    "Admin",
                    DateTime.Now,
                    ex.Message,
                    "FormAdmin",
                    "private void pic_Cerrar_Click(object sender, EventArgs e)");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_Volquetes_Click(object sender, EventArgs e)
        {
            try
            {
                this.dtgv_Datos.DataSource = VolqueteBD.LeerDB();
                this.panel_Volquete.Visible = true;
                this.panel_Compra.Visible = false;
                this.panel_Usuario.Visible = false;
                this.botonSeleccionado = "Volquete";
                this.btn_Agregar.Enabled = true;
                LimpiarTexboxVolquete();
            }
            catch (Exception ex)
            {

                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Admin",
                DateTime.Now,
                ex.Message,
                "FormAdmin",
                "private void btn_Volquetes_Click(object sender, EventArgs e)");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            try
            {
                this.dtgv_Datos.DataSource = UsuarioBD.LeerDB();
                this.panel_Volquete.Visible = false;
                this.panel_Compra.Visible = false;
                this.panel_Usuario.Visible = true;
                this.botonSeleccionado = "Usuario";
                this.btn_Agregar.Enabled = true;
                LimpiarTexboxUsuario();
            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Admin",
                DateTime.Now,
                ex.Message,
                "FormAdmin",
                "private void btn_Usuarios_Click(object sender, EventArgs e)");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Compras_Click(object sender, EventArgs e)
        {
            try
            {
                this.panel_Volquete.Visible = false;
                this.panel_Compra.Visible = true;
                this.panel_Usuario.Visible = false;
                this.botonSeleccionado = "Compra";
                this.dtgv_Datos.DataSource = CompraBD.LeerDB();
                this.btn_Agregar.Enabled = false;
                LimpiarTexBoxCompra();
            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Admin",
                DateTime.Now,
                $"{ex.Message}",
                "FormAdmin",
                "private void btn_Compras_Click(object sender, EventArgs e)");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }//problemas con la serializacion 


        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                string cadenaId;
                switch (this.botonSeleccionado)
                {
                    case "Usuario":
                        string nombreUsuario = this.txt_UsuarioNombreUsuario.Text;
                        string clave = this.txt_UsuarioClave.Text;
                        string nombre = this.txt_UsuarioNombre.Text;
                        string apellido = this.txt_UsuarioApellido.Text;
                        string cadenaTelefono = this.txt_UsuarioTelefono.Text;
                        string cadenaDni = this.txt_UsuarioDni.Text;
                        string cadenaModoOscuor = this.lbl_FondoColorUsuario.Text;
                        string cadenaIdCompra = this.txt_UsuarioIdCompra.Text;
                        cadenaId = this.txt_UsuarioId.Text;


                        if (int.TryParse(cadenaId, out int idUsuario) &&
                            double.TryParse(cadenaTelefono, out double telefono) &&
                            double.TryParse(cadenaDni, out double dni) &&
                            bool.TryParse(cadenaModoOscuor, out bool modoOscuro) &&
                            int.TryParse(cadenaIdCompra, out int idCompra))
                        {
                            Usuario aux = new Usuario(nombreUsuario, clave, telefono, nombre, apellido, dni, idUsuario, modoOscuro);

                            if (AdminControl.ModificarUsuario(aux))
                            {
                                RefrezcarDTG_Usuario();
                                MessageBox.Show("Se MODIFICO el Usuario con exito..", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("NO SE PUDO MODIFICAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        break;
                    case "Volquete":
                        cadenaId = this.txt_VolqueteId.Text;
                        if (int.TryParse(cadenaId, out int idVolquete))
                        {
                            //string tipoVolquete , float precio , float capacidad , string observacion, int id
                            string tipoVolquete = this.txt_VolqueteTipoVolquete.Text;
                            string cadenaPrecio = this.txt_VolquetePrecio.Text;
                            string cadenaCapacidad = this.txt_VolqueteCapacidad.Text;
                            string observacion = this.txt_VolqueteObservacion.Text;
                            if (float.TryParse(cadenaPrecio, out float precio) &&
                                float.TryParse(cadenaCapacidad, out float capacidad))
                            {
                                Volquete auxVolquete = new Volquete(tipoVolquete, precio, capacidad, observacion, idVolquete);
                                if (AdminControl.ModificarVolquete(auxVolquete))
                                {
                                    MessageBox.Show("Se MODIFICO el Volquete con exito..", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("NO SE PUDO MODIFICICAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                        }
                        break;

                }

            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Admin",
                DateTime.Now,
                ex.Message,
                "FormAdmin",
                "private void btn_Usuarios_Click(object sender, EventArgs e)");
                MessageBox.Show("NO SE PUDO MODIFICAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

            try
            {
                string cadenaId;
                switch (this.botonSeleccionado)
                {
                    case "Usuario":

                        cadenaId = this.txt_UsuarioId.Text;
                        if (int.TryParse(cadenaId, out int idUsuario))
                        {
                            if (AdminControl.EliminarUsuario(idUsuario))
                            {
                                RefrezcarDTG_Usuario();
                                MessageBox.Show("Se elimino el Usuario con exito..", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("NO SE PUDO ELIMINAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        break;
                    case "Volquete":
                        cadenaId = this.txt_VolqueteId.Text;
                        if (int.TryParse(cadenaId, out int idVolquete))
                        {
                            if (AdminControl.EliminarVolquete(idVolquete))
                            {
                                MessageBox.Show("Se elimino el Volquete con exito..", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("NO SE PUDO ELIMINAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                }

            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Admin",
                DateTime.Now,
                ex.Message,
                "FormAdmin",
                "private void btn_Eliminar_Click(object sender, EventArgs e)");
                MessageBox.Show("NO SE PUDO ELIMINAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            try
            {

                this.btn_Editar.Enabled = false;
                this.btn_Eliminar.Enabled = false;
                this.txt_UsuarioId.ReadOnly = true;
                this.txt_UsuarioIdCompra.ReadOnly = true;
                AdminControl.adminActual.ListaUsuarios = ControlApp.GetListaUsuarios;

            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Admin",
                DateTime.Now,
                ex.Message,
                "FormAdmin",
                "private void FormAdmin_Load(object sender, EventArgs e)");

                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void CargarTexbox(string seleccion, int posicionDTG)
        {
            try
            {
                switch (seleccion)
                {
                    case "Usuario":
                        this.btn_Agregar.Enabled = true;
                        //bool modoOscuro;
                        this.txt_UsuarioNombreUsuario.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[0].Value.ToString();
                        this.txt_UsuarioClave.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[1].Value.ToString();
                        this.txt_UsuarioTelefono.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[2].Value.ToString();
                        this.txt_UsuarioId.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[3].Value.ToString();
                        this.lbl_FondoColorUsuario.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[4].Value.ToString();
                        this.txt_UsuarioIdCompra.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[5].Value.ToString();
                        this.txt_UsuarioNombre.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[6].Value.ToString();
                        this.txt_UsuarioApellido.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[7].Value.ToString();
                        this.txt_UsuarioDni.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[8].Value.ToString();
                        this.btn_Editar.Enabled = true;
                        this.btn_Eliminar.Enabled = true;
                        break;

                    case "Volquete":
                        this.btn_Agregar.Enabled = true;

                        this.txt_VolquetePrecio.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[0].Value.ToString();
                        this.txt_VolqueteTipoVolquete.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[1].Value.ToString();
                        this.txt_VolqueteCapacidad.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[2].Value.ToString();
                        this.txt_VolqueteObservacion.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[3].Value.ToString();
                        this.txt_VolqueteId.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[4].Value.ToString();

                        this.btn_Editar.Enabled = true;
                        this.btn_Eliminar.Enabled = true;
                        break;

                    case "Compra":

                        this.txt_CompraCantidad.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[0].Value.ToString();
                        this.txt_CompraDias.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[1].Value.ToString();
                        this.txt_CompraFechaDeEntrga.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[2].Value.ToString();
                        this.txt_CompraHorario.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[3].Value.ToString();
                        this.txt_CompraDIreccion.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[4].Value.ToString();
                        this.txt_CompraPrecioCompra.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[5].Value.ToString();
                        this.txt_CompraIdVolquete.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[6].Value.ToString();
                        this.txt_CompraIdUsuario.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[7].Value.ToString();
                        this.txt_CompraIdCompra.Text = this.dtgv_Datos.Rows[posicionDTG].Cells[8].Value.ToString();


                        this.btn_Editar.Enabled = false;
                        this.btn_Eliminar.Enabled = false;
                        this.btn_Agregar.Enabled = false;


                        break;
                }

            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Admin",
                DateTime.Now,
                ex.Message,
                "FormAdmin",
                "private void CargarTexbox(string seleccion, int posicionDTG)");
                MessageBox.Show($"Error {ex.Message} ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void LimpiarTexBoxCompra()
        {

            this.txt_CompraIdVolquete.Text = string.Empty;
            this.txt_CompraCantidad.Text = string.Empty;
            this.txt_CompraDias.Text = string.Empty;
            this.txt_CompraFechaDeEntrga.Text = string.Empty;
            this.txt_CompraHorario.Text = string.Empty;
            this.txt_CompraDIreccion.Text = string.Empty;
            this.txt_CompraPrecioCompra.Text = string.Empty;
            this.txt_CompraIdCompra.Text = string.Empty;
            this.txt_CompraIdUsuario.Text = string.Empty;
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
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Admin",
                DateTime.Now,
                ex.Message,
                "FormAdmin",
                "private void dtgv_Datos_CellClick(object sender, DataGridViewCellEventArgs e)");
                MessageBox.Show($"Error {ex.Message} ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarTexboxUsuario()
        {
            try
            {
                this.txt_UsuarioNombreUsuario.Text = string.Empty;
                this.txt_UsuarioClave.Text = string.Empty;
                this.txt_UsuarioTelefono.Text = string.Empty;
                this.txt_UsuarioNombre.Text = string.Empty;
                this.txt_UsuarioApellido.Text = string.Empty;
                this.txt_UsuarioDni.Text = string.Empty;
                this.txt_UsuarioId.Text = string.Empty;
            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Admin",
                DateTime.Now,
                ex.Message,
                "FormAlquilerVolquete",
                "private void LimpiarTexboxUsuario()");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void LimpiarTexboxVolquete()
        {
            try
            {
                this.txt_VolqueteTipoVolquete.Text = string.Empty;
                this.txt_VolqueteCapacidad.Text = string.Empty;
                this.txt_VolqueteId.Text = string.Empty;
                this.txt_VolquetePrecio.Text = string.Empty;
                this.txt_VolqueteObservacion.Text = string.Empty;
            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Admin",
                DateTime.Now,
                ex.Message,
                "FormAdmin",
                "private void LimpiarTexboxVolquete()");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            try
            {
                string nombreUsuario = this.txt_UsuarioNombreUsuario.Text;
                string clave = this.txt_UsuarioClave.Text;
                string cadenaTelefono = this.txt_UsuarioTelefono.Text;
                string nombre = this.txt_UsuarioNombre.Text;
                string apellido = this.txt_UsuarioApellido.Text;
                string cadenaDni = this.txt_UsuarioDni.Text;
                string cadenaId = this.txt_UsuarioId.Text;
                string cadenaIdCompra = this.txt_UsuarioIdCompra.Text;


                string tipoVolquete = this.txt_VolqueteTipoVolquete.Text;
                string cadenaPrecio = this.txt_VolquetePrecio.Text;
                string cadenaCapacidad = this.txt_VolqueteCapacidad.Text;
                string observacion = this.txt_VolqueteObservacion.Text;
                string cadenaIdVolquete = this.txt_VolqueteId.Text;

                switch (this.botonSeleccionado)
                {
                    case "Usuario":
                        try
                        {
                            if (double.TryParse(cadenaTelefono, out double telefono) &&
                                double.TryParse(cadenaDni, out double dni)
                                )
                            {
                                AdminControl.AgrergarUsuario(new Usuario(nombreUsuario, clave, telefono, nombre, apellido, dni, UsuarioBD.NuevoIdDB(), false));
                                ControlApp.ControlAgregarUsuario(new Usuario(nombreUsuario, clave, telefono, nombre, apellido, dni, UsuarioBD.NuevoIdDB(), false));
                                RefrezcarDTG_Usuario();
                                LimpiarTexboxUsuario();
                            }
                            else
                            {
                                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                                "Admin",
                                DateTime.Now,
                                "Al agregar un Usuario",
                                "FormAdmin",
                                "private void btn_Agregar_Click(object sender, EventArgs e)");
                                MessageBox.Show($"Error en agregar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                                "Admin",
                                DateTime.Now,
                                ex.Message,
                                "FormAdmin",
                                "private void btn_Agregar_Click(object sender, EventArgs e)");

                        }


                        break;
                    case "Volquete":
                        try
                        {
                            bool banderaPrecio = float.TryParse(cadenaPrecio, out float precio);
                            bool banderaCapacidad = float.TryParse(cadenaCapacidad, out float capacidad);
                            bool banderaId = int.TryParse(cadenaIdVolquete, out int idVolquete);

                            if (banderaPrecio &&
                                banderaCapacidad &&
                                banderaId)
                            {
                                AdminControl.AgrergarVolquete(new Volquete(tipoVolquete, precio, capacidad, observacion, idVolquete));
                                ControlApp.ControlAgregarVolquete(new Volquete(tipoVolquete, precio, capacidad, observacion, idVolquete));
                                RefrezcarDTG_Volquete();
                                LimpiarTexboxVolquete();
                            }
                            else
                            {
                                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                                "Admin",
                                DateTime.Now,
                                "Al agregar un volquete",
                                "FormAdmin",
                                "private void btn_Agregar_Click(object sender, EventArgs e)");
                                MessageBox.Show($"Error en agregar volquete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                            "Admin",
                            DateTime.Now,
                            ex.Message,
                            "FormAdmin",
                            "private void btn_Agregar_Click(object sender, EventArgs e)");
                        }


                        break;
                }
            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Admin",
                DateTime.Now,
                ex.Message,
                "FormAdmin",
                "private void btn_Agregar_Click(object sender, EventArgs e)");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void RefrezcarDTG_Volquete()
        {
            try
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = VolqueteBD.LeerDB();
                this.dtgv_Datos.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Admin",
                DateTime.Now,
                ex.Message,
                "FormAdmin",
                "private void RefrezcarDTG_Volquete()");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void RefrezcarDTG_Usuario()
        {
            try
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = UsuarioBD.LeerDB();
                this.dtgv_Datos.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Admin",
                DateTime.Now,
                ex.Message,
                "FormAdmin",
                "private void RefrezcarDTG_Usuario()");
                MessageBox.Show($"Error : {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaVolqueteXML = ControlApp.rutaCapetaArchivoImprido + "Volquete.xml";
                string rutaUsuarioXML = ControlApp.rutaCapetaArchivoImprido + "Usuario.xml";
                string rutaCompraXML = ControlApp.rutaCapetaArchivoImprido + "Compra.xml";


                switch (this.botonSeleccionado)
                {
                    case "Volquete":
                        var xmlSerializadorVolquete = new SerializadorXML<Volquete>(rutaVolqueteXML);

                        if (Directory.Exists(ControlApp.rutaCapetaArchivoImprido))
                        {
                            xmlSerializadorVolquete.Serializar(ControlApp.GetListaVolquetes);
                            MessageBox.Show("El archivo XML fue un exito!!!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                            "Admin",
                            DateTime.Now,
                            "ERROR al generar el archivo XML del objeto Volquete",
                            "FormAdmin",
                            "private void btn_Imprimir_Click(object sender, EventArgs e)");
                            MessageBox.Show($"Error : ERROR al generar el archivo XML del objeto Volquete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    case "Usuario":

                        var xmlSerializadorUsuario = new SerializadorXML<Usuario>(rutaUsuarioXML);

                        if (Directory.Exists(ControlApp.rutaCapetaArchivoImprido))
                        {
                            xmlSerializadorUsuario.Serializar(ControlApp.GetListaUsuarios);
                            MessageBox.Show("El archivo XML fue un exito!!!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                            "Admin",
                            DateTime.Now,
                            "ERROR al generar el archivo XML del objeto Usuario",
                            "FormAdmin",
                            "private void btn_Imprimir_Click(object sender, EventArgs e)");
                            MessageBox.Show($"Error : ERROR al generar el archivo XML del objeto Usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    case "Compra":
                        var xmlSerializadorCompra = new SerializadorXML<Compra>(rutaCompraXML);

                        if (Directory.Exists(ControlApp.rutaCapetaArchivoImprido))
                        {
                            xmlSerializadorCompra.Serializar(CompraBD.LeerDB());
                            MessageBox.Show("El archivo XML fue un exito!!!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                            "Admin",
                            DateTime.Now,
                            "ERROR al generar el archivo XML del objeto Compra",
                            "FormAdmin",
                            "private void btn_Imprimir_Click(object sender, EventArgs e)");
                            MessageBox.Show($"Error : ERROR al generar el archivo XML del objeto Compra", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;

                }

            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Admin",
                DateTime.Now,
                ex.Message,
                "FormAdmin",
                "private void btn_Imprimir_Click(object sender, EventArgs e)");

            }
        }

        private void btn_ImprimirJson_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaVolqueteJSON = ControlApp.rutaCapetaArchivoImprido + "Volquete.json";
                string rutaUsuarioJSON = ControlApp.rutaCapetaArchivoImprido + "Usuario.json";
                string rutaCompraJSON = ControlApp.rutaCapetaArchivoImprido + "Compra.json";


                switch (this.botonSeleccionado)
                {
                    case "Volquete":
                        var jsonSerializadorVolquete = new SerializadorJSON<Volquete>(rutaVolqueteJSON);

                        if (Directory.Exists(ControlApp.rutaCapetaArchivoImprido))
                        {
                            jsonSerializadorVolquete.Serializar(ControlApp.GetListaVolquetes);
                            MessageBox.Show("El archivo JSON fue un exito!!!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                            "Admin",
                            DateTime.Now,
                            "ERROR al generar el archivo JSON del objeto Volquete",
                            "FormAdmin",
                            "private void btn_ImprimirJson_Click(object sender, EventArgs e)");
                            MessageBox.Show($"Error : ERROR al generar el archivo JSON del objeto Volquete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    case "Usuario":

                        var jsonSerializadorUsuario = new SerializadorJSON<Usuario>(rutaUsuarioJSON);

                        if (Directory.Exists(ControlApp.rutaCapetaArchivoImprido))
                        {
                            jsonSerializadorUsuario.Serializar(ControlApp.GetListaUsuarios);
                            MessageBox.Show("El archivo JSON fue un exito!!!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                            "Admin",
                            DateTime.Now,
                            "ERROR al generar el archivo JSON del objeto Usuario",
                            "FormAdmin",
                            "private void btn_ImprimirJson_Click(object sender, EventArgs e)");
                            MessageBox.Show($"Error : ERROR al generar el archivo JSON del objeto Usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    case "Compra":
                        var jsonSerializadorCompra = new SerializadorJSON<Compra>(rutaCompraJSON);

                        if (Directory.Exists(ControlApp.rutaCapetaArchivoImprido))
                        {
                            jsonSerializadorCompra.Serializar(CompraBD.LeerDB());
                            MessageBox.Show("El archivo JSON fue un exito!!!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                            "Admin",
                            DateTime.Now,
                            "ERROR al generar el archivo XML del objeto Compra",
                            "FormAdmin",
                            "private void btn_ImprimirJson_Click(object sender, EventArgs e)");
                            MessageBox.Show($"Error : ERROR al generar el archivo JSON del objeto Compra", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;

                }

            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Admin",
                DateTime.Now,
                ex.Message,
                "FormAdmin",
                "private void btn_ImprimirJson_Click(object sender, EventArgs e)");

            }
        }
    }
}
