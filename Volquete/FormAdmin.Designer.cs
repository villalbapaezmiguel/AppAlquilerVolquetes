namespace Vista
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            panel_InformacionDatos = new Panel();
            btn_Eliminar = new Button();
            dtgv_Datos = new DataGridView();
            btn_Editar = new Button();
            panel_IngresosDatos = new Panel();
            btn_Guardar = new Button();
            textBox4 = new TextBox();
            txt_Observacion = new TextBox();
            txt_Capacidad = new TextBox();
            txt_Precio = new TextBox();
            txt_TipoVolquete = new TextBox();
            panel_Cabecera = new Panel();
            btn_Compras = new Button();
            btn_Usuarios = new Button();
            btn_Volquetes = new Button();
            pic_Cerrar = new PictureBox();
            txt_NombreUsuario = new TextBox();
            txt_Clave = new TextBox();
            txt_Telefono = new TextBox();
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            txt_Dni = new TextBox();
            txt_Id = new TextBox();
            txt_PrecioCompra = new TextBox();
            txt_DIreccion = new TextBox();
            txt_FechaDeEntrga = new TextBox();
            txt_Dias = new TextBox();
            txt_Cantidad = new TextBox();
            txt_Usuario = new TextBox();
            txt_Volquete = new TextBox();
            txt_IdCompra = new TextBox();
            panel_InformacionDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_Datos).BeginInit();
            panel_IngresosDatos.SuspendLayout();
            panel_Cabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Cerrar).BeginInit();
            SuspendLayout();
            // 
            // panel_InformacionDatos
            // 
            panel_InformacionDatos.BackColor = Color.FromArgb(39, 57, 70);
            panel_InformacionDatos.Controls.Add(txt_IdCompra);
            panel_InformacionDatos.Controls.Add(txt_PrecioCompra);
            panel_InformacionDatos.Controls.Add(txt_DIreccion);
            panel_InformacionDatos.Controls.Add(txt_FechaDeEntrga);
            panel_InformacionDatos.Controls.Add(txt_Dias);
            panel_InformacionDatos.Controls.Add(txt_Cantidad);
            panel_InformacionDatos.Controls.Add(txt_Usuario);
            panel_InformacionDatos.Controls.Add(txt_Volquete);
            panel_InformacionDatos.Controls.Add(txt_Id);
            panel_InformacionDatos.Controls.Add(txt_Dni);
            panel_InformacionDatos.Controls.Add(txt_Apellido);
            panel_InformacionDatos.Controls.Add(txt_Nombre);
            panel_InformacionDatos.Controls.Add(txt_Telefono);
            panel_InformacionDatos.Controls.Add(txt_Clave);
            panel_InformacionDatos.Controls.Add(txt_NombreUsuario);
            panel_InformacionDatos.Controls.Add(btn_Eliminar);
            panel_InformacionDatos.Controls.Add(dtgv_Datos);
            panel_InformacionDatos.Controls.Add(btn_Editar);
            panel_InformacionDatos.Controls.Add(panel_IngresosDatos);
            panel_InformacionDatos.Controls.Add(panel_Cabecera);
            panel_InformacionDatos.Dock = DockStyle.Fill;
            panel_InformacionDatos.Location = new Point(0, 0);
            panel_InformacionDatos.Name = "panel_InformacionDatos";
            panel_InformacionDatos.Size = new Size(895, 359);
            panel_InformacionDatos.TabIndex = 0;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Cursor = Cursors.Hand;
            btn_Eliminar.FlatStyle = FlatStyle.Popup;
            btn_Eliminar.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Eliminar.Location = new Point(110, 324);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(75, 23);
            btn_Eliminar.TabIndex = 5;
            btn_Eliminar.Text = "ELIMINAR";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // dtgv_Datos
            // 
            dtgv_Datos.BackgroundColor = Color.FromArgb(45, 66, 91);
            dtgv_Datos.BorderStyle = BorderStyle.None;
            dtgv_Datos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_Datos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Constantia", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgv_Datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgv_Datos.ColumnHeadersHeight = 30;
            dtgv_Datos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgv_Datos.Cursor = Cursors.Hand;
            dtgv_Datos.EnableHeadersVisualStyles = false;
            dtgv_Datos.GridColor = Color.SteelBlue;
            dtgv_Datos.Location = new Point(3, 71);
            dtgv_Datos.Name = "dtgv_Datos";
            dtgv_Datos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dtgv_Datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dtgv_Datos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle6.Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dtgv_Datos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dtgv_Datos.RowTemplate.Height = 25;
            dtgv_Datos.Size = new Size(585, 247);
            dtgv_Datos.TabIndex = 4;
            // 
            // btn_Editar
            // 
            btn_Editar.Cursor = Cursors.Hand;
            btn_Editar.FlatStyle = FlatStyle.Popup;
            btn_Editar.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Editar.Location = new Point(12, 324);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(75, 23);
            btn_Editar.TabIndex = 3;
            btn_Editar.Text = "EDITAR";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // panel_IngresosDatos
            // 
            panel_IngresosDatos.BackColor = Color.FromArgb(39, 57, 80);
            panel_IngresosDatos.BackgroundImage = (Image)resources.GetObject("panel_IngresosDatos.BackgroundImage");
            panel_IngresosDatos.BackgroundImageLayout = ImageLayout.Zoom;
            panel_IngresosDatos.BorderStyle = BorderStyle.FixedSingle;
            panel_IngresosDatos.Controls.Add(btn_Guardar);
            panel_IngresosDatos.Controls.Add(textBox4);
            panel_IngresosDatos.Controls.Add(txt_Observacion);
            panel_IngresosDatos.Controls.Add(txt_Capacidad);
            panel_IngresosDatos.Controls.Add(txt_Precio);
            panel_IngresosDatos.Controls.Add(txt_TipoVolquete);
            panel_IngresosDatos.Dock = DockStyle.Right;
            panel_IngresosDatos.Location = new Point(594, 40);
            panel_IngresosDatos.Name = "panel_IngresosDatos";
            panel_IngresosDatos.Size = new Size(301, 319);
            panel_IngresosDatos.TabIndex = 2;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Cursor = Cursors.Hand;
            btn_Guardar.FlatStyle = FlatStyle.Popup;
            btn_Guardar.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Guardar.Location = new Point(33, 255);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(239, 33);
            btn_Guardar.TabIndex = 9;
            btn_Guardar.Text = "GUARDAR";
            btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(33, 163);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "TIPO DE VOLQUETE";
            textBox4.Size = new Size(239, 23);
            textBox4.TabIndex = 4;
            textBox4.Visible = false;
            // 
            // txt_Observacion
            // 
            txt_Observacion.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Observacion.Location = new Point(33, 128);
            txt_Observacion.Name = "txt_Observacion";
            txt_Observacion.PlaceholderText = "OBSERVACION";
            txt_Observacion.Size = new Size(239, 23);
            txt_Observacion.TabIndex = 3;
            txt_Observacion.Visible = false;
            // 
            // txt_Capacidad
            // 
            txt_Capacidad.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Capacidad.Location = new Point(33, 90);
            txt_Capacidad.Name = "txt_Capacidad";
            txt_Capacidad.PlaceholderText = "CAPACIDAD";
            txt_Capacidad.Size = new Size(239, 23);
            txt_Capacidad.TabIndex = 2;
            txt_Capacidad.Visible = false;
            // 
            // txt_Precio
            // 
            txt_Precio.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Precio.Location = new Point(33, 54);
            txt_Precio.Name = "txt_Precio";
            txt_Precio.PlaceholderText = "PRECIO";
            txt_Precio.Size = new Size(239, 23);
            txt_Precio.TabIndex = 1;
            txt_Precio.Visible = false;
            // 
            // txt_TipoVolquete
            // 
            txt_TipoVolquete.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_TipoVolquete.Location = new Point(33, 19);
            txt_TipoVolquete.Name = "txt_TipoVolquete";
            txt_TipoVolquete.PlaceholderText = "TIPO DE VOLQUETE";
            txt_TipoVolquete.Size = new Size(239, 23);
            txt_TipoVolquete.TabIndex = 0;
            txt_TipoVolquete.Visible = false;
            // 
            // panel_Cabecera
            // 
            panel_Cabecera.BackColor = Color.FromArgb(39, 57, 90);
            panel_Cabecera.BorderStyle = BorderStyle.FixedSingle;
            panel_Cabecera.Controls.Add(btn_Compras);
            panel_Cabecera.Controls.Add(btn_Usuarios);
            panel_Cabecera.Controls.Add(btn_Volquetes);
            panel_Cabecera.Controls.Add(pic_Cerrar);
            panel_Cabecera.Dock = DockStyle.Top;
            panel_Cabecera.Location = new Point(0, 0);
            panel_Cabecera.Name = "panel_Cabecera";
            panel_Cabecera.Size = new Size(895, 40);
            panel_Cabecera.TabIndex = 1;
            // 
            // btn_Compras
            // 
            btn_Compras.Cursor = Cursors.Hand;
            btn_Compras.FlatStyle = FlatStyle.Popup;
            btn_Compras.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Compras.Location = new Point(259, 8);
            btn_Compras.Name = "btn_Compras";
            btn_Compras.Size = new Size(101, 23);
            btn_Compras.TabIndex = 8;
            btn_Compras.Text = "COMPRAS";
            btn_Compras.UseVisualStyleBackColor = true;
            btn_Compras.Click += btn_Compras_Click;
            // 
            // btn_Usuarios
            // 
            btn_Usuarios.Cursor = Cursors.Hand;
            btn_Usuarios.FlatStyle = FlatStyle.Popup;
            btn_Usuarios.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Usuarios.Location = new Point(135, 8);
            btn_Usuarios.Name = "btn_Usuarios";
            btn_Usuarios.Size = new Size(101, 23);
            btn_Usuarios.TabIndex = 7;
            btn_Usuarios.Text = "USUARIOS";
            btn_Usuarios.UseVisualStyleBackColor = true;
            btn_Usuarios.Click += btn_Usuarios_Click;
            // 
            // btn_Volquetes
            // 
            btn_Volquetes.Cursor = Cursors.Hand;
            btn_Volquetes.FlatStyle = FlatStyle.Popup;
            btn_Volquetes.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Volquetes.Location = new Point(12, 8);
            btn_Volquetes.Name = "btn_Volquetes";
            btn_Volquetes.Size = new Size(101, 23);
            btn_Volquetes.TabIndex = 6;
            btn_Volquetes.Text = "VOLQUETES";
            btn_Volquetes.UseVisualStyleBackColor = true;
            btn_Volquetes.Click += btn_Volquetes_Click;
            // 
            // pic_Cerrar
            // 
            pic_Cerrar.BackgroundImage = (Image)resources.GetObject("pic_Cerrar.BackgroundImage");
            pic_Cerrar.BackgroundImageLayout = ImageLayout.Zoom;
            pic_Cerrar.Cursor = Cursors.Hand;
            pic_Cerrar.Location = new Point(867, 0);
            pic_Cerrar.Name = "pic_Cerrar";
            pic_Cerrar.Size = new Size(25, 25);
            pic_Cerrar.TabIndex = 3;
            pic_Cerrar.TabStop = false;
            pic_Cerrar.Click += pic_Cerrar_Click;
            // 
            // txt_NombreUsuario
            // 
            txt_NombreUsuario.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_NombreUsuario.Location = new Point(349, 71);
            txt_NombreUsuario.Name = "txt_NombreUsuario";
            txt_NombreUsuario.PlaceholderText = "USUARIO";
            txt_NombreUsuario.Size = new Size(239, 23);
            txt_NombreUsuario.TabIndex = 10;
            txt_NombreUsuario.Visible = false;
            // 
            // txt_Clave
            // 
            txt_Clave.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Clave.Location = new Point(349, 100);
            txt_Clave.Name = "txt_Clave";
            txt_Clave.PlaceholderText = "CLAVE";
            txt_Clave.Size = new Size(239, 23);
            txt_Clave.TabIndex = 11;
            txt_Clave.Visible = false;
            // 
            // txt_Telefono
            // 
            txt_Telefono.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Telefono.Location = new Point(349, 131);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.PlaceholderText = "TELEFONO";
            txt_Telefono.Size = new Size(239, 23);
            txt_Telefono.TabIndex = 12;
            txt_Telefono.Visible = false;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Nombre.Location = new Point(349, 160);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.PlaceholderText = "NOMBRE";
            txt_Nombre.Size = new Size(239, 23);
            txt_Nombre.TabIndex = 13;
            txt_Nombre.Visible = false;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Apellido.Location = new Point(349, 189);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.PlaceholderText = "APELLIDO";
            txt_Apellido.Size = new Size(239, 23);
            txt_Apellido.TabIndex = 14;
            txt_Apellido.Visible = false;
            // 
            // txt_Dni
            // 
            txt_Dni.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Dni.Location = new Point(349, 218);
            txt_Dni.Name = "txt_Dni";
            txt_Dni.PlaceholderText = "DNI";
            txt_Dni.Size = new Size(239, 23);
            txt_Dni.TabIndex = 15;
            txt_Dni.Visible = false;
            // 
            // txt_Id
            // 
            txt_Id.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Id.Location = new Point(349, 247);
            txt_Id.Name = "txt_Id";
            txt_Id.PlaceholderText = "ID";
            txt_Id.Size = new Size(239, 23);
            txt_Id.TabIndex = 16;
            txt_Id.Visible = false;
            // 
            // txt_PrecioCompra
            // 
            txt_PrecioCompra.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_PrecioCompra.Location = new Point(104, 247);
            txt_PrecioCompra.Name = "txt_PrecioCompra";
            txt_PrecioCompra.PlaceholderText = "PRECIO";
            txt_PrecioCompra.Size = new Size(239, 23);
            txt_PrecioCompra.TabIndex = 23;
            txt_PrecioCompra.Visible = false;
            // 
            // txt_DIreccion
            // 
            txt_DIreccion.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_DIreccion.Location = new Point(104, 218);
            txt_DIreccion.Name = "txt_DIreccion";
            txt_DIreccion.PlaceholderText = "DIRECCION";
            txt_DIreccion.Size = new Size(239, 23);
            txt_DIreccion.TabIndex = 22;
            txt_DIreccion.Visible = false;
            // 
            // txt_FechaDeEntrga
            // 
            txt_FechaDeEntrga.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_FechaDeEntrga.Location = new Point(104, 189);
            txt_FechaDeEntrga.Name = "txt_FechaDeEntrga";
            txt_FechaDeEntrga.PlaceholderText = "FECHA DE ENTRAGA";
            txt_FechaDeEntrga.Size = new Size(239, 23);
            txt_FechaDeEntrga.TabIndex = 21;
            txt_FechaDeEntrga.Visible = false;
            // 
            // txt_Dias
            // 
            txt_Dias.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Dias.Location = new Point(104, 160);
            txt_Dias.Name = "txt_Dias";
            txt_Dias.PlaceholderText = "DIAS";
            txt_Dias.Size = new Size(239, 23);
            txt_Dias.TabIndex = 20;
            txt_Dias.Visible = false;
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Cantidad.Location = new Point(104, 131);
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.PlaceholderText = "CANTIDAD ";
            txt_Cantidad.Size = new Size(239, 23);
            txt_Cantidad.TabIndex = 19;
            txt_Cantidad.Visible = false;
            // 
            // txt_Usuario
            // 
            txt_Usuario.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Usuario.Location = new Point(104, 100);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.PlaceholderText = "USUARIO";
            txt_Usuario.Size = new Size(239, 23);
            txt_Usuario.TabIndex = 18;
            txt_Usuario.Visible = false;
            // 
            // txt_Volquete
            // 
            txt_Volquete.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Volquete.Location = new Point(104, 71);
            txt_Volquete.Name = "txt_Volquete";
            txt_Volquete.PlaceholderText = "VOLQUETE";
            txt_Volquete.Size = new Size(239, 23);
            txt_Volquete.TabIndex = 17;
            txt_Volquete.Visible = false;
            // 
            // txt_IdCompra
            // 
            txt_IdCompra.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_IdCompra.Location = new Point(104, 276);
            txt_IdCompra.Name = "txt_IdCompra";
            txt_IdCompra.PlaceholderText = "ID COMPRA";
            txt_IdCompra.Size = new Size(239, 23);
            txt_IdCompra.TabIndex = 24;
            txt_IdCompra.Visible = false;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 359);
            Controls.Add(panel_InformacionDatos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmin";
            Load += FormAdmin_Load;
            panel_InformacionDatos.ResumeLayout(false);
            panel_InformacionDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_Datos).EndInit();
            panel_IngresosDatos.ResumeLayout(false);
            panel_IngresosDatos.PerformLayout();
            panel_Cabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Cerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_InformacionDatos;
        private TextBox txt_TipoVolquete;
        private Panel panel_Cabecera;
        private Panel panel_IngresosDatos;
        private PictureBox pic_Cerrar;
        private Button btn_Editar;
        private DataGridView dtgv_Datos;
        private Button btn_Eliminar;
        private Button btn_Volquetes;
        private Button btn_Usuarios;
        private Button btn_Compras;
        private TextBox textBox4;
        private TextBox txt_Observacion;
        private TextBox txt_Capacidad;
        private TextBox txt_Precio;
        private Button btn_Guardar;
        private TextBox txt_NombreUsuario;
        private TextBox txt_Clave;
        private TextBox txt_Telefono;
        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private TextBox txt_Dni;
        private TextBox txt_Id;
        private TextBox txt_PrecioCompra;
        private TextBox txt_DIreccion;
        private TextBox txt_FechaDeEntrga;
        private TextBox txt_Dias;
        private TextBox txt_Cantidad;
        private TextBox txt_Usuario;
        private TextBox txt_Volquete;
        private TextBox txt_IdCompra;
    }
}