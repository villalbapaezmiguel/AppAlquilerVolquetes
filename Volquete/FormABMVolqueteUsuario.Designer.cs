namespace Formulario
{
    partial class FormABMVolqueteUsuario
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormABMVolqueteUsuario));
            cmBox_Volquete = new ComboBox();
            pic_CerrarFormulario = new PictureBox();
            panel_ContenedorVolquetes = new Panel();
            lbl_Titulo = new Label();
            imgList_FotosTiposVolquetes = new ImageList(components);
            panel_ContenedorPreciosYCapacidades = new Panel();
            lbl_Obeservaciones = new Label();
            lbl_Capacidad = new Label();
            lbl_Precio = new Label();
            panel_FotoVolquete = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).BeginInit();
            panel_ContenedorVolquetes.SuspendLayout();
            panel_ContenedorPreciosYCapacidades.SuspendLayout();
            SuspendLayout();
            // 
            // cmBox_Volquete
            // 
            cmBox_Volquete.BackColor = SystemColors.Menu;
            cmBox_Volquete.DropDownStyle = ComboBoxStyle.Simple;
            cmBox_Volquete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cmBox_Volquete.FormattingEnabled = true;
            cmBox_Volquete.Location = new Point(519, 25);
            cmBox_Volquete.Name = "cmBox_Volquete";
            cmBox_Volquete.Size = new Size(145, 25);
            cmBox_Volquete.TabIndex = 37;
            cmBox_Volquete.SelectedIndexChanged += cmBox_TiposVolquetes_SelectedIndexChanged;
            // 
            // pic_CerrarFormulario
            // 
            pic_CerrarFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pic_CerrarFormulario.BackgroundImageLayout = ImageLayout.Zoom;
            pic_CerrarFormulario.Cursor = Cursors.Hand;
            pic_CerrarFormulario.Image = (Image)resources.GetObject("pic_CerrarFormulario.Image");
            pic_CerrarFormulario.Location = new Point(651, 0);
            pic_CerrarFormulario.Name = "pic_CerrarFormulario";
            pic_CerrarFormulario.Size = new Size(25, 25);
            pic_CerrarFormulario.SizeMode = PictureBoxSizeMode.Zoom;
            pic_CerrarFormulario.TabIndex = 6;
            pic_CerrarFormulario.TabStop = false;
            pic_CerrarFormulario.Click += pic_CerrarFormulario_Click;
            // 
            // panel_ContenedorVolquetes
            // 
            panel_ContenedorVolquetes.BackColor = Color.DodgerBlue;
            panel_ContenedorVolquetes.BackgroundImageLayout = ImageLayout.Zoom;
            panel_ContenedorVolquetes.Controls.Add(lbl_Titulo);
            panel_ContenedorVolquetes.Controls.Add(pic_CerrarFormulario);
            panel_ContenedorVolquetes.Cursor = Cursors.Hand;
            panel_ContenedorVolquetes.Dock = DockStyle.Top;
            panel_ContenedorVolquetes.Location = new Point(0, 0);
            panel_ContenedorVolquetes.Name = "panel_ContenedorVolquetes";
            panel_ContenedorVolquetes.Size = new Size(676, 40);
            panel_ContenedorVolquetes.TabIndex = 31;
            panel_ContenedorVolquetes.Tag = "";
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Titulo.Location = new Point(233, 9);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(202, 22);
            lbl_Titulo.TabIndex = 8;
            lbl_Titulo.Text = "Precios y Capacidades";
            // 
            // imgList_FotosTiposVolquetes
            // 
            imgList_FotosTiposVolquetes.ColorDepth = ColorDepth.Depth8Bit;
            imgList_FotosTiposVolquetes.ImageSize = new Size(16, 16);
            imgList_FotosTiposVolquetes.TransparentColor = Color.Transparent;
            // 
            // panel_ContenedorPreciosYCapacidades
            // 
            panel_ContenedorPreciosYCapacidades.BackColor = SystemColors.Highlight;
            panel_ContenedorPreciosYCapacidades.BackgroundImage = (Image)resources.GetObject("panel_ContenedorPreciosYCapacidades.BackgroundImage");
            panel_ContenedorPreciosYCapacidades.BackgroundImageLayout = ImageLayout.Zoom;
            panel_ContenedorPreciosYCapacidades.Controls.Add(lbl_Obeservaciones);
            panel_ContenedorPreciosYCapacidades.Controls.Add(lbl_Capacidad);
            panel_ContenedorPreciosYCapacidades.Controls.Add(lbl_Precio);
            panel_ContenedorPreciosYCapacidades.Controls.Add(panel_FotoVolquete);
            panel_ContenedorPreciosYCapacidades.Controls.Add(label6);
            panel_ContenedorPreciosYCapacidades.Controls.Add(cmBox_Volquete);
            panel_ContenedorPreciosYCapacidades.Controls.Add(label5);
            panel_ContenedorPreciosYCapacidades.Controls.Add(label4);
            panel_ContenedorPreciosYCapacidades.Controls.Add(label3);
            panel_ContenedorPreciosYCapacidades.Controls.Add(label2);
            panel_ContenedorPreciosYCapacidades.Controls.Add(label1);
            panel_ContenedorPreciosYCapacidades.Dock = DockStyle.Fill;
            panel_ContenedorPreciosYCapacidades.Location = new Point(0, 40);
            panel_ContenedorPreciosYCapacidades.Name = "panel_ContenedorPreciosYCapacidades";
            panel_ContenedorPreciosYCapacidades.Size = new Size(676, 354);
            panel_ContenedorPreciosYCapacidades.TabIndex = 32;
            // 
            // lbl_Obeservaciones
            // 
            lbl_Obeservaciones.AutoSize = true;
            lbl_Obeservaciones.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Obeservaciones.Location = new Point(412, 71);
            lbl_Obeservaciones.Name = "lbl_Obeservaciones";
            lbl_Obeservaciones.Size = new Size(40, 25);
            lbl_Obeservaciones.TabIndex = 42;
            lbl_Obeservaciones.Text = ".......";
            // 
            // lbl_Capacidad
            // 
            lbl_Capacidad.AutoSize = true;
            lbl_Capacidad.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Capacidad.Location = new Point(301, 66);
            lbl_Capacidad.Name = "lbl_Capacidad";
            lbl_Capacidad.Size = new Size(40, 25);
            lbl_Capacidad.TabIndex = 41;
            lbl_Capacidad.Text = ".......";
            // 
            // lbl_Precio
            // 
            lbl_Precio.AutoSize = true;
            lbl_Precio.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Precio.Location = new Point(202, 68);
            lbl_Precio.Name = "lbl_Precio";
            lbl_Precio.Size = new Size(40, 25);
            lbl_Precio.TabIndex = 40;
            lbl_Precio.Text = ".......";
            // 
            // panel_FotoVolquete
            // 
            panel_FotoVolquete.Location = new Point(3, 71);
            panel_FotoVolquete.Name = "panel_FotoVolquete";
            panel_FotoVolquete.Size = new Size(193, 169);
            panel_FotoVolquete.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(195, 91);
            label6.Name = "label6";
            label6.Size = new Size(482, 15);
            label6.TabIndex = 38;
            label6.Text = "-----------------------------------------------------------------------------------------------";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 53);
            label5.Name = "label5";
            label5.Size = new Size(677, 15);
            label5.TabIndex = 4;
            label5.Text = "--------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(372, 19);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 3;
            label4.Text = "Observaciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(191, 19);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(262, 19);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "Capacidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 0;
            label1.Text = "Tipos de Volquetes";
            // 
            // FormABMVolqueteUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 394);
            Controls.Add(panel_ContenedorPreciosYCapacidades);
            Controls.Add(panel_ContenedorVolquetes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormABMVolqueteUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormABMVolquete";
            Load += FormABMVolqueteUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).EndInit();
            panel_ContenedorVolquetes.ResumeLayout(false);
            panel_ContenedorVolquetes.PerformLayout();
            panel_ContenedorPreciosYCapacidades.ResumeLayout(false);
            panel_ContenedorPreciosYCapacidades.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pic_CerrarFormulario;
        private Panel panel_ContenedorVolquetes;
        private Label lbl_Titulo;
        private ImageList imgList_FotosTiposVolquetes;
        private Panel panel_ContenedorPreciosYCapacidades;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmBox_Volquete;
        private Label label6;
        private Panel panel_FotoVolquete;
        private Label lbl_Precio;
        private Label lbl_Capacidad;
        private Label lbl_Obeservaciones;
    }
}