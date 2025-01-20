namespace Vista
{
    partial class FormDatosUsuarios
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
            lblClave = new Label();
            lblDni = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            menuStrip1 = new MenuStrip();
            iconModificar = new FontAwesome.Sharp.IconMenuItem();
            txtNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtDni = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            txtNuevaClave = new TextBox();
            label6 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            panel2 = new DataGridView();
            txtClave = new TextBox();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panel2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SeaGreen;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(415, 30);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 92;
            label5.Text = "Nombre:";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.BackColor = SystemColors.ControlDark;
            lblClave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblClave.ForeColor = SystemColors.Control;
            lblClave.Location = new Point(24, 177);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(73, 15);
            lblClave.TabIndex = 90;
            lblClave.Text = "Contraseña:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = SystemColors.ControlDark;
            lblDni.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDni.ForeColor = SystemColors.Control;
            lblDni.Location = new Point(24, 128);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(31, 15);
            lblDni.TabIndex = 89;
            lblDni.Text = "DNI:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = SystemColors.ControlDark;
            lblApellido.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblApellido.ForeColor = SystemColors.Control;
            lblApellido.Location = new Point(24, 79);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 88;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.ControlDark;
            lblNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.Control;
            lblNombre.Location = new Point(24, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(55, 15);
            lblNombre.TabIndex = 87;
            lblNombre.Text = "Nombre:";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.MediumSeaGreen;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconModificar });
            menuStrip1.Location = new Point(0, 415);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1059, 58);
            menuStrip1.TabIndex = 85;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconModificar
            // 
            iconModificar.AutoSize = false;
            iconModificar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconModificar.ForeColor = Color.White;
            iconModificar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            iconModificar.IconColor = Color.White;
            iconModificar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconModificar.IconSize = 30;
            iconModificar.ImageScaling = ToolStripItemImageScaling.None;
            iconModificar.Name = "iconModificar";
            iconModificar.Size = new Size(152, 55);
            iconModificar.Text = "Modificar Datos";
            iconModificar.Click += iconModificar_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightGray;
            txtNombre.Location = new Point(531, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(186, 23);
            txtNombre.TabIndex = 75;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SeaGreen;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(415, 128);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 94;
            label3.Text = "DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SeaGreen;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(415, 79);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 93;
            label4.Text = "Apellido:";
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.LightGray;
            txtDni.Location = new Point(531, 125);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(186, 23);
            txtDni.TabIndex = 77;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaGreen;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(415, 177);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 95;
            label2.Text = "Contraseña:";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.LightGray;
            txtApellido.Location = new Point(531, 76);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(186, 23);
            txtApellido.TabIndex = 76;
            // 
            // txtNuevaClave
            // 
            txtNuevaClave.BackColor = Color.LightGray;
            txtNuevaClave.Location = new Point(531, 223);
            txtNuevaClave.Name = "txtNuevaClave";
            txtNuevaClave.PasswordChar = '*';
            txtNuevaClave.Size = new Size(186, 23);
            txtNuevaClave.TabIndex = 83;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SeaGreen;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(415, 226);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 82;
            label6.Text = "Nueva contraseña:";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.MediumSeaGreen;
            btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = SystemColors.Control;
            btnAceptar.Location = new Point(531, 336);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(81, 23);
            btnAceptar.TabIndex = 80;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Tomato;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(636, 336);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 23);
            btnCancelar.TabIndex = 81;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel2
            // 
            panel2.AllowUserToAddRows = false;
            panel2.AllowUserToDeleteRows = false;
            panel2.AllowUserToResizeColumns = false;
            panel2.AllowUserToResizeRows = false;
            panel2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.ReadOnly = true;
            panel2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            panel2.RowTemplate.Height = 25;
            panel2.Size = new Size(351, 415);
            panel2.TabIndex = 86;
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.LightGray;
            txtClave.Location = new Point(531, 174);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(186, 23);
            txtClave.TabIndex = 78;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtDni);
            panel1.Controls.Add(txtClave);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtNuevaClave);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnAceptar);
            panel1.Controls.Add(btnCancelar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1059, 473);
            panel1.TabIndex = 96;
            // 
            // FormDatosUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 473);
            Controls.Add(label5);
            Controls.Add(lblClave);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(menuStrip1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormDatosUsuarios";
            Text = "Datos - Usuario";
            Load += FormDatosUsuarios_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panel2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label lblClave;
        private Label lblDni;
        private Label lblApellido;
        private Label lblNombre;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconModificar;
        private TextBox txtNombre;
        private Label label3;
        private Label label4;
        private TextBox txtDni;
        private Label label2;
        private TextBox txtApellido;
        private TextBox txtNuevaClave;
        private Label label6;
        private Button btnAceptar;
        private Button btnCancelar;
        private DataGridView panel2;
        private TextBox txtClave;
        private Panel panel1;
    }
}