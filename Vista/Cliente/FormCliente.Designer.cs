namespace Vista
{
    partial class FormCliente
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
            txtTelefono = new TextBox();
            label6 = new Label();
            txtDireccion = new TextBox();
            label5 = new Label();
            txtCuit = new TextBox();
            label4 = new Label();
            txtDni = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            iconAceptar = new FontAwesome.Sharp.IconMenuItem();
            iconCancelar = new FontAwesome.Sharp.IconMenuItem();
            panel1 = new Panel();
            txtCodPostal = new TextBox();
            label7 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.LightGray;
            txtTelefono.Location = new Point(82, 186);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(149, 23);
            txtTelefono.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MediumSeaGreen;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(7, 189);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 26;
            label6.Text = "Teléfono:";
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.LightGray;
            txtDireccion.Location = new Point(82, 128);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(149, 23);
            txtDireccion.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumSeaGreen;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(7, 131);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 24;
            label5.Text = "Dirección:";
            // 
            // txtCuit
            // 
            txtCuit.BackColor = Color.LightGray;
            txtCuit.Location = new Point(82, 99);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(149, 23);
            txtCuit.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumSeaGreen;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(7, 102);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 22;
            label4.Text = "Nro CUIT:";
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.LightGray;
            txtDni.Location = new Point(82, 70);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(149, 23);
            txtDni.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSeaGreen;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(7, 73);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 20;
            label3.Text = "DNI:";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.LightGray;
            txtApellido.Location = new Point(82, 41);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(149, 23);
            txtApellido.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSeaGreen;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(7, 44);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 18;
            label2.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightGray;
            txtNombre.Location = new Point(82, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(149, 23);
            txtNombre.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSeaGreen;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(7, 15);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 16;
            label1.Text = "Nombre:";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.DimGray;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconAceptar, iconCancelar });
            menuStrip1.Location = new Point(0, 219);
            menuStrip1.Margin = new Padding(0, 0, 10, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(247, 45);
            menuStrip1.TabIndex = 28;
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
            iconAceptar.Margin = new Padding(10, 0, 35, 0);
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
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtCodPostal);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 264);
            panel1.TabIndex = 29;
            // 
            // txtCodPostal
            // 
            txtCodPostal.BackColor = Color.LightGray;
            txtCodPostal.Location = new Point(82, 157);
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.Size = new Size(149, 23);
            txtCodPostal.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.MediumSeaGreen;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(7, 160);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 30;
            label7.Text = "Cod Postal:";
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 264);
            Controls.Add(txtDireccion);
            Controls.Add(label5);
            Controls.Add(txtCuit);
            Controls.Add(label4);
            Controls.Add(txtDni);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Name = "FormCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
            Load += FormCliente_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelefono;
        private Label label6;
        private TextBox txtDireccion;
        private Label label5;
        private TextBox txtCuit;
        private Label label4;
        private TextBox txtDni;
        private Label label3;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconAceptar;
        private FontAwesome.Sharp.IconMenuItem iconCancelar;
        private Panel panel1;
        private TextBox txtCodPostal;
        private Label label7;
    }
}