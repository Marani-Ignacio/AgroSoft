namespace Vista
{
    partial class FormVentas
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
            label5 = new Label();
            dgvVentas = new DataGridView();
            label4 = new Label();
            dgvDetalleVenta = new DataGridView();
            label3 = new Label();
            dgvDatosCliente = new DataGridView();
            btnNuevoIngreso = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            iconEliminarRegistro = new FontAwesome.Sharp.IconMenuItem();
            iconComprobante = new FontAwesome.Sharp.IconMenuItem();
            iconExportarExcel = new FontAwesome.Sharp.IconMenuItem();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosCliente).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DimGray;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(10, 48);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 36;
            label5.Text = "LISTA DE VENTAS";
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(10, 65);
            dgvVentas.Margin = new Padding(3, 2, 3, 2);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.RowTemplate.Height = 29;
            dgvVentas.Size = new Size(454, 331);
            dgvVentas.TabIndex = 35;
            dgvVentas.CellClick += dgvVentas_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DimGray;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(479, 48);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 34;
            label4.Text = "Datos Cliente";
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Location = new Point(479, 138);
            dgvDetalleVenta.Margin = new Padding(3, 2, 3, 2);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.RowHeadersWidth = 51;
            dgvDetalleVenta.RowTemplate.Height = 29;
            dgvDetalleVenta.Size = new Size(568, 258);
            dgvDetalleVenta.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DimGray;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(479, 121);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 32;
            label3.Text = "Detalle Venta";
            // 
            // dgvDatosCliente
            // 
            dgvDatosCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosCliente.Location = new Point(479, 65);
            dgvDatosCliente.Margin = new Padding(3, 2, 3, 2);
            dgvDatosCliente.Name = "dgvDatosCliente";
            dgvDatosCliente.RowHeadersWidth = 51;
            dgvDatosCliente.RowTemplate.Height = 29;
            dgvDatosCliente.Size = new Size(568, 50);
            dgvDatosCliente.TabIndex = 31;
            // 
            // btnNuevoIngreso
            // 
            btnNuevoIngreso.BackColor = Color.MediumSeaGreen;
            btnNuevoIngreso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevoIngreso.ForeColor = SystemColors.Control;
            btnNuevoIngreso.Location = new Point(196, 13);
            btnNuevoIngreso.Margin = new Padding(3, 2, 3, 2);
            btnNuevoIngreso.Name = "btnNuevoIngreso";
            btnNuevoIngreso.Size = new Size(111, 23);
            btnNuevoIngreso.TabIndex = 30;
            btnNuevoIngreso.Text = "Nueva Venta";
            btnNuevoIngreso.UseVisualStyleBackColor = false;
            btnNuevoIngreso.Click += btnNuevoIngreso_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(178, 18);
            label1.TabIndex = 29;
            label1.Text = "REGISTRAR VENTAS";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.MediumSeaGreen;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconEliminarRegistro, iconComprobante, iconExportarExcel });
            menuStrip1.Location = new Point(0, 427);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1059, 46);
            menuStrip1.TabIndex = 37;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconEliminarRegistro
            // 
            iconEliminarRegistro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconEliminarRegistro.ForeColor = Color.White;
            iconEliminarRegistro.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconEliminarRegistro.IconColor = Color.White;
            iconEliminarRegistro.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconEliminarRegistro.IconSize = 30;
            iconEliminarRegistro.ImageScaling = ToolStripItemImageScaling.None;
            iconEliminarRegistro.Name = "iconEliminarRegistro";
            iconEliminarRegistro.Size = new Size(168, 42);
            iconEliminarRegistro.Text = "Eliminar Registro";
            iconEliminarRegistro.Click += iconEliminarRegistro_Click;
            // 
            // iconComprobante
            // 
            iconComprobante.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconComprobante.ForeColor = Color.White;
            iconComprobante.IconChar = FontAwesome.Sharp.IconChar.File;
            iconComprobante.IconColor = Color.White;
            iconComprobante.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconComprobante.IconSize = 30;
            iconComprobante.ImageScaling = ToolStripItemImageScaling.None;
            iconComprobante.Name = "iconComprobante";
            iconComprobante.Size = new Size(142, 42);
            iconComprobante.Text = "Comprobante";
            iconComprobante.Click += iconComprobante_Click;
            // 
            // iconExportarExcel
            // 
            iconExportarExcel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconExportarExcel.ForeColor = Color.White;
            iconExportarExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            iconExportarExcel.IconColor = Color.White;
            iconExportarExcel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconExportarExcel.IconSize = 30;
            iconExportarExcel.ImageScaling = ToolStripItemImageScaling.None;
            iconExportarExcel.Name = "iconExportarExcel";
            iconExportarExcel.Size = new Size(162, 42);
            iconExportarExcel.Text = "Exportar a Excel";
            iconExportarExcel.Click += iconExportarExcel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dgvDatosCliente);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dgvVentas);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dgvDetalleVenta);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1059, 473);
            panel1.TabIndex = 38;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 473);
            Controls.Add(btnNuevoIngreso);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Name = "FormVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            Load += FormVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosCliente).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView dgvVentas;
        private Label label4;
        private DataGridView dgvDetalleVenta;
        private Label label3;
        private DataGridView dgvDatosCliente;
        private Button btnNuevoIngreso;
        private Label label1;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconEliminarRegistro;
        private FontAwesome.Sharp.IconMenuItem iconComprobante;
        private FontAwesome.Sharp.IconMenuItem iconExportarExcel;
        private Panel panel1;
    }
}