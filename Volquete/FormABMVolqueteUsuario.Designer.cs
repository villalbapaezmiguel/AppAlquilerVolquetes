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
            pic_CerrarFormulario = new PictureBox();
            panel_TiposDeVolquetes = new Panel();
            cmBox_Particular = new ComboBox();
            cmBox_Industrial = new ComboBox();
            panel_ContenedorVolquetes = new Panel();
            grpBox_TiposVolquetes = new GroupBox();
            rdb_Industrial = new RadioButton();
            rdb_Particular = new RadioButton();
            btn_InformacionVolquete = new Button();
            lbl_Titulo = new Label();
            pic_FotoDeVolquetes = new PictureBox();
            imgList_FotosTiposVolquetes = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).BeginInit();
            panel_TiposDeVolquetes.SuspendLayout();
            panel_ContenedorVolquetes.SuspendLayout();
            grpBox_TiposVolquetes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_FotoDeVolquetes).BeginInit();
            SuspendLayout();
            // 
            // pic_CerrarFormulario
            // 
            pic_CerrarFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pic_CerrarFormulario.BackgroundImageLayout = ImageLayout.Zoom;
            pic_CerrarFormulario.Cursor = Cursors.Hand;
            pic_CerrarFormulario.Image = (Image)resources.GetObject("pic_CerrarFormulario.Image");
            pic_CerrarFormulario.Location = new Point(475, 0);
            pic_CerrarFormulario.Name = "pic_CerrarFormulario";
            pic_CerrarFormulario.Size = new Size(25, 25);
            pic_CerrarFormulario.SizeMode = PictureBoxSizeMode.Zoom;
            pic_CerrarFormulario.TabIndex = 6;
            pic_CerrarFormulario.TabStop = false;
            pic_CerrarFormulario.Click += pic_CerrarFormulario_Click;
            // 
            // panel_TiposDeVolquetes
            // 
            panel_TiposDeVolquetes.BackColor = SystemColors.MenuHighlight;
            panel_TiposDeVolquetes.Controls.Add(cmBox_Particular);
            panel_TiposDeVolquetes.Controls.Add(cmBox_Industrial);
            panel_TiposDeVolquetes.Dock = DockStyle.Left;
            panel_TiposDeVolquetes.Location = new Point(0, 0);
            panel_TiposDeVolquetes.Name = "panel_TiposDeVolquetes";
            panel_TiposDeVolquetes.Size = new Size(176, 394);
            panel_TiposDeVolquetes.TabIndex = 30;
            // 
            // cmBox_Particular
            // 
            cmBox_Particular.Cursor = Cursors.Hand;
            cmBox_Particular.FlatStyle = FlatStyle.Popup;
            cmBox_Particular.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cmBox_Particular.FormattingEnabled = true;
            cmBox_Particular.Location = new Point(0, 0);
            cmBox_Particular.Name = "cmBox_Particular";
            cmBox_Particular.Size = new Size(176, 23);
            cmBox_Particular.TabIndex = 38;
            cmBox_Particular.Text = "Volquetes Particulares";
            cmBox_Particular.Visible = false;
            // 
            // cmBox_Industrial
            // 
            cmBox_Industrial.Dock = DockStyle.Top;
            cmBox_Industrial.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cmBox_Industrial.FormattingEnabled = true;
            cmBox_Industrial.Location = new Point(0, 0);
            cmBox_Industrial.Name = "cmBox_Industrial";
            cmBox_Industrial.Size = new Size(176, 23);
            cmBox_Industrial.TabIndex = 37;
            cmBox_Industrial.Text = "Volquetes Industriales";
            // 
            // panel_ContenedorVolquetes
            // 
            panel_ContenedorVolquetes.BackColor = Color.DodgerBlue;
            panel_ContenedorVolquetes.BackgroundImageLayout = ImageLayout.Zoom;
            panel_ContenedorVolquetes.Controls.Add(grpBox_TiposVolquetes);
            panel_ContenedorVolquetes.Controls.Add(btn_InformacionVolquete);
            panel_ContenedorVolquetes.Controls.Add(lbl_Titulo);
            panel_ContenedorVolquetes.Controls.Add(pic_FotoDeVolquetes);
            panel_ContenedorVolquetes.Controls.Add(pic_CerrarFormulario);
            panel_ContenedorVolquetes.Cursor = Cursors.Hand;
            panel_ContenedorVolquetes.Dock = DockStyle.Fill;
            panel_ContenedorVolquetes.Location = new Point(176, 0);
            panel_ContenedorVolquetes.Name = "panel_ContenedorVolquetes";
            panel_ContenedorVolquetes.Size = new Size(500, 394);
            panel_ContenedorVolquetes.TabIndex = 31;
            panel_ContenedorVolquetes.Tag = "";
            // 
            // grpBox_TiposVolquetes
            // 
            grpBox_TiposVolquetes.Controls.Add(rdb_Industrial);
            grpBox_TiposVolquetes.Controls.Add(rdb_Particular);
            grpBox_TiposVolquetes.Location = new Point(315, 47);
            grpBox_TiposVolquetes.Name = "grpBox_TiposVolquetes";
            grpBox_TiposVolquetes.Size = new Size(144, 110);
            grpBox_TiposVolquetes.TabIndex = 37;
            grpBox_TiposVolquetes.TabStop = false;
            grpBox_TiposVolquetes.Text = "Volquetes";
            // 
            // rdb_Industrial
            // 
            rdb_Industrial.AutoSize = true;
            rdb_Industrial.Checked = true;
            rdb_Industrial.Font = new Font("Cambria", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            rdb_Industrial.Location = new Point(19, 22);
            rdb_Industrial.Name = "rdb_Industrial";
            rdb_Industrial.Size = new Size(110, 21);
            rdb_Industrial.TabIndex = 35;
            rdb_Industrial.TabStop = true;
            rdb_Industrial.Text = "Industriales";
            rdb_Industrial.UseVisualStyleBackColor = true;
            // 
            // rdb_Particular
            // 
            rdb_Particular.AutoSize = true;
            rdb_Particular.Font = new Font("Cambria", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            rdb_Particular.Location = new Point(19, 63);
            rdb_Particular.Name = "rdb_Particular";
            rdb_Particular.Size = new Size(111, 21);
            rdb_Particular.TabIndex = 36;
            rdb_Particular.Text = "Particulares";
            rdb_Particular.UseVisualStyleBackColor = true;
            // 
            // btn_InformacionVolquete
            // 
            btn_InformacionVolquete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_InformacionVolquete.AutoSize = true;
            btn_InformacionVolquete.FlatAppearance.BorderSize = 0;
            btn_InformacionVolquete.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_InformacionVolquete.FlatStyle = FlatStyle.Popup;
            btn_InformacionVolquete.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_InformacionVolquete.ForeColor = Color.Black;
            btn_InformacionVolquete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_InformacionVolquete.Location = new Point(394, 352);
            btn_InformacionVolquete.Name = "btn_InformacionVolquete";
            btn_InformacionVolquete.Size = new Size(94, 30);
            btn_InformacionVolquete.TabIndex = 34;
            btn_InformacionVolquete.Text = "Mas informacion";
            btn_InformacionVolquete.UseVisualStyleBackColor = true;
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.Anchor = AnchorStyles.Top;
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Titulo.Location = new Point(156, 8);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(174, 22);
            lbl_Titulo.TabIndex = 8;
            lbl_Titulo.Text = "Tipos de Volquetes";
            // 
            // pic_FotoDeVolquetes
            // 
            pic_FotoDeVolquetes.BackgroundImageLayout = ImageLayout.Zoom;
            pic_FotoDeVolquetes.Location = new Point(24, 47);
            pic_FotoDeVolquetes.Name = "pic_FotoDeVolquetes";
            pic_FotoDeVolquetes.Size = new Size(226, 147);
            pic_FotoDeVolquetes.SizeMode = PictureBoxSizeMode.Zoom;
            pic_FotoDeVolquetes.TabIndex = 7;
            pic_FotoDeVolquetes.TabStop = false;
            // 
            // imgList_FotosTiposVolquetes
            // 
            imgList_FotosTiposVolquetes.ColorDepth = ColorDepth.Depth8Bit;
            imgList_FotosTiposVolquetes.ImageSize = new Size(16, 16);
            imgList_FotosTiposVolquetes.TransparentColor = Color.Transparent;
            // 
            // FormABMVolqueteUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 394);
            Controls.Add(panel_ContenedorVolquetes);
            Controls.Add(panel_TiposDeVolquetes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormABMVolqueteUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormABMVolquete";
            Load += FormABMVolqueteUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).EndInit();
            panel_TiposDeVolquetes.ResumeLayout(false);
            panel_ContenedorVolquetes.ResumeLayout(false);
            panel_ContenedorVolquetes.PerformLayout();
            grpBox_TiposVolquetes.ResumeLayout(false);
            grpBox_TiposVolquetes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_FotoDeVolquetes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pic_CerrarFormulario;
        private Panel panel_TiposDeVolquetes;
        private Panel panel_ContenedorVolquetes;
        private PictureBox pic_FotoDeVolquetes;
        private Label lbl_Titulo;
        private ImageList imgList_FotosTiposVolquetes;
        private Button btn_InformacionVolquete;
        private RadioButton rdb_Industrial;
        private RadioButton rdb_Particular;
        private ComboBox cmBox_Industrial;
        private ComboBox cmBox_Particular;
        private GroupBox grpBox_TiposVolquetes;
    }
}