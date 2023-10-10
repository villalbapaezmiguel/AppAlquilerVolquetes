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
            lbl_Titulo = new Label();
            pic_CerrarFormulario = new PictureBox();
            panel_Titulo = new Panel();
            label1 = new Label();
            cmBox_TiposVolquetes = new ComboBox();
            label2 = new Label();
            numUD_CantidadVolquetes = new NumericUpDown();
            numUD_CantidadDias = new NumericUpDown();
            label3 = new Label();
            gpb_SolicitarVolquete = new GroupBox();
            lbl_PrecioDelProducto = new Label();
            lbl_TituloPrecio = new Label();
            txt_Direccion = new TextBox();
            txt_FechaDeEntrega = new TextBox();
            cmBox_HoraDeEntrega = new ComboBox();
            pic_Calendario = new PictureBox();
            lbl_TituloCalendario = new Label();
            lbl_TituloHoraEntrega = new Label();
            lbl_TituloDireccionEntrega = new Label();
            btn_AgregarALaLista = new Button();
            btn_HacerCompra = new Button();
            dtg_ListaDeVolquetes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).BeginInit();
            panel_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUD_CantidadVolquetes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUD_CantidadDias).BeginInit();
            gpb_SolicitarVolquete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Calendario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_ListaDeVolquetes).BeginInit();
            SuspendLayout();
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.Anchor = AnchorStyles.Top;
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Titulo.Location = new Point(251, 9);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(165, 22);
            lbl_Titulo.TabIndex = 2;
            lbl_Titulo.Text = "Solicitar Volquete";
            // 
            // pic_CerrarFormulario
            // 
            pic_CerrarFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pic_CerrarFormulario.BackgroundImage = (Image)resources.GetObject("pic_CerrarFormulario.BackgroundImage");
            pic_CerrarFormulario.BackgroundImageLayout = ImageLayout.Zoom;
            pic_CerrarFormulario.Cursor = Cursors.Hand;
            pic_CerrarFormulario.Location = new Point(652, 3);
            pic_CerrarFormulario.Name = "pic_CerrarFormulario";
            pic_CerrarFormulario.Size = new Size(25, 25);
            pic_CerrarFormulario.SizeMode = PictureBoxSizeMode.Zoom;
            pic_CerrarFormulario.TabIndex = 3;
            pic_CerrarFormulario.TabStop = false;
            pic_CerrarFormulario.Click += pic_CerrarFormulario_Click;
            // 
            // panel_Titulo
            // 
            panel_Titulo.BackColor = SystemColors.MenuHighlight;
            panel_Titulo.Controls.Add(pic_CerrarFormulario);
            panel_Titulo.Controls.Add(lbl_Titulo);
            panel_Titulo.Dock = DockStyle.Top;
            panel_Titulo.Location = new Point(0, 0);
            panel_Titulo.Name = "panel_Titulo";
            panel_Titulo.Size = new Size(680, 37);
            panel_Titulo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 24);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 5;
            label1.Text = "Tipo de Volqueta";
            // 
            // cmBox_TiposVolquetes
            // 
            cmBox_TiposVolquetes.FormattingEnabled = true;
            cmBox_TiposVolquetes.Location = new Point(18, 54);
            cmBox_TiposVolquetes.Name = "cmBox_TiposVolquetes";
            cmBox_TiposVolquetes.Size = new Size(121, 23);
            cmBox_TiposVolquetes.TabIndex = 36;
            cmBox_TiposVolquetes.Text = "Seleccione Volquete";
            cmBox_TiposVolquetes.SelectedIndexChanged += cmBox_TiposVolquetes_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 24);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 37;
            label2.Text = "Cantidad";
            // 
            // numUD_CantidadVolquetes
            // 
            numUD_CantidadVolquetes.Location = new Point(201, 54);
            numUD_CantidadVolquetes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUD_CantidadVolquetes.Name = "numUD_CantidadVolquetes";
            numUD_CantidadVolquetes.Size = new Size(120, 23);
            numUD_CantidadVolquetes.TabIndex = 38;
            numUD_CantidadVolquetes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numUD_CantidadDias
            // 
            numUD_CantidadDias.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numUD_CantidadDias.Location = new Point(388, 54);
            numUD_CantidadDias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUD_CantidadDias.Name = "numUD_CantidadDias";
            numUD_CantidadDias.Size = new Size(120, 23);
            numUD_CantidadDias.TabIndex = 39;
            numUD_CantidadDias.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numUD_CantidadDias.ValueChanged += numUD_CantidadDias_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(402, 24);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 40;
            label3.Text = "Cantidad Dias";
            // 
            // gpb_SolicitarVolquete
            // 
            gpb_SolicitarVolquete.Controls.Add(lbl_PrecioDelProducto);
            gpb_SolicitarVolquete.Controls.Add(lbl_TituloPrecio);
            gpb_SolicitarVolquete.Controls.Add(numUD_CantidadDias);
            gpb_SolicitarVolquete.Controls.Add(label3);
            gpb_SolicitarVolquete.Controls.Add(label1);
            gpb_SolicitarVolquete.Controls.Add(cmBox_TiposVolquetes);
            gpb_SolicitarVolquete.Controls.Add(numUD_CantidadVolquetes);
            gpb_SolicitarVolquete.Controls.Add(label2);
            gpb_SolicitarVolquete.Location = new Point(12, 43);
            gpb_SolicitarVolquete.Name = "gpb_SolicitarVolquete";
            gpb_SolicitarVolquete.Size = new Size(656, 100);
            gpb_SolicitarVolquete.TabIndex = 41;
            gpb_SolicitarVolquete.TabStop = false;
            // 
            // lbl_PrecioDelProducto
            // 
            lbl_PrecioDelProducto.Anchor = AnchorStyles.Top;
            lbl_PrecioDelProducto.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PrecioDelProducto.Location = new Point(547, 54);
            lbl_PrecioDelProducto.Name = "lbl_PrecioDelProducto";
            lbl_PrecioDelProducto.Size = new Size(67, 22);
            lbl_PrecioDelProducto.TabIndex = 42;
            // 
            // lbl_TituloPrecio
            // 
            lbl_TituloPrecio.Anchor = AnchorStyles.Top;
            lbl_TituloPrecio.AutoSize = true;
            lbl_TituloPrecio.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TituloPrecio.Location = new Point(547, 24);
            lbl_TituloPrecio.Name = "lbl_TituloPrecio";
            lbl_TituloPrecio.Size = new Size(67, 22);
            lbl_TituloPrecio.TabIndex = 41;
            lbl_TituloPrecio.Text = "Precio";
            // 
            // txt_Direccion
            // 
            txt_Direccion.Location = new Point(406, 166);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.PlaceholderText = "Direccion";
            txt_Direccion.Size = new Size(162, 23);
            txt_Direccion.TabIndex = 44;
            // 
            // txt_FechaDeEntrega
            // 
            txt_FechaDeEntrega.Location = new Point(28, 166);
            txt_FechaDeEntrega.Name = "txt_FechaDeEntrega";
            txt_FechaDeEntrega.PlaceholderText = " DD/MM/AAAA";
            txt_FechaDeEntrega.ReadOnly = true;
            txt_FechaDeEntrega.Size = new Size(121, 23);
            txt_FechaDeEntrega.TabIndex = 42;
            // 
            // cmBox_HoraDeEntrega
            // 
            cmBox_HoraDeEntrega.FormattingEnabled = true;
            cmBox_HoraDeEntrega.Location = new Point(213, 166);
            cmBox_HoraDeEntrega.Name = "cmBox_HoraDeEntrega";
            cmBox_HoraDeEntrega.Size = new Size(162, 23);
            cmBox_HoraDeEntrega.TabIndex = 45;
            // 
            // pic_Calendario
            // 
            pic_Calendario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pic_Calendario.BackgroundImage = Vista.Properties.Resources.Volvo;
            pic_Calendario.BackgroundImageLayout = ImageLayout.Zoom;
            pic_Calendario.Cursor = Cursors.Hand;
            pic_Calendario.Location = new Point(155, 164);
            pic_Calendario.Name = "pic_Calendario";
            pic_Calendario.Size = new Size(25, 25);
            pic_Calendario.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Calendario.TabIndex = 46;
            pic_Calendario.TabStop = false;
            pic_Calendario.Click += pic_Calendario_Click;
            // 
            // lbl_TituloCalendario
            // 
            lbl_TituloCalendario.AutoSize = true;
            lbl_TituloCalendario.Location = new Point(42, 148);
            lbl_TituloCalendario.Name = "lbl_TituloCalendario";
            lbl_TituloCalendario.Size = new Size(97, 15);
            lbl_TituloCalendario.TabIndex = 47;
            lbl_TituloCalendario.Text = "Fecha de entrega";
            // 
            // lbl_TituloHoraEntrega
            // 
            lbl_TituloHoraEntrega.AutoSize = true;
            lbl_TituloHoraEntrega.Location = new Point(229, 148);
            lbl_TituloHoraEntrega.Name = "lbl_TituloHoraEntrega";
            lbl_TituloHoraEntrega.Size = new Size(125, 15);
            lbl_TituloHoraEntrega.TabIndex = 48;
            lbl_TituloHoraEntrega.Text = "Hora de entrega aprox";
            // 
            // lbl_TituloDireccionEntrega
            // 
            lbl_TituloDireccionEntrega.AutoSize = true;
            lbl_TituloDireccionEntrega.Location = new Point(416, 148);
            lbl_TituloDireccionEntrega.Name = "lbl_TituloDireccionEntrega";
            lbl_TituloDireccionEntrega.Size = new Size(116, 15);
            lbl_TituloDireccionEntrega.TabIndex = 49;
            lbl_TituloDireccionEntrega.Text = "Direccion de entrega";
            // 
            // btn_AgregarALaLista
            // 
            btn_AgregarALaLista.BackColor = SystemColors.ActiveCaption;
            btn_AgregarALaLista.Cursor = Cursors.Hand;
            btn_AgregarALaLista.FlatAppearance.BorderSize = 0;
            btn_AgregarALaLista.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_AgregarALaLista.FlatStyle = FlatStyle.Flat;
            btn_AgregarALaLista.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AgregarALaLista.ForeColor = Color.Black;
            btn_AgregarALaLista.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AgregarALaLista.Location = new Point(223, 205);
            btn_AgregarALaLista.Name = "btn_AgregarALaLista";
            btn_AgregarALaLista.Size = new Size(154, 30);
            btn_AgregarALaLista.TabIndex = 50;
            btn_AgregarALaLista.Text = "Agregar a la Lista";
            btn_AgregarALaLista.UseVisualStyleBackColor = false;
            btn_AgregarALaLista.Click += btn_AgregarALaLista_Click;
            // 
            // btn_HacerCompra
            // 
            btn_HacerCompra.BackColor = SystemColors.ActiveCaption;
            btn_HacerCompra.Cursor = Cursors.Hand;
            btn_HacerCompra.FlatAppearance.BorderSize = 0;
            btn_HacerCompra.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_HacerCompra.FlatStyle = FlatStyle.Flat;
            btn_HacerCompra.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_HacerCompra.ForeColor = Color.Black;
            btn_HacerCompra.ImageAlign = ContentAlignment.MiddleLeft;
            btn_HacerCompra.Location = new Point(559, 339);
            btn_HacerCompra.Name = "btn_HacerCompra";
            btn_HacerCompra.Size = new Size(118, 30);
            btn_HacerCompra.TabIndex = 51;
            btn_HacerCompra.Text = "Hacer Compra";
            btn_HacerCompra.UseVisualStyleBackColor = false;
            btn_HacerCompra.Click += btn_HacerCompra_Click;
            // 
            // dtg_ListaDeVolquetes
            // 
            dtg_ListaDeVolquetes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtg_ListaDeVolquetes.BackgroundColor = SystemColors.ActiveCaption;
            dtg_ListaDeVolquetes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ListaDeVolquetes.Location = new Point(2, 242);
            dtg_ListaDeVolquetes.Name = "dtg_ListaDeVolquetes";
            dtg_ListaDeVolquetes.RowTemplate.Height = 25;
            dtg_ListaDeVolquetes.Size = new Size(553, 135);
            dtg_ListaDeVolquetes.TabIndex = 52;
            // 
            // FormAlquilarVolquete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(680, 381);
            Controls.Add(dtg_ListaDeVolquetes);
            Controls.Add(btn_HacerCompra);
            Controls.Add(btn_AgregarALaLista);
            Controls.Add(lbl_TituloDireccionEntrega);
            Controls.Add(lbl_TituloHoraEntrega);
            Controls.Add(lbl_TituloCalendario);
            Controls.Add(pic_Calendario);
            Controls.Add(cmBox_HoraDeEntrega);
            Controls.Add(txt_Direccion);
            Controls.Add(txt_FechaDeEntrega);
            Controls.Add(gpb_SolicitarVolquete);
            Controls.Add(panel_Titulo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAlquilarVolquete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTiposVolquetes";
            Load += FormAlquilarVolquete_Load;
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).EndInit();
            panel_Titulo.ResumeLayout(false);
            panel_Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUD_CantidadVolquetes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUD_CantidadDias).EndInit();
            gpb_SolicitarVolquete.ResumeLayout(false);
            gpb_SolicitarVolquete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Calendario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_ListaDeVolquetes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Titulo;
        private PictureBox pic_CerrarFormulario;
        private Panel panel_Titulo;
        private Label label1;
        private ComboBox cmBox_TiposVolquetes;
        private Label label2;
        private NumericUpDown numUD_CantidadVolquetes;
        private NumericUpDown numUD_CantidadDias;
        private Label label3;
        private GroupBox gpb_SolicitarVolquete;
        private TextBox txt_Direccion;
        private TextBox txt_FechaDeEntrega;
        private ComboBox cmBox_HoraDeEntrega;
        private PictureBox pic_Calendario;
        private Label lbl_TituloCalendario;
        private Label lbl_TituloHoraEntrega;
        private Label lbl_TituloDireccionEntrega;
        private Button btn_AgregarALaLista;
        private Button btn_HacerCompra;
        private Label lbl_TituloPrecio;
        private DataGridView dtg_ListaDeVolquetes;
        private Label lbl_PrecioDelProducto;
    }
}