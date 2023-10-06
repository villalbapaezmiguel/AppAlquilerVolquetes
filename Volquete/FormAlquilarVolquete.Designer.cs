namespace Formulario
{
    partial class FormAlquilarVolquete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlquilarVolquete));
            lbl_Titulo = new Label();
            pic_CerrarFormulario = new PictureBox();
            panel_Titulo = new Panel();
            lbl_Fecha = new Label();
            cbox_ListaVolquetes = new ComboBox();
            grpBox_Comboboxs = new GroupBox();
            btn_Registrar = new Button();
            rdl_Contendor = new RadioButton();
            rdl_Camion = new RadioButton();
            btn_Cancelar = new Button();
            lbl_MaterialContenedor = new Label();
            cbox_Material = new ComboBox();
            lbl_ModeloCamion = new Label();
            cbox_ModeloVolquete = new ComboBox();
            lbl_PrecioDelProducto = new Label();
            lbl_precio = new Label();
            lbl_DiasDeArriendo = new Label();
            numUD_Cantidad = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            cbox_TipoDePago = new ComboBox();
            btn_Historial = new Button();
            panel_RegistrosCompras = new Panel();
            btn_Volver = new Button();
            dtg_HistorialCompras = new DataGridView();
            btn_Imprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).BeginInit();
            panel_Titulo.SuspendLayout();
            grpBox_Comboboxs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUD_Cantidad).BeginInit();
            panel_RegistrosCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_HistorialCompras).BeginInit();
            SuspendLayout();
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.Anchor = AnchorStyles.Top;
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Titulo.Location = new Point(155, 9);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(372, 22);
            lbl_Titulo.TabIndex = 2;
            lbl_Titulo.Text = "Alquilar Volquetes Camion/Contenedores";
            // 
            // pic_CerrarFormulario
            // 
            pic_CerrarFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pic_CerrarFormulario.BackgroundImage = (Image)resources.GetObject("pic_CerrarFormulario.BackgroundImage");
            pic_CerrarFormulario.BackgroundImageLayout = ImageLayout.Zoom;
            pic_CerrarFormulario.Cursor = Cursors.Hand;
            pic_CerrarFormulario.Location = new Point(652, 3);
            pic_CerrarFormulario.Name = "pic_CerrarFormulario";
            pic_CerrarFormulario.Size = new Size(25, 25);
            pic_CerrarFormulario.SizeMode = PictureBoxSizeMode.Zoom;
            pic_CerrarFormulario.TabIndex = 3;
            pic_CerrarFormulario.TabStop = false;
            pic_CerrarFormulario.Click += pic_CerrarFormulario_Click;
            // 
            // panel_Titulo
            // 
            panel_Titulo.BackColor = Color.DimGray;
            panel_Titulo.Controls.Add(lbl_Fecha);
            panel_Titulo.Controls.Add(pic_CerrarFormulario);
            panel_Titulo.Controls.Add(lbl_Titulo);
            panel_Titulo.Dock = DockStyle.Top;
            panel_Titulo.Location = new Point(0, 0);
            panel_Titulo.Name = "panel_Titulo";
            panel_Titulo.Size = new Size(680, 37);
            panel_Titulo.TabIndex = 4;
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Location = new Point(12, 12);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new Size(84, 15);
            lbl_Fecha.TabIndex = 8;
            lbl_Fecha.Text = "Fecha Actual : ";
            // 
            // cbox_ListaVolquetes
            // 
            cbox_ListaVolquetes.FormattingEnabled = true;
            cbox_ListaVolquetes.Location = new Point(6, 37);
            cbox_ListaVolquetes.Name = "cbox_ListaVolquetes";
            cbox_ListaVolquetes.Size = new Size(201, 23);
            cbox_ListaVolquetes.TabIndex = 5;
            cbox_ListaVolquetes.SelectedIndexChanged += cbox_ListaVolquetes_SelectedIndexChanged;
            // 
            // grpBox_Comboboxs
            // 
            grpBox_Comboboxs.BackColor = Color.Transparent;
            grpBox_Comboboxs.Controls.Add(btn_Registrar);
            grpBox_Comboboxs.Controls.Add(rdl_Contendor);
            grpBox_Comboboxs.Controls.Add(rdl_Camion);
            grpBox_Comboboxs.Controls.Add(btn_Cancelar);
            grpBox_Comboboxs.Controls.Add(lbl_MaterialContenedor);
            grpBox_Comboboxs.Controls.Add(cbox_Material);
            grpBox_Comboboxs.Controls.Add(lbl_ModeloCamion);
            grpBox_Comboboxs.Controls.Add(cbox_ModeloVolquete);
            grpBox_Comboboxs.Controls.Add(lbl_PrecioDelProducto);
            grpBox_Comboboxs.Controls.Add(lbl_precio);
            grpBox_Comboboxs.Controls.Add(lbl_DiasDeArriendo);
            grpBox_Comboboxs.Controls.Add(numUD_Cantidad);
            grpBox_Comboboxs.Controls.Add(label2);
            grpBox_Comboboxs.Controls.Add(label1);
            grpBox_Comboboxs.Controls.Add(cbox_TipoDePago);
            grpBox_Comboboxs.Controls.Add(cbox_ListaVolquetes);
            grpBox_Comboboxs.Location = new Point(3, 43);
            grpBox_Comboboxs.Name = "grpBox_Comboboxs";
            grpBox_Comboboxs.Size = new Size(674, 242);
            grpBox_Comboboxs.TabIndex = 6;
            grpBox_Comboboxs.TabStop = false;
            grpBox_Comboboxs.Text = "Area de compra";
            // 
            // btn_Registrar
            // 
            btn_Registrar.BackColor = Color.Silver;
            btn_Registrar.FlatAppearance.BorderSize = 0;
            btn_Registrar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_Registrar.FlatStyle = FlatStyle.Flat;
            btn_Registrar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Registrar.ForeColor = Color.Black;
            btn_Registrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Registrar.Location = new Point(353, 194);
            btn_Registrar.Name = "btn_Registrar";
            btn_Registrar.Size = new Size(88, 30);
            btn_Registrar.TabIndex = 10;
            btn_Registrar.Text = "Registrar";
            btn_Registrar.UseVisualStyleBackColor = false;
            btn_Registrar.Click += btn_Registrar_Click;
            // 
            // rdl_Contendor
            // 
            rdl_Contendor.AutoSize = true;
            rdl_Contendor.Location = new Point(274, 86);
            rdl_Contendor.Name = "rdl_Contendor";
            rdl_Contendor.Size = new Size(88, 19);
            rdl_Contendor.TabIndex = 20;
            rdl_Contendor.TabStop = true;
            rdl_Contendor.Text = "Contenedor";
            rdl_Contendor.UseVisualStyleBackColor = true;
            rdl_Contendor.Click += rdl_Contendor_Click;
            // 
            // rdl_Camion
            // 
            rdl_Camion.AutoSize = true;
            rdl_Camion.Checked = true;
            rdl_Camion.Location = new Point(274, 61);
            rdl_Camion.Name = "rdl_Camion";
            rdl_Camion.Size = new Size(67, 19);
            rdl_Camion.TabIndex = 19;
            rdl_Camion.TabStop = true;
            rdl_Camion.Text = "Camion";
            rdl_Camion.UseVisualStyleBackColor = true;
            rdl_Camion.Click += rdl_Contendor_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.Silver;
            btn_Cancelar.FlatAppearance.BorderSize = 0;
            btn_Cancelar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cancelar.ForeColor = Color.Black;
            btn_Cancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Cancelar.Location = new Point(239, 194);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(88, 30);
            btn_Cancelar.TabIndex = 9;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // lbl_MaterialContenedor
            // 
            lbl_MaterialContenedor.Anchor = AnchorStyles.Top;
            lbl_MaterialContenedor.AutoSize = true;
            lbl_MaterialContenedor.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_MaterialContenedor.Location = new Point(9, 74);
            lbl_MaterialContenedor.Name = "lbl_MaterialContenedor";
            lbl_MaterialContenedor.Size = new Size(139, 15);
            lbl_MaterialContenedor.TabIndex = 18;
            lbl_MaterialContenedor.Text = "Seleccione el material";
            lbl_MaterialContenedor.Visible = false;
            // 
            // cbox_Material
            // 
            cbox_Material.FormattingEnabled = true;
            cbox_Material.Location = new Point(6, 92);
            cbox_Material.Name = "cbox_Material";
            cbox_Material.Size = new Size(201, 23);
            cbox_Material.TabIndex = 16;
            cbox_Material.Visible = false;
            // 
            // lbl_ModeloCamion
            // 
            lbl_ModeloCamion.Anchor = AnchorStyles.Top;
            lbl_ModeloCamion.AutoSize = true;
            lbl_ModeloCamion.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ModeloCamion.Location = new Point(11, 74);
            lbl_ModeloCamion.Name = "lbl_ModeloCamion";
            lbl_ModeloCamion.Size = new Size(133, 15);
            lbl_ModeloCamion.TabIndex = 15;
            lbl_ModeloCamion.Text = "Seleccione El modelo";
            // 
            // cbox_ModeloVolquete
            // 
            cbox_ModeloVolquete.FormattingEnabled = true;
            cbox_ModeloVolquete.Location = new Point(6, 92);
            cbox_ModeloVolquete.Name = "cbox_ModeloVolquete";
            cbox_ModeloVolquete.Size = new Size(201, 23);
            cbox_ModeloVolquete.TabIndex = 14;
            // 
            // lbl_PrecioDelProducto
            // 
            lbl_PrecioDelProducto.BackColor = Color.DarkGray;
            lbl_PrecioDelProducto.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PrecioDelProducto.Location = new Point(464, 61);
            lbl_PrecioDelProducto.Name = "lbl_PrecioDelProducto";
            lbl_PrecioDelProducto.Size = new Size(135, 44);
            lbl_PrecioDelProducto.TabIndex = 13;
            lbl_PrecioDelProducto.Text = "lbl_Precio";
            lbl_PrecioDelProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_precio
            // 
            lbl_precio.Anchor = AnchorStyles.Top;
            lbl_precio.AutoSize = true;
            lbl_precio.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_precio.Location = new Point(469, 37);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(135, 15);
            lbl_precio.TabIndex = 12;
            lbl_precio.Text = "Precio del producto : ";
            // 
            // lbl_DiasDeArriendo
            // 
            lbl_DiasDeArriendo.Anchor = AnchorStyles.Top;
            lbl_DiasDeArriendo.AutoSize = true;
            lbl_DiasDeArriendo.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DiasDeArriendo.Location = new Point(6, 176);
            lbl_DiasDeArriendo.Name = "lbl_DiasDeArriendo";
            lbl_DiasDeArriendo.Size = new Size(107, 15);
            lbl_DiasDeArriendo.TabIndex = 11;
            lbl_DiasDeArriendo.Text = "Dias de arriendo";
            // 
            // numUD_Cantidad
            // 
            numUD_Cantidad.Location = new Point(6, 194);
            numUD_Cantidad.Name = "numUD_Cantidad";
            numUD_Cantidad.Size = new Size(102, 23);
            numUD_Cantidad.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 127);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 9;
            label2.Text = "Seleccione tipo de pago";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 8;
            label1.Text = "Seleccione la Marca";
            // 
            // cbox_TipoDePago
            // 
            cbox_TipoDePago.FormattingEnabled = true;
            cbox_TipoDePago.Location = new Point(6, 145);
            cbox_TipoDePago.Name = "cbox_TipoDePago";
            cbox_TipoDePago.Size = new Size(201, 23);
            cbox_TipoDePago.TabIndex = 6;
            // 
            // btn_Historial
            // 
            btn_Historial.BackColor = Color.Silver;
            btn_Historial.FlatAppearance.BorderSize = 0;
            btn_Historial.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_Historial.FlatStyle = FlatStyle.Flat;
            btn_Historial.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Historial.ForeColor = Color.Black;
            btn_Historial.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Historial.Location = new Point(580, 339);
            btn_Historial.Name = "btn_Historial";
            btn_Historial.Size = new Size(88, 30);
            btn_Historial.TabIndex = 11;
            btn_Historial.Text = "Historial ";
            btn_Historial.UseVisualStyleBackColor = false;
            btn_Historial.Click += btn_Historial_Click;
            // 
            // panel_RegistrosCompras
            // 
            panel_RegistrosCompras.Controls.Add(btn_Imprimir);
            panel_RegistrosCompras.Controls.Add(btn_Volver);
            panel_RegistrosCompras.Controls.Add(dtg_HistorialCompras);
            panel_RegistrosCompras.Dock = DockStyle.Fill;
            panel_RegistrosCompras.Location = new Point(0, 37);
            panel_RegistrosCompras.Name = "panel_RegistrosCompras";
            panel_RegistrosCompras.Size = new Size(680, 344);
            panel_RegistrosCompras.TabIndex = 21;
            panel_RegistrosCompras.Visible = false;
            // 
            // btn_Volver
            // 
            btn_Volver.Location = new Point(21, 302);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(75, 23);
            btn_Volver.TabIndex = 1;
            btn_Volver.Text = "Volver";
            btn_Volver.UseVisualStyleBackColor = true;
            btn_Volver.Click += btn_Volver_Click;
            // 
            // dtg_HistorialCompras
            // 
            dtg_HistorialCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_HistorialCompras.Location = new Point(38, 28);
            dtg_HistorialCompras.Name = "dtg_HistorialCompras";
            dtg_HistorialCompras.RowTemplate.Height = 25;
            dtg_HistorialCompras.Size = new Size(592, 249);
            dtg_HistorialCompras.TabIndex = 0;
            // 
            // btn_Imprimir
            // 
            btn_Imprimir.Location = new Point(555, 302);
            btn_Imprimir.Name = "btn_Imprimir";
            btn_Imprimir.Size = new Size(75, 23);
            btn_Imprimir.TabIndex = 2;
            btn_Imprimir.Text = "Imprimir";
            btn_Imprimir.UseVisualStyleBackColor = true;
            btn_Imprimir.Click += btn_Imprimir_Click;
            // 
            // FormAlquilarVolquete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(680, 381);
            Controls.Add(panel_RegistrosCompras);
            Controls.Add(btn_Historial);
            Controls.Add(grpBox_Comboboxs);
            Controls.Add(panel_Titulo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAlquilarVolquete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTiposVolquetes";
            Load += FormAlquilarVolquete_Load;
            ((System.ComponentModel.ISupportInitialize)pic_CerrarFormulario).EndInit();
            panel_Titulo.ResumeLayout(false);
            panel_Titulo.PerformLayout();
            grpBox_Comboboxs.ResumeLayout(false);
            grpBox_Comboboxs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUD_Cantidad).EndInit();
            panel_RegistrosCompras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_HistorialCompras).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_Titulo;
        private PictureBox pic_CerrarFormulario;
        private Panel panel_Titulo;
        private ComboBox cbox_ListaVolquetes;
        private GroupBox grpBox_Comboboxs;
        private ComboBox cbox_TipoDePago;
        private Label lbl_Fecha;
        private Label label1;
        private Label label2;
        private NumericUpDown numUD_Cantidad;
        private Label lbl_DiasDeArriendo;
        private Label lbl_precio;
        private Label lbl_PrecioDelProducto;
        private Button btn_Cancelar;
        private Button btn_Registrar;
        private Label lbl_ModeloCamion;
        private ComboBox cbox_ModeloVolquete;
        private ComboBox cbox_Material;
        private Label lbl_MaterialContenedor;
        private RadioButton rdl_Contendor;
        private RadioButton rdl_Camion;
        private Button btn_Historial;
        private Panel panel_RegistrosCompras;
        private Button btn_Volver;
        private DataGridView dtg_HistorialCompras;
        private Button btn_Imprimir;
    }
}