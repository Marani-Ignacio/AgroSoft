namespace Vista
{
    partial class FormReporteVenta
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
            txtDatos = new TextBox();
            label2 = new Label();
            cbBusqueda = new ComboBox();
            label1 = new Label();
            menuStrip3 = new MenuStrip();
            iconBusqueda = new FontAwesome.Sharp.IconMenuItem();
            cbFiltro = new ComboBox();
            lblFechaHasta = new Label();
            dtpDesde = new DateTimePicker();
            lblFechaDesde = new Label();
            dtpHasta = new DateTimePicker();
            menuStrip1 = new MenuStrip();
            iconLimpiar = new FontAwesome.Sharp.IconMenuItem();
            iconFiltro = new FontAwesome.Sharp.IconMenuItem();
            menuStrip2 = new MenuStrip();
            iconConsultarRegistro = new FontAwesome.Sharp.IconMenuItem();
            panel1 = new Panel();
            dgvRegistrosVenta = new DataGridView();
            iconGrafico = new FontAwesome.Sharp.IconMenuItem();
            menuStrip3.SuspendLayout();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistrosVenta).BeginInit();
            SuspendLayout();
            // 
            // txtDatos
            // 
            txtDatos.Location = new Point(875, 56);
            txtDatos.Name = "txtDatos";
            txtDatos.Size = new Size(137, 23);
            txtDatos.TabIndex = 119;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(826, 60);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 118;
            label2.Text = "Datos:";
            // 
            // cbBusqueda
            // 
            cbBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Location = new Point(589, 56);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(202, 23);
            cbBusqueda.TabIndex = 117;
            cbBusqueda.SelectedIndexChanged += cbBusqueda_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(412, 60);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 116;
            label1.Text = "Seleccionar tipo de busqueda:";
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
            menuStrip3.TabIndex = 115;
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
            // cbFiltro
            // 
            cbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltro.FormattingEnabled = true;
            cbFiltro.Location = new Point(782, 10);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(202, 23);
            cbFiltro.TabIndex = 110;
            cbFiltro.SelectedIndexChanged += cbFiltro_SelectedIndexChanged;
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.BackColor = Color.MediumSeaGreen;
            lblFechaHasta.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFechaHasta.Location = new Point(466, 14);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(42, 15);
            lblFechaHasta.TabIndex = 111;
            lblFechaHasta.Text = "Fecha:";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(209, 10);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(238, 23);
            dtpDesde.TabIndex = 114;
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.BackColor = Color.MediumSeaGreen;
            lblFechaDesde.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFechaDesde.Location = new Point(159, 14);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(42, 15);
            lblFechaDesde.TabIndex = 113;
            lblFechaDesde.Text = "Fecha:";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(513, 10);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(239, 23);
            dtpHasta.TabIndex = 112;
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
            menuStrip1.TabIndex = 108;
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
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.BackColor = Color.MediumSeaGreen;
            menuStrip2.Dock = DockStyle.Bottom;
            menuStrip2.Items.AddRange(new ToolStripItem[] { iconConsultarRegistro, iconGrafico });
            menuStrip2.Location = new Point(0, 425);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1059, 46);
            menuStrip2.TabIndex = 122;
            menuStrip2.Text = "menuStrip2";
            // 
            // iconConsultarRegistro
            // 
            iconConsultarRegistro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconConsultarRegistro.ForeColor = Color.White;
            iconConsultarRegistro.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconConsultarRegistro.IconColor = Color.White;
            iconConsultarRegistro.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconConsultarRegistro.IconSize = 30;
            iconConsultarRegistro.ImageScaling = ToolStripItemImageScaling.None;
            iconConsultarRegistro.Name = "iconConsultarRegistro";
            iconConsultarRegistro.Size = new Size(177, 42);
            iconConsultarRegistro.Text = "Consultar Registro";
            iconConsultarRegistro.Click += iconConsultarRegistro_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(dgvRegistrosVenta);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(1059, 337);
            panel1.TabIndex = 123;
            // 
            // dgvRegistrosVenta
            // 
            dgvRegistrosVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistrosVenta.Dock = DockStyle.Fill;
            dgvRegistrosVenta.Location = new Point(0, 0);
            dgvRegistrosVenta.Name = "dgvRegistrosVenta";
            dgvRegistrosVenta.RowTemplate.Height = 25;
            dgvRegistrosVenta.Size = new Size(1059, 337);
            dgvRegistrosVenta.TabIndex = 0;
            // 
            // iconGrafico
            // 
            iconGrafico.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconGrafico.ForeColor = Color.White;
            iconGrafico.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            iconGrafico.IconColor = Color.White;
            iconGrafico.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconGrafico.IconSize = 30;
            iconGrafico.ImageScaling = ToolStripItemImageScaling.None;
            iconGrafico.Name = "iconGrafico";
            iconGrafico.Size = new Size(99, 42);
            iconGrafico.Text = "Gráfico";
            iconGrafico.Click += iconGrafico_Click;
            // 
            // FormReporteVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 471);
            Controls.Add(panel1);
            Controls.Add(menuStrip2);
            Controls.Add(txtDatos);
            Controls.Add(label2);
            Controls.Add(cbBusqueda);
            Controls.Add(label1);
            Controls.Add(menuStrip3);
            Controls.Add(cbFiltro);
            Controls.Add(lblFechaHasta);
            Controls.Add(dtpDesde);
            Controls.Add(lblFechaDesde);
            Controls.Add(dtpHasta);
            Controls.Add(menuStrip1);
            Name = "FormReporteVenta";
            Text = "FormReporteVenta";
            Load += FormReporteVenta_Load;
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegistrosVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDatos;
        private Label label2;
        private ComboBox cbBusqueda;
        private Label label1;
        private MenuStrip menuStrip3;
        private FontAwesome.Sharp.IconMenuItem iconBusqueda;
        private ComboBox cbFiltro;
        private Label lblFechaHasta;
        private DateTimePicker dtpDesde;
        private Label lblFechaDesde;
        private DateTimePicker dtpHasta;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconLimpiar;
        private FontAwesome.Sharp.IconMenuItem iconFiltro;
        private MenuStrip menuStrip2;
        private FontAwesome.Sharp.IconMenuItem iconConsultarRegistro;
        private Panel panel1;
        private DataGridView dgvRegistrosVenta;
        private FontAwesome.Sharp.IconMenuItem iconGrafico;
    }
}