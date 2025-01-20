namespace Vista
{
    partial class FormConsultarVenta
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
            txtFecha = new TextBox();
            label13 = new Label();
            txtTotal = new TextBox();
            label6 = new Label();
            gbCliente = new GroupBox();
            txtTelefono = new TextBox();
            label8 = new Label();
            txtDireccion = new TextBox();
            label7 = new Label();
            txtCuit = new TextBox();
            label5 = new Label();
            txtDni = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            dgvProductos = new DataGridView();
            gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(624, 16);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.ShortcutsEnabled = false;
            txtFecha.Size = new Size(89, 23);
            txtFecha.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(569, 18);
            label13.Name = "label13";
            label13.Size = new Size(46, 15);
            label13.TabIndex = 24;
            label13.Text = "Fecha:";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(624, 265);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.ShortcutsEnabled = false;
            txtTotal.Size = new Size(89, 23);
            txtTotal.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(579, 268);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 20;
            label6.Text = "Total:";
            // 
            // gbCliente
            // 
            gbCliente.Controls.Add(txtTelefono);
            gbCliente.Controls.Add(label8);
            gbCliente.Controls.Add(txtDireccion);
            gbCliente.Controls.Add(label7);
            gbCliente.Controls.Add(txtCuit);
            gbCliente.Controls.Add(label5);
            gbCliente.Controls.Add(txtDni);
            gbCliente.Controls.Add(label4);
            gbCliente.Controls.Add(txtNombre);
            gbCliente.Controls.Add(label3);
            gbCliente.Controls.Add(txtApellido);
            gbCliente.Controls.Add(label2);
            gbCliente.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gbCliente.ForeColor = SystemColors.Control;
            gbCliente.Location = new Point(17, 50);
            gbCliente.Name = "gbCliente";
            gbCliente.Size = new Size(215, 238);
            gbCliente.TabIndex = 19;
            gbCliente.TabStop = false;
            gbCliente.Text = "Cliente";
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(86, 204);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.ShortcutsEnabled = false;
            txtTelefono.Size = new Size(108, 23);
            txtTelefono.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(17, 207);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 13;
            label8.Text = "Teléfono:";
            // 
            // txtDireccion
            // 
            txtDireccion.Enabled = false;
            txtDireccion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.Location = new Point(86, 172);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ReadOnly = true;
            txtDireccion.ShortcutsEnabled = false;
            txtDireccion.Size = new Size(108, 23);
            txtDireccion.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(13, 175);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 11;
            label7.Text = "Dirección:";
            // 
            // txtCuit
            // 
            txtCuit.Enabled = false;
            txtCuit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCuit.Location = new Point(86, 138);
            txtCuit.Name = "txtCuit";
            txtCuit.ReadOnly = true;
            txtCuit.ShortcutsEnabled = false;
            txtCuit.Size = new Size(108, 23);
            txtCuit.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(44, 141);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 9;
            label5.Text = "Cuit:";
            // 
            // txtDni
            // 
            txtDni.Enabled = false;
            txtDni.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(86, 104);
            txtDni.Name = "txtDni";
            txtDni.ReadOnly = true;
            txtDni.ShortcutsEnabled = false;
            txtDni.Size = new Size(108, 23);
            txtDni.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(48, 107);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 7;
            label4.Text = "Dni:";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(86, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.ShortcutsEnabled = false;
            txtNombre.Size = new Size(108, 23);
            txtNombre.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(23, 37);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Nombre:";
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(86, 69);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.ShortcutsEnabled = false;
            txtApellido.Size = new Size(108, 23);
            txtApellido.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(23, 72);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellido:";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(103, 14);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.ShortcutsEnabled = false;
            txtCodigo.Size = new Size(58, 23);
            txtCodigo.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 17;
            label1.Text = "Venta Nro:";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(266, 59);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(447, 186);
            dgvProductos.TabIndex = 26;
            // 
            // FormConsultarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(730, 318);
            Controls.Add(dgvProductos);
            Controls.Add(txtFecha);
            Controls.Add(label13);
            Controls.Add(txtTotal);
            Controls.Add(label6);
            Controls.Add(gbCliente);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Name = "FormConsultarVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Venta";
            Load += FormConsultarVenta_Load;
            gbCliente.ResumeLayout(false);
            gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFecha;
        private Label label13;
        private TextBox txtTotal;
        private Label label6;
        private GroupBox gbCliente;
        private TextBox txtTelefono;
        private Label label8;
        private TextBox txtDireccion;
        private Label label7;
        private TextBox txtCuit;
        private Label label5;
        private TextBox txtDni;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private DataGridView dgvProductos;
    }
}