namespace Formulario
{
    partial class FormRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrar));
            panel_Registrar = new Panel();
            txt_NumeroDeTelefono = new TextBox();
            btn_Cancelar = new Button();
            btn_Registrar = new Button();
            txt_ClaveRepita = new TextBox();
            lbl_Titulo = new Label();
            txt_DNI = new TextBox();
            txt_Apellido = new TextBox();
            txt_Nombre = new TextBox();
            txt_Clave = new TextBox();
            txt_NombreUsuario = new TextBox();
            panel_Registrar.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Registrar
            // 
            panel_Registrar.BackColor = Color.SkyBlue;
            panel_Registrar.BackgroundImage = (Image)resources.GetObject("panel_Registrar.BackgroundImage");
            panel_Registrar.BackgroundImageLayout = ImageLayout.Zoom;
            panel_Registrar.Controls.Add(txt_NumeroDeTelefono);
            panel_Registrar.Controls.Add(btn_Cancelar);
            panel_Registrar.Controls.Add(btn_Registrar);
            panel_Registrar.Controls.Add(txt_ClaveRepita);
            panel_Registrar.Controls.Add(lbl_Titulo);
            panel_Registrar.Controls.Add(txt_DNI);
            panel_Registrar.Controls.Add(txt_Apellido);
            panel_Registrar.Controls.Add(txt_Nombre);
            panel_Registrar.Controls.Add(txt_Clave);
            panel_Registrar.Controls.Add(txt_NombreUsuario);
            panel_Registrar.Dock = DockStyle.Fill;
            panel_Registrar.Location = new Point(0, 0);
            panel_Registrar.Name = "panel_Registrar";
            panel_Registrar.Size = new Size(481, 450);
            panel_Registrar.TabIndex = 0;
            // 
            // txt_NumeroDeTelefono
            // 
            txt_NumeroDeTelefono.BackColor = Color.LightCyan;
            txt_NumeroDeTelefono.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_NumeroDeTelefono.Location = new Point(21, 163);
            txt_NumeroDeTelefono.Name = "txt_NumeroDeTelefono";
            txt_NumeroDeTelefono.PlaceholderText = "Ingrese Telefono";
            txt_NumeroDeTelefono.Size = new Size(207, 22);
            txt_NumeroDeTelefono.TabIndex = 4;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.AntiqueWhite;
            btn_Cancelar.FlatAppearance.BorderSize = 0;
            btn_Cancelar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cancelar.ForeColor = Color.Black;
            btn_Cancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Cancelar.Location = new Point(21, 373);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(180, 30);
            btn_Cancelar.TabIndex = 8;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Registrar
            // 
            btn_Registrar.BackColor = Color.MediumAquamarine;
            btn_Registrar.FlatAppearance.BorderSize = 0;
            btn_Registrar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_Registrar.FlatStyle = FlatStyle.Flat;
            btn_Registrar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Registrar.ForeColor = Color.Black;
            btn_Registrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Registrar.Location = new Point(262, 373);
            btn_Registrar.Name = "btn_Registrar";
            btn_Registrar.Size = new Size(180, 30);
            btn_Registrar.TabIndex = 9;
            btn_Registrar.Text = "Resgistrar";
            btn_Registrar.UseVisualStyleBackColor = false;
            btn_Registrar.Click += btn_Registrar_Click;
            // 
            // txt_ClaveRepita
            // 
            txt_ClaveRepita.BackColor = Color.LightCyan;
            txt_ClaveRepita.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_ClaveRepita.Location = new Point(262, 85);
            txt_ClaveRepita.Name = "txt_ClaveRepita";
            txt_ClaveRepita.PasswordChar = '*';
            txt_ClaveRepita.PlaceholderText = "Ingrese Nuevamente la Clave ";
            txt_ClaveRepita.Size = new Size(207, 22);
            txt_ClaveRepita.TabIndex = 6;
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.Anchor = AnchorStyles.Top;
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Titulo.Location = new Point(199, 9);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(101, 22);
            lbl_Titulo.TabIndex = 7;
            lbl_Titulo.Text = "Registrate";
            // 
            // txt_DNI
            // 
            txt_DNI.BackColor = Color.LightCyan;
            txt_DNI.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_DNI.Location = new Point(21, 124);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.PlaceholderText = "Ingrese su DNI";
            txt_DNI.Size = new Size(207, 22);
            txt_DNI.TabIndex = 3;
            // 
            // txt_Apellido
            // 
            txt_Apellido.BackColor = Color.LightCyan;
            txt_Apellido.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Apellido.Location = new Point(21, 87);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.PlaceholderText = "Ingrese Apellido";
            txt_Apellido.Size = new Size(207, 22);
            txt_Apellido.TabIndex = 2;
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = Color.LightCyan;
            txt_Nombre.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Nombre.Location = new Point(21, 46);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.PlaceholderText = "Ingrese Nombre";
            txt_Nombre.Size = new Size(207, 22);
            txt_Nombre.TabIndex = 1;
            // 
            // txt_Clave
            // 
            txt_Clave.BackColor = Color.LightCyan;
            txt_Clave.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Clave.Location = new Point(262, 46);
            txt_Clave.Name = "txt_Clave";
            txt_Clave.PasswordChar = '*';
            txt_Clave.PlaceholderText = "Ingrese su Clave ";
            txt_Clave.Size = new Size(207, 22);
            txt_Clave.TabIndex = 5;
            // 
            // txt_NombreUsuario
            // 
            txt_NombreUsuario.BackColor = Color.LightCyan;
            txt_NombreUsuario.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_NombreUsuario.Location = new Point(262, 124);
            txt_NombreUsuario.Name = "txt_NombreUsuario";
            txt_NombreUsuario.PlaceholderText = "Ingrese Nombre Usuario";
            txt_NombreUsuario.Size = new Size(207, 22);
            txt_NombreUsuario.TabIndex = 7;
            // 
            // FormRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 450);
            Controls.Add(panel_Registrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistrar";
            panel_Registrar.ResumeLayout(false);
            panel_Registrar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Registrar;
        private TextBox txt_DNI;
        private TextBox txt_Apellido;
        private TextBox txt_Nombre;
        private TextBox txt_Clave;
        private TextBox txt_NombreUsuario;
        private Label lbl_Titulo;
        private TextBox txt_ClaveRepita;
        private Button btn_Registrar;
        private Button btn_Cancelar;
        private TextBox txt_NumeroDeTelefono;
    }
}