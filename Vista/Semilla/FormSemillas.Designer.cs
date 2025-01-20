namespace Vista
{
    partial class FormSemillas
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
            iconAgregar = new FontAwesome.Sharp.IconMenuItem();
            iconModificar = new FontAwesome.Sharp.IconMenuItem();
            iconEliminar = new FontAwesome.Sharp.IconMenuItem();
            dgvSemillas = new DataGridView();
            iconExportarExcel = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSemillas).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.MediumSeaGreen;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconAgregar, iconModificar, iconEliminar, iconExportarExcel });
            menuStrip1.Location = new Point(0, 415);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1059, 58);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconAgregar
            // 
            iconAgregar.AutoSize = false;
            iconAgregar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconAgregar.ForeColor = Color.White;
            iconAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iconAgregar.IconColor = Color.White;
            iconAgregar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconAgregar.IconSize = 30;
            iconAgregar.ImageScaling = ToolStripItemImageScaling.None;
            iconAgregar.Name = "iconAgregar";
            iconAgregar.Size = new Size(122, 55);
            iconAgregar.Text = "Agregar";
            iconAgregar.Click += iconAgregar_Click;
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
            iconModificar.Size = new Size(122, 55);
            iconModificar.Text = "Modificar";
            iconModificar.Click += iconModificar_Click;
            // 
            // iconEliminar
            // 
            iconEliminar.AutoSize = false;
            iconEliminar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconEliminar.ForeColor = Color.White;
            iconEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconEliminar.IconColor = Color.White;
            iconEliminar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconEliminar.IconSize = 30;
            iconEliminar.ImageScaling = ToolStripItemImageScaling.None;
            iconEliminar.Name = "iconEliminar";
            iconEliminar.Size = new Size(122, 55);
            iconEliminar.Text = "Eliminar";
            iconEliminar.Click += iconEliminar_Click;
            // 
            // dgvSemillas
            // 
            dgvSemillas.AllowUserToAddRows = false;
            dgvSemillas.AllowUserToDeleteRows = false;
            dgvSemillas.AllowUserToResizeColumns = false;
            dgvSemillas.AllowUserToResizeRows = false;
            dgvSemillas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSemillas.Dock = DockStyle.Fill;
            dgvSemillas.Location = new Point(0, 0);
            dgvSemillas.Name = "dgvSemillas";
            dgvSemillas.ReadOnly = true;
            dgvSemillas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvSemillas.RowTemplate.Height = 25;
            dgvSemillas.Size = new Size(1059, 415);
            dgvSemillas.TabIndex = 15;
            // 
            // iconExportarExcel
            // 
            iconExportarExcel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconExportarExcel.ForeColor = Color.White;
            iconExportarExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            iconExportarExcel.IconColor = Color.White;
            iconExportarExcel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconExportarExcel.IconSize = 30;
            iconExportarExcel.ImageScaling = ToolStripItemImageScaling.None;
            iconExportarExcel.Name = "iconExportarExcel";
            iconExportarExcel.Size = new Size(162, 54);
            iconExportarExcel.Text = "Exportar a Excel";
            iconExportarExcel.Click += iconExportarExcel_Click;
            // 
            // FormSemillas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 473);
            Controls.Add(dgvSemillas);
            Controls.Add(menuStrip1);
            Name = "FormSemillas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Semillas";
            Load += FormSemillas_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSemillas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconAgregar;
        private FontAwesome.Sharp.IconMenuItem iconModificar;
        private FontAwesome.Sharp.IconMenuItem iconEliminar;
        private DataGridView dgvSemillas;
        private FontAwesome.Sharp.IconMenuItem iconExportarExcel;
    }
}