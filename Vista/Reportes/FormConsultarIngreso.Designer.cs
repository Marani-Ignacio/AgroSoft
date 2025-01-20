namespace Vista
{
    partial class FormConsultarIngreso
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
            label1 = new Label();
            txtCodigo = new TextBox();
            gbAgricultor = new GroupBox();
            txtCuit = new TextBox();
            label5 = new Label();
            txtDni = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtTotal = new TextBox();
            label6 = new Label();
            gbSemilla = new GroupBox();
            txtCantSemilla = new TextBox();
            label8 = new Label();
            txtClaseSemilla = new TextBox();
            label9 = new Label();
            txtCodSemilla = new TextBox();
            label10 = new Label();
            groupBox1 = new GroupBox();
            txtModelo = new TextBox();
            label7 = new Label();
            txtMarca = new TextBox();
            label11 = new Label();
            txtPatente = new TextBox();
            label12 = new Label();
            txtFecha = new TextBox();
            label13 = new Label();
            gbAgricultor.SuspendLayout();
            gbSemilla.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingreso Nro:";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(98, 12);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.ShortcutsEnabled = false;
            txtCodigo.Size = new Size(58, 23);
            txtCodigo.TabIndex = 1;
            // 
            // gbAgricultor
            // 
            gbAgricultor.Controls.Add(txtCuit);
            gbAgricultor.Controls.Add(label5);
            gbAgricultor.Controls.Add(txtDni);
            gbAgricultor.Controls.Add(label4);
            gbAgricultor.Controls.Add(txtNombre);
            gbAgricultor.Controls.Add(label3);
            gbAgricultor.Controls.Add(txtApellido);
            gbAgricultor.Controls.Add(label2);
            gbAgricultor.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gbAgricultor.ForeColor = SystemColors.Control;
            gbAgricultor.Location = new Point(12, 48);
            gbAgricultor.Name = "gbAgricultor";
            gbAgricultor.Size = new Size(215, 182);
            gbAgricultor.TabIndex = 2;
            gbAgricultor.TabStop = false;
            gbAgricultor.Text = "Agricultor";
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
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(619, 207);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.ShortcutsEnabled = false;
            txtTotal.Size = new Size(89, 23);
            txtTotal.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(574, 210);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 11;
            label6.Text = "Total:";
            // 
            // gbSemilla
            // 
            gbSemilla.Controls.Add(txtCantSemilla);
            gbSemilla.Controls.Add(label8);
            gbSemilla.Controls.Add(txtClaseSemilla);
            gbSemilla.Controls.Add(label9);
            gbSemilla.Controls.Add(txtCodSemilla);
            gbSemilla.Controls.Add(label10);
            gbSemilla.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gbSemilla.ForeColor = SystemColors.Control;
            gbSemilla.Location = new Point(250, 48);
            gbSemilla.Name = "gbSemilla";
            gbSemilla.Size = new Size(215, 142);
            gbSemilla.TabIndex = 13;
            gbSemilla.TabStop = false;
            gbSemilla.Text = "Semilla";
            // 
            // txtCantSemilla
            // 
            txtCantSemilla.Enabled = false;
            txtCantSemilla.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantSemilla.Location = new Point(86, 100);
            txtCantSemilla.Name = "txtCantSemilla";
            txtCantSemilla.ReadOnly = true;
            txtCantSemilla.ShortcutsEnabled = false;
            txtCantSemilla.Size = new Size(108, 23);
            txtCantSemilla.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(10, 103);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 7;
            label8.Text = "Cantidad:";
            // 
            // txtClaseSemilla
            // 
            txtClaseSemilla.Enabled = false;
            txtClaseSemilla.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtClaseSemilla.Location = new Point(86, 67);
            txtClaseSemilla.Name = "txtClaseSemilla";
            txtClaseSemilla.ReadOnly = true;
            txtClaseSemilla.ShortcutsEnabled = false;
            txtClaseSemilla.Size = new Size(108, 23);
            txtClaseSemilla.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(33, 70);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 5;
            label9.Text = "Clase:";
            // 
            // txtCodSemilla
            // 
            txtCodSemilla.Enabled = false;
            txtCodSemilla.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodSemilla.Location = new Point(86, 33);
            txtCodSemilla.Name = "txtCodSemilla";
            txtCodSemilla.ReadOnly = true;
            txtCodSemilla.ShortcutsEnabled = false;
            txtCodSemilla.Size = new Size(108, 23);
            txtCodSemilla.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(27, 36);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 3;
            label10.Text = "Código:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtPatente);
            groupBox1.Controls.Add(label12);
            groupBox1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(492, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 141);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transporte";
            // 
            // txtModelo
            // 
            txtModelo.Enabled = false;
            txtModelo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtModelo.Location = new Point(86, 102);
            txtModelo.Name = "txtModelo";
            txtModelo.ReadOnly = true;
            txtModelo.ShortcutsEnabled = false;
            txtModelo.Size = new Size(110, 23);
            txtModelo.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(24, 105);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 7;
            label7.Text = "Modelo:";
            // 
            // txtMarca
            // 
            txtMarca.Enabled = false;
            txtMarca.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarca.Location = new Point(86, 68);
            txtMarca.Name = "txtMarca";
            txtMarca.ReadOnly = true;
            txtMarca.ShortcutsEnabled = false;
            txtMarca.Size = new Size(110, 23);
            txtMarca.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(25, 71);
            label11.Name = "label11";
            label11.Size = new Size(50, 15);
            label11.TabIndex = 5;
            label11.Text = "Marca:";
            // 
            // txtPatente
            // 
            txtPatente.Enabled = false;
            txtPatente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPatente.Location = new Point(86, 34);
            txtPatente.Name = "txtPatente";
            txtPatente.ReadOnly = true;
            txtPatente.ShortcutsEnabled = false;
            txtPatente.Size = new Size(108, 23);
            txtPatente.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(18, 37);
            label12.Name = "label12";
            label12.Size = new Size(59, 15);
            label12.TabIndex = 3;
            label12.Text = "Patente:";
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(619, 14);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.ShortcutsEnabled = false;
            txtFecha.Size = new Size(89, 23);
            txtFecha.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(564, 16);
            label13.Name = "label13";
            label13.Size = new Size(46, 15);
            label13.TabIndex = 15;
            label13.Text = "Fecha:";
            // 
            // FormConsultarIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(727, 247);
            Controls.Add(txtFecha);
            Controls.Add(label13);
            Controls.Add(groupBox1);
            Controls.Add(gbSemilla);
            Controls.Add(txtTotal);
            Controls.Add(label6);
            Controls.Add(gbAgricultor);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Name = "FormConsultarIngreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Ingreso";
            Load += FormConsultarIngreso_Load;
            gbAgricultor.ResumeLayout(false);
            gbAgricultor.PerformLayout();
            gbSemilla.ResumeLayout(false);
            gbSemilla.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private GroupBox gbAgricultor;
        private TextBox txtDni;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtCuit;
        private Label label5;
        private TextBox txtTotal;
        private Label label6;
        private GroupBox gbSemilla;
        private TextBox txtCantSemilla;
        private Label label8;
        private TextBox txtClaseSemilla;
        private Label label9;
        private TextBox txtCodSemilla;
        private Label label10;
        private GroupBox groupBox1;
        private TextBox txtModelo;
        private Label label7;
        private TextBox txtMarca;
        private Label label11;
        private TextBox txtPatente;
        private Label label12;
        private TextBox txtFecha;
        private Label label13;
    }
}