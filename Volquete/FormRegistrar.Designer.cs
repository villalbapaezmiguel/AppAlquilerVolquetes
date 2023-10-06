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
            panel1 = new Panel();
            btn_Cancelar = new Button();
            btn_Registrar = new Button();
            txt_ClaveRepita = new TextBox();
            lbl_Titulo = new Label();
            cal_FechaDeNacimiento = new MonthCalendar();
            txt_Edad = new TextBox();
            txt_Apellido = new TextBox();
            txt_Nombre = new TextBox();
            txt_Clave = new TextBox();
            txt_Correo = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btn_Cancelar);
            panel1.Controls.Add(btn_Registrar);
            panel1.Controls.Add(txt_ClaveRepita);
            panel1.Controls.Add(lbl_Titulo);
            panel1.Controls.Add(cal_FechaDeNacimiento);
            panel1.Controls.Add(txt_Edad);
            panel1.Controls.Add(txt_Apellido);
            panel1.Controls.Add(txt_Nombre);
            panel1.Controls.Add(txt_Clave);
            panel1.Controls.Add(txt_Correo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 450);
            panel1.TabIndex = 0;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.DarkGray;
            btn_Cancelar.FlatAppearance.BorderSize = 0;
            btn_Cancelar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cancelar.ForeColor = Color.Black;
            btn_Cancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Cancelar.Location = new Point(21, 373);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(180, 30);
            btn_Cancelar.TabIndex = 10;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Registrar
            // 
            btn_Registrar.BackColor = Color.DarkGray;
            btn_Registrar.FlatAppearance.BorderSize = 0;
            btn_Registrar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_Registrar.FlatStyle = FlatStyle.Flat;
            btn_Registrar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
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
            txt_ClaveRepita.BackColor = SystemColors.ButtonHighlight;
            txt_ClaveRepita.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_ClaveRepita.Location = new Point(262, 85);
            txt_ClaveRepita.Name = "txt_ClaveRepita";
            txt_ClaveRepita.PasswordChar = '*';
            txt_ClaveRepita.PlaceholderText = "Ingrese Nuevamente la Clave ";
            txt_ClaveRepita.Size = new Size(207, 22);
            txt_ClaveRepita.TabIndex = 8;
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
            // cal_FechaDeNacimiento
            // 
            cal_FechaDeNacimiento.BackColor = SystemColors.Control;
            cal_FechaDeNacimiento.Location = new Point(127, 174);
            cal_FechaDeNacimiento.Name = "cal_FechaDeNacimiento";
            cal_FechaDeNacimiento.TabIndex = 6;
            // 
            // txt_Edad
            // 
            txt_Edad.BackColor = SystemColors.ButtonHighlight;
            txt_Edad.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Edad.Location = new Point(21, 124);
            txt_Edad.Name = "txt_Edad";
            txt_Edad.PlaceholderText = "Ingrese Edad";
            txt_Edad.Size = new Size(207, 22);
            txt_Edad.TabIndex = 5;
            // 
            // txt_Apellido
            // 
            txt_Apellido.BackColor = SystemColors.ButtonHighlight;
            txt_Apellido.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Apellido.Location = new Point(21, 87);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.PlaceholderText = "Ingrese Apellido";
            txt_Apellido.Size = new Size(207, 22);
            txt_Apellido.TabIndex = 4;
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = SystemColors.ButtonHighlight;
            txt_Nombre.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Nombre.Location = new Point(21, 46);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.PlaceholderText = "Ingrese Nombre";
            txt_Nombre.Size = new Size(207, 22);
            txt_Nombre.TabIndex = 3;
            // 
            // txt_Clave
            // 
            txt_Clave.BackColor = SystemColors.ButtonHighlight;
            txt_Clave.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Clave.Location = new Point(262, 46);
            txt_Clave.Name = "txt_Clave";
            txt_Clave.PasswordChar = '*';
            txt_Clave.PlaceholderText = "Ingrese su Clave ";
            txt_Clave.Size = new Size(207, 22);
            txt_Clave.TabIndex = 2;
            // 
            // txt_Correo
            // 
            txt_Correo.BackColor = SystemColors.ButtonHighlight;
            txt_Correo.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Correo.Location = new Point(262, 124);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.PlaceholderText = "Ingrese su Correo";
            txt_Correo.Size = new Size(207, 22);
            txt_Correo.TabIndex = 1;
            // 
            // FormRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistrar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txt_Edad;
        private TextBox txt_Apellido;
        private TextBox txt_Nombre;
        private TextBox txt_Clave;
        private TextBox txt_Correo;
        private MonthCalendar cal_FechaDeNacimiento;
        private Label lbl_Titulo;
        private TextBox txt_ClaveRepita;
        private Button btn_Registrar;
        private Button btn_Cancelar;
    }
}