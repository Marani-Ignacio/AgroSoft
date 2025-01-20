namespace Vista
{
    partial class FormProducto
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
            txtPrecio = new TextBox();
            label5 = new Label();
            txtStock = new TextBox();
            label4 = new Label();
            txtMarca = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            iconAceptar = new FontAwesome.Sharp.IconMenuItem();
            iconCancelar = new FontAwesome.Sharp.IconMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.LightGray;
            txtPrecio.Location = new Point(70, 128);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(149, 23);
            txtPrecio.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumSeaGreen;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(7, 131);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 24;
            label5.Text = "Precio c/u:";
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.LightGray;
            txtStock.Location = new Point(70, 99);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(149, 23);
            txtStock.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumSeaGreen;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(7, 102);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 22;
            label4.Text = "Stock:";
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.LightGray;
            txtMarca.Location = new Point(70, 70);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(149, 23);
            txtMarca.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSeaGreen;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(7, 73);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 20;
            label3.Text = "Marca:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightGray;
            txtNombre.Location = new Point(70, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(149, 23);
            txtNombre.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSeaGreen;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(7, 44);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 18;
            label2.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.LightGray;
            txtCodigo.Location = new Point(70, 12);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(149, 23);
            txtCodigo.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSeaGreen;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(7, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 16;
            label1.Text = "Codigo:";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.DimGray;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconAceptar, iconCancelar });
            menuStrip1.Location = new Point(0, 162);
            menuStrip1.Margin = new Padding(0, 0, 10, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(233, 45);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconAceptar
            // 
            iconAceptar.AutoSize = false;
            iconAceptar.BackColor = Color.MediumSeaGreen;
            iconAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconAceptar.ForeColor = SystemColors.Control;
            iconAceptar.IconChar = FontAwesome.Sharp.IconChar.Check;
            iconAceptar.IconColor = Color.Black;
            iconAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAceptar.IconSize = 18;
            iconAceptar.ImageScaling = ToolStripItemImageScaling.None;
            iconAceptar.Margin = new Padding(0, 0, 35, 0);
            iconAceptar.Name = "iconAceptar";
            iconAceptar.Size = new Size(90, 25);
            iconAceptar.Text = "Aceptar";
            iconAceptar.Click += iconAceptar_Click;
            // 
            // iconCancelar
            // 
            iconCancelar.AutoSize = false;
            iconCancelar.BackColor = Color.Tomato;
            iconCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconCancelar.ForeColor = SystemColors.Control;
            iconCancelar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconCancelar.IconColor = Color.Black;
            iconCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCancelar.IconSize = 18;
            iconCancelar.ImageScaling = ToolStripItemImageScaling.None;
            iconCancelar.Name = "iconCancelar";
            iconCancelar.Size = new Size(90, 25);
            iconCancelar.Text = "Cancelar";
            iconCancelar.Click += iconCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 207);
            panel1.TabIndex = 27;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(233, 207);
            Controls.Add(txtPrecio);
            Controls.Add(label5);
            Controls.Add(txtStock);
            Controls.Add(label4);
            Controls.Add(txtMarca);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Name = "FormProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Producto";
            Load += FormProducto_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrecio;
        private Label label5;
        private TextBox txtStock;
        private Label label4;
        private TextBox txtMarca;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconAceptar;
        private FontAwesome.Sharp.IconMenuItem iconCancelar;
        private Panel panel1;
    }
}