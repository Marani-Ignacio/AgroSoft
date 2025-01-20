namespace Vista
{
    partial class FormAuditoriasVentas
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
            menuStrip2 = new MenuStrip();
            iconConsultarAuditoria = new FontAwesome.Sharp.IconMenuItem();
            txtDatos = new TextBox();
            label2 = new Label();
            cbBusqueda = new ComboBox();
            label1 = new Label();
            cbFiltro = new ComboBox();
            lblFechaHasta = new Label();
            dtpDesde = new DateTimePicker();
            lblFechaDesde = new Label();
            dtpHasta = new DateTimePicker();
            menuStrip3 = new MenuStrip();
            iconBusqueda = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1 = new MenuStrip();
            iconLimpiar = new FontAwesome.Sharp.IconMenuItem();
            iconFiltro = new FontAwesome.Sharp.IconMenuItem();
            panel1 = new Panel();
            dgvAuditoriasVentas = new DataGridView();
            menuStrip2.SuspendLayout();
            menuStrip3.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditoriasVentas).BeginInit();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.BackColor = Color.MediumSeaGreen;
            menuStrip2.Dock = DockStyle.Bottom;
            menuStrip2.Items.AddRange(new ToolStripItem[] { iconConsultarAuditoria });
            menuStrip2.Location = new Point(0, 427);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1059, 46);
            menuStrip2.TabIndex = 113;
            menuStrip2.Text = "menuStrip2";
            // 
            // iconConsultarAuditoria
            // 
            iconConsultarAuditoria.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconConsultarAuditoria.ForeColor = Color.White;
            iconConsultarAuditoria.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconConsultarAuditoria.IconColor = Color.White;
            iconConsultarAuditoria.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconConsultarAuditoria.IconSize = 30;
            iconConsultarAuditoria.ImageScaling = ToolStripItemImageScaling.None;
            iconConsultarAuditoria.Name = "iconConsultarAuditoria";
            iconConsultarAuditoria.Size = new Size(180, 42);
            iconConsultarAuditoria.Text = "Consultar Auditoria";
            iconConsultarAuditoria.Click += iconConsultarAuditoria_Click;
            // 
            // txtDatos
            // 
            txtDatos.Location = new Point(880, 55);
            txtDatos.Name = "txtDatos";
            txtDatos.Size = new Size(137, 23);
            txtDatos.TabIndex = 131;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(831, 59);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 130;
            label2.Text = "Datos:";
            // 
            // cbBusqueda
            // 
            cbBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Location = new Point(594, 55);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(202, 23);
            cbBusqueda.TabIndex = 129;
            cbBusqueda.SelectedIndexChanged += cbBusqueda_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(417, 59);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 128;
            label1.Text = "Seleccionar tipo de busqueda:";
            // 
            // cbFiltro
            // 
            cbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltro.FormattingEnabled = true;
            cbFiltro.Location = new Point(787, 9);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(202, 23);
            cbFiltro.TabIndex = 122;
            cbFiltro.SelectedIndexChanged += cbFiltro_SelectedIndexChanged;
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.BackColor = Color.MediumSeaGreen;
            lblFechaHasta.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFechaHasta.Location = new Point(471, 13);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(42, 15);
            lblFechaHasta.TabIndex = 123;
            lblFechaHasta.Text = "Fecha:";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(214, 9);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(238, 23);
            dtpDesde.TabIndex = 126;
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.BackColor = Color.MediumSeaGreen;
            lblFechaDesde.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFechaDesde.Location = new Point(164, 13);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(42, 15);
            lblFechaDesde.TabIndex = 125;
            lblFechaDesde.Text = "Fecha:";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(518, 9);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(239, 23);
            dtpHasta.TabIndex = 124;
            // 
            // menuStrip3
            // 
            menuStrip3.AutoSize = false;
            menuStrip3.BackColor = Color.Gray;
            menuStrip3.Items.AddRange(new ToolStripItem[] { iconBusqueda });
            menuStrip3.Location = new Point(0, 44);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.RightToLeft = RightToLeft.Yes;
            menuStrip3.Size = new Size(1059, 44);
            menuStrip3.TabIndex = 127;
            menuStrip3.Text = "menuStrip3";
            // 
            // iconBusqueda
            // 
            iconBusqueda.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconBusqueda.IconColor = Color.Black;
            iconBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBusqueda.IconSize = 20;
            iconBusqueda.ImageScaling = ToolStripItemImageScaling.None;
            iconBusqueda.Name = "iconBusqueda";
            iconBusqueda.Size = new Size(32, 40);
            iconBusqueda.TextImageRelation = TextImageRelation.ImageAboveText;
            iconBusqueda.Click += iconBusqueda_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.MediumSeaGreen;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconLimpiar, iconFiltro });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(1059, 44);
            menuStrip1.TabIndex = 121;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconLimpiar
            // 
            iconLimpiar.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            iconLimpiar.IconColor = Color.Black;
            iconLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconLimpiar.IconSize = 20;
            iconLimpiar.ImageScaling = ToolStripItemImageScaling.None;
            iconLimpiar.Name = "iconLimpiar";
            iconLimpiar.Size = new Size(32, 40);
            iconLimpiar.TextImageRelation = TextImageRelation.ImageAboveText;
            iconLimpiar.Click += iconLimpiar_Click;
            // 
            // iconFiltro
            // 
            iconFiltro.IconChar = FontAwesome.Sharp.IconChar.Filter;
            iconFiltro.IconColor = Color.Black;
            iconFiltro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconFiltro.IconSize = 20;
            iconFiltro.ImageScaling = ToolStripItemImageScaling.None;
            iconFiltro.Name = "iconFiltro";
            iconFiltro.Size = new Size(32, 40);
            iconFiltro.TextImageRelation = TextImageRelation.ImageAboveText;
            iconFiltro.Click += iconFiltro_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(dgvAuditoriasVentas);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(1059, 339);
            panel1.TabIndex = 132;
            // 
            // dgvAuditoriasVentas
            // 
            dgvAuditoriasVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditoriasVentas.Dock = DockStyle.Fill;
            dgvAuditoriasVentas.Location = new Point(0, 0);
            dgvAuditoriasVentas.Name = "dgvAuditoriasVentas";
            dgvAuditoriasVentas.RowTemplate.Height = 25;
            dgvAuditoriasVentas.Size = new Size(1059, 339);
            dgvAuditoriasVentas.TabIndex = 0;
            // 
            // FormAuditoriasVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 473);
            Controls.Add(panel1);
            Controls.Add(txtDatos);
            Controls.Add(label2);
            Controls.Add(cbBusqueda);
            Controls.Add(label1);
            Controls.Add(cbFiltro);
            Controls.Add(lblFechaHasta);
            Controls.Add(dtpDesde);
            Controls.Add(lblFechaDesde);
            Controls.Add(dtpHasta);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip3);
            Controls.Add(menuStrip1);
            Name = "FormAuditoriasVentas";
            Text = "Auditorias Ventas";
            Load += FormAuditoriasVentas_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAuditoriasVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip2;
        private FontAwesome.Sharp.IconMenuItem iconConsultarAuditoria;
        private TextBox txtDatos;
        private Label label2;
        private ComboBox cbBusqueda;
        private Label label1;
        private ComboBox cbFiltro;
        private Label lblFechaHasta;
        private DateTimePicker dtpDesde;
        private Label lblFechaDesde;
        private DateTimePicker dtpHasta;
        private MenuStrip menuStrip3;
        private FontAwesome.Sharp.IconMenuItem iconBusqueda;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconLimpiar;
        private FontAwesome.Sharp.IconMenuItem iconFiltro;
        private Panel panel1;
        private DataGridView dgvAuditoriasVentas;
    }
}