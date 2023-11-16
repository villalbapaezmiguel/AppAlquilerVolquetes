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
                this.dtgv_Datos.DataSource = AdminControl.GetListaUsuario;//cambiar por admin
                this.panel_Volquete.Visible = false;
                this.panel_Compra.Visible = false;
                this.panel_Usuario.Visible = true;
                this.botonSeleccionado = "Usuario";
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

                        cadenaId = this.txt_UsuarioId.Text;
                        if (int.TryParse(cadenaId, out int idUsuario) &&
                            double.TryParse(cadenaTelefono, out double telefono) &&
                            double.TryParse(cadenaDni, out double dni))
                        {

                            Usuario aux = new Usuario(nombreUsuario, clave, telefono, nombre, apellido, dni, idUsuario);
                            //AdminControl.BuscarPorIdUsuario(idUsuario);

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
                            Volquete auxVolquete = VolqueteControl.EncontrarPorId(idVolquete);
                            /*moficar todos los campos de este volquete , tomarlos de los texbox*/

                            if (AdminControl.ModificarVolquete(auxVolquete))
                            {
                                MessageBox.Show("Se MODIFICO el Volquete con exito..", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("NO SE PUDO MODIFICICAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    
                }

            }
            catch (Exception ex )
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
                    int idVolquete = (int)this.dtgv_Datos.Rows[posicionDTG].Cells[4].Value;

                    this.txt_VolquetePrecio.Text = precio.ToString();
                    this.txt_VolqueteTipoVolquete.Text = tipoVolquete.ToString();
                    this.txt_VolqueteCapacidad.Text = capacidad.ToString();
                    this.txt_VolqueteObservacion.Text = observacion.ToString();
                    this.txt_VolqueteId.Text = idVolquete.ToString();


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




        private void dtgv_Datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.posicionDTG = e.RowIndex;
                if (this.posicionDTG != -1)
                {

                    CargarTexbox(this.botonSeleccionado, this.posicionDTG);
                    this.btn_Eliminar.Enabled = true;
                    this.btn_Editar.Enabled = true;
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


                string tipoVolquete = this.txt_VolqueteTipoVolquete.Text;
                string cadenaPrecio = this.txt_VolquetePrecio.Text;
                string cadenaCapacidad = this.txt_VolqueteCapacidad.Text;
                string observacion = this.txt_VolqueteObservacion.Text;
                string cadenaIdVolquete = this.txt_VolqueteId.Text;

                switch(this.botonSeleccionado)
                {
                    case "Usuario":
                        try
                        {
                            if (double.TryParse(cadenaTelefono, out double telefono) &&
                                double.TryParse(cadenaDni, out double dni) &&
                                int.TryParse(cadenaId, out int id))
                            {
                                AdminControl.AgrergarUsuario(new Usuario(nombreUsuario, clave, telefono, nombre, apellido, dni, id));
                                ControlApp.ControlAgregarUsuario(new Usuario(nombreUsuario, clave, telefono, nombre, apellido, dni, id));
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
    }
}
