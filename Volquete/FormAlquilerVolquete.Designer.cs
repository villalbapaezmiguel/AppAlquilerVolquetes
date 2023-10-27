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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlquilerVolquete));
            panel_Datos = new Panel();
            label6 = new Label();
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
            dtgv_Compra = new DataGridView();
            btn_Agregar = new Button();
            btn_Modificar = new Button();
            btn_Eliminar = new Button();
            pic_CerrarFormulario = new PictureBox();
            panel_Contenedor = new Panel();
            btn_Comprar = new Button();
            btn_SeleccionarFecha = new Button();
            mthCalendar_FechaDeEntrega = new MonthCalendar();
            panel_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUD_Dias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUD_Cantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_Compra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).BeginInit();
            panel_Contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Datos
            // 
            panel_Datos.BackColor = Color.FromArgb(41, 128, 185);
            panel_Datos.Controls.Add(label6);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(18, 272);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 16;
            label6.Text = "DIRECCION";
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
            lbl_Id.Location = new Point(99, 319);
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(25, 23);
            lbl_Id.TabIndex = 14;
            lbl_Id.Text = "...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(29, 327);
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
            label3.Location = new Point(23, 224);
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
            lbl_Precio.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Precio.Location = new Point(86, 354);
            lbl_Precio.Name = "lbl_Precio";
            lbl_Precio.Size = new Size(38, 19);
            lbl_Precio.TabIndex = 10;
            lbl_Precio.Text = "$0.0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 357);
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
            // dtgv_Compra
            // 
            dtgv_Compra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgv_Compra.BackgroundColor = Color.FromArgb(31, 97, 141);
            dtgv_Compra.BorderStyle = BorderStyle.None;
            dtgv_Compra.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_Compra.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(11, 83, 69);
            dataGridViewCellStyle4.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgv_Compra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgv_Compra.ColumnHeadersHeight = 30;
            dtgv_Compra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgv_Compra.Dock = DockStyle.Bottom;
            dtgv_Compra.EnableHeadersVisualStyles = false;
            dtgv_Compra.GridColor = Color.SteelBlue;
            dtgv_Compra.Location = new Point(188, 255);
            dtgv_Compra.Name = "dtgv_Compra";
            dtgv_Compra.ReadOnly = true;
            dtgv_Compra.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(11, 83, 69);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dtgv_Compra.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(31, 97, 141);
            dataGridViewCellStyle6.Font = new Font("Constantia", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dtgv_Compra.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dtgv_Compra.RowTemplate.Height = 25;
            dtgv_Compra.Size = new Size(492, 126);
            dtgv_Compra.TabIndex = 2;
            dtgv_Compra.CellClick += dtgv_Compra_CellClick;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Cursor = Cursors.Hand;
            btn_Agregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 165, 137);
            btn_Agregar.FlatStyle = FlatStyle.Flat;
            btn_Agregar.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Agregar.Location = new Point(584, 45);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(93, 23);
            btn_Agregar.TabIndex = 3;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Modificar
            // 
            btn_Modificar.Cursor = Cursors.Hand;
            btn_Modificar.Enabled = false;
            btn_Modificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 165, 137);
            btn_Modificar.FlatStyle = FlatStyle.Flat;
            btn_Modificar.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Modificar.Location = new Point(584, 74);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(93, 23);
            btn_Modificar.TabIndex = 4;
            btn_Modificar.Text = "MODIFICAR";
            btn_Modificar.UseVisualStyleBackColor = true;
            btn_Modificar.Click += btn_Modificar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Cursor = Cursors.Hand;
            btn_Eliminar.Enabled = false;
            btn_Eliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(146, 43, 33);
            btn_Eliminar.FlatStyle = FlatStyle.Flat;
            btn_Eliminar.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Eliminar.Location = new Point(584, 106);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(93, 23);
            btn_Eliminar.TabIndex = 5;
            btn_Eliminar.Text = "ELIMINAR";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
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
            // panel_Contenedor
            // 
            panel_Contenedor.BackColor = Color.SteelBlue;
            panel_Contenedor.Controls.Add(btn_Comprar);
            panel_Contenedor.Controls.Add(btn_SeleccionarFecha);
            panel_Contenedor.Controls.Add(mthCalendar_FechaDeEntrega);
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
            // btn_Comprar
            // 
            btn_Comprar.Cursor = Cursors.Hand;
            btn_Comprar.Enabled = false;
            btn_Comprar.FlatAppearance.MouseOverBackColor = Color.FromArgb(146, 43, 33);
            btn_Comprar.FlatStyle = FlatStyle.Flat;
            btn_Comprar.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Comprar.Location = new Point(584, 135);
            btn_Comprar.Name = "btn_Comprar";
            btn_Comprar.Size = new Size(93, 23);
            btn_Comprar.TabIndex = 9;
            btn_Comprar.Text = "COMPRAR";
            btn_Comprar.UseVisualStyleBackColor = true;
            btn_Comprar.Click += btn_Comprar_Click;
            // 
            // btn_SeleccionarFecha
            // 
            btn_SeleccionarFecha.Cursor = Cursors.Hand;
            btn_SeleccionarFecha.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 165, 137);
            btn_SeleccionarFecha.FlatStyle = FlatStyle.Flat;
            btn_SeleccionarFecha.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_SeleccionarFecha.Location = new Point(259, 196);
            btn_SeleccionarFecha.Name = "btn_SeleccionarFecha";
            btn_SeleccionarFecha.Size = new Size(135, 23);
            btn_SeleccionarFecha.TabIndex = 8;
            btn_SeleccionarFecha.Text = "Seleccionar Fecha";
            btn_SeleccionarFecha.UseVisualStyleBackColor = true;
            btn_SeleccionarFecha.Click += btn_SeleccionarFecha_Click;
            // 
            // mthCalendar_FechaDeEntrega
            // 
            mthCalendar_FechaDeEntrega.BackColor = Color.DarkOrchid;
            mthCalendar_FechaDeEntrega.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mthCalendar_FechaDeEntrega.Location = new Point(200, 22);
            mthCalendar_FechaDeEntrega.MaxDate = new DateTime(2025, 12, 25, 0, 0, 0, 0);
            mthCalendar_FechaDeEntrega.MaxSelectionCount = 1;
            mthCalendar_FechaDeEntrega.MinDate = new DateTime(2023, 12, 25, 23, 59, 59, 0);
            mthCalendar_FechaDeEntrega.Name = "mthCalendar_FechaDeEntrega";
            mthCalendar_FechaDeEntrega.TabIndex = 1;
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
            panel_Datos.ResumeLayout(false);
            panel_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUD_Dias).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUD_Cantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_Compra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).EndInit();
            panel_Contenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Datos;
        private NumericUpDown numUD_Dias;
        private Label lbl_Id;
        private Label label7;
        private TextBox txt_Direccion;
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
        private DataGridView dtgv_Compra;
        private Button btn_Agregar;
        private Button btn_Modificar;
        private Button btn_Eliminar;
        private PictureBox pic_CerrarFormulario;
        private Panel panel_Contenedor;
        private Button btn_SeleccionarFecha;
        private MonthCalendar mthCalendar_FechaDeEntrega;
        private Label label6;
        private Button btn_Comprar;
    }
}