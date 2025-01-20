namespace Vista
{
    partial class FormVerPermisosUsuario
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
            iconEliminar = new FontAwesome.Sharp.IconMenuItem();
            iconVolver = new FontAwesome.Sharp.IconMenuItem();
            label1 = new Label();
            dgvPermisosUsuario = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPermisosUsuario).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.DimGray;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconEliminar, iconVolver });
            menuStrip1.Location = new Point(0, 283);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(594, 50);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconEliminar
            // 
            iconEliminar.AutoSize = false;
            iconEliminar.BackColor = Color.Tomato;
            iconEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconEliminar.ForeColor = SystemColors.Control;
            iconEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconEliminar.IconColor = Color.Black;
            iconEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEliminar.IconSize = 20;
            iconEliminar.ImageScaling = ToolStripItemImageScaling.None;
            iconEliminar.Margin = new Padding(20, 0, 320, 0);
            iconEliminar.Name = "iconEliminar";
            iconEliminar.Size = new Size(110, 35);
            iconEliminar.Text = " Eliminar";
            iconEliminar.Click += iconEliminar_Click;
            // 
            // iconVolver
            // 
            iconVolver.AutoSize = false;
            iconVolver.BackColor = Color.Tan;
            iconVolver.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconVolver.ForeColor = SystemColors.Control;
            iconVolver.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            iconVolver.IconColor = Color.Black;
            iconVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconVolver.IconSize = 20;
            iconVolver.ImageScaling = ToolStripItemImageScaling.None;
            iconVolver.Name = "iconVolver";
            iconVolver.Size = new Size(100, 35);
            iconVolver.Text = " Volver";
            iconVolver.Click += iconVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 10;
            label1.Text = "Permisos Asociados";
            // 
            // dgvPermisosUsuario
            // 
            dgvPermisosUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermisosUsuario.Location = new Point(12, 32);
            dgvPermisosUsuario.Name = "dgvPermisosUsuario";
            dgvPermisosUsuario.RowTemplate.Height = 25;
            dgvPermisosUsuario.Size = new Size(564, 229);
            dgvPermisosUsuario.TabIndex = 9;
            // 
            // FormVerPermisosUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(594, 333);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(dgvPermisosUsuario);
            Name = "FormVerPermisosUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Permisos - Usuario";
            Load += FormVerPermisosUsuario_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPermisosUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconEliminar;
        private FontAwesome.Sharp.IconMenuItem iconVolver;
        private Label label1;
        private DataGridView dgvPermisosUsuario;
    }
}