namespace Vista
{
    partial class FormIndustrias
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
            iconAgregarTransportes = new FontAwesome.Sharp.IconMenuItem();
            iconVerTransportes = new FontAwesome.Sharp.IconMenuItem();
            dgvIndustrias = new DataGridView();
            iconExportarExcel = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIndustrias).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.MediumSeaGreen;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconAgregar, iconModificar, iconEliminar, iconAgregarTransportes, iconVerTransportes, iconExportarExcel });
            menuStrip1.Location = new Point(0, 415);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1059, 58);
            menuStrip1.TabIndex = 16;
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
            // iconAgregarTransportes
            // 
            iconAgregarTransportes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconAgregarTransportes.ForeColor = Color.White;
            iconAgregarTransportes.IconChar = FontAwesome.Sharp.IconChar.TruckFront;
            iconAgregarTransportes.IconColor = Color.White;
            iconAgregarTransportes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconAgregarTransportes.IconSize = 30;
            iconAgregarTransportes.ImageScaling = ToolStripItemImageScaling.None;
            iconAgregarTransportes.Name = "iconAgregarTransportes";
            iconAgregarTransportes.Size = new Size(193, 54);
            iconAgregarTransportes.Text = "Agregar Transportes";
            iconAgregarTransportes.Click += iconAgregarTransportes_Click;
            // 
            // iconVerTransportes
            // 
            iconVerTransportes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconVerTransportes.ForeColor = Color.White;
            iconVerTransportes.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconVerTransportes.IconColor = Color.White;
            iconVerTransportes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconVerTransportes.IconSize = 30;
            iconVerTransportes.ImageScaling = ToolStripItemImageScaling.None;
            iconVerTransportes.Name = "iconVerTransportes";
            iconVerTransportes.Size = new Size(161, 54);
            iconVerTransportes.Text = "Ver Transportes";
            iconVerTransportes.Click += iconVerTransportes_Click;
            // 
            // dgvIndustrias
            // 
            dgvIndustrias.AllowUserToAddRows = false;
            dgvIndustrias.AllowUserToDeleteRows = false;
            dgvIndustrias.AllowUserToResizeColumns = false;
            dgvIndustrias.AllowUserToResizeRows = false;
            dgvIndustrias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIndustrias.Dock = DockStyle.Fill;
            dgvIndustrias.Location = new Point(0, 0);
            dgvIndustrias.Name = "dgvIndustrias";
            dgvIndustrias.ReadOnly = true;
            dgvIndustrias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvIndustrias.RowTemplate.Height = 25;
            dgvIndustrias.Size = new Size(1059, 415);
            dgvIndustrias.TabIndex = 17;
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
            // FormIndustrias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 473);
            Controls.Add(dgvIndustrias);
            Controls.Add(menuStrip1);
            Name = "FormIndustrias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Industrias";
            Load += FormIndustrias_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIndustrias).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconAgregar;
        private FontAwesome.Sharp.IconMenuItem iconModificar;
        private FontAwesome.Sharp.IconMenuItem iconEliminar;
        private FontAwesome.Sharp.IconMenuItem iconAgregarTransportes;
        private FontAwesome.Sharp.IconMenuItem iconVerTransportes;
        private DataGridView dgvIndustrias;
        private FontAwesome.Sharp.IconMenuItem iconExportarExcel;
    }
}