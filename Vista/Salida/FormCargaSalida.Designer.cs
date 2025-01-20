namespace Vista
{
    partial class FormCargaSalida
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
            txtCuil = new TextBox();
            btnConsultarIndustria = new Button();
            dtpFecha = new DateTimePicker();
            label7 = new Label();
            menuStrip1 = new MenuStrip();
            iconRegistrar = new FontAwesome.Sharp.IconMenuItem();
            iconCancelar = new FontAwesome.Sharp.IconMenuItem();
            btnConsultarTransporte = new Button();
            dgvConsulta = new DataGridView();
            cbCodigo = new ComboBox();
            btnConsultarSemilla = new Button();
            txtCantidad = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            txtPatenteTransporte = new TextBox();
            label6 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCuil
            // 
            txtCuil.BackColor = Color.LightGray;
            txtCuil.Location = new Point(123, 11);
            txtCuil.Margin = new Padding(3, 2, 3, 2);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(110, 23);
            txtCuil.TabIndex = 1;
            // 
            // btnConsultarIndustria
            // 
            btnConsultarIndustria.BackColor = Color.DimGray;
            btnConsultarIndustria.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultarIndustria.ForeColor = SystemColors.Control;
            btnConsultarIndustria.Location = new Point(241, 11);
            btnConsultarIndustria.Margin = new Padding(3, 2, 3, 2);
            btnConsultarIndustria.Name = "btnConsultarIndustria";
            btnConsultarIndustria.Size = new Size(60, 22);
            btnConsultarIndustria.TabIndex = 2;
            btnConsultarIndustria.Text = "Consultar";
            btnConsultarIndustria.UseVisualStyleBackColor = false;
            btnConsultarIndustria.Click += btnConsultarIndustria_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(64, 47);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(237, 23);
            dtpFecha.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.MediumSeaGreen;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(50, 206);
            label7.Name = "label7";
            label7.Size = new Size(129, 15);
            label7.TabIndex = 12;
            label7.Text = "Patente Transporte:";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.DimGray;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconRegistrar, iconCancelar });
            menuStrip1.Location = new Point(0, 309);
            menuStrip1.Margin = new Padding(0, 0, 10, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(380, 45);
            menuStrip1.TabIndex = 31;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconRegistrar
            // 
            iconRegistrar.AutoSize = false;
            iconRegistrar.BackColor = Color.MediumSeaGreen;
            iconRegistrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconRegistrar.ForeColor = SystemColors.Control;
            iconRegistrar.IconChar = FontAwesome.Sharp.IconChar.Check;
            iconRegistrar.IconColor = Color.Black;
            iconRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconRegistrar.IconSize = 18;
            iconRegistrar.ImageScaling = ToolStripItemImageScaling.None;
            iconRegistrar.Margin = new Padding(20, 0, 145, 0);
            iconRegistrar.Name = "iconRegistrar";
            iconRegistrar.Size = new Size(90, 25);
            iconRegistrar.Text = "Registrar";
            iconRegistrar.Click += iconRegistrar_Click;
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
            // btnConsultarTransporte
            // 
            btnConsultarTransporte.BackColor = Color.DimGray;
            btnConsultarTransporte.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultarTransporte.ForeColor = SystemColors.Control;
            btnConsultarTransporte.Location = new Point(301, 204);
            btnConsultarTransporte.Margin = new Padding(3, 2, 3, 2);
            btnConsultarTransporte.Name = "btnConsultarTransporte";
            btnConsultarTransporte.Size = new Size(60, 21);
            btnConsultarTransporte.TabIndex = 14;
            btnConsultarTransporte.Text = "Consultar";
            btnConsultarTransporte.UseVisualStyleBackColor = false;
            btnConsultarTransporte.Click += btnConsultarTransporte_Click;
            // 
            // dgvConsulta
            // 
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(12, 241);
            dgvConsulta.Margin = new Padding(3, 2, 3, 2);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.RowHeadersWidth = 51;
            dgvConsulta.RowTemplate.Height = 29;
            dgvConsulta.Size = new Size(355, 53);
            dgvConsulta.TabIndex = 29;
            // 
            // cbCodigo
            // 
            cbCodigo.BackColor = Color.LightGray;
            cbCodigo.FormattingEnabled = true;
            cbCodigo.Location = new Point(122, 112);
            cbCodigo.Margin = new Padding(3, 2, 3, 2);
            cbCodigo.Name = "cbCodigo";
            cbCodigo.Size = new Size(77, 23);
            cbCodigo.TabIndex = 28;
            // 
            // btnConsultarSemilla
            // 
            btnConsultarSemilla.BackColor = Color.DimGray;
            btnConsultarSemilla.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultarSemilla.ForeColor = SystemColors.Control;
            btnConsultarSemilla.Location = new Point(205, 112);
            btnConsultarSemilla.Margin = new Padding(3, 2, 3, 2);
            btnConsultarSemilla.Name = "btnConsultarSemilla";
            btnConsultarSemilla.Size = new Size(60, 22);
            btnConsultarSemilla.TabIndex = 27;
            btnConsultarSemilla.Text = "Consultar";
            btnConsultarSemilla.UseVisualStyleBackColor = false;
            btnConsultarSemilla.Click += btnConsultarSemilla_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.LightGray;
            txtCantidad.Location = new Point(160, 140);
            txtCantidad.Margin = new Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(105, 23);
            txtCantidad.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumSeaGreen;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(50, 115);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 24;
            label5.Text = "Codigo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumSeaGreen;
            label4.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(10, 176);
            label4.Name = "label4";
            label4.Size = new Size(153, 17);
            label4.TabIndex = 23;
            label4.Text = "Seleccionar Transporte";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSeaGreen;
            label3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(129, 17);
            label3.TabIndex = 22;
            label3.Text = "Seleccionar Semilla";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSeaGreen;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(10, 51);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 21;
            label2.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSeaGreen;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(104, 17);
            label1.TabIndex = 20;
            label1.Text = "CUIL Industria:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtCuil);
            panel1.Controls.Add(btnConsultarIndustria);
            panel1.Controls.Add(btnConsultarTransporte);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(txtPatenteTransporte);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 354);
            panel1.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.MediumSeaGreen;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(50, 143);
            label8.Name = "label8";
            label8.Size = new Size(105, 15);
            label8.TabIndex = 15;
            label8.Text = "Cantidad en Kg:";
            // 
            // txtPatenteTransporte
            // 
            txtPatenteTransporte.BackColor = Color.LightGray;
            txtPatenteTransporte.Location = new Point(185, 203);
            txtPatenteTransporte.Margin = new Padding(3, 2, 3, 2);
            txtPatenteTransporte.Name = "txtPatenteTransporte";
            txtPatenteTransporte.Size = new Size(110, 23);
            txtPatenteTransporte.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MediumSeaGreen;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(50, 142);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 25;
            label6.Text = "Cantidad en Kg:";
            // 
            // FormCargaSalida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 354);
            Controls.Add(menuStrip1);
            Controls.Add(dgvConsulta);
            Controls.Add(cbCodigo);
            Controls.Add(btnConsultarSemilla);
            Controls.Add(txtCantidad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label6);
            Name = "FormCargaSalida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carga Salida";
            Load += FormCargaSalida_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCuil;
        private Button btnConsultarIndustria;
        private DateTimePicker dtpFecha;
        private Label label7;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconRegistrar;
        private FontAwesome.Sharp.IconMenuItem iconCancelar;
        private Button btnConsultarTransporte;
        private DataGridView dgvConsulta;
        private ComboBox cbCodigo;
        private Button btnConsultarSemilla;
        private TextBox txtCantidad;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private TextBox txtPatenteTransporte;
        private Label label6;
        private Label label8;
    }
}