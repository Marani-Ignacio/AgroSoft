namespace Vista
{
    partial class FormIngresos
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
            btnNuevoIngreso = new Button();
            dgvDatosAgricultor = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            dgvDatosTransporte = new DataGridView();
            label4 = new Label();
            dgvDatosSemilla = new DataGridView();
            dgvIngresos = new DataGridView();
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            iconEliminarRegistro = new FontAwesome.Sharp.IconMenuItem();
            iconCartadePorte = new FontAwesome.Sharp.IconMenuItem();
            iconExportarExcel = new FontAwesome.Sharp.IconMenuItem();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDatosAgricultor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosTransporte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosSemilla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(298, 18);
            label1.TabIndex = 0;
            label1.Text = "REGISTRAR INGRESOS DE CEREAL";
            // 
            // btnNuevoIngreso
            // 
            btnNuevoIngreso.BackColor = Color.MediumSeaGreen;
            btnNuevoIngreso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevoIngreso.ForeColor = SystemColors.Control;
            btnNuevoIngreso.Location = new Point(314, 9);
            btnNuevoIngreso.Margin = new Padding(3, 2, 3, 2);
            btnNuevoIngreso.Name = "btnNuevoIngreso";
            btnNuevoIngreso.Size = new Size(111, 23);
            btnNuevoIngreso.TabIndex = 1;
            btnNuevoIngreso.Text = "Nuevo Ingreso";
            btnNuevoIngreso.UseVisualStyleBackColor = false;
            btnNuevoIngreso.Click += btnNuevoIngreso_Click;
            // 
            // dgvDatosAgricultor
            // 
            dgvDatosAgricultor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosAgricultor.Location = new Point(10, 55);
            dgvDatosAgricultor.Margin = new Padding(3, 2, 3, 2);
            dgvDatosAgricultor.Name = "dgvDatosAgricultor";
            dgvDatosAgricultor.RowHeadersWidth = 51;
            dgvDatosAgricultor.RowTemplate.Height = 29;
            dgvDatosAgricultor.Size = new Size(555, 43);
            dgvDatosAgricultor.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DimGray;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(10, 38);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 3;
            label2.Text = "Datos Agricultor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DimGray;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(8, 107);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 5;
            label3.Text = "Datos Semilla";
            // 
            // dgvDatosTransporte
            // 
            dgvDatosTransporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosTransporte.Location = new Point(593, 55);
            dgvDatosTransporte.Margin = new Padding(3, 2, 3, 2);
            dgvDatosTransporte.Name = "dgvDatosTransporte";
            dgvDatosTransporte.RowHeadersWidth = 51;
            dgvDatosTransporte.RowTemplate.Height = 29;
            dgvDatosTransporte.Size = new Size(454, 43);
            dgvDatosTransporte.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DimGray;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(593, 38);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 7;
            label4.Text = "Datos Transporte";
            // 
            // dgvDatosSemilla
            // 
            dgvDatosSemilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosSemilla.Location = new Point(10, 124);
            dgvDatosSemilla.Margin = new Padding(3, 2, 3, 2);
            dgvDatosSemilla.Name = "dgvDatosSemilla";
            dgvDatosSemilla.RowHeadersWidth = 51;
            dgvDatosSemilla.RowTemplate.Height = 29;
            dgvDatosSemilla.Size = new Size(555, 43);
            dgvDatosSemilla.TabIndex = 6;
            // 
            // dgvIngresos
            // 
            dgvIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngresos.Location = new Point(10, 194);
            dgvIngresos.Margin = new Padding(3, 2, 3, 2);
            dgvIngresos.Name = "dgvIngresos";
            dgvIngresos.RowHeadersWidth = 51;
            dgvIngresos.RowTemplate.Height = 29;
            dgvIngresos.Size = new Size(1037, 203);
            dgvIngresos.TabIndex = 8;
            dgvIngresos.CellClick += dgvIngresos_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DimGray;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(10, 177);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 9;
            label5.Text = "LISTA DE INGRESOS";
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
            menuStrip1.TabIndex = 28;
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
            panel2.TabIndex = 29;
            // 
            // FormIngresos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1059, 473);
            Controls.Add(label5);
            Controls.Add(dgvIngresos);
            Controls.Add(label4);
            Controls.Add(dgvDatosSemilla);
            Controls.Add(label3);
            Controls.Add(dgvDatosTransporte);
            Controls.Add(label2);
            Controls.Add(dgvDatosAgricultor);
            Controls.Add(btnNuevoIngreso);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(panel2);
            MainMenuStrip = menuStrip1;
            Name = "FormIngresos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresos";
            Load += FormIngresos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatosAgricultor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosTransporte).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosSemilla).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnNuevoIngreso;
        private DataGridView dgvDatosAgricultor;
        private Label label2;
        private Label label3;
        private DataGridView dgvDatosTransporte;
        private Label label4;
        private DataGridView dgvDatosSemilla;
        private DataGridView dgvIngresos;
        private Label label5;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconEliminarRegistro;
        private FontAwesome.Sharp.IconMenuItem iconCartadePorte;
        private Panel panel2;
        private FontAwesome.Sharp.IconMenuItem iconExportarExcel;
    }
}