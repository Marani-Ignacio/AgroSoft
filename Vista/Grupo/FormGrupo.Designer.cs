namespace Vista
{
    partial class FormGrupo
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
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            iconAceptar = new FontAwesome.Sharp.IconMenuItem();
            iconCancelar = new FontAwesome.Sharp.IconMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.LightGray;
            txtDescripcion.Location = new Point(13, 62);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(206, 69);
            txtDescripcion.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSeaGreen;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(7, 44);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 18;
            label2.Text = "Descripción:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightGray;
            txtNombre.Location = new Point(70, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(149, 23);
            txtNombre.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSeaGreen;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(7, 15);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 16;
            label1.Text = "Nombre:";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.DimGray;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconAceptar, iconCancelar });
            menuStrip1.Location = new Point(0, 142);
            menuStrip1.Margin = new Padding(0, 0, 10, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(230, 45);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconAceptar
            // 
            iconAceptar.AutoSize = false;
            iconAceptar.BackColor = Color.MediumSeaGreen;
            iconAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconAceptar.ForeColor = SystemColors.Control;
            iconAceptar.IconChar = FontAwesome.Sharp.IconChar.Check;
            iconAceptar.IconColor = Color.Black;
            iconAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAceptar.IconSize = 18;
            iconAceptar.ImageScaling = ToolStripItemImageScaling.None;
            iconAceptar.Margin = new Padding(0, 0, 35, 0);
            iconAceptar.Name = "iconAceptar";
            iconAceptar.Size = new Size(90, 25);
            iconAceptar.Text = "Aceptar";
            iconAceptar.Click += iconAceptar_Click;
            // 
            // iconCancelar
            // 
            iconCancelar.AutoSize = false;
            iconCancelar.BackColor = Color.Tomato;
            iconCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconCancelar.ForeColor = SystemColors.Control;
            iconCancelar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconCancelar.IconColor = Color.Black;
            iconCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCancelar.IconSize = 18;
            iconCancelar.ImageScaling = ToolStripItemImageScaling.None;
            iconCancelar.Name = "iconCancelar";
            iconCancelar.Size = new Size(90, 25);
            iconCancelar.Text = "Cancelar";
            iconCancelar.Click += iconCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(txtDescripcion);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 187);
            panel1.TabIndex = 21;
            // 
            // FormGrupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 187);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Name = "FormGrupo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grupo";
            Load += FormGrupo_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconAceptar;
        private FontAwesome.Sharp.IconMenuItem iconCancelar;
        private Panel panel1;
    }
}