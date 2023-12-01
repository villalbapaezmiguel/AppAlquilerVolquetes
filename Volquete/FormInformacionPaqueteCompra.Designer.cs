namespace Vista
{
    partial class FormInformacionPaqueteCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformacionPaqueteCompra));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pic_Cerrar = new PictureBox();
            dtgv_Datos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pic_Cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_Datos).BeginInit();
            SuspendLayout();
            // 
            // pic_Cerrar
            // 
            pic_Cerrar.BackgroundImage = (Image)resources.GetObject("pic_Cerrar.BackgroundImage");
            pic_Cerrar.BackgroundImageLayout = ImageLayout.Zoom;
            pic_Cerrar.Cursor = Cursors.Hand;
            pic_Cerrar.Location = new Point(552, 0);
            pic_Cerrar.Name = "pic_Cerrar";
            pic_Cerrar.Size = new Size(25, 25);
            pic_Cerrar.TabIndex = 4;
            pic_Cerrar.TabStop = false;
            pic_Cerrar.Click += pic_Cerrar_Click;
            // 
            // dtgv_Datos
            // 
            dtgv_Datos.BackgroundColor = Color.FromArgb(45, 66, 91);
            dtgv_Datos.BorderStyle = BorderStyle.None;
            dtgv_Datos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_Datos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Constantia", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgv_Datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_Datos.ColumnHeadersHeight = 30;
            dtgv_Datos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgv_Datos.Cursor = Cursors.Hand;
            dtgv_Datos.EnableHeadersVisualStyles = false;
            dtgv_Datos.GridColor = Color.SteelBlue;
            dtgv_Datos.Location = new Point(6, 64);
            dtgv_Datos.Name = "dtgv_Datos";
            dtgv_Datos.ReadOnly = true;
            dtgv_Datos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgv_Datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgv_Datos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dtgv_Datos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dtgv_Datos.RowTemplate.Height = 25;
            dtgv_Datos.Size = new Size(571, 247);
            dtgv_Datos.TabIndex = 5;
            // 
            // FormInformacionPaqueteCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 57, 70);
            ClientSize = new Size(581, 323);
            Controls.Add(dtgv_Datos);
            Controls.Add(pic_Cerrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInformacionPaqueteCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInformacionPaqueteCompra";
            Load += FormInformacionPaqueteCompra_Load;
            ((System.ComponentModel.ISupportInitialize)pic_Cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_Datos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_Cerrar;
        private DataGridView dtgv_Datos;
    }
}