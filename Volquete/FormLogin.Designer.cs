namespace Formulario
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            txt_Correo = new TextBox();
            txt_Clave = new TextBox();
            btn_Ingresar = new Button();
            panel_Login = new Panel();
            btn_Admin = new Button();
            btn_Registrar = new Button();
            pic_CerrarFormulario = new PictureBox();
            panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).BeginInit();
            SuspendLayout();
            // 
            // txt_Correo
            // 
            txt_Correo.BackColor = SystemColors.ButtonHighlight;
            txt_Correo.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Correo.Location = new Point(87, 123);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.PlaceholderText = "Ingrese Correo";
            txt_Correo.Size = new Size(219, 22);
            txt_Correo.TabIndex = 0;
            // 
            // txt_Clave
            // 
            txt_Clave.BackColor = SystemColors.ButtonHighlight;
            txt_Clave.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Clave.Location = new Point(87, 162);
            txt_Clave.Name = "txt_Clave";
            txt_Clave.PasswordChar = '*';
            txt_Clave.PlaceholderText = "Ingrese Clave";
            txt_Clave.Size = new Size(219, 22);
            txt_Clave.TabIndex = 1;
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.BackColor = Color.YellowGreen;
            btn_Ingresar.Cursor = Cursors.Hand;
            btn_Ingresar.FlatAppearance.BorderSize = 0;
            btn_Ingresar.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btn_Ingresar.FlatStyle = FlatStyle.Popup;
            btn_Ingresar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Ingresar.ForeColor = Color.Black;
            btn_Ingresar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Ingresar.Location = new Point(99, 218);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(180, 30);
            btn_Ingresar.TabIndex = 2;
            btn_Ingresar.Text = "INGRESAR";
            btn_Ingresar.UseVisualStyleBackColor = false;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // panel_Login
            // 
            panel_Login.BackColor = Color.FromArgb(44, 65, 91);
            panel_Login.BackgroundImage = (Image)resources.GetObject("panel_Login.BackgroundImage");
            panel_Login.BackgroundImageLayout = ImageLayout.Zoom;
            panel_Login.Controls.Add(btn_Admin);
            panel_Login.Controls.Add(btn_Registrar);
            panel_Login.Controls.Add(pic_CerrarFormulario);
            panel_Login.Controls.Add(btn_Ingresar);
            panel_Login.Controls.Add(txt_Correo);
            panel_Login.Controls.Add(txt_Clave);
            panel_Login.Dock = DockStyle.Fill;
            panel_Login.Location = new Point(0, 0);
            panel_Login.Name = "panel_Login";
            panel_Login.Size = new Size(403, 327);
            panel_Login.TabIndex = 3;
            // 
            // btn_Admin
            // 
            btn_Admin.BackColor = SystemColors.ActiveCaption;
            btn_Admin.Cursor = Cursors.Hand;
            btn_Admin.FlatAppearance.BorderSize = 0;
            btn_Admin.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_Admin.FlatStyle = FlatStyle.Popup;
            btn_Admin.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Admin.ForeColor = Color.Black;
            btn_Admin.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Admin.Location = new Point(152, 290);
            btn_Admin.Name = "btn_Admin";
            btn_Admin.Size = new Size(65, 30);
            btn_Admin.TabIndex = 6;
            btn_Admin.Text = "Admin";
            btn_Admin.UseVisualStyleBackColor = false;
            btn_Admin.Click += btn_Admin_Click;
            // 
            // btn_Registrar
            // 
            btn_Registrar.BackColor = Color.FromArgb(130, 224, 170);
            btn_Registrar.Cursor = Cursors.Hand;
            btn_Registrar.FlatAppearance.BorderSize = 0;
            btn_Registrar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_Registrar.FlatStyle = FlatStyle.Popup;
            btn_Registrar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Registrar.ForeColor = Color.Black;
            btn_Registrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Registrar.Location = new Point(99, 254);
            btn_Registrar.Name = "btn_Registrar";
            btn_Registrar.Size = new Size(180, 30);
            btn_Registrar.TabIndex = 5;
            btn_Registrar.Text = "Registrar";
            btn_Registrar.UseVisualStyleBackColor = false;
            btn_Registrar.Click += btn_Registrar_Click;
            // 
            // pic_CerrarFormulario
            // 
            pic_CerrarFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pic_CerrarFormulario.BackgroundImage = (Image)resources.GetObject("pic_CerrarFormulario.BackgroundImage");
            pic_CerrarFormulario.BackgroundImageLayout = ImageLayout.Zoom;
            pic_CerrarFormulario.Cursor = Cursors.Hand;
            pic_CerrarFormulario.Location = new Point(377, -1);
            pic_CerrarFormulario.Name = "pic_CerrarFormulario";
            pic_CerrarFormulario.Size = new Size(25, 25);
            pic_CerrarFormulario.SizeMode = PictureBoxSizeMode.Zoom;
            pic_CerrarFormulario.TabIndex = 4;
            pic_CerrarFormulario.TabStop = false;
            pic_CerrarFormulario.Click += pic_CerrarFormulario_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(403, 327);
            Controls.Add(panel_Login);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            panel_Login.ResumeLayout(false);
            panel_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_Correo;
        private TextBox txt_Clave;
        private Button btn_Ingresar;
        private Panel panel_Login;
        private PictureBox pic_CerrarFormulario;
        private Button btn_Registrar;
        private Button btn_Admin;
    }
}