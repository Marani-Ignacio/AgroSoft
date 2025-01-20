namespace Vista
{
    partial class FormSalidas
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
            dgvSalidas = new DataGridView();
            label4 = new Label();
            dgvDatosSemilla = new DataGridView();
            label3 = new Label();
            dgvDatosIndustria = new DataGridView();
            label2 = new Label();
            dgvDatosTransporte = new DataGridView();
            btnNuevaSalida = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            iconEliminarRegistro = new FontAwesome.Sharp.IconMenuItem();
            iconCartadePorte = new FontAwesome.Sharp.IconMenuItem();
            iconExportarExcel = new FontAwesome.Sharp.IconMenuItem();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvSalidas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosSemilla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosIndustria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosTransporte).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DimGray;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(12, 177);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 37;
            label5.Text = "LISTA DE SALIDAS";
            // 
            // dgvSalidas
            // 
            dgvSalidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalidas.Location = new Point(10, 194);
            dgvSalidas.Margin = new Padding(3, 2, 3, 2);
            dgvSalidas.Name = "dgvSalidas";
            dgvSalidas.RowHeadersWidth = 51;
            dgvSalidas.RowTemplate.Height = 29;
            dgvSalidas.Size = new Size(1037, 203);
            dgvSalidas.TabIndex = 36;
            dgvSalidas.CellClick += dgvSalidas_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DimGray;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(513, 41);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 35;
            label4.Text = "Datos Transporte";
            // 
            // dgvDatosSemilla
            // 
            dgvDatosSemilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosSemilla.Location = new Point(12, 127);
            dgvDatosSemilla.Margin = new Padding(3, 2, 3, 2);
            dgvDatosSemilla.Name = "dgvDatosSemilla";
            dgvDatosSemilla.RowHeadersWidth = 51;
            dgvDatosSemilla.RowTemplate.Height = 29;
            dgvDatosSemilla.Size = new Size(555, 43);
            dgvDatosSemilla.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DimGray;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(10, 110);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 33;
            label3.Text = "Datos Semilla";
            // 
            // dgvDatosIndustria
            // 
            dgvDatosIndustria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosIndustria.Location = new Point(14, 58);
            dgvDatosIndustria.Margin = new Padding(3, 2, 3, 2);
            dgvDatosIndustria.Name = "dgvDatosIndustria";
            dgvDatosIndustria.RowHeadersWidth = 51;
            dgvDatosIndustria.RowTemplate.Height = 29;
            dgvDatosIndustria.Size = new Size(454, 43);
            dgvDatosIndustria.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DimGray;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 31;
            label2.Text = "Datos Industria";
            // 
            // dgvDatosTransporte
            // 
            dgvDatosTransporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosTransporte.Location = new Point(513, 58);
            dgvDatosTransporte.Margin = new Padding(3, 2, 3, 2);
            dgvDatosTransporte.Name = "dgvDatosTransporte";
            dgvDatosTransporte.RowHeadersWidth = 51;
            dgvDatosTransporte.RowTemplate.Height = 29;
            dgvDatosTransporte.Size = new Size(454, 43);
            dgvDatosTransporte.TabIndex = 30;
            // 
            // btnNuevaSalida
            // 
            btnNuevaSalida.BackColor = Color.MediumSeaGreen;
            btnNuevaSalida.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevaSalida.ForeColor = SystemColors.Control;
            btnNuevaSalida.Location = new Point(316, 12);
            btnNuevaSalida.Margin = new Padding(3, 2, 3, 2);
            btnNuevaSalida.Name = "btnNuevaSalida";
            btnNuevaSalida.Size = new Size(111, 23);
            btnNuevaSalida.TabIndex = 29;
            btnNuevaSalida.Text = "Nueva Salida";
            btnNuevaSalida.UseVisualStyleBackColor = false;
            btnNuevaSalida.Click += btnNuevaSalida_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(285, 18);
            label1.TabIndex = 28;
            label1.Text = "REGISTRAR SALIDAS DE CEREAL";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.MediumSeaGreen;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconEliminarRegistro, iconCartadePorte, iconExportarExcel });
            menuStrip1.Location = new Point(0, 427);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1059, 46);
            menuStrip1.TabIndex = 54;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconEliminarRegistro
            // 
            iconEliminarRegistro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconEliminarRegistro.ForeColor = Color.White;
            iconEliminarRegistro.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconEliminarRegistro.IconColor = Color.White;
            iconEliminarRegistro.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconEliminarRegistro.IconSize = 30;
            iconEliminarRegistro.ImageScaling = ToolStripItemImageScaling.None;
            iconEliminarRegistro.Name = "iconEliminarRegistro";
            iconEliminarRegistro.Size = new Size(168, 42);
            iconEliminarRegistro.Text = "Eliminar Registro";
            iconEliminarRegistro.Click += iconEliminarRegistro_Click;
            // 
            // iconCartadePorte
            // 
            iconCartadePorte.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconCartadePorte.ForeColor = Color.White;
            iconCartadePorte.IconChar = FontAwesome.Sharp.IconChar.File;
            iconCartadePorte.IconColor = Color.White;
            iconCartadePorte.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconCartadePorte.IconSize = 30;
            iconCartadePorte.ImageScaling = ToolStripItemImageScaling.None;
            iconCartadePorte.Name = "iconCartadePorte";
            iconCartadePorte.Size = new Size(149, 42);
            iconCartadePorte.Text = "Carta de Porte";
            iconCartadePorte.Click += iconCartadePorte_Click;
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
            iconExportarExcel.Size = new Size(162, 42);
            iconExportarExcel.Text = "Exportar a Excel";
            iconExportarExcel.Click += iconExportarExcel_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1059, 473);
            panel2.TabIndex = 55;
            // 
            // FormSalidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1059, 473);
            Controls.Add(menuStrip1);
            Controls.Add(label5);
            Controls.Add(dgvSalidas);
            Controls.Add(label4);
            Controls.Add(dgvDatosSemilla);
            Controls.Add(label3);
            Controls.Add(dgvDatosIndustria);
            Controls.Add(label2);
            Controls.Add(dgvDatosTransporte);
            Controls.Add(btnNuevaSalida);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "FormSalidas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salidas";
            Load += FormSalidas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSalidas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosSemilla).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosIndustria).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosTransporte).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private DataGridView dgvSalidas;
        private Label label4;
        private DataGridView dgvDatosSemilla;
        private Label label3;
        private DataGridView dgvDatosIndustria;
        private Label label2;
        private DataGridView dgvDatosTransporte;
        private Button btnNuevaSalida;
        private Label label1;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconEliminarRegistro;
        private FontAwesome.Sharp.IconMenuItem iconCartadePorte;
        private Panel panel2;
        private FontAwesome.Sharp.IconMenuItem iconExportarExcel;
    }
}