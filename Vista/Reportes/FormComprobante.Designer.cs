namespace Vista.Reportes
{
    partial class FormComprobante
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            lblCliente = new Label();
            panel1 = new Panel();
            lblComprobante = new Label();
            lblFecha = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblTotal = new Label();
            lblPrecio = new Label();
            menuStrip1 = new MenuStrip();
            exportarAPDFToolStripMenuItem = new ToolStripMenuItem();
            iconPDF = new FontAwesome.Sharp.IconMenuItem();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSeaGreen;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(186, 19);
            label2.Name = "label2";
            label2.Size = new Size(136, 24);
            label2.TabIndex = 6;
            label2.Text = "Comprobante";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSeaGreen;
            label1.Font = new Font("Sylfaen", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 1);
            label1.Name = "label1";
            label1.Size = new Size(166, 48);
            label1.TabIndex = 5;
            label1.Text = "AgroSoft";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(-10, 19);
            label3.Name = "label3";
            label3.Size = new Size(605, 45);
            label3.TabIndex = 7;
            label3.Text = "_____________________________________________";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.Location = new Point(27, 127);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(51, 15);
            lblCliente.TabIndex = 9;
            lblCliente.Text = "Nombre";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 62);
            panel1.TabIndex = 10;
            // 
            // lblComprobante
            // 
            lblComprobante.AutoSize = true;
            lblComprobante.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblComprobante.Location = new Point(27, 77);
            lblComprobante.Name = "lblComprobante";
            lblComprobante.Size = new Size(107, 15);
            lblComprobante.TabIndex = 11;
            lblComprobante.Text = "Nro Comprobante ";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(27, 102);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 12;
            lblFecha.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(-10, 117);
            label4.Name = "label4";
            label4.Size = new Size(605, 45);
            label4.TabIndex = 13;
            label4.Text = "_____________________________________________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 171);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 14;
            label5.Text = "Producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(386, 171);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 15;
            label6.Text = "Cantidad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(489, 171);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 16;
            label7.Text = "Precio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(489, 487);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 17;
            label9.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(-10, 162);
            label8.Name = "label8";
            label8.Size = new Size(605, 45);
            label8.TabIndex = 18;
            label8.Text = "_____________________________________________";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblProducto.Location = new Point(27, 217);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(0, 15);
            lblProducto.TabIndex = 19;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.Location = new Point(405, 217);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(0, 15);
            lblCantidad.TabIndex = 20;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(489, 524);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 21;
            lblTotal.Text = "xTotal";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(489, 217);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(0, 15);
            lblPrecio.TabIndex = 22;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.MediumSeaGreen;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { exportarAPDFToolStripMenuItem, iconPDF });
            menuStrip1.Location = new Point(0, 550);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(567, 44);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // exportarAPDFToolStripMenuItem
            // 
            exportarAPDFToolStripMenuItem.Name = "exportarAPDFToolStripMenuItem";
            exportarAPDFToolStripMenuItem.Size = new Size(12, 40);
            // 
            // iconPDF
            // 
            iconPDF.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconPDF.ForeColor = SystemColors.Control;
            iconPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            iconPDF.IconColor = Color.White;
            iconPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPDF.IconSize = 28;
            iconPDF.ImageScaling = ToolStripItemImageScaling.None;
            iconPDF.Name = "iconPDF";
            iconPDF.Size = new Size(152, 40);
            iconPDF.Text = "Exportar a PDF";
            iconPDF.Click += iconPDF_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Control;
            label10.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(-10, 437);
            label10.Name = "label10";
            label10.Size = new Size(605, 45);
            label10.TabIndex = 24;
            label10.Text = "_____________________________________________";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Control;
            label11.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(-10, 472);
            label11.Name = "label11";
            label11.Size = new Size(605, 45);
            label11.TabIndex = 25;
            label11.Text = "_____________________________________________";
            // 
            // FormComprobante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 594);
            Controls.Add(lblPrecio);
            Controls.Add(lblTotal);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblFecha);
            Controls.Add(lblComprobante);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCliente);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(menuStrip1);
            Controls.Add(label10);
            Controls.Add(label11);
            MainMenuStrip = menuStrip1;
            Name = "FormComprobante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprobante";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label lblCliente;
        private Panel panel1;
        private Label lblComprobante;
        private Label lblFecha;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblTotal;
        private Label lblPrecio;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exportarAPDFToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem iconPDF;
        private Label label10;
        private Label label11;
    }
}