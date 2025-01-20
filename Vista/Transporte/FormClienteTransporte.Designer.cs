namespace Vista
{
    partial class FormClienteTransporte
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
            dgvClienteTransporte = new DataGridView();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            iconEliminar = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvClienteTransporte).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClienteTransporte
            // 
            dgvClienteTransporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClienteTransporte.Location = new Point(12, 37);
            dgvClienteTransporte.Name = "dgvClienteTransporte";
            dgvClienteTransporte.RowTemplate.Height = 25;
            dgvClienteTransporte.Size = new Size(564, 229);
            dgvClienteTransporte.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 1;
            label1.Text = "Transportes Asociados";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.DimGray;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconEliminar, iconMenuItem1 });
            menuStrip1.Location = new Point(0, 280);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(593, 50);
            menuStrip1.TabIndex = 2;
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
            // iconMenuItem1
            // 
            iconMenuItem1.AutoSize = false;
            iconMenuItem1.BackColor = Color.Tan;
            iconMenuItem1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconMenuItem1.ForeColor = SystemColors.Control;
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.IconSize = 20;
            iconMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(100, 35);
            iconMenuItem1.Text = " Volver";
            iconMenuItem1.Click += iconMenuItem1_Click;
            // 
            // FormClienteTransporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(593, 330);
            Controls.Add(label1);
            Controls.Add(dgvClienteTransporte);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormClienteTransporte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente - Transporte";
            Load += FormClienteTransporte_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClienteTransporte).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClienteTransporte;
        private Label label1;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconEliminar;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
    }
}