namespace Formulario
{
    partial class FormAlquilarVolquete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlquilarVolquete));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            pic_CerrarFormulario = new PictureBox();
            panel_Fecha = new Panel();
            btn_FechaSeleccionada = new Button();
            mth_Canlendario = new MonthCalendar();
            label1 = new Label();
            cmBox_TiposVolquetes = new ComboBox();
            label2 = new Label();
            numUD_CantidadVolquetes = new NumericUpDown();
            numUD_CantidadDias = new NumericUpDown();
            label3 = new Label();
            lbl_PrecioDelProducto = new Label();
            lbl_TituloPrecio = new Label();
            txt_Direccion = new TextBox();
            txt_FechaDeEntrega = new TextBox();
            cmBox_HoraDeEntrega = new ComboBox();
            lbl_TituloCalendario = new Label();
            lbl_TituloHoraEntrega = new Label();
            lbl_TituloDireccionEntrega = new Label();
            btn_AgregarALaLista = new Button();
            btn_HacerCompra = new Button();
            dtg_ListaDeVolquetes = new DataGridView();
            TipoProducto = new DataGridViewTextBoxColumn();
            IdCompra = new DataGridViewTextBoxColumn();
            PrecioVolquete = new DataGridViewTextBoxColumn();
            CantidadDias = new DataGridViewTextBoxColumn();
            CantidadVolquete = new DataGridViewTextBoxColumn();
            FechaDeEntraga = new DataGridViewTextBoxColumn();
            HorarioDeEntrga = new DataGridViewTextBoxColumn();
            DireccionUsuario = new DataGridViewTextBoxColumn();
            pic_FechaDeEntrega = new PictureBox();
            btn_Eliminar = new Button();
            btn_Modificar = new Button();
            lblId = new Label();
            lbl_IdCompra = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).BeginInit();
            panel_Fecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUD_CantidadVolquetes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUD_CantidadDias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_ListaDeVolquetes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_FechaDeEntrega).BeginInit();
            SuspendLayout();
            // 
            // pic_CerrarFormulario
            // 
            pic_CerrarFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pic_CerrarFormulario.BackgroundImage = (Image)resources.GetObject("pic_CerrarFormulario.BackgroundImage");
            pic_CerrarFormulario.BackgroundImageLayout = ImageLayout.Zoom;
            pic_CerrarFormulario.Cursor = Cursors.Hand;
            pic_CerrarFormulario.Location = new Point(655, 1);
            pic_CerrarFormulario.Name = "pic_CerrarFormulario";
            pic_CerrarFormulario.Size = new Size(25, 25);
            pic_CerrarFormulario.SizeMode = PictureBoxSizeMode.Zoom;
            pic_CerrarFormulario.TabIndex = 3;
            pic_CerrarFormulario.TabStop = false;
            pic_CerrarFormulario.Click += pic_CerrarFormulario_Click;
            // 
            // panel_Fecha
            // 
            panel_Fecha.Controls.Add(btn_FechaSeleccionada);
            panel_Fecha.Controls.Add(mth_Canlendario);
            panel_Fecha.Dock = DockStyle.Fill;
            panel_Fecha.Location = new Point(0, 0);
            panel_Fecha.Name = "panel_Fecha";
            panel_Fecha.Size = new Size(680, 246);
            panel_Fecha.TabIndex = 53;
            panel_Fecha.Visible = false;
            // 
            // btn_FechaSeleccionada
            // 
            btn_FechaSeleccionada.BackColor = SystemColors.ActiveCaption;
            btn_FechaSeleccionada.Cursor = Cursors.Hand;
            btn_FechaSeleccionada.FlatAppearance.BorderSize = 0;
            btn_FechaSeleccionada.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_FechaSeleccionada.FlatStyle = FlatStyle.Flat;
            btn_FechaSeleccionada.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_FechaSeleccionada.ForeColor = Color.Black;
            btn_FechaSeleccionada.ImageAlign = ContentAlignment.MiddleLeft;
            btn_FechaSeleccionada.Location = new Point(262, 221);
            btn_FechaSeleccionada.Name = "btn_FechaSeleccionada";
            btn_FechaSeleccionada.Size = new Size(154, 30);
            btn_FechaSeleccionada.TabIndex = 51;
            btn_FechaSeleccionada.Text = "Fecha Seleccionada";
            btn_FechaSeleccionada.UseVisualStyleBackColor = false;
            btn_FechaSeleccionada.Click += btn_FechaSeleccionada_Click_1;
            // 
            // mth_Canlendario
            // 
            mth_Canlendario.Location = new Point(213, 47);
            mth_Canlendario.MaxDate = new DateTime(2024, 12, 19, 0, 0, 0, 0);
            mth_Canlendario.MaxSelectionCount = 1;
            mth_Canlendario.MinDate = new DateTime(2023, 10, 10, 0, 0, 0, 0);
            mth_Canlendario.Name = "mth_Canlendario";
            mth_Canlendario.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 5;
            label1.Text = "TIPO DE VOLQUETA";
            // 
            // cmBox_TiposVolquetes
            // 
            cmBox_TiposVolquetes.BackColor = Color.FromArgb(45, 66, 91);
            cmBox_TiposVolquetes.Cursor = Cursors.Hand;
            cmBox_TiposVolquetes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmBox_TiposVolquetes.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmBox_TiposVolquetes.ForeColor = Color.White;
            cmBox_TiposVolquetes.FormattingEnabled = true;
            cmBox_TiposVolquetes.Location = new Point(20, 27);
            cmBox_TiposVolquetes.Name = "cmBox_TiposVolquetes";
            cmBox_TiposVolquetes.Size = new Size(121, 23);
            cmBox_TiposVolquetes.TabIndex = 36;
            cmBox_TiposVolquetes.SelectedIndexChanged += cmBox_TiposVolquetes_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(168, 28);
            label2.Name = "label2";
            label2.Size = new Size(93, 17);
            label2.TabIndex = 37;
            label2.Text = "CANTIDAD : ";
            // 
            // numUD_CantidadVolquetes
            // 
            numUD_CantidadVolquetes.Anchor = AnchorStyles.Top;
            numUD_CantidadVolquetes.BackColor = Color.FromArgb(45, 66, 91);
            numUD_CantidadVolquetes.BorderStyle = BorderStyle.FixedSingle;
            numUD_CantidadVolquetes.Cursor = Cursors.Hand;
            numUD_CantidadVolquetes.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            numUD_CantidadVolquetes.ForeColor = Color.White;
            numUD_CantidadVolquetes.Location = new Point(267, 22);
            numUD_CantidadVolquetes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUD_CantidadVolquetes.Name = "numUD_CantidadVolquetes";
            numUD_CantidadVolquetes.Size = new Size(48, 23);
            numUD_CantidadVolquetes.TabIndex = 38;
            numUD_CantidadVolquetes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numUD_CantidadVolquetes.Click += numUD_CantidadVolquetes_Click;
            // 
            // numUD_CantidadDias
            // 
            numUD_CantidadDias.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numUD_CantidadDias.BackColor = Color.FromArgb(45, 66, 91);
            numUD_CantidadDias.Cursor = Cursors.Hand;
            numUD_CantidadDias.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            numUD_CantidadDias.ForeColor = Color.White;
            numUD_CantidadDias.Location = new Point(305, 59);
            numUD_CantidadDias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUD_CantidadDias.Name = "numUD_CantidadDias";
            numUD_CantidadDias.Size = new Size(48, 23);
            numUD_CantidadDias.TabIndex = 39;
            numUD_CantidadDias.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numUD_CantidadDias.Click += numUD_CantidadVolquetes_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(168, 65);
            label3.Name = "label3";
            label3.Size = new Size(130, 17);
            label3.TabIndex = 40;
            label3.Text = "CANTIDAD DIAS : ";
            // 
            // lbl_PrecioDelProducto
            // 
            lbl_PrecioDelProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_PrecioDelProducto.AutoSize = true;
            lbl_PrecioDelProducto.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PrecioDelProducto.Location = new Point(400, 55);
            lbl_PrecioDelProducto.Name = "lbl_PrecioDelProducto";
            lbl_PrecioDelProducto.Size = new Size(26, 22);
            lbl_PrecioDelProducto.TabIndex = 42;
            lbl_PrecioDelProducto.Text = "....";
            // 
            // lbl_TituloPrecio
            // 
            lbl_TituloPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_TituloPrecio.AutoSize = true;
            lbl_TituloPrecio.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TituloPrecio.Location = new Point(385, 22);
            lbl_TituloPrecio.Name = "lbl_TituloPrecio";
            lbl_TituloPrecio.Size = new Size(67, 22);
            lbl_TituloPrecio.TabIndex = 41;
            lbl_TituloPrecio.Text = "Precio";
            // 
            // txt_Direccion
            // 
            txt_Direccion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_Direccion.BackColor = Color.FromArgb(45, 66, 91);
            txt_Direccion.BorderStyle = BorderStyle.FixedSingle;
            txt_Direccion.Cursor = Cursors.Hand;
            txt_Direccion.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Direccion.ForeColor = Color.White;
            txt_Direccion.Location = new Point(400, 166);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.PlaceholderText = "Direccion";
            txt_Direccion.Size = new Size(162, 23);
            txt_Direccion.TabIndex = 44;
            // 
            // txt_FechaDeEntrega
            // 
            txt_FechaDeEntrega.BackColor = Color.FromArgb(45, 66, 91);
            txt_FechaDeEntrega.BorderStyle = BorderStyle.FixedSingle;
            txt_FechaDeEntrega.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_FechaDeEntrega.ForeColor = Color.White;
            txt_FechaDeEntrega.Location = new Point(23, 166);
            txt_FechaDeEntrega.Name = "txt_FechaDeEntrega";
            txt_FechaDeEntrega.PlaceholderText = " DD/MM/AAAA";
            txt_FechaDeEntrega.ReadOnly = true;
            txt_FechaDeEntrega.Size = new Size(143, 23);
            txt_FechaDeEntrega.TabIndex = 42;
            // 
            // cmBox_HoraDeEntrega
            // 
            cmBox_HoraDeEntrega.Anchor = AnchorStyles.Top;
            cmBox_HoraDeEntrega.BackColor = Color.FromArgb(45, 66, 91);
            cmBox_HoraDeEntrega.Cursor = Cursors.Hand;
            cmBox_HoraDeEntrega.DropDownStyle = ComboBoxStyle.DropDownList;
            cmBox_HoraDeEntrega.ForeColor = Color.White;
            cmBox_HoraDeEntrega.FormattingEnabled = true;
            cmBox_HoraDeEntrega.Location = new Point(213, 166);
            cmBox_HoraDeEntrega.Name = "cmBox_HoraDeEntrega";
            cmBox_HoraDeEntrega.Size = new Size(162, 23);
            cmBox_HoraDeEntrega.TabIndex = 45;
            // 
            // lbl_TituloCalendario
            // 
            lbl_TituloCalendario.AutoSize = true;
            lbl_TituloCalendario.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TituloCalendario.Location = new Point(29, 148);
            lbl_TituloCalendario.Name = "lbl_TituloCalendario";
            lbl_TituloCalendario.Size = new Size(127, 15);
            lbl_TituloCalendario.TabIndex = 47;
            lbl_TituloCalendario.Text = "FECHA DE ENTREGA";
            // 
            // lbl_TituloHoraEntrega
            // 
            lbl_TituloHoraEntrega.Anchor = AnchorStyles.Top;
            lbl_TituloHoraEntrega.AutoSize = true;
            lbl_TituloHoraEntrega.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TituloHoraEntrega.Location = new Point(223, 149);
            lbl_TituloHoraEntrega.Name = "lbl_TituloHoraEntrega";
            lbl_TituloHoraEntrega.Size = new Size(146, 15);
            lbl_TituloHoraEntrega.TabIndex = 48;
            lbl_TituloHoraEntrega.Text = "HORARIO DE ENTREGA";
            // 
            // lbl_TituloDireccionEntrega
            // 
            lbl_TituloDireccionEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_TituloDireccionEntrega.AutoSize = true;
            lbl_TituloDireccionEntrega.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TituloDireccionEntrega.Location = new Point(441, 146);
            lbl_TituloDireccionEntrega.Name = "lbl_TituloDireccionEntrega";
            lbl_TituloDireccionEntrega.Size = new Size(75, 15);
            lbl_TituloDireccionEntrega.TabIndex = 49;
            lbl_TituloDireccionEntrega.Text = "DIRECCION";
            // 
            // btn_AgregarALaLista
            // 
            btn_AgregarALaLista.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_AgregarALaLista.BackColor = Color.SteelBlue;
            btn_AgregarALaLista.Cursor = Cursors.Hand;
            btn_AgregarALaLista.FlatAppearance.BorderSize = 0;
            btn_AgregarALaLista.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            btn_AgregarALaLista.FlatStyle = FlatStyle.Popup;
            btn_AgregarALaLista.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AgregarALaLista.ForeColor = Color.Black;
            btn_AgregarALaLista.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AgregarALaLista.Location = new Point(41, 205);
            btn_AgregarALaLista.Name = "btn_AgregarALaLista";
            btn_AgregarALaLista.Size = new Size(128, 30);
            btn_AgregarALaLista.TabIndex = 50;
            btn_AgregarALaLista.Text = "Agregar";
            btn_AgregarALaLista.UseVisualStyleBackColor = false;
            btn_AgregarALaLista.Click += btn_AgregarALaLista_Click;
            // 
            // btn_HacerCompra
            // 
            btn_HacerCompra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_HacerCompra.BackColor = Color.LightGreen;
            btn_HacerCompra.Cursor = Cursors.Hand;
            btn_HacerCompra.FlatAppearance.BorderSize = 0;
            btn_HacerCompra.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_HacerCompra.FlatStyle = FlatStyle.Flat;
            btn_HacerCompra.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_HacerCompra.ForeColor = Color.Black;
            btn_HacerCompra.ImageAlign = ContentAlignment.MiddleLeft;
            btn_HacerCompra.Location = new Point(501, 205);
            btn_HacerCompra.Name = "btn_HacerCompra";
            btn_HacerCompra.Size = new Size(118, 30);
            btn_HacerCompra.TabIndex = 51;
            btn_HacerCompra.Text = "COMPRAR";
            btn_HacerCompra.UseVisualStyleBackColor = false;
            btn_HacerCompra.Click += btn_HacerCompra_Click;
            // 
            // dtg_ListaDeVolquetes
            // 
            dtg_ListaDeVolquetes.BackgroundColor = Color.FromArgb(45, 66, 91);
            dtg_ListaDeVolquetes.BorderStyle = BorderStyle.None;
            dtg_ListaDeVolquetes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtg_ListaDeVolquetes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtg_ListaDeVolquetes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dtg_ListaDeVolquetes.ColumnHeadersHeight = 30;
            dtg_ListaDeVolquetes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtg_ListaDeVolquetes.Columns.AddRange(new DataGridViewColumn[] { TipoProducto, IdCompra, PrecioVolquete, CantidadDias, CantidadVolquete, FechaDeEntraga, HorarioDeEntrga, DireccionUsuario });
            dtg_ListaDeVolquetes.Dock = DockStyle.Bottom;
            dtg_ListaDeVolquetes.EnableHeadersVisualStyles = false;
            dtg_ListaDeVolquetes.GridColor = Color.SteelBlue;
            dtg_ListaDeVolquetes.Location = new Point(0, 246);
            dtg_ListaDeVolquetes.Name = "dtg_ListaDeVolquetes";
            dtg_ListaDeVolquetes.ReadOnly = true;
            dtg_ListaDeVolquetes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dtg_ListaDeVolquetes.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle9.Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dtg_ListaDeVolquetes.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dtg_ListaDeVolquetes.RowTemplate.Height = 25;
            dtg_ListaDeVolquetes.Size = new Size(680, 135);
            dtg_ListaDeVolquetes.TabIndex = 52;
            dtg_ListaDeVolquetes.CellClick += dtg_ListaDeVolquetes_CellClick;
            // 
            // TipoProducto
            // 
            TipoProducto.HeaderText = "Tipo";
            TipoProducto.Name = "TipoProducto";
            TipoProducto.ReadOnly = true;
            // 
            // IdCompra
            // 
            IdCompra.HeaderText = "Id";
            IdCompra.Name = "IdCompra";
            IdCompra.ReadOnly = true;
            // 
            // PrecioVolquete
            // 
            PrecioVolquete.HeaderText = "Precio";
            PrecioVolquete.Name = "PrecioVolquete";
            PrecioVolquete.ReadOnly = true;
            // 
            // CantidadDias
            // 
            CantidadDias.HeaderText = "Dias";
            CantidadDias.Name = "CantidadDias";
            CantidadDias.ReadOnly = true;
            // 
            // CantidadVolquete
            // 
            CantidadVolquete.HeaderText = "Cantidad";
            CantidadVolquete.Name = "CantidadVolquete";
            CantidadVolquete.ReadOnly = true;
            // 
            // FechaDeEntraga
            // 
            FechaDeEntraga.HeaderText = "Entrega";
            FechaDeEntraga.Name = "FechaDeEntraga";
            FechaDeEntraga.ReadOnly = true;
            // 
            // HorarioDeEntrga
            // 
            HorarioDeEntrga.HeaderText = "Horario";
            HorarioDeEntrga.Name = "HorarioDeEntrga";
            HorarioDeEntrga.ReadOnly = true;
            // 
            // DireccionUsuario
            // 
            DireccionUsuario.HeaderText = "Direccion";
            DireccionUsuario.Name = "DireccionUsuario";
            DireccionUsuario.ReadOnly = true;
            // 
            // pic_FechaDeEntrega
            // 
            pic_FechaDeEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pic_FechaDeEntrega.BackgroundImage = (Image)resources.GetObject("pic_FechaDeEntrega.BackgroundImage");
            pic_FechaDeEntrega.BackgroundImageLayout = ImageLayout.Zoom;
            pic_FechaDeEntrega.Cursor = Cursors.Hand;
            pic_FechaDeEntrega.Location = new Point(168, 164);
            pic_FechaDeEntrega.Name = "pic_FechaDeEntrega";
            pic_FechaDeEntrega.Size = new Size(25, 25);
            pic_FechaDeEntrega.SizeMode = PictureBoxSizeMode.Zoom;
            pic_FechaDeEntrega.TabIndex = 54;
            pic_FechaDeEntrega.TabStop = false;
            pic_FechaDeEntrega.Click += pic_FechaDeEntrega_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Anchor = AnchorStyles.Bottom;
            btn_Eliminar.BackColor = Color.RosyBrown;
            btn_Eliminar.Cursor = Cursors.Hand;
            btn_Eliminar.FlatAppearance.BorderSize = 0;
            btn_Eliminar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_Eliminar.FlatStyle = FlatStyle.Flat;
            btn_Eliminar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Eliminar.ForeColor = Color.Black;
            btn_Eliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Eliminar.Location = new Point(339, 205);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(128, 30);
            btn_Eliminar.TabIndex = 56;
            btn_Eliminar.Text = "ELIMINAR";
            btn_Eliminar.UseVisualStyleBackColor = false;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Modificar
            // 
            btn_Modificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Modificar.BackColor = Color.Olive;
            btn_Modificar.Cursor = Cursors.Hand;
            btn_Modificar.FlatAppearance.BorderSize = 0;
            btn_Modificar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_Modificar.FlatStyle = FlatStyle.Flat;
            btn_Modificar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Modificar.ForeColor = Color.Black;
            btn_Modificar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Modificar.Location = new Point(193, 205);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(128, 30);
            btn_Modificar.TabIndex = 57;
            btn_Modificar.Text = "MODIFICAR";
            btn_Modificar.UseVisualStyleBackColor = false;
            btn_Modificar.Click += btn_Modificar_Click;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblId.AutoSize = true;
            lblId.Font = new Font("Cambria", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(601, 149);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 12);
            lblId.TabIndex = 58;
            lblId.Text = "ID";
            // 
            // lbl_IdCompra
            // 
            lbl_IdCompra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_IdCompra.AutoSize = true;
            lbl_IdCompra.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_IdCompra.Location = new Point(599, 164);
            lbl_IdCompra.Name = "lbl_IdCompra";
            lbl_IdCompra.Size = new Size(20, 17);
            lbl_IdCompra.TabIndex = 43;
            lbl_IdCompra.Text = "__";
            // 
            // FormAlquilarVolquete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 97, 141);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(680, 381);
            Controls.Add(lbl_PrecioDelProducto);
            Controls.Add(pic_CerrarFormulario);
            Controls.Add(lbl_TituloPrecio);
            Controls.Add(lbl_IdCompra);
            Controls.Add(numUD_CantidadDias);
            Controls.Add(lblId);
            Controls.Add(label3);
            Controls.Add(panel_Fecha);
            Controls.Add(label1);
            Controls.Add(cmBox_TiposVolquetes);
            Controls.Add(btn_Modificar);
            Controls.Add(numUD_CantidadVolquetes);
            Controls.Add(btn_Eliminar);
            Controls.Add(label2);
            Controls.Add(pic_FechaDeEntrega);
            Controls.Add(dtg_ListaDeVolquetes);
            Controls.Add(btn_HacerCompra);
            Controls.Add(btn_AgregarALaLista);
            Controls.Add(lbl_TituloDireccionEntrega);
            Controls.Add(lbl_TituloHoraEntrega);
            Controls.Add(lbl_TituloCalendario);
            Controls.Add(cmBox_HoraDeEntrega);
            Controls.Add(txt_Direccion);
            Controls.Add(txt_FechaDeEntrega);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAlquilarVolquete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTiposVolquetes";
            Load += FormAlquilarVolquete_Load;
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).EndInit();
            panel_Fecha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numUD_CantidadVolquetes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUD_CantidadDias).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_ListaDeVolquetes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_FechaDeEntrega).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pic_CerrarFormulario;
        private Label label1;
        private ComboBox cmBox_TiposVolquetes;
        private Label label2;
        private NumericUpDown numUD_CantidadVolquetes;
        private NumericUpDown numUD_CantidadDias;
        private Label label3;
        private TextBox txt_Direccion;
        private TextBox txt_FechaDeEntrega;
        private ComboBox cmBox_HoraDeEntrega;
        private Label lbl_TituloCalendario;
        private Label lbl_TituloHoraEntrega;
        private Label lbl_TituloDireccionEntrega;
        private Button btn_AgregarALaLista;
        private Button btn_HacerCompra;
        private Label lbl_TituloPrecio;
        private DataGridView dtg_ListaDeVolquetes;
        private Label lbl_PrecioDelProducto;
        private Panel panel_Fecha;
        private Button btn_FechaSeleccionada;
        private MonthCalendar mth_Canlendario;
        private PictureBox pic_FechaDeEntrega;
        private Button btn_Eliminar;
        private Button btn_Modificar;
        private DataGridViewTextBoxColumn TipoProducto;
        private DataGridViewTextBoxColumn IdCompra;
        private DataGridViewTextBoxColumn PrecioVolquete;
        private DataGridViewTextBoxColumn CantidadDias;
        private DataGridViewTextBoxColumn CantidadVolquete;
        private DataGridViewTextBoxColumn FechaDeEntraga;
        private DataGridViewTextBoxColumn HorarioDeEntrga;
        private DataGridViewTextBoxColumn DireccionUsuario;
        private Label lblId;
        private Label lbl_IdCompra;
    }
}