namespace Formulario
{
    partial class FormPerfilUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerfilUsuario));
            panel_PefilUsuario = new Panel();
            lbl_Correo = new Label();
            lbl_FechaDeNacimiento = new Label();
            lbl_Edad = new Label();
            lbl_Apellido = new Label();
            lbl_Nombre = new Label();
            pic_CerrarFormulario = new PictureBox();
            panel_PefilUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).BeginInit();
            SuspendLayout();
            // 
            // panel_PefilUsuario
            // 
            panel_PefilUsuario.BackColor = Color.FromArgb(64, 64, 64);
            panel_PefilUsuario.BackgroundImageLayout = ImageLayout.Zoom;
            panel_PefilUsuario.Controls.Add(lbl_Correo);
            panel_PefilUsuario.Controls.Add(lbl_FechaDeNacimiento);
            panel_PefilUsuario.Controls.Add(lbl_Edad);
            panel_PefilUsuario.Controls.Add(lbl_Apellido);
            panel_PefilUsuario.Controls.Add(lbl_Nombre);
            panel_PefilUsuario.Controls.Add(pic_CerrarFormulario);
            panel_PefilUsuario.Dock = DockStyle.Fill;
            panel_PefilUsuario.Location = new Point(0, 0);
            panel_PefilUsuario.Name = "panel_PefilUsuario";
            panel_PefilUsuario.Size = new Size(644, 330);
            panel_PefilUsuario.TabIndex = 0;
            panel_PefilUsuario.Paint += panel_PefilUsuario_Paint;
            // 
            // lbl_Correo
            // 
            lbl_Correo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Correo.AutoSize = true;
            lbl_Correo.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Correo.Location = new Point(14, 152);
            lbl_Correo.Name = "lbl_Correo";
            lbl_Correo.Size = new Size(84, 22);
            lbl_Correo.TabIndex = 9;
            lbl_Correo.Text = "Correo  :";
            // 
            // lbl_FechaDeNacimiento
            // 
            lbl_FechaDeNacimiento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_FechaDeNacimiento.AutoSize = true;
            lbl_FechaDeNacimiento.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_FechaDeNacimiento.Location = new Point(12, 116);
            lbl_FechaDeNacimiento.Name = "lbl_FechaDeNacimiento";
            lbl_FechaDeNacimiento.Size = new Size(197, 22);
            lbl_FechaDeNacimiento.TabIndex = 8;
            lbl_FechaDeNacimiento.Text = "Fecha de Nacimiento :";
            // 
            // lbl_Edad
            // 
            lbl_Edad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Edad.AutoSize = true;
            lbl_Edad.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Edad.Location = new Point(14, 83);
            lbl_Edad.Name = "lbl_Edad";
            lbl_Edad.Size = new Size(62, 22);
            lbl_Edad.TabIndex = 7;
            lbl_Edad.Text = "Edad :";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Apellido.Location = new Point(14, 51);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(92, 22);
            lbl_Apellido.TabIndex = 6;
            lbl_Apellido.Text = "Apellido :";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Nombre.Location = new Point(14, 13);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(94, 22);
            lbl_Nombre.TabIndex = 5;
            lbl_Nombre.Text = "Nombre : ";
            // 
            // pic_CerrarFormulario
            // 
            pic_CerrarFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pic_CerrarFormulario.BackgroundImage = (Image)resources.GetObject("pic_CerrarFormulario.BackgroundImage");
            pic_CerrarFormulario.BackgroundImageLayout = ImageLayout.Zoom;
            pic_CerrarFormulario.Cursor = Cursors.Hand;
            pic_CerrarFormulario.Location = new Point(618, 0);
            pic_CerrarFormulario.Name = "pic_CerrarFormulario";
            pic_CerrarFormulario.Size = new Size(25, 25);
            pic_CerrarFormulario.SizeMode = PictureBoxSizeMode.Zoom;
            pic_CerrarFormulario.TabIndex = 4;
            pic_CerrarFormulario.TabStop = false;
            pic_CerrarFormulario.Click += pic_CerrarFormulario_Click;
            // 
            // FormPerfilUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 330);
            Controls.Add(panel_PefilUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPerfilUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPerfilUsuario";
            Load += FormPerfilUsuario_Load;
            panel_PefilUsuario.ResumeLayout(false);
            panel_PefilUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_PefilUsuario;
        private PictureBox pic_CerrarFormulario;
        private Label lbl_Nombre;
        private Label lbl_Apellido;
        private Label lbl_Edad;
        private Label lbl_FechaDeNacimiento;
        private Label lbl_Correo;
    }
}