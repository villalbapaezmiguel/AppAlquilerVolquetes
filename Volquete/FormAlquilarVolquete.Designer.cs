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
            txt_Direccion = new TextBox();
            txt_FechaDeEntrega = new TextBox();
            cmBox_HoraDeEntrega = new ComboBox();
            pic_Calendario = new PictureBox();
            lbl_TituloCalendario = new Label();
            lbl_TituloHoraEntrega = new Label();
            lbl_TituloDireccionEntrega = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).BeginInit();
            panel_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUD_CantidadVolquetes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUD_CantidadDias).BeginInit();
            gpb_SolicitarVolquete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Calendario).BeginInit();
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
            label1.Location = new Point(65, 26);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 5;
            label1.Text = "Tipo de Volqueta";
            // 
            // cmBox_TiposVolquetes
            // 
            cmBox_TiposVolquetes.FormattingEnabled = true;
            cmBox_TiposVolquetes.Location = new Point(65, 56);
            cmBox_TiposVolquetes.Name = "cmBox_TiposVolquetes";
            cmBox_TiposVolquetes.Size = new Size(121, 23);
            cmBox_TiposVolquetes.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 26);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 37;
            label2.Text = "Cantidad";
            // 
            // numUD_CantidadVolquetes
            // 
            numUD_CantidadVolquetes.Location = new Point(248, 56);
            numUD_CantidadVolquetes.Name = "numUD_CantidadVolquetes";
            numUD_CantidadVolquetes.Size = new Size(120, 23);
            numUD_CantidadVolquetes.TabIndex = 38;
            // 
            // numUD_CantidadDias
            // 
            numUD_CantidadDias.Location = new Point(435, 56);
            numUD_CantidadDias.Name = "numUD_CantidadDias";
            numUD_CantidadDias.Size = new Size(120, 23);
            numUD_CantidadDias.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(449, 26);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 40;
            label3.Text = "Cantidad Dias";
            // 
            // gpb_SolicitarVolquete
            // 
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
            // txt_Direccion
            // 
            txt_Direccion.Location = new Point(432, 177);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.PlaceholderText = "Direccion";
            txt_Direccion.Size = new Size(162, 23);
            txt_Direccion.TabIndex = 44;
            // 
            // txt_FechaDeEntrega
            // 
            txt_FechaDeEntrega.Location = new Point(54, 177);
            txt_FechaDeEntrega.Name = "txt_FechaDeEntrega";
            txt_FechaDeEntrega.PlaceholderText = " DD/MM/AAAA";
            txt_FechaDeEntrega.ReadOnly = true;
            txt_FechaDeEntrega.Size = new Size(121, 23);
            txt_FechaDeEntrega.TabIndex = 42;
            // 
            // cmBox_HoraDeEntrega
            // 
            cmBox_HoraDeEntrega.FormattingEnabled = true;
            cmBox_HoraDeEntrega.Location = new Point(239, 177);
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
            pic_Calendario.Location = new Point(181, 175);
            pic_Calendario.Name = "pic_Calendario";
            pic_Calendario.Size = new Size(25, 25);
            pic_Calendario.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Calendario.TabIndex = 46;
            pic_Calendario.TabStop = false;
            // 
            // lbl_TituloCalendario
            // 
            lbl_TituloCalendario.AutoSize = true;
            lbl_TituloCalendario.Location = new Point(68, 159);
            lbl_TituloCalendario.Name = "lbl_TituloCalendario";
            lbl_TituloCalendario.Size = new Size(97, 15);
            lbl_TituloCalendario.TabIndex = 47;
            lbl_TituloCalendario.Text = "Fecha de entrega";
            // 
            // lbl_TituloHoraEntrega
            // 
            lbl_TituloHoraEntrega.AutoSize = true;
            lbl_TituloHoraEntrega.Location = new Point(255, 159);
            lbl_TituloHoraEntrega.Name = "lbl_TituloHoraEntrega";
            lbl_TituloHoraEntrega.Size = new Size(125, 15);
            lbl_TituloHoraEntrega.TabIndex = 48;
            lbl_TituloHoraEntrega.Text = "Hora de entrega aprox";
            // 
            // lbl_TituloDireccionEntrega
            // 
            lbl_TituloDireccionEntrega.AutoSize = true;
            lbl_TituloDireccionEntrega.Location = new Point(442, 159);
            lbl_TituloDireccionEntrega.Name = "lbl_TituloDireccionEntrega";
            lbl_TituloDireccionEntrega.Size = new Size(116, 15);
            lbl_TituloDireccionEntrega.TabIndex = 49;
            lbl_TituloDireccionEntrega.Text = "Direccion de entrega";
            // 
            // FormAlquilarVolquete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(680, 381);
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
    }
}