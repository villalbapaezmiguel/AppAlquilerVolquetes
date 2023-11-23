using Entidades;
using Entidades.EntidadesControl;
using Entidades.EntidadesUsuarios;
using System.IO;

namespace Formulario
{
    public partial class FormRegistrar : Form
    {
        public FormRegistrar()
        {
            InitializeComponent();

        }


        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private bool ValidarCampos(string nombreUsuario, string clave, string nombre, string apellido, string cadenaTelefono, string cadenaDNI)
        {
            try
            {
                double numeroTelefono = double.Parse(cadenaTelefono);
                double dni = double.Parse(cadenaDNI);
                
                try
                {
                    if (nombreUsuario is not null && clave is not null && nombre is not null && apellido is not null)
                    {
                        if(ValidarCantidadCaracter(nombreUsuario , 5))
                        {
                            if(ValidarMayusculaEnCadena(nombre, nombre.ToUpper()[0]) &&
                            ValidarMayusculaEnCadena(nombre, nombre.ToUpper()[0]))
                            {
                                return true;    
                            }
                            else
                            {
                                MessageBox.Show("El nombre y apellido debe de empezar con Mayusculas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El nombre de usuario es muy corto....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex )
                {
                    ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                    "Desconocido...",
                    DateTime.Now,
                    ex.Message,
                    "FormRegistrar",
                    "private bool ValidarCampos(string nombreUsuario, string clave, string nombre, string apellido, string cadenaTelefono, string cadenaDNI)");
                    MessageBox.Show("Hay campos vacios...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                this.txt_NumeroDeTelefono.Focus();
                this.txt_DNI.Focus();

                MessageBox.Show("Telefono o DNI no pueden ser texto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return false;
        }

        private bool ValidarMayusculaEnCadena(string cadena , char mayuscula)
        {
            try
            {
                if (cadena is not null)
                {
                    if (cadena[0] == mayuscula)
                    {
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Desconocido...",
                DateTime.Now,
                ex.Message,
                "FormRegistrar",
                "private bool ValidarMayusculaEnCadena(string cadena , char mayuscula)");
                MessageBox.Show("Hay campos vacios","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }

                return false;

        }

        private bool ValidarCantidadCaracter(string cadena, int largo)
        {
            try
            {
                if(cadena is not null )
                {
                    if(cadena.Length >= largo )
                    {
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Desconocido...",
                DateTime.Now,
                ex.Message,
                "FormRegistrar",
                "private bool ValidarCantidadCaracter(string cadena, int largo)");

            }


            return false;
        }


        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos(txt_NombreUsuario.Text, txt_Clave.Text, txt_Nombre.Text, txt_Apellido.Text, txt_NumeroDeTelefono.Text, txt_DNI.Text))
                {

                    if (txt_Clave.Text == txt_ClaveRepita.Text)
                    {
                        Usuario nuevo = new Usuario(txt_NombreUsuario.Text,
                        txt_Clave.Text,
                        double.Parse(txt_NumeroDeTelefono.Text),
                        txt_Apellido.Text,
                        txt_Nombre.Text,
                        double.Parse(txt_DNI.Text),
                        ControlApp.NuevoIdUsuario()
                        );

                        if (!UsuarioControl.ExisteUsuario(txt_NombreUsuario.Text))
                        {
                            if (UsuarioControl.AgregarUsuario(nuevo))
                            {
                                string path = @"C:\Users\villa\Desktop\PracticaLaboDos\AppAlquilerVolquetes\Volquete\Archivos\Carpeta del admin";
                                string rutaJSON = path + @$"\ListaUsuarios.json";
                                AdminControl.adminActual.ListaUsuarios.Add(nuevo);
                                UsuarioBD.GuardarDB(nuevo);
                                Serializar.SerializarJSON_ListaUsuario(rutaJSON, AdminControl.adminActual.ListaUsuarios);

                                MessageBox.Show("Se agrego corrctamente", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //UsuarioControl.SetUsuario = nuevo;
                                this.Close();
                                FormLogin formLogin = new FormLogin();
                                formLogin.Show();
                            }
                            else
                            {
                                MessageBox.Show("ERROR al agregar el Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El nombre de usuario ya está en uso. Por favor, elige otro nombre de usuario. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        txt_Clave.Focus();

                        MessageBox.Show("Clave incorrecta...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                ControlApp.ControlGuardarError(ControlApp.rutaCarpetaArchivoErrores,
                "Desconocido...",
                DateTime.Now,
                ex.Message,
                "FormRegistrar",
                "private void btn_Registrar_Click(object sender, EventArgs e)");

                MessageBox.Show(ex.Message);

            }

        }
    }
}
