namespace Vista
{
    partial class FormCargarVenta
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
            menuStrip1 = new MenuStrip();
            iconRegistrar = new FontAwesome.Sharp.IconMenuItem();
            iconCancelar = new FontAwesome.Sharp.IconMenuItem();
            dgvConsulta = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            txtDni = new TextBox();
            btnConsultarAgricultor = new Button();
            dtpFecha = new DateTimePicker();
            cbProducto = new ComboBox();
            btnConsultarSemilla = new Button();
            txtCantidad = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label5 = new Label();
            dgvCarrito = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.DimGray;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconRegistrar, iconCancelar });
            menuStrip1.Location = new Point(0, 394);
            menuStrip1.Margin = new Padding(0, 0, 10, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 45);
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
            iconRegistrar.Margin = new Padding(20, 0, 510, 0);
            iconRegistrar.Name = "iconRegistrar";
            iconRegistrar.Size = new Size(150, 25);
            iconRegistrar.Text = "Finalizar Compra";
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
            // dgvConsulta
            // 
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(335, 85);
            dgvConsulta.Margin = new Padding(3, 2, 3, 2);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.RowHeadersWidth = 51;
            dgvConsulta.RowTemplate.Height = 29;
            dgvConsulta.Size = new Size(453, 53);
            dgvConsulta.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSeaGreen;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(252, 9);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 24;
            label2.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSeaGreen;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 17);
            label1.TabIndex = 20;
            label1.Text = "Ingresar DNI Cliente";
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.LightGray;
            txtDni.Location = new Point(12, 29);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(155, 23);
            txtDni.TabIndex = 21;
            // 
            // btnConsultarAgricultor
            // 
            btnConsultarAgricultor.BackColor = Color.DimGray;
            btnConsultarAgricultor.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultarAgricultor.ForeColor = SystemColors.Control;
            btnConsultarAgricultor.Location = new Point(173, 30);
            btnConsultarAgricultor.Margin = new Padding(3, 2, 3, 2);
            btnConsultarAgricultor.Name = "btnConsultarAgricultor";
            btnConsultarAgricultor.Size = new Size(60, 22);
            btnConsultarAgricultor.TabIndex = 22;
            btnConsultarAgricultor.Text = "Consultar";
            btnConsultarAgricultor.UseVisualStyleBackColor = false;
            btnConsultarAgricultor.Click += btnConsultarAgricultor_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(252, 29);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(247, 23);
            dtpFecha.TabIndex = 23;
            // 
            // cbProducto
            // 
            cbProducto.BackColor = Color.LightGray;
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(12, 85);
            cbProducto.Margin = new Padding(3, 2, 3, 2);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(155, 23);
            cbProducto.TabIndex = 29;
            // 
            // btnConsultarSemilla
            // 
            btnConsultarSemilla.BackColor = Color.DimGray;
            btnConsultarSemilla.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultarSemilla.ForeColor = SystemColors.Control;
            btnConsultarSemilla.Location = new Point(173, 85);
            btnConsultarSemilla.Margin = new Padding(3, 2, 3, 2);
            btnConsultarSemilla.Name = "btnConsultarSemilla";
            btnConsultarSemilla.Size = new Size(60, 22);
            btnConsultarSemilla.TabIndex = 28;
            btnConsultarSemilla.Text = "Consultar";
            btnConsultarSemilla.UseVisualStyleBackColor = false;
            btnConsultarSemilla.Click += btnConsultarSemilla_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.LightGray;
            txtCantidad.Location = new Point(252, 85);
            txtCantidad.Margin = new Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(64, 23);
            txtCantidad.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dgvCarrito);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dgvConsulta);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbProducto);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtDni);
            panel1.Controls.Add(btnConsultarAgricultor);
            panel1.Controls.Add(btnConsultarSemilla);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(dtpFecha);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 439);
            panel1.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MediumSeaGreen;
            label6.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(335, 66);
            label6.Name = "label6";
            label6.Size = new Size(63, 17);
            label6.TabIndex = 37;
            label6.Text = "Consulta";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Tomato;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(186, 124);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(81, 27);
            btnEliminar.TabIndex = 36;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Goldenrod;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = SystemColors.Control;
            btnModificar.Location = new Point(99, 124);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(81, 27);
            btnModificar.TabIndex = 35;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.MediumSeaGreen;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(12, 124);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(81, 27);
            btnAgregar.TabIndex = 34;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumSeaGreen;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(12, 165);
            label5.Name = "label5";
            label5.Size = new Size(129, 15);
            label5.TabIndex = 33;
            label5.Text = "CARRITO DE COMPRA";
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(12, 191);
            dgvCarrito.Margin = new Padding(3, 2, 3, 2);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.RowTemplate.Height = 29;
            dgvCarrito.Size = new Size(776, 183);
            dgvCarrito.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumSeaGreen;
            label4.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(251, 66);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 31;
            label4.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSeaGreen;
            label3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 66);
            label3.Name = "label3";
            label3.Size = new Size(141, 17);
            label3.TabIndex = 30;
            label3.Text = "Seleccionar Producto";
            // 
            // FormCargarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 439);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Name = "FormCargarVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cargar Venta";
            Load += FormCargarVenta_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconRegistrar;
        private FontAwesome.Sharp.IconMenuItem iconCancelar;
        private DataGridView dgvConsulta;
        private Label label2;
        private Label label1;
        private TextBox txtDni;
        private Button btnConsultarAgricultor;
        private DateTimePicker dtpFecha;
        private ComboBox cbProducto;
        private Button btnConsultarSemilla;
        private TextBox txtCantidad;
        private Panel panel1;
        private Label label5;
        private DataGridView dgvCarrito;
        private Label label4;
        private Label label3;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private Label label6;
    }
}