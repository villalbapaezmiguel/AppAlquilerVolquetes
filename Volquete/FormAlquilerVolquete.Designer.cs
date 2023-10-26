namespace Vista
{
    partial class FormAlquilerVolquete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlquilerVolquete));
            panel_Contenedor = new Panel();
            pic_CerrarFormulario = new PictureBox();
            btn_Eliminar = new Button();
            btn_Modificar = new Button();
            btn_Agregar = new Button();
            dtgv_Compra = new DataGridView();
            panel_Datos = new Panel();
            pic_FechaDeEntrega = new PictureBox();
            numUD_Dias = new NumericUpDown();
            lbl_Id = new Label();
            label7 = new Label();
            txt_Direccion = new TextBox();
            label3 = new Label();
            txt_FechaDeEntrga = new TextBox();
            lbl_Precio = new Label();
            label5 = new Label();
            numUD_Cantidad = new NumericUpDown();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbox_Horario = new ComboBox();
            lbl_Tipo = new Label();
            cmbox_Tipo = new ComboBox();
            panel_Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_Compra).BeginInit();
            panel_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_FechaDeEntrega).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUD_Dias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUD_Cantidad).BeginInit();
            SuspendLayout();
            // 
            // panel_Contenedor
            // 
            panel_Contenedor.BackColor = Color.FromArgb(31, 97, 141);
            panel_Contenedor.Controls.Add(pic_CerrarFormulario);
            panel_Contenedor.Controls.Add(btn_Eliminar);
            panel_Contenedor.Controls.Add(btn_Modificar);
            panel_Contenedor.Controls.Add(btn_Agregar);
            panel_Contenedor.Controls.Add(dtgv_Compra);
            panel_Contenedor.Controls.Add(panel_Datos);
            panel_Contenedor.Dock = DockStyle.Fill;
            panel_Contenedor.Location = new Point(0, 0);
            panel_Contenedor.Name = "panel_Contenedor";
            panel_Contenedor.Size = new Size(680, 381);
            panel_Contenedor.TabIndex = 1;
            // 
            // pic_CerrarFormulario
            // 
            pic_CerrarFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pic_CerrarFormulario.BackgroundImage = (Image)resources.GetObject("pic_CerrarFormulario.BackgroundImage");
            pic_CerrarFormulario.BackgroundImageLayout = ImageLayout.Zoom;
            pic_CerrarFormulario.Cursor = Cursors.Hand;
            pic_CerrarFormulario.Location = new Point(654, 0);
            pic_CerrarFormulario.Name = "pic_CerrarFormulario";
            pic_CerrarFormulario.Size = new Size(25, 25);
            pic_CerrarFormulario.SizeMode = PictureBoxSizeMode.Zoom;
            pic_CerrarFormulario.TabIndex = 6;
            pic_CerrarFormulario.TabStop = false;
            pic_CerrarFormulario.Click += pic_CerrarFormulario_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Cursor = Cursors.Hand;
            btn_Eliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(146, 43, 33);
            btn_Eliminar.FlatStyle = FlatStyle.Flat;
            btn_Eliminar.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Eliminar.Location = new Point(408, 226);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(93, 23);
            btn_Eliminar.TabIndex = 5;
            btn_Eliminar.Text = "ELIMINAR";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Modificar
            // 
            btn_Modificar.Cursor = Cursors.Hand;
            btn_Modificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 165, 137);
            btn_Modificar.FlatStyle = FlatStyle.Flat;
            btn_Modificar.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Modificar.Location = new Point(309, 226);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(93, 23);
            btn_Modificar.TabIndex = 4;
            btn_Modificar.Text = "MODIFICAR";
            btn_Modificar.UseVisualStyleBackColor = true;
            btn_Modificar.Click += btn_Modificar_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Cursor = Cursors.Hand;
            btn_Agregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 165, 137);
            btn_Agregar.FlatStyle = FlatStyle.Flat;
            btn_Agregar.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Agregar.Location = new Point(204, 226);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(93, 23);
            btn_Agregar.TabIndex = 3;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // dtgv_Compra
            // 
            dtgv_Compra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_Compra.Dock = DockStyle.Bottom;
            dtgv_Compra.Location = new Point(188, 255);
            dtgv_Compra.Name = "dtgv_Compra";
            dtgv_Compra.RowTemplate.Height = 25;
            dtgv_Compra.Size = new Size(492, 126);
            dtgv_Compra.TabIndex = 2;
            dtgv_Compra.CellClick += dtgv_Compra_CellClick;
            // 
            // panel_Datos
            // 
            panel_Datos.BackColor = Color.FromArgb(26, 82, 118);
            panel_Datos.Controls.Add(pic_FechaDeEntrega);
            panel_Datos.Controls.Add(numUD_Dias);
            panel_Datos.Controls.Add(lbl_Id);
            panel_Datos.Controls.Add(label7);
            panel_Datos.Controls.Add(txt_Direccion);
            panel_Datos.Controls.Add(label3);
            panel_Datos.Controls.Add(txt_FechaDeEntrga);
            panel_Datos.Controls.Add(lbl_Precio);
            panel_Datos.Controls.Add(label5);
            panel_Datos.Controls.Add(numUD_Cantidad);
            panel_Datos.Controls.Add(label4);
            panel_Datos.Controls.Add(label2);
            panel_Datos.Controls.Add(label1);
            panel_Datos.Controls.Add(cmbox_Horario);
            panel_Datos.Controls.Add(lbl_Tipo);
            panel_Datos.Controls.Add(cmbox_Tipo);
            panel_Datos.Dock = DockStyle.Left;
            panel_Datos.Location = new Point(0, 0);
            panel_Datos.Name = "panel_Datos";
            panel_Datos.Size = new Size(188, 381);
            panel_Datos.TabIndex = 1;
            // 
            // pic_FechaDeEntrega
            // 
            pic_FechaDeEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pic_FechaDeEntrega.BackgroundImage = (Image)resources.GetObject("pic_FechaDeEntrega.BackgroundImage");
            pic_FechaDeEntrega.BackgroundImageLayout = ImageLayout.Zoom;
            pic_FechaDeEntrega.Cursor = Cursors.Hand;
            pic_FechaDeEntrega.Location = new Point(147, 240);
            pic_FechaDeEntrega.Name = "pic_FechaDeEntrega";
            pic_FechaDeEntrega.Size = new Size(25, 25);
            pic_FechaDeEntrega.SizeMode = PictureBoxSizeMode.Zoom;
            pic_FechaDeEntrega.TabIndex = 55;
            pic_FechaDeEntrega.TabStop = false;
            pic_FechaDeEntrega.Click += pic_FechaDeEntrega_Click;
            // 
            // numUD_Dias
            // 
            numUD_Dias.BorderStyle = BorderStyle.None;
            numUD_Dias.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            numUD_Dias.Location = new Point(62, 129);
            numUD_Dias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUD_Dias.Name = "numUD_Dias";
            numUD_Dias.Size = new Size(40, 19);
            numUD_Dias.TabIndex = 15;
            numUD_Dias.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numUD_Dias.Click += numUD_Dias_Click;
            // 
            // lbl_Id
            // 
            lbl_Id.AutoSize = true;
            lbl_Id.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Id.Location = new Point(109, 312);
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(25, 23);
            lbl_Id.TabIndex = 14;
            lbl_Id.Text = "...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(39, 320);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 13;
            label7.Text = "ID : ";
            // 
            // txt_Direccion
            // 
            txt_Direccion.BorderStyle = BorderStyle.None;
            txt_Direccion.Cursor = Cursors.Hand;
            txt_Direccion.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Direccion.Location = new Point(18, 290);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.PlaceholderText = "Direccion";
            txt_Direccion.Size = new Size(124, 19);
            txt_Direccion.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 224);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 11;
            label3.Text = "FECHA DE ENTREGA";
            // 
            // txt_FechaDeEntrga
            // 
            txt_FechaDeEntrga.BorderStyle = BorderStyle.None;
            txt_FechaDeEntrga.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_FechaDeEntrga.Location = new Point(18, 242);
            txt_FechaDeEntrga.Name = "txt_FechaDeEntrga";
            txt_FechaDeEntrga.PlaceholderText = "DD/MM/AAAA";
            txt_FechaDeEntrga.ReadOnly = true;
            txt_FechaDeEntrga.Size = new Size(124, 19);
            txt_FechaDeEntrga.TabIndex = 6;
            // 
            // lbl_Precio
            // 
            lbl_Precio.AutoSize = true;
            lbl_Precio.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Precio.Location = new Point(99, 349);
            lbl_Precio.Name = "lbl_Precio";
            lbl_Precio.Size = new Size(43, 23);
            lbl_Precio.TabIndex = 10;
            lbl_Precio.Text = "$0.0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(29, 357);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 6;
            label5.Text = "PRECIO : ";
            // 
            // numUD_Cantidad
            // 
            numUD_Cantidad.BorderStyle = BorderStyle.None;
            numUD_Cantidad.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            numUD_Cantidad.Location = new Point(62, 187);
            numUD_Cantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUD_Cantidad.Name = "numUD_Cantidad";
            numUD_Cantidad.Size = new Size(40, 19);
            numUD_Cantidad.TabIndex = 8;
            numUD_Cantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numUD_Cantidad.Click += numUD_Dias_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(52, 169);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 9;
            label4.Text = "CANTIDAD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(62, 111);
            label2.Name = "label2";
            label2.Size = new Size(35, 18);
            label2.TabIndex = 6;
            label2.Text = "Dias";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 57);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "HORARIO";
            // 
            // cmbox_Horario
            // 
            cmbox_Horario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbox_Horario.FormattingEnabled = true;
            cmbox_Horario.Location = new Point(12, 75);
            cmbox_Horario.Name = "cmbox_Horario";
            cmbox_Horario.Size = new Size(153, 23);
            cmbox_Horario.TabIndex = 3;
            // 
            // lbl_Tipo
            // 
            lbl_Tipo.AutoSize = true;
            lbl_Tipo.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Tipo.Location = new Point(39, 3);
            lbl_Tipo.Name = "lbl_Tipo";
            lbl_Tipo.Size = new Size(98, 15);
            lbl_Tipo.TabIndex = 2;
            lbl_Tipo.Text = "TIPO VOLQUETE";
            // 
            // cmbox_Tipo
            // 
            cmbox_Tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbox_Tipo.FormattingEnabled = true;
            cmbox_Tipo.Location = new Point(12, 22);
            cmbox_Tipo.Name = "cmbox_Tipo";
            cmbox_Tipo.Size = new Size(153, 23);
            cmbox_Tipo.TabIndex = 2;
            cmbox_Tipo.SelectedIndexChanged += cmbox_Tipo_SelectedIndexChanged;
            // 
            // FormAlquilerVolquete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 381);
            Controls.Add(panel_Contenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAlquilerVolquete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAlquiler";
            Load += FormAlquilerVolquete_Load;
            panel_Contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_Compra).EndInit();
            panel_Datos.ResumeLayout(false);
            panel_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_FechaDeEntrega).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUD_Dias).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUD_Cantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Contenedor;
        private Button btn_Eliminar;
        private Button btn_Modificar;
        private Button btn_Agregar;
        private DataGridView dtgv_Compra;
        private Panel panel_Datos;
        private Label label3;
        private TextBox txt_FechaDeEntrga;
        private Label lbl_Precio;
        private Label label5;
        private NumericUpDown numUD_Cantidad;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox cmbox_Horario;
        private Label lbl_Tipo;
        private ComboBox cmbox_Tipo;
        private PictureBox pic_CerrarFormulario;
        private TextBox txt_Direccion;
        private Label lbl_Id;
        private Label label7;
        private NumericUpDown numUD_Dias;
        private PictureBox pic_FechaDeEntrega;
    }
}