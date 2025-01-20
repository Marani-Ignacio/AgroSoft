namespace Vista
{
    partial class FormGraficoReporteSalida
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
            panel1 = new Panel();
            chartCirculo = new FastReport.DataVisualization.Charting.Chart();
            chartColumna = new FastReport.DataVisualization.Charting.Chart();
            cbFiltro = new ComboBox();
            lblFechaHasta = new Label();
            dtpDesde = new DateTimePicker();
            lblFechaDesde = new Label();
            dtpHasta = new DateTimePicker();
            menuStrip1 = new MenuStrip();
            iconLimpiar = new FontAwesome.Sharp.IconMenuItem();
            iconFiltro = new FontAwesome.Sharp.IconMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartCirculo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartColumna).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(chartCirculo);
            panel1.Controls.Add(chartColumna);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(1032, 395);
            panel1.TabIndex = 19;
            // 
            // chartCirculo
            // 
            chartCirculo.Location = new Point(649, 22);
            chartCirculo.Name = "chartCirculo";
            chartCirculo.Size = new Size(355, 350);
            chartCirculo.TabIndex = 1;
            chartCirculo.Text = "chart1";
            // 
            // chartColumna
            // 
            chartColumna.Location = new Point(28, 22);
            chartColumna.Name = "chartColumna";
            chartColumna.Size = new Size(594, 350);
            chartColumna.TabIndex = 0;
            chartColumna.Text = "chart1";
            // 
            // cbFiltro
            // 
            cbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltro.FormattingEnabled = true;
            cbFiltro.Location = new Point(759, 11);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(202, 23);
            cbFiltro.TabIndex = 14;
            cbFiltro.SelectedIndexChanged += cbFiltro_SelectedIndexChanged;
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.BackColor = Color.MediumSeaGreen;
            lblFechaHasta.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFechaHasta.Location = new Point(443, 15);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(42, 15);
            lblFechaHasta.TabIndex = 15;
            lblFechaHasta.Text = "Fecha:";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(186, 11);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(238, 23);
            dtpDesde.TabIndex = 18;
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.BackColor = Color.MediumSeaGreen;
            lblFechaDesde.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFechaDesde.Location = new Point(136, 15);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(42, 15);
            lblFechaDesde.TabIndex = 17;
            lblFechaDesde.Text = "Fecha:";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(490, 11);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(239, 23);
            dtpHasta.TabIndex = 16;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.MediumSeaGreen;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconLimpiar, iconFiltro });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(1032, 44);
            menuStrip1.TabIndex = 13;
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
            // FormGraficoReporteSalida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 439);
            Controls.Add(panel1);
            Controls.Add(cbFiltro);
            Controls.Add(lblFechaHasta);
            Controls.Add(dtpDesde);
            Controls.Add(lblFechaDesde);
            Controls.Add(dtpHasta);
            Controls.Add(menuStrip1);
            Name = "FormGraficoReporteSalida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gráfico";
            Load += FormGraficoReporteSalida_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartCirculo).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartColumna).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FastReport.DataVisualization.Charting.Chart chartCirculo;
        private FastReport.DataVisualization.Charting.Chart chartColumna;
        private ComboBox cbFiltro;
        private Label lblFechaHasta;
        private DateTimePicker dtpDesde;
        private Label lblFechaDesde;
        private DateTimePicker dtpHasta;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconLimpiar;
        private FontAwesome.Sharp.IconMenuItem iconFiltro;
    }
}