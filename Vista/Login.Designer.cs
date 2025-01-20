namespace Vista
{
    partial class Login
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
            label2 = new Label();
            label3 = new Label();
            txtDni = new TextBox();
            txtClave = new TextBox();
            label4 = new Label();
            btnIngresar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.MediumSeaGreen;
            label1.Location = new Point(-2, -2);
            label1.Name = "label1";
            label1.Size = new Size(263, 64);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.MediumSeaGreen;
            label2.Font = new Font("Sylfaen", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(-2, -2);
            label2.Name = "label2";
            label2.Size = new Size(263, 64);
            label2.TabIndex = 1;
            label2.Text = "AgroSoft";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(50, 84);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Dni ";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(50, 102);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(163, 23);
            txtDni.TabIndex = 3;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(50, 156);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(163, 23);
            txtClave.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(50, 138);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 5;
            label4.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.CornflowerBlue;
            btnIngresar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.Control;
            btnIngresar.Location = new Point(50, 206);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(80, 25);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(133, 206);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 25);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(262, 263);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(label4);
            Controls.Add(txtClave);
            Controls.Add(txtDni);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Login_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDni;
        private TextBox txtClave;
        private Label label4;
        private Button btnIngresar;
        private Button btnCancelar;
    }
}