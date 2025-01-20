namespace Vista
{
    partial class FormConsultarUsuario
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
            dgvPermisos = new DataGridView();
            gbCliente = new GroupBox();
            txtDni = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            dgvGrupos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).BeginInit();
            gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).BeginInit();
            SuspendLayout();
            // 
            // dgvPermisos
            // 
            dgvPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermisos.Location = new Point(261, 34);
            dgvPermisos.Name = "dgvPermisos";
            dgvPermisos.ReadOnly = true;
            dgvPermisos.RowTemplate.Height = 25;
            dgvPermisos.Size = new Size(447, 65);
            dgvPermisos.TabIndex = 34;
            // 
            // gbCliente
            // 
            gbCliente.Controls.Add(txtDni);
            gbCliente.Controls.Add(label4);
            gbCliente.Controls.Add(txtNombre);
            gbCliente.Controls.Add(label3);
            gbCliente.Controls.Add(txtApellido);
            gbCliente.Controls.Add(label2);
            gbCliente.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gbCliente.ForeColor = SystemColors.Control;
            gbCliente.Location = new Point(12, 12);
            gbCliente.Name = "gbCliente";
            gbCliente.Size = new Size(215, 141);
            gbCliente.TabIndex = 29;
            gbCliente.TabStop = false;
            gbCliente.Text = "Usuario";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(261, 12);
            label1.Name = "label1";
            label1.Size = new Size(118, 17);
            label1.TabIndex = 35;
            label1.Text = "Permisos Simples";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(261, 112);
            label5.Name = "label5";
            label5.Size = new Size(53, 17);
            label5.TabIndex = 37;
            label5.Text = "Grupos";
            // 
            // dgvGrupos
            // 
            dgvGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupos.Location = new Point(261, 134);
            dgvGrupos.Name = "dgvGrupos";
            dgvGrupos.ReadOnly = true;
            dgvGrupos.RowTemplate.Height = 25;
            dgvGrupos.Size = new Size(447, 65);
            dgvGrupos.TabIndex = 36;
            // 
            // FormConsultarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(730, 229);
            Controls.Add(label5);
            Controls.Add(dgvGrupos);
            Controls.Add(label1);
            Controls.Add(dgvPermisos);
            Controls.Add(gbCliente);
            Name = "FormConsultarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Usuario";
            Load += FormConsultarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).EndInit();
            gbCliente.ResumeLayout(false);
            gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPermisos;
        private GroupBox gbCliente;
        private TextBox txtDni;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtApellido;
        private Label label2;
        private Label label1;
        private Label label5;
        private DataGridView dgvGrupos;
    }
}