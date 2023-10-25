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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel_InformacionDatos = new Panel();
            panel_Compra = new Panel();
            txt_CompraHorario = new TextBox();
            txt_CompraVolquete = new TextBox();
            txt_CompraIdCompra = new TextBox();
            txt_CompraCantidad = new TextBox();
            txt_CompraFechaDeEntrga = new TextBox();
            txt_CompraDIreccion = new TextBox();
            txt_CompraUsuario = new TextBox();
            txt_CompraPrecioCompra = new TextBox();
            txt_CompraDias = new TextBox();
            panel_Volquete = new Panel();
            txt_VolqueteTipoVolquete = new TextBox();
            txt_VolqueteObservacion = new TextBox();
            txt_VolqueteCapacidad = new TextBox();
            txt_VolquetePrecio = new TextBox();
            panel_Usuario = new Panel();
            txt_UsuarioClave = new TextBox();
            txt_UsuarioNombreUsuario = new TextBox();
            txt_UsuarioDni = new TextBox();
            txt_UsuarioTelefono = new TextBox();
            txt_UsuarioId = new TextBox();
            txt_UsuarioNombre = new TextBox();
            txt_UsuarioApellido = new TextBox();
            btn_Guardar = new Button();
            btn_Eliminar = new Button();
            dtgv_Datos = new DataGridView();
            btn_Editar = new Button();
            panel_Datos = new Panel();
            panel_Cabecera = new Panel();
            btn_Compras = new Button();
            btn_Usuarios = new Button();
            btn_Volquetes = new Button();
            pic_Cerrar = new PictureBox();
            btn_Agregar = new Button();
            panel_InformacionDatos.SuspendLayout();
            panel_Compra.SuspendLayout();
            panel_Volquete.SuspendLayout();
            panel_Usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_Datos).BeginInit();
            panel_Cabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Cerrar).BeginInit();
            SuspendLayout();
            // 
            // panel_InformacionDatos
            // 
            panel_InformacionDatos.BackColor = Color.FromArgb(39, 57, 70);
            panel_InformacionDatos.Controls.Add(btn_Agregar);
            panel_InformacionDatos.Controls.Add(panel_Compra);
            panel_InformacionDatos.Controls.Add(panel_Volquete);
            panel_InformacionDatos.Controls.Add(panel_Usuario);
            panel_InformacionDatos.Controls.Add(btn_Guardar);
            panel_InformacionDatos.Controls.Add(btn_Eliminar);
            panel_InformacionDatos.Controls.Add(dtgv_Datos);
            panel_InformacionDatos.Controls.Add(btn_Editar);
            panel_InformacionDatos.Controls.Add(panel_Datos);
            panel_InformacionDatos.Controls.Add(panel_Cabecera);
            panel_InformacionDatos.Dock = DockStyle.Fill;
            panel_InformacionDatos.Location = new Point(0, 0);
            panel_InformacionDatos.Name = "panel_InformacionDatos";
            panel_InformacionDatos.Size = new Size(895, 359);
            panel_InformacionDatos.TabIndex = 0;
            // 
            // panel_Compra
            // 
            panel_Compra.BackColor = Color.FromArgb(39, 57, 80);
            panel_Compra.BackgroundImage = (Image)resources.GetObject("panel_Compra.BackgroundImage");
            panel_Compra.BackgroundImageLayout = ImageLayout.Zoom;
            panel_Compra.BorderStyle = BorderStyle.FixedSingle;
            panel_Compra.Controls.Add(txt_CompraHorario);
            panel_Compra.Controls.Add(txt_CompraVolquete);
            panel_Compra.Controls.Add(txt_CompraIdCompra);
            panel_Compra.Controls.Add(txt_CompraCantidad);
            panel_Compra.Controls.Add(txt_CompraFechaDeEntrga);
            panel_Compra.Controls.Add(txt_CompraDIreccion);
            panel_Compra.Controls.Add(txt_CompraUsuario);
            panel_Compra.Controls.Add(txt_CompraPrecioCompra);
            panel_Compra.Controls.Add(txt_CompraDias);
            panel_Compra.Location = new Point(592, 40);
            panel_Compra.Name = "panel_Compra";
            panel_Compra.Size = new Size(301, 278);
            panel_Compra.TabIndex = 12;
            panel_Compra.Visible = false;
            // 
            // txt_CompraHorario
            // 
            txt_CompraHorario.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_CompraHorario.Location = new Point(29, 243);
            txt_CompraHorario.Name = "txt_CompraHorario";
            txt_CompraHorario.PlaceholderText = "HORARIO DE ENTRGA";
            txt_CompraHorario.Size = new Size(239, 23);
            txt_CompraHorario.TabIndex = 25;
            // 
            // txt_CompraVolquete
            // 
            txt_CompraVolquete.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_CompraVolquete.Location = new Point(28, 9);
            txt_CompraVolquete.Name = "txt_CompraVolquete";
            txt_CompraVolquete.PlaceholderText = "VOLQUETE";
            txt_CompraVolquete.Size = new Size(239, 23);
            txt_CompraVolquete.TabIndex = 17;
            // 
            // txt_CompraIdCompra
            // 
            txt_CompraIdCompra.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_CompraIdCompra.Location = new Point(28, 214);
            txt_CompraIdCompra.Name = "txt_CompraIdCompra";
            txt_CompraIdCompra.PlaceholderText = "ID COMPRA";
            txt_CompraIdCompra.Size = new Size(239, 23);
            txt_CompraIdCompra.TabIndex = 24;
            // 
            // txt_CompraCantidad
            // 
            txt_CompraCantidad.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_CompraCantidad.Location = new Point(28, 69);
            txt_CompraCantidad.Name = "txt_CompraCantidad";
            txt_CompraCantidad.PlaceholderText = "CANTIDAD ";
            txt_CompraCantidad.Size = new Size(239, 23);
            txt_CompraCantidad.TabIndex = 19;
            // 
            // txt_CompraFechaDeEntrga
            // 
            txt_CompraFechaDeEntrga.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_CompraFechaDeEntrga.Location = new Point(28, 127);
            txt_CompraFechaDeEntrga.Name = "txt_CompraFechaDeEntrga";
            txt_CompraFechaDeEntrga.PlaceholderText = "FECHA DE ENTRAGA";
            txt_CompraFechaDeEntrga.Size = new Size(239, 23);
            txt_CompraFechaDeEntrga.TabIndex = 21;
            // 
            // txt_CompraDIreccion
            // 
            txt_CompraDIreccion.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_CompraDIreccion.Location = new Point(28, 156);
            txt_CompraDIreccion.Name = "txt_CompraDIreccion";
            txt_CompraDIreccion.PlaceholderText = "DIRECCION";
            txt_CompraDIreccion.Size = new Size(239, 23);
            txt_CompraDIreccion.TabIndex = 22;
            // 
            // txt_CompraUsuario
            // 
            txt_CompraUsuario.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_CompraUsuario.Location = new Point(28, 38);
            txt_CompraUsuario.Name = "txt_CompraUsuario";
            txt_CompraUsuario.PlaceholderText = "USUARIO";
            txt_CompraUsuario.Size = new Size(239, 23);
            txt_CompraUsuario.TabIndex = 18;
            // 
            // txt_CompraPrecioCompra
            // 
            txt_CompraPrecioCompra.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_CompraPrecioCompra.Location = new Point(28, 185);
            txt_CompraPrecioCompra.Name = "txt_CompraPrecioCompra";
            txt_CompraPrecioCompra.PlaceholderText = "PRECIO";
            txt_CompraPrecioCompra.Size = new Size(239, 23);
            txt_CompraPrecioCompra.TabIndex = 23;
            // 
            // txt_CompraDias
            // 
            txt_CompraDias.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_CompraDias.Location = new Point(28, 98);
            txt_CompraDias.Name = "txt_CompraDias";
            txt_CompraDias.PlaceholderText = "DIAS";
            txt_CompraDias.Size = new Size(239, 23);
            txt_CompraDias.TabIndex = 20;
            // 
            // panel_Volquete
            // 
            panel_Volquete.BackColor = Color.FromArgb(39, 57, 80);
            panel_Volquete.BackgroundImage = (Image)resources.GetObject("panel_Volquete.BackgroundImage");
            panel_Volquete.BackgroundImageLayout = ImageLayout.Zoom;
            panel_Volquete.BorderStyle = BorderStyle.FixedSingle;
            panel_Volquete.Controls.Add(txt_VolqueteTipoVolquete);
            panel_Volquete.Controls.Add(txt_VolqueteObservacion);
            panel_Volquete.Controls.Add(txt_VolqueteCapacidad);
            panel_Volquete.Controls.Add(txt_VolquetePrecio);
            panel_Volquete.Location = new Point(591, 40);
            panel_Volquete.Name = "panel_Volquete";
            panel_Volquete.Size = new Size(301, 278);
            panel_Volquete.TabIndex = 11;
            panel_Volquete.Visible = false;
            // 
            // txt_VolqueteTipoVolquete
            // 
            txt_VolqueteTipoVolquete.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_VolqueteTipoVolquete.Location = new Point(26, 45);
            txt_VolqueteTipoVolquete.Name = "txt_VolqueteTipoVolquete";
            txt_VolqueteTipoVolquete.PlaceholderText = "TIPO DE VOLQUETE";
            txt_VolqueteTipoVolquete.Size = new Size(239, 23);
            txt_VolqueteTipoVolquete.TabIndex = 0;
            // 
            // txt_VolqueteObservacion
            // 
            txt_VolqueteObservacion.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_VolqueteObservacion.Location = new Point(26, 134);
            txt_VolqueteObservacion.Name = "txt_VolqueteObservacion";
            txt_VolqueteObservacion.PlaceholderText = "OBSERVACION";
            txt_VolqueteObservacion.Size = new Size(239, 23);
            txt_VolqueteObservacion.TabIndex = 3;
            // 
            // txt_VolqueteCapacidad
            // 
            txt_VolqueteCapacidad.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_VolqueteCapacidad.Location = new Point(26, 105);
            txt_VolqueteCapacidad.Name = "txt_VolqueteCapacidad";
            txt_VolqueteCapacidad.PlaceholderText = "CAPACIDAD";
            txt_VolqueteCapacidad.Size = new Size(239, 23);
            txt_VolqueteCapacidad.TabIndex = 2;
            // 
            // txt_VolquetePrecio
            // 
            txt_VolquetePrecio.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_VolquetePrecio.Location = new Point(26, 74);
            txt_VolquetePrecio.Name = "txt_VolquetePrecio";
            txt_VolquetePrecio.PlaceholderText = "PRECIO";
            txt_VolquetePrecio.Size = new Size(239, 23);
            txt_VolquetePrecio.TabIndex = 1;
            // 
            // panel_Usuario
            // 
            panel_Usuario.BackColor = Color.FromArgb(39, 57, 80);
            panel_Usuario.BackgroundImage = (Image)resources.GetObject("panel_Usuario.BackgroundImage");
            panel_Usuario.BackgroundImageLayout = ImageLayout.Zoom;
            panel_Usuario.BorderStyle = BorderStyle.FixedSingle;
            panel_Usuario.Controls.Add(txt_UsuarioClave);
            panel_Usuario.Controls.Add(txt_UsuarioNombreUsuario);
            panel_Usuario.Controls.Add(txt_UsuarioDni);
            panel_Usuario.Controls.Add(txt_UsuarioTelefono);
            panel_Usuario.Controls.Add(txt_UsuarioId);
            panel_Usuario.Controls.Add(txt_UsuarioNombre);
            panel_Usuario.Controls.Add(txt_UsuarioApellido);
            panel_Usuario.Location = new Point(591, 40);
            panel_Usuario.Name = "panel_Usuario";
            panel_Usuario.Size = new Size(301, 278);
            panel_Usuario.TabIndex = 10;
            panel_Usuario.Visible = false;
            // 
            // txt_UsuarioClave
            // 
            txt_UsuarioClave.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_UsuarioClave.Location = new Point(33, 55);
            txt_UsuarioClave.Name = "txt_UsuarioClave";
            txt_UsuarioClave.PlaceholderText = "CLAVE";
            txt_UsuarioClave.Size = new Size(239, 23);
            txt_UsuarioClave.TabIndex = 11;
            // 
            // txt_UsuarioNombreUsuario
            // 
            txt_UsuarioNombreUsuario.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_UsuarioNombreUsuario.Location = new Point(33, 26);
            txt_UsuarioNombreUsuario.Name = "txt_UsuarioNombreUsuario";
            txt_UsuarioNombreUsuario.PlaceholderText = "USUARIO";
            txt_UsuarioNombreUsuario.Size = new Size(239, 23);
            txt_UsuarioNombreUsuario.TabIndex = 10;
            // 
            // txt_UsuarioDni
            // 
            txt_UsuarioDni.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_UsuarioDni.Location = new Point(33, 173);
            txt_UsuarioDni.Name = "txt_UsuarioDni";
            txt_UsuarioDni.PlaceholderText = "DNI";
            txt_UsuarioDni.Size = new Size(239, 23);
            txt_UsuarioDni.TabIndex = 15;
            // 
            // txt_UsuarioTelefono
            // 
            txt_UsuarioTelefono.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_UsuarioTelefono.Location = new Point(33, 86);
            txt_UsuarioTelefono.Name = "txt_UsuarioTelefono";
            txt_UsuarioTelefono.PlaceholderText = "TELEFONO";
            txt_UsuarioTelefono.Size = new Size(239, 23);
            txt_UsuarioTelefono.TabIndex = 12;
            // 
            // txt_UsuarioId
            // 
            txt_UsuarioId.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_UsuarioId.Location = new Point(33, 202);
            txt_UsuarioId.Name = "txt_UsuarioId";
            txt_UsuarioId.PlaceholderText = "ID";
            txt_UsuarioId.Size = new Size(239, 23);
            txt_UsuarioId.TabIndex = 16;
            // 
            // txt_UsuarioNombre
            // 
            txt_UsuarioNombre.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_UsuarioNombre.Location = new Point(33, 115);
            txt_UsuarioNombre.Name = "txt_UsuarioNombre";
            txt_UsuarioNombre.PlaceholderText = "NOMBRE";
            txt_UsuarioNombre.Size = new Size(239, 23);
            txt_UsuarioNombre.TabIndex = 13;
            // 
            // txt_UsuarioApellido
            // 
            txt_UsuarioApellido.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_UsuarioApellido.Location = new Point(33, 144);
            txt_UsuarioApellido.Name = "txt_UsuarioApellido";
            txt_UsuarioApellido.PlaceholderText = "APELLIDO";
            txt_UsuarioApellido.Size = new Size(239, 23);
            txt_UsuarioApellido.TabIndex = 14;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Cursor = Cursors.Hand;
            btn_Guardar.FlatAppearance.BorderColor = Color.Lime;
            btn_Guardar.FlatStyle = FlatStyle.Popup;
            btn_Guardar.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Guardar.ForeColor = Color.LightGreen;
            btn_Guardar.Location = new Point(621, 325);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(239, 31);
            btn_Guardar.TabIndex = 9;
            btn_Guardar.Text = "GUARDAR";
            btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Cursor = Cursors.Hand;
            btn_Eliminar.FlatStyle = FlatStyle.Popup;
            btn_Eliminar.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Eliminar.ForeColor = Color.RosyBrown;
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new Font("Constantia", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtgv_Datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dtgv_Datos.ColumnHeadersHeight = 30;
            dtgv_Datos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgv_Datos.Cursor = Cursors.Hand;
            dtgv_Datos.EnableHeadersVisualStyles = false;
            dtgv_Datos.GridColor = Color.SteelBlue;
            dtgv_Datos.Location = new Point(3, 71);
            dtgv_Datos.Name = "dtgv_Datos";
            dtgv_Datos.ReadOnly = true;
            dtgv_Datos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dtgv_Datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dtgv_Datos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle9.Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dtgv_Datos.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dtgv_Datos.RowTemplate.Height = 25;
            dtgv_Datos.Size = new Size(585, 247);
            dtgv_Datos.TabIndex = 4;
            dtgv_Datos.CellClick += dtgv_Datos_CellClick;
            // 
            // btn_Editar
            // 
            btn_Editar.Cursor = Cursors.Hand;
            btn_Editar.FlatStyle = FlatStyle.Popup;
            btn_Editar.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Editar.ForeColor = Color.Orange;
            btn_Editar.Location = new Point(12, 324);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(75, 23);
            btn_Editar.TabIndex = 3;
            btn_Editar.Text = "EDITAR";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // panel_Datos
            // 
            panel_Datos.BackColor = Color.FromArgb(39, 57, 80);
            panel_Datos.BackgroundImage = (Image)resources.GetObject("panel_Datos.BackgroundImage");
            panel_Datos.BackgroundImageLayout = ImageLayout.Zoom;
            panel_Datos.BorderStyle = BorderStyle.FixedSingle;
            panel_Datos.Location = new Point(594, 40);
            panel_Datos.Name = "panel_Datos";
            panel_Datos.Size = new Size(301, 278);
            panel_Datos.TabIndex = 2;
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
            // btn_Agregar
            // 
            btn_Agregar.Cursor = Cursors.Hand;
            btn_Agregar.FlatStyle = FlatStyle.Popup;
            btn_Agregar.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Agregar.ForeColor = Color.OliveDrab;
            btn_Agregar.Location = new Point(203, 324);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(75, 23);
            btn_Agregar.TabIndex = 13;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
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
            panel_Compra.ResumeLayout(false);
            panel_Compra.PerformLayout();
            panel_Volquete.ResumeLayout(false);
            panel_Volquete.PerformLayout();
            panel_Usuario.ResumeLayout(false);
            panel_Usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_Datos).EndInit();
            panel_Cabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Cerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_InformacionDatos;
        private TextBox txt_VolqueteTipoVolquete;
        private Panel panel_Cabecera;
        private Panel panel_Datos;
        private PictureBox pic_Cerrar;
        private Button btn_Editar;
        private DataGridView dtgv_Datos;
        private Button btn_Eliminar;
        private Button btn_Volquetes;
        private Button btn_Usuarios;
        private Button btn_Compras;
        private TextBox txt_VolqueteObservacion;
        private TextBox txt_VolqueteCapacidad;
        private TextBox txt_VolquetePrecio;
        private Button btn_Guardar;
        private TextBox txt_UsuarioNombreUsuario;
        private TextBox txt_UsuarioClave;
        private TextBox txt_UsuarioTelefono;
        private TextBox txt_UsuarioNombre;
        private TextBox txt_UsuarioApellido;
        private TextBox txt_UsuarioDni;
        private TextBox txt_UsuarioId;
        private TextBox txt_CompraPrecioCompra;
        private TextBox txt_CompraDIreccion;
        private TextBox txt_CompraFechaDeEntrga;
        private TextBox txt_CompraDias;
        private TextBox txt_CompraCantidad;
        private TextBox txt_CompraUsuario;
        private TextBox txt_CompraVolquete;
        private TextBox txt_CompraIdCompra;
        private Panel panel_Usuario;
        private Panel panel_Compra;
        private Panel panel_Volquete;
        private TextBox txt_CompraHorario;
        private Button btn_Agregar;
    }
}