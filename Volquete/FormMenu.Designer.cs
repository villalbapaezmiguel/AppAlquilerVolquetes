namespace Formulario
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panel_MenuVertical = new Panel();
            btn_Perfil = new Button();
            btn_TiposVolquetes = new Button();
            btn_AlquilarVolquete = new Button();
            pic_LogoMarca = new PictureBox();
            panel_Titulo = new Panel();
            pic_Agrandar = new PictureBox();
            pic_Cerrar = new PictureBox();
            pic_Restaurar = new PictureBox();
            pic_Minizar = new PictureBox();
            pic_Menu = new PictureBox();
            panel_Contenedor = new Panel();
            panel_MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_LogoMarca).BeginInit();
            panel_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Agrandar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Restaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Minizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Menu).BeginInit();
            SuspendLayout();
            // 
            // panel_MenuVertical
            // 
            panel_MenuVertical.BackColor = SystemColors.HotTrack;
            panel_MenuVertical.Controls.Add(btn_Perfil);
            panel_MenuVertical.Controls.Add(btn_TiposVolquetes);
            panel_MenuVertical.Controls.Add(btn_AlquilarVolquete);
            panel_MenuVertical.Controls.Add(pic_LogoMarca);
            panel_MenuVertical.Dock = DockStyle.Left;
            panel_MenuVertical.Location = new Point(0, 0);
            panel_MenuVertical.Name = "panel_MenuVertical";
            panel_MenuVertical.Size = new Size(180, 440);
            panel_MenuVertical.TabIndex = 0;
            // 
            // btn_Perfil
            // 
            btn_Perfil.FlatAppearance.BorderSize = 0;
            btn_Perfil.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_Perfil.FlatStyle = FlatStyle.Flat;
            btn_Perfil.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Perfil.ForeColor = Color.Black;
            btn_Perfil.Image = (Image)resources.GetObject("btn_Perfil.Image");
            btn_Perfil.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Perfil.Location = new Point(3, 177);
            btn_Perfil.Name = "btn_Perfil";
            btn_Perfil.Size = new Size(180, 30);
            btn_Perfil.TabIndex = 2;
            btn_Perfil.Text = "Perfil";
            btn_Perfil.UseVisualStyleBackColor = true;
            btn_Perfil.Click += button1_Click;
            // 
            // btn_TiposVolquetes
            // 
            btn_TiposVolquetes.FlatAppearance.BorderSize = 0;
            btn_TiposVolquetes.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_TiposVolquetes.FlatStyle = FlatStyle.Flat;
            btn_TiposVolquetes.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_TiposVolquetes.ForeColor = Color.Black;
            btn_TiposVolquetes.Image = (Image)resources.GetObject("btn_TiposVolquetes.Image");
            btn_TiposVolquetes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_TiposVolquetes.Location = new Point(0, 141);
            btn_TiposVolquetes.Name = "btn_TiposVolquetes";
            btn_TiposVolquetes.Size = new Size(180, 30);
            btn_TiposVolquetes.TabIndex = 1;
            btn_TiposVolquetes.Text = "Tipos de Volquetes";
            btn_TiposVolquetes.UseVisualStyleBackColor = true;
            btn_TiposVolquetes.Click += btn_Alquilar_Click;
            // 
            // btn_AlquilarVolquete
            // 
            btn_AlquilarVolquete.FlatAppearance.BorderSize = 0;
            btn_AlquilarVolquete.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_AlquilarVolquete.FlatStyle = FlatStyle.Flat;
            btn_AlquilarVolquete.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AlquilarVolquete.ForeColor = Color.Black;
            btn_AlquilarVolquete.Image = (Image)resources.GetObject("btn_AlquilarVolquete.Image");
            btn_AlquilarVolquete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AlquilarVolquete.Location = new Point(0, 105);
            btn_AlquilarVolquete.Name = "btn_AlquilarVolquete";
            btn_AlquilarVolquete.Size = new Size(180, 30);
            btn_AlquilarVolquete.TabIndex = 0;
            btn_AlquilarVolquete.Text = "Alquilar Volquete";
            btn_AlquilarVolquete.UseVisualStyleBackColor = true;
            btn_AlquilarVolquete.Click += btn_Usuario_Click;
            // 
            // pic_LogoMarca
            // 
            pic_LogoMarca.BackgroundImage = (Image)resources.GetObject("pic_LogoMarca.BackgroundImage");
            pic_LogoMarca.BackgroundImageLayout = ImageLayout.Stretch;
            pic_LogoMarca.Location = new Point(3, 0);
            pic_LogoMarca.Name = "pic_LogoMarca";
            pic_LogoMarca.Size = new Size(180, 99);
            pic_LogoMarca.SizeMode = PictureBoxSizeMode.Zoom;
            pic_LogoMarca.TabIndex = 0;
            pic_LogoMarca.TabStop = false;
            // 
            // panel_Titulo
            // 
            panel_Titulo.BackColor = SystemColors.HotTrack;
            panel_Titulo.Controls.Add(pic_Agrandar);
            panel_Titulo.Controls.Add(pic_Cerrar);
            panel_Titulo.Controls.Add(pic_Restaurar);
            panel_Titulo.Controls.Add(pic_Minizar);
            panel_Titulo.Controls.Add(pic_Menu);
            panel_Titulo.Dock = DockStyle.Top;
            panel_Titulo.Location = new Point(180, 0);
            panel_Titulo.Name = "panel_Titulo";
            panel_Titulo.Size = new Size(690, 40);
            panel_Titulo.TabIndex = 1;
            // 
            // pic_Agrandar
            // 
            pic_Agrandar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pic_Agrandar.BackgroundImage = (Image)resources.GetObject("pic_Agrandar.BackgroundImage");
            pic_Agrandar.BackgroundImageLayout = ImageLayout.Zoom;
            pic_Agrandar.Cursor = Cursors.Hand;
            pic_Agrandar.Location = new Point(631, 0);
            pic_Agrandar.Name = "pic_Agrandar";
            pic_Agrandar.Size = new Size(25, 25);
            pic_Agrandar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Agrandar.TabIndex = 1;
            pic_Agrandar.TabStop = false;
            pic_Agrandar.Click += pic_Agrandar_Click;
            // 
            // pic_Cerrar
            // 
            pic_Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pic_Cerrar.Cursor = Cursors.Hand;
            pic_Cerrar.Image = (Image)resources.GetObject("pic_Cerrar.Image");
            pic_Cerrar.Location = new Point(662, 0);
            pic_Cerrar.Name = "pic_Cerrar";
            pic_Cerrar.Size = new Size(25, 25);
            pic_Cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Cerrar.TabIndex = 1;
            pic_Cerrar.TabStop = false;
            pic_Cerrar.Click += pic_Cerrar_Click;
            // 
            // pic_Restaurar
            // 
            pic_Restaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pic_Restaurar.BackgroundImage = (Image)resources.GetObject("pic_Restaurar.BackgroundImage");
            pic_Restaurar.BackgroundImageLayout = ImageLayout.Zoom;
            pic_Restaurar.Cursor = Cursors.Hand;
            pic_Restaurar.Location = new Point(631, 0);
            pic_Restaurar.Name = "pic_Restaurar";
            pic_Restaurar.Size = new Size(25, 25);
            pic_Restaurar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Restaurar.TabIndex = 3;
            pic_Restaurar.TabStop = false;
            pic_Restaurar.Visible = false;
            pic_Restaurar.Click += pic_Restaurar_Click;
            // 
            // pic_Minizar
            // 
            pic_Minizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pic_Minizar.BackgroundImage = (Image)resources.GetObject("pic_Minizar.BackgroundImage");
            pic_Minizar.BackgroundImageLayout = ImageLayout.Zoom;
            pic_Minizar.Cursor = Cursors.Hand;
            pic_Minizar.Location = new Point(600, 0);
            pic_Minizar.Name = "pic_Minizar";
            pic_Minizar.Size = new Size(25, 25);
            pic_Minizar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Minizar.TabIndex = 2;
            pic_Minizar.TabStop = false;
            pic_Minizar.Click += pic_Minizar_Click;
            // 
            // pic_Menu
            // 
            pic_Menu.BackgroundImage = (Image)resources.GetObject("pic_Menu.BackgroundImage");
            pic_Menu.BackgroundImageLayout = ImageLayout.Stretch;
            pic_Menu.Cursor = Cursors.Hand;
            pic_Menu.Location = new Point(6, 3);
            pic_Menu.Name = "pic_Menu";
            pic_Menu.Size = new Size(35, 35);
            pic_Menu.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Menu.TabIndex = 0;
            pic_Menu.TabStop = false;
            pic_Menu.Click += pic_Menu_Click;
            // 
            // panel_Contenedor
            // 
            panel_Contenedor.BackColor = Color.FromArgb(64, 64, 64);
            panel_Contenedor.BackgroundImage = (Image)resources.GetObject("panel_Contenedor.BackgroundImage");
            panel_Contenedor.BackgroundImageLayout = ImageLayout.Zoom;
            panel_Contenedor.Dock = DockStyle.Fill;
            panel_Contenedor.Location = new Point(180, 40);
            panel_Contenedor.Name = "panel_Contenedor";
            panel_Contenedor.Size = new Size(690, 400);
            panel_Contenedor.TabIndex = 2;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 440);
            Controls.Add(panel_Contenedor);
            Controls.Add(panel_Titulo);
            Controls.Add(panel_MenuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel_MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_LogoMarca).EndInit();
            panel_Titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Agrandar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Restaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Minizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Menu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_MenuVertical;
        private Panel panel_Titulo;
        private Panel panel_Contenedor;
        private PictureBox pic_Menu;
        private PictureBox pic_Cerrar;
        private PictureBox pic_Agrandar;
        private PictureBox pic_LogoMarca;
        private PictureBox pic_Minizar;
        private PictureBox pic_Restaurar;
        private Button btn_AlquilarVolquete;
        private Button btn_TiposVolquetes;
        private Button btn_Perfil;
    }
}