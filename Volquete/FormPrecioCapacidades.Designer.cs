namespace Formulario
{
    partial class FormPrecioCapacidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrecioCapacidades));
            cmBox_Volquete = new ComboBox();
            pic_CerrarFormulario = new PictureBox();
            panel_ContenedorVolquetes = new Panel();
            lbl_Titulo = new Label();
            panel_ContenedorPreciosYCapacidades = new Panel();
            lbl_Obeservaciones = new Label();
            lbl_Capacidad = new Label();
            lbl_Precio = new Label();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
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
            cmBox_Volquete.Location = new Point(200, 19);
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
            panel_ContenedorVolquetes.BackColor = Color.FromArgb(41, 128, 185);
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
            // panel_ContenedorPreciosYCapacidades
            // 
            panel_ContenedorPreciosYCapacidades.BackColor = Color.SteelBlue;
            panel_ContenedorPreciosYCapacidades.BackgroundImageLayout = ImageLayout.Zoom;
            panel_ContenedorPreciosYCapacidades.Controls.Add(label2);
            panel_ContenedorPreciosYCapacidades.Controls.Add(label7);
            panel_ContenedorPreciosYCapacidades.Controls.Add(label6);
            panel_ContenedorPreciosYCapacidades.Controls.Add(lbl_Obeservaciones);
            panel_ContenedorPreciosYCapacidades.Controls.Add(lbl_Capacidad);
            panel_ContenedorPreciosYCapacidades.Controls.Add(lbl_Precio);
            panel_ContenedorPreciosYCapacidades.Controls.Add(cmBox_Volquete);
            panel_ContenedorPreciosYCapacidades.Controls.Add(label5);
            panel_ContenedorPreciosYCapacidades.Controls.Add(label3);
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
            lbl_Obeservaciones.Location = new Point(155, 173);
            lbl_Obeservaciones.Name = "lbl_Obeservaciones";
            lbl_Obeservaciones.Size = new Size(40, 25);
            lbl_Obeservaciones.TabIndex = 42;
            lbl_Obeservaciones.Text = ".......";
            // 
            // lbl_Capacidad
            // 
            lbl_Capacidad.AutoSize = true;
            lbl_Capacidad.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Capacidad.Location = new Point(136, 125);
            lbl_Capacidad.Name = "lbl_Capacidad";
            lbl_Capacidad.Size = new Size(40, 25);
            lbl_Capacidad.TabIndex = 41;
            lbl_Capacidad.Text = ".......";
            // 
            // lbl_Precio
            // 
            lbl_Precio.AutoSize = true;
            lbl_Precio.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Precio.Location = new Point(87, 79);
            lbl_Precio.Name = "lbl_Precio";
            lbl_Precio.Size = new Size(40, 25);
            lbl_Precio.TabIndex = 40;
            lbl_Precio.Text = ".......";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 44);
            label5.Name = "label5";
            label5.Size = new Size(677, 15);
            label5.TabIndex = 4;
            label5.Text = "--------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(73, 22);
            label3.TabIndex = 2;
            label3.Text = "PRECIO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 18);
            label6.Name = "label6";
            label6.Size = new Size(161, 22);
            label6.TabIndex = 43;
            label6.Text = "TIPOS VOLQUETES";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 128);
            label7.Name = "label7";
            label7.Size = new Size(109, 22);
            label7.TabIndex = 44;
            label7.Text = "CAPACIDAD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 176);
            label2.Name = "label2";
            label2.Size = new Size(128, 22);
            label2.TabIndex = 45;
            label2.Text = "OBSERVACION";
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
        private Panel panel_ContenedorPreciosYCapacidades;
        private Label label3;
        private Label label5;
        private ComboBox cmBox_Volquete;
        private Label lbl_Precio;
        private Label lbl_Capacidad;
        private Label lbl_Obeservaciones;
        private Label label6;
        private Label label7;
        private Label label2;
    }
}