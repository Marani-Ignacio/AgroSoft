namespace Vista
{
    partial class FormGrupos
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
            iconAgregarPermisos = new FontAwesome.Sharp.IconMenuItem();
            iconVerPermisos = new FontAwesome.Sharp.IconMenuItem();
            dgvGrupos = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.MediumSeaGreen;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconAgregar, iconModificar, iconEliminar, iconAgregarPermisos, iconVerPermisos });
            menuStrip1.Location = new Point(0, 415);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1059, 58);
            menuStrip1.TabIndex = 17;
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
            // iconAgregarPermisos
            // 
            iconAgregarPermisos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconAgregarPermisos.ForeColor = Color.White;
            iconAgregarPermisos.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            iconAgregarPermisos.IconColor = Color.White;
            iconAgregarPermisos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconAgregarPermisos.IconSize = 30;
            iconAgregarPermisos.ImageScaling = ToolStripItemImageScaling.None;
            iconAgregarPermisos.Name = "iconAgregarPermisos";
            iconAgregarPermisos.Size = new Size(185, 54);
            iconAgregarPermisos.Text = "Gestionar Permisos";
            iconAgregarPermisos.Click += iconAgregarPermisos_Click;
            // 
            // iconVerPermisos
            // 
            iconVerPermisos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconVerPermisos.ForeColor = Color.White;
            iconVerPermisos.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconVerPermisos.IconColor = Color.White;
            iconVerPermisos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconVerPermisos.IconSize = 30;
            iconVerPermisos.ImageScaling = ToolStripItemImageScaling.None;
            iconVerPermisos.Name = "iconVerPermisos";
            iconVerPermisos.Size = new Size(114, 54);
            iconVerPermisos.Text = "Permisos";
            iconVerPermisos.Click += iconVerPermisos_Click;
            // 
            // dgvGrupos
            // 
            dgvGrupos.AllowUserToAddRows = false;
            dgvGrupos.AllowUserToDeleteRows = false;
            dgvGrupos.AllowUserToResizeColumns = false;
            dgvGrupos.AllowUserToResizeRows = false;
            dgvGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupos.Dock = DockStyle.Fill;
            dgvGrupos.Location = new Point(0, 0);
            dgvGrupos.Name = "dgvGrupos";
            dgvGrupos.ReadOnly = true;
            dgvGrupos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvGrupos.RowTemplate.Height = 25;
            dgvGrupos.Size = new Size(1059, 473);
            dgvGrupos.TabIndex = 16;
            // 
            // FormGrupos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 473);
            Controls.Add(menuStrip1);
            Controls.Add(dgvGrupos);
            Name = "FormGrupos";
            Text = "Grupos";
            Load += FormGrupos_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconAgregar;
        private FontAwesome.Sharp.IconMenuItem iconModificar;
        private FontAwesome.Sharp.IconMenuItem iconEliminar;
        private FontAwesome.Sharp.IconMenuItem iconAgregarPermisos;
        private FontAwesome.Sharp.IconMenuItem iconVerPermisos;
        private DataGridView dgvGrupos;
    }
}