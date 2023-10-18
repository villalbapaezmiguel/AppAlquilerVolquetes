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
            lbl_TituloListaDeCompras = new Label();
            panel_DatosUsuario = new Panel();
            lbl_Id = new Label();
            lbl_Telefono = new Label();
            lbl_Usuario = new Label();
            lbl_Apellido = new Label();
            lbl_Nombre = new Label();
            panel_ContenedorVolquetes = new Panel();
            lbl_TituloPerfil = new Label();
            pictureBox1 = new PictureBox();
            pic_CerrarFormulario = new PictureBox();
            dtgv_ListasCompras = new DataGridView();
            TipoProducto = new DataGridViewTextBoxColumn();
            IdCompra = new DataGridViewTextBoxColumn();
            PrecioVolquete = new DataGridViewTextBoxColumn();
            CantidadDias = new DataGridViewTextBoxColumn();
            CantidadVolquete = new DataGridViewTextBoxColumn();
            FechaDeEntraga = new DataGridViewTextBoxColumn();
            HorarioDeEntrga = new DataGridViewTextBoxColumn();
            DireccionUsuario = new DataGridViewTextBoxColumn();
            panel_PefilUsuario.SuspendLayout();
            panel_DatosUsuario.SuspendLayout();
            panel_ContenedorVolquetes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_ListasCompras).BeginInit();
            SuspendLayout();
            // 
            // panel_PefilUsuario
            // 
            panel_PefilUsuario.BackColor = SystemColors.HotTrack;
            panel_PefilUsuario.BackgroundImageLayout = ImageLayout.Zoom;
            panel_PefilUsuario.Controls.Add(dtgv_ListasCompras);
            panel_PefilUsuario.Controls.Add(lbl_TituloListaDeCompras);
            panel_PefilUsuario.Controls.Add(panel_DatosUsuario);
            panel_PefilUsuario.Controls.Add(panel_ContenedorVolquetes);
            panel_PefilUsuario.Dock = DockStyle.Fill;
            panel_PefilUsuario.Location = new Point(0, 0);
            panel_PefilUsuario.Name = "panel_PefilUsuario";
            panel_PefilUsuario.Size = new Size(675, 405);
            panel_PefilUsuario.TabIndex = 0;
            panel_PefilUsuario.Paint += panel_PefilUsuario_Paint;
            // 
            // lbl_TituloListaDeCompras
            // 
            lbl_TituloListaDeCompras.AutoSize = true;
            lbl_TituloListaDeCompras.Font = new Font("Comfortaa", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TituloListaDeCompras.Location = new Point(334, 45);
            lbl_TituloListaDeCompras.Name = "lbl_TituloListaDeCompras";
            lbl_TituloListaDeCompras.Size = new Size(185, 29);
            lbl_TituloListaDeCompras.TabIndex = 35;
            lbl_TituloListaDeCompras.Text = "Lista de compras";
            // 
            // panel_DatosUsuario
            // 
            panel_DatosUsuario.BackColor = Color.DodgerBlue;
            panel_DatosUsuario.Controls.Add(lbl_Id);
            panel_DatosUsuario.Controls.Add(lbl_Telefono);
            panel_DatosUsuario.Controls.Add(lbl_Usuario);
            panel_DatosUsuario.Controls.Add(lbl_Apellido);
            panel_DatosUsuario.Controls.Add(lbl_Nombre);
            panel_DatosUsuario.Location = new Point(0, 40);
            panel_DatosUsuario.Name = "panel_DatosUsuario";
            panel_DatosUsuario.Size = new Size(152, 362);
            panel_DatosUsuario.TabIndex = 33;
            // 
            // lbl_Id
            // 
            lbl_Id.AutoSize = true;
            lbl_Id.Font = new Font("Comfortaa", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Id.Location = new Point(3, 287);
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(35, 21);
            lbl_Id.TabIndex = 9;
            lbl_Id.Text = "ID : ";
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Font = new Font("Comfortaa", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Telefono.Location = new Point(3, 108);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(80, 21);
            lbl_Telefono.TabIndex = 8;
            lbl_Telefono.Text = "Telefono : ";
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Font = new Font("Comfortaa", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Usuario.Location = new Point(3, 75);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(76, 21);
            lbl_Usuario.TabIndex = 7;
            lbl_Usuario.Text = "Usuario : ";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Font = new Font("Comfortaa", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Apellido.Location = new Point(3, 44);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(77, 21);
            lbl_Apellido.TabIndex = 6;
            lbl_Apellido.Text = "Apellido : ";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Comfortaa", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Nombre.Location = new Point(3, 12);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(75, 21);
            lbl_Nombre.TabIndex = 5;
            lbl_Nombre.Text = "Nombre : ";
            // 
            // panel_ContenedorVolquetes
            // 
            panel_ContenedorVolquetes.BackColor = Color.DodgerBlue;
            panel_ContenedorVolquetes.BackgroundImageLayout = ImageLayout.Zoom;
            panel_ContenedorVolquetes.Controls.Add(lbl_TituloPerfil);
            panel_ContenedorVolquetes.Controls.Add(pictureBox1);
            panel_ContenedorVolquetes.Controls.Add(pic_CerrarFormulario);
            panel_ContenedorVolquetes.Cursor = Cursors.Hand;
            panel_ContenedorVolquetes.Dock = DockStyle.Top;
            panel_ContenedorVolquetes.Location = new Point(0, 0);
            panel_ContenedorVolquetes.Name = "panel_ContenedorVolquetes";
            panel_ContenedorVolquetes.Size = new Size(675, 40);
            panel_ContenedorVolquetes.TabIndex = 32;
            panel_ContenedorVolquetes.Tag = "";
            // 
            // lbl_TituloPerfil
            // 
            lbl_TituloPerfil.AutoSize = true;
            lbl_TituloPerfil.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TituloPerfil.Location = new Point(12, 9);
            lbl_TituloPerfil.Name = "lbl_TituloPerfil";
            lbl_TituloPerfil.Size = new Size(59, 22);
            lbl_TituloPerfil.TabIndex = 8;
            lbl_TituloPerfil.Text = "Perfil";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1126, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pic_CerrarFormulario
            // 
            pic_CerrarFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pic_CerrarFormulario.BackgroundImage = (Image)resources.GetObject("pic_CerrarFormulario.BackgroundImage");
            pic_CerrarFormulario.BackgroundImageLayout = ImageLayout.Zoom;
            pic_CerrarFormulario.Cursor = Cursors.Hand;
            pic_CerrarFormulario.Location = new Point(647, 0);
            pic_CerrarFormulario.Name = "pic_CerrarFormulario";
            pic_CerrarFormulario.Size = new Size(25, 25);
            pic_CerrarFormulario.SizeMode = PictureBoxSizeMode.Zoom;
            pic_CerrarFormulario.TabIndex = 4;
            pic_CerrarFormulario.TabStop = false;
            pic_CerrarFormulario.Click += pic_CerrarFormulario_Click;
            // 
            // dtgv_ListasCompras
            // 
            dtgv_ListasCompras.BackgroundColor = SystemColors.ActiveCaption;
            dtgv_ListasCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_ListasCompras.Columns.AddRange(new DataGridViewColumn[] { TipoProducto, IdCompra, PrecioVolquete, CantidadDias, CantidadVolquete, FechaDeEntraga, HorarioDeEntrga, DireccionUsuario });
            dtgv_ListasCompras.Location = new Point(155, 77);
            dtgv_ListasCompras.Name = "dtgv_ListasCompras";
            dtgv_ListasCompras.ReadOnly = true;
            dtgv_ListasCompras.RowTemplate.Height = 25;
            dtgv_ListasCompras.Size = new Size(517, 316);
            dtgv_ListasCompras.TabIndex = 53;
            // 
            // TipoProducto
            // 
            TipoProducto.HeaderText = "Tipo";
            TipoProducto.Name = "TipoProducto";
            TipoProducto.ReadOnly = true;
            // 
            // IdCompra
            // 
            IdCompra.HeaderText = "Id";
            IdCompra.Name = "IdCompra";
            IdCompra.ReadOnly = true;
            // 
            // PrecioVolquete
            // 
            PrecioVolquete.HeaderText = "Precio";
            PrecioVolquete.Name = "PrecioVolquete";
            PrecioVolquete.ReadOnly = true;
            // 
            // CantidadDias
            // 
            CantidadDias.HeaderText = "Dias";
            CantidadDias.Name = "CantidadDias";
            CantidadDias.ReadOnly = true;
            // 
            // CantidadVolquete
            // 
            CantidadVolquete.HeaderText = "Cantidad";
            CantidadVolquete.Name = "CantidadVolquete";
            CantidadVolquete.ReadOnly = true;
            // 
            // FechaDeEntraga
            // 
            FechaDeEntraga.HeaderText = "Entrega";
            FechaDeEntraga.Name = "FechaDeEntraga";
            FechaDeEntraga.ReadOnly = true;
            // 
            // HorarioDeEntrga
            // 
            HorarioDeEntrga.HeaderText = "Horario";
            HorarioDeEntrga.Name = "HorarioDeEntrga";
            HorarioDeEntrga.ReadOnly = true;
            // 
            // DireccionUsuario
            // 
            DireccionUsuario.HeaderText = "Direccion";
            DireccionUsuario.Name = "DireccionUsuario";
            DireccionUsuario.ReadOnly = true;
            // 
            // FormPerfilUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 405);
            Controls.Add(panel_PefilUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPerfilUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPerfilUsuario";
            Load += FormPerfilUsuario_Load;
            panel_PefilUsuario.ResumeLayout(false);
            panel_PefilUsuario.PerformLayout();
            panel_DatosUsuario.ResumeLayout(false);
            panel_DatosUsuario.PerformLayout();
            panel_ContenedorVolquetes.ResumeLayout(false);
            panel_ContenedorVolquetes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_ListasCompras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_PefilUsuario;
        private PictureBox pic_CerrarFormulario;
        private Label lbl_Nombre;
        private Panel panel_ContenedorVolquetes;
        private Label lbl_TituloPerfil;
        private PictureBox pictureBox1;
        private Panel panel_DatosUsuario;
        private Label lbl_Usuario;
        private Label lbl_Apellido;
        private Label lbl_Telefono;
        private Label lbl_Id;
        private Label lbl_TituloListaDeCompras;
        private DataGridView dtgv_ListasCompras;
        private DataGridViewTextBoxColumn TipoProducto;
        private DataGridViewTextBoxColumn IdCompra;
        private DataGridViewTextBoxColumn PrecioVolquete;
        private DataGridViewTextBoxColumn CantidadDias;
        private DataGridViewTextBoxColumn CantidadVolquete;
        private DataGridViewTextBoxColumn FechaDeEntraga;
        private DataGridViewTextBoxColumn HorarioDeEntrga;
        private DataGridViewTextBoxColumn DireccionUsuario;
    }
}