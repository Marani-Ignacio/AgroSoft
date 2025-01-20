namespace Vista
{
    partial class FormAgricultor
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label2 = new Label();
            txtDni = new TextBox();
            label3 = new Label();
            txtCuit = new TextBox();
            label4 = new Label();
            txtDireccion = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            menuStrip1 = new MenuStrip();
            iconAceptar = new FontAwesome.Sharp.IconMenuItem();
            iconCancelar = new FontAwesome.Sharp.IconMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
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
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightGray;
            txtNombre.Location = new Point(70, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(149, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.LightGray;
            txtApellido.Location = new Point(70, 41);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(149, 23);
            txtApellido.TabIndex = 3;
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
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.LightGray;
            txtDni.Location = new Point(70, 70);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(149, 23);
            txtDni.TabIndex = 5;
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
            label3.TabIndex = 4;
            label3.Text = "DNI:";
            // 
            // txtCuit
            // 
            txtCuit.BackColor = Color.LightGray;
            txtCuit.Location = new Point(70, 99);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(149, 23);
            txtCuit.TabIndex = 7;
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
            label4.TabIndex = 6;
            label4.Text = "Nro CUIT:";
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.LightGray;
            txtDireccion.Location = new Point(70, 128);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(149, 23);
            txtDireccion.TabIndex = 9;
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
            label5.TabIndex = 8;
            label5.Text = "Dirección:";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.LightGray;
            txtTelefono.Location = new Point(70, 157);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(149, 23);
            txtTelefono.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MediumSeaGreen;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(7, 160);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "Teléfono:";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.DimGray;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconAceptar, iconCancelar });
            menuStrip1.Location = new Point(0, 189);
            menuStrip1.Margin = new Padding(0, 0, 10, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(231, 45);
            menuStrip1.TabIndex = 14;
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
            panel1.Size = new Size(231, 234);
            panel1.TabIndex = 15;
            // 
            // FormAgricultor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 234);
            Controls.Add(txtTelefono);
            Controls.Add(label6);
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
            MainMenuStrip = menuStrip1;
            Name = "FormAgricultor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agricultor";
            Load += FormAgricultor_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtDni;
        private Label label3;
        private TextBox txtCuit;
        private Label label4;
        private TextBox txtDireccion;
        private Label label5;
        private TextBox txtTelefono;
        private Label label6;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconAceptar;
        private FontAwesome.Sharp.IconMenuItem iconCancelar;
        private Panel panel1;
    }
}