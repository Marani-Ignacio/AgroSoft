namespace Vista
{
    partial class FormGestionarPermisosUsuario
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
            iconAceptar = new FontAwesome.Sharp.IconMenuItem();
            iconCancelar = new FontAwesome.Sharp.IconMenuItem();
            cbPermisos = new ComboBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.DimGray;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconAceptar, iconCancelar });
            menuStrip1.Location = new Point(0, 74);
            menuStrip1.Margin = new Padding(0, 0, 10, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(479, 45);
            menuStrip1.TabIndex = 24;
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
            iconAceptar.Margin = new Padding(25, 0, 230, 0);
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
            // cbPermisos
            // 
            cbPermisos.FormattingEnabled = true;
            cbPermisos.Location = new Point(175, 10);
            cbPermisos.Name = "cbPermisos";
            cbPermisos.Size = new Size(274, 23);
            cbPermisos.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 22;
            label1.Text = "Seleccionar Permiso";
            // 
            // FormGestionarPermisosUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(479, 119);
            Controls.Add(menuStrip1);
            Controls.Add(cbPermisos);
            Controls.Add(label1);
            Name = "FormGestionarPermisosUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormGestionarPermisosUsuario_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconAceptar;
        private FontAwesome.Sharp.IconMenuItem iconCancelar;
        private ComboBox cbPermisos;
        private Label label1;
    }
}