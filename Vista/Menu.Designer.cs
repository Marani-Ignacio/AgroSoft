using System.Data.Common;

namespace Vista
{
    partial class Menu
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
            miniToolStrip = new MenuStrip();
            menuTitulo = new MenuStrip();
            menuStrip1 = new MenuStrip();
            lblBienvenido = new Label();
            label1 = new Label();
            iconRegistroSalidas = new FontAwesome.Sharp.IconMenuItem();
            iconTransporte2 = new FontAwesome.Sharp.IconMenuItem();
            menuPropiedades = new MenuStrip();
            iconSeguridad = new FontAwesome.Sharp.IconMenuItem();
            iconGestionarUsuarios = new FontAwesome.Sharp.IconMenuItem();
            iconGestionarGrupos = new FontAwesome.Sharp.IconMenuItem();
            iconAuditoria = new FontAwesome.Sharp.IconMenuItem();
            iconAuditoriasIngresos = new FontAwesome.Sharp.IconMenuItem();
            iconAuditoriasSalidas = new FontAwesome.Sharp.IconMenuItem();
            iconAuditoriasVentas = new FontAwesome.Sharp.IconMenuItem();
            iconAuditoriasInicioDeSesion = new FontAwesome.Sharp.IconMenuItem();
            iconIngreso = new FontAwesome.Sharp.IconMenuItem();
            iconRegistroIngresos = new FontAwesome.Sharp.IconMenuItem();
            iconAgricultor = new FontAwesome.Sharp.IconMenuItem();
            iconTransporte1 = new FontAwesome.Sharp.IconMenuItem();
            iconSalida = new FontAwesome.Sharp.IconMenuItem();
            iconRegistroSalida = new FontAwesome.Sharp.IconMenuItem();
            iconIndustrias = new FontAwesome.Sharp.IconMenuItem();
            iconTransporte = new FontAwesome.Sharp.IconMenuItem();
            iconSemillas = new FontAwesome.Sharp.IconMenuItem();
            iconVentas = new FontAwesome.Sharp.IconMenuItem();
            iconRegistroVentas = new FontAwesome.Sharp.IconMenuItem();
            iconClientes = new FontAwesome.Sharp.IconMenuItem();
            iconProductos = new FontAwesome.Sharp.IconMenuItem();
            iconReportes = new FontAwesome.Sharp.IconMenuItem();
            iconReporteIngreso = new FontAwesome.Sharp.IconMenuItem();
            iconReporteSalida = new FontAwesome.Sharp.IconMenuItem();
            iconReporteVenta = new FontAwesome.Sharp.IconMenuItem();
            iconConfiguracion = new FontAwesome.Sharp.IconMenuItem();
            iconDatosPersonales = new FontAwesome.Sharp.IconMenuItem();
            contenedor = new Panel();
            iconLogOut = new FontAwesome.Sharp.IconButton();
            menuPropiedades.SuspendLayout();
            SuspendLayout();
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "Selección de nuevo elemento";
            miniToolStrip.AccessibleRole = AccessibleRole.ComboBox;
            miniToolStrip.AutoSize = false;
            miniToolStrip.BackColor = Color.MediumSeaGreen;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.ImageScalingSize = new Size(20, 20);
            miniToolStrip.Location = new Point(955, 26);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.RightToLeft = RightToLeft.Yes;
            miniToolStrip.Size = new Size(1075, 72);
            miniToolStrip.TabIndex = 6;
            // 
            // menuTitulo
            // 
            menuTitulo.AutoSize = false;
            menuTitulo.BackColor = Color.MediumSeaGreen;
            menuTitulo.Dock = DockStyle.Bottom;
            menuTitulo.ImageScalingSize = new Size(20, 20);
            menuTitulo.Location = new Point(0, 0);
            menuTitulo.Name = "menuTitulo";
            menuTitulo.RightToLeft = RightToLeft.Yes;
            menuTitulo.Size = new Size(1075, 72);
            menuTitulo.TabIndex = 6;
            menuTitulo.Text = "menuTitulo";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.MediumSeaGreen;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(1075, 75);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.BackColor = Color.MediumSeaGreen;
            lblBienvenido.Font = new Font("Imprint MT Shadow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenido.ForeColor = SystemColors.Control;
            lblBienvenido.Location = new Point(809, 52);
            lblBienvenido.Margin = new Padding(4, 0, 4, 0);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(85, 15);
            lblBienvenido.TabIndex = 10;
            lblBienvenido.Text = "Bienvenido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSeaGreen;
            label1.Font = new Font("Imprint MT Shadow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(22, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(771, 32);
            label1.TabIndex = 9;
            label1.Text = "Sistema de Administración de Cereales y Venta de Productos";
            // 
            // iconRegistroSalidas
            // 
            iconRegistroSalidas.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            iconRegistroSalidas.IconColor = Color.Black;
            iconRegistroSalidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconRegistroSalidas.Name = "iconRegistroSalidas";
            iconRegistroSalidas.Size = new Size(245, 28);
            iconRegistroSalidas.Text = "Registros de Salidas";
            // 
            // iconTransporte2
            // 
            iconTransporte2.IconChar = FontAwesome.Sharp.IconChar.Truck;
            iconTransporte2.IconColor = Color.Black;
            iconTransporte2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconTransporte2.Name = "iconTransporte2";
            iconTransporte2.Size = new Size(245, 28);
            iconTransporte2.Text = "Transportes";
            // 
            // menuPropiedades
            // 
            menuPropiedades.AutoSize = false;
            menuPropiedades.ImageScalingSize = new Size(20, 20);
            menuPropiedades.Items.AddRange(new ToolStripItem[] { iconSeguridad, iconIngreso, iconSalida, iconSemillas, iconVentas, iconReportes, iconConfiguracion });
            menuPropiedades.Location = new Point(0, 75);
            menuPropiedades.Name = "menuPropiedades";
            menuPropiedades.Padding = new Padding(6, 1, 0, 1);
            menuPropiedades.Size = new Size(1075, 73);
            menuPropiedades.TabIndex = 0;
            menuPropiedades.Text = "menuStrip1";
            // 
            // iconSeguridad
            // 
            iconSeguridad.AutoSize = false;
            iconSeguridad.DropDownItems.AddRange(new ToolStripItem[] { iconGestionarUsuarios, iconGestionarGrupos, iconAuditoria });
            iconSeguridad.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconSeguridad.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconSeguridad.IconColor = Color.Black;
            iconSeguridad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSeguridad.IconSize = 35;
            iconSeguridad.ImageScaling = ToolStripItemImageScaling.None;
            iconSeguridad.Name = "iconSeguridad";
            iconSeguridad.Size = new Size(122, 60);
            iconSeguridad.Text = "Seguridad";
            iconSeguridad.TextAlign = ContentAlignment.BottomCenter;
            iconSeguridad.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconGestionarUsuarios
            // 
            iconGestionarUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconGestionarUsuarios.IconColor = Color.Black;
            iconGestionarUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconGestionarUsuarios.Name = "iconGestionarUsuarios";
            iconGestionarUsuarios.Size = new Size(138, 22);
            iconGestionarUsuarios.Text = "Usuarios";
            iconGestionarUsuarios.Click += iconGestionarUsuarios_Click;
            // 
            // iconGestionarGrupos
            // 
            iconGestionarGrupos.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconGestionarGrupos.IconColor = Color.Black;
            iconGestionarGrupos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconGestionarGrupos.Name = "iconGestionarGrupos";
            iconGestionarGrupos.Size = new Size(138, 22);
            iconGestionarGrupos.Text = "Grupos";
            iconGestionarGrupos.Click += iconGestionarGrupos_Click;
            // 
            // iconAuditoria
            // 
            iconAuditoria.DropDownItems.AddRange(new ToolStripItem[] { iconAuditoriasIngresos, iconAuditoriasSalidas, iconAuditoriasVentas, iconAuditoriasInicioDeSesion });
            iconAuditoria.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            iconAuditoria.IconColor = Color.Black;
            iconAuditoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAuditoria.Name = "iconAuditoria";
            iconAuditoria.Size = new Size(138, 22);
            iconAuditoria.Text = "Auditorias";
            // 
            // iconAuditoriasIngresos
            // 
            iconAuditoriasIngresos.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            iconAuditoriasIngresos.IconColor = Color.Black;
            iconAuditoriasIngresos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAuditoriasIngresos.Name = "iconAuditoriasIngresos";
            iconAuditoriasIngresos.Size = new Size(178, 22);
            iconAuditoriasIngresos.Text = "Ingresos";
            iconAuditoriasIngresos.Click += iconAuditoriasIngresos_Click;
            // 
            // iconAuditoriasSalidas
            // 
            iconAuditoriasSalidas.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            iconAuditoriasSalidas.IconColor = Color.Black;
            iconAuditoriasSalidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAuditoriasSalidas.Name = "iconAuditoriasSalidas";
            iconAuditoriasSalidas.Size = new Size(178, 22);
            iconAuditoriasSalidas.Text = "Salidas";
            iconAuditoriasSalidas.Click += iconAuditoriasSalidas_Click;
            // 
            // iconAuditoriasVentas
            // 
            iconAuditoriasVentas.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            iconAuditoriasVentas.IconColor = Color.Black;
            iconAuditoriasVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAuditoriasVentas.Name = "iconAuditoriasVentas";
            iconAuditoriasVentas.Size = new Size(178, 22);
            iconAuditoriasVentas.Text = "Ventas";
            iconAuditoriasVentas.Click += iconAuditoriasVentas_Click;
            // 
            // iconAuditoriasInicioDeSesion
            // 
            iconAuditoriasInicioDeSesion.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconAuditoriasInicioDeSesion.IconColor = Color.Black;
            iconAuditoriasInicioDeSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAuditoriasInicioDeSesion.Name = "iconAuditoriasInicioDeSesion";
            iconAuditoriasInicioDeSesion.Size = new Size(178, 22);
            iconAuditoriasInicioDeSesion.Text = "Log-In / Log-Out";
            iconAuditoriasInicioDeSesion.Click += iconAuditoriasInicioDeSesion_Click;
            // 
            // iconIngreso
            // 
            iconIngreso.AutoSize = false;
            iconIngreso.DropDownItems.AddRange(new ToolStripItem[] { iconRegistroIngresos, iconAgricultor, iconTransporte1 });
            iconIngreso.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconIngreso.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            iconIngreso.IconColor = Color.Black;
            iconIngreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconIngreso.IconSize = 35;
            iconIngreso.ImageScaling = ToolStripItemImageScaling.None;
            iconIngreso.Name = "iconIngreso";
            iconIngreso.Size = new Size(110, 60);
            iconIngreso.Text = "Ingresos";
            iconIngreso.TextAlign = ContentAlignment.BottomCenter;
            iconIngreso.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconRegistroIngresos
            // 
            iconRegistroIngresos.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            iconRegistroIngresos.IconColor = Color.Black;
            iconRegistroIngresos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconRegistroIngresos.Name = "iconRegistroIngresos";
            iconRegistroIngresos.Size = new Size(207, 22);
            iconRegistroIngresos.Text = "Registros de Ingresos";
            iconRegistroIngresos.Click += iconRegistroIngresos_Click;
            // 
            // iconAgricultor
            // 
            iconAgricultor.IconChar = FontAwesome.Sharp.IconChar.Tractor;
            iconAgricultor.IconColor = Color.Black;
            iconAgricultor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAgricultor.Name = "iconAgricultor";
            iconAgricultor.Size = new Size(207, 22);
            iconAgricultor.Text = "Agricultores";
            iconAgricultor.Click += iconAgricultores_Click;
            // 
            // iconTransporte1
            // 
            iconTransporte1.IconChar = FontAwesome.Sharp.IconChar.Truck;
            iconTransporte1.IconColor = Color.Black;
            iconTransporte1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconTransporte1.Name = "iconTransporte1";
            iconTransporte1.Size = new Size(207, 22);
            iconTransporte1.Text = "Transportes";
            iconTransporte1.Click += iconTransporte1_Click;
            // 
            // iconSalida
            // 
            iconSalida.AutoSize = false;
            iconSalida.DropDownItems.AddRange(new ToolStripItem[] { iconRegistroSalida, iconIndustrias, iconTransporte });
            iconSalida.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconSalida.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            iconSalida.IconColor = Color.Black;
            iconSalida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSalida.IconSize = 35;
            iconSalida.ImageScaling = ToolStripItemImageScaling.None;
            iconSalida.Name = "iconSalida";
            iconSalida.Size = new Size(110, 60);
            iconSalida.Text = "Salidas";
            iconSalida.TextAlign = ContentAlignment.BottomCenter;
            iconSalida.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconRegistroSalida
            // 
            iconRegistroSalida.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            iconRegistroSalida.IconColor = Color.Black;
            iconRegistroSalida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconRegistroSalida.Name = "iconRegistroSalida";
            iconRegistroSalida.Size = new Size(196, 22);
            iconRegistroSalida.Text = "Registros de Salidas";
            iconRegistroSalida.Click += iconRegistroSalida_Click;
            // 
            // iconIndustrias
            // 
            iconIndustrias.IconChar = FontAwesome.Sharp.IconChar.Industry;
            iconIndustrias.IconColor = Color.Black;
            iconIndustrias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconIndustrias.Name = "iconIndustrias";
            iconIndustrias.Size = new Size(196, 22);
            iconIndustrias.Text = "Industrias";
            iconIndustrias.Click += iconIndustrias_Click;
            // 
            // iconTransporte
            // 
            iconTransporte.IconChar = FontAwesome.Sharp.IconChar.Truck;
            iconTransporte.IconColor = Color.Black;
            iconTransporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconTransporte.Name = "iconTransporte";
            iconTransporte.Size = new Size(196, 22);
            iconTransporte.Text = "Transportes";
            iconTransporte.Click += iconTransporte_Click;
            // 
            // iconSemillas
            // 
            iconSemillas.AutoSize = false;
            iconSemillas.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconSemillas.IconChar = FontAwesome.Sharp.IconChar.WheatAwn;
            iconSemillas.IconColor = Color.Black;
            iconSemillas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSemillas.IconSize = 35;
            iconSemillas.ImageScaling = ToolStripItemImageScaling.None;
            iconSemillas.Name = "iconSemillas";
            iconSemillas.Size = new Size(110, 60);
            iconSemillas.Text = "Semillas";
            iconSemillas.TextAlign = ContentAlignment.BottomCenter;
            iconSemillas.TextImageRelation = TextImageRelation.ImageAboveText;
            iconSemillas.Click += iconSemillas_Click;
            // 
            // iconVentas
            // 
            iconVentas.AutoSize = false;
            iconVentas.DropDownItems.AddRange(new ToolStripItem[] { iconRegistroVentas, iconClientes, iconProductos });
            iconVentas.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconVentas.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            iconVentas.IconColor = Color.Black;
            iconVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconVentas.IconSize = 35;
            iconVentas.ImageScaling = ToolStripItemImageScaling.None;
            iconVentas.Name = "iconVentas";
            iconVentas.Size = new Size(110, 60);
            iconVentas.Text = "Ventas";
            iconVentas.TextAlign = ContentAlignment.BottomCenter;
            iconVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconRegistroVentas
            // 
            iconRegistroVentas.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            iconRegistroVentas.IconColor = Color.Black;
            iconRegistroVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconRegistroVentas.Name = "iconRegistroVentas";
            iconRegistroVentas.Size = new Size(195, 22);
            iconRegistroVentas.Text = "Registros de Ventas";
            iconRegistroVentas.Click += iconRegistroVentas_Click;
            // 
            // iconClientes
            // 
            iconClientes.IconChar = FontAwesome.Sharp.IconChar.User;
            iconClientes.IconColor = Color.Black;
            iconClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconClientes.Name = "iconClientes";
            iconClientes.Size = new Size(195, 22);
            iconClientes.Text = "Clientes";
            iconClientes.Click += iconClientes_Click;
            // 
            // iconProductos
            // 
            iconProductos.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            iconProductos.IconColor = Color.Black;
            iconProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconProductos.Name = "iconProductos";
            iconProductos.Size = new Size(195, 22);
            iconProductos.Text = "Productos";
            iconProductos.Click += iconProductos_Click;
            // 
            // iconReportes
            // 
            iconReportes.AutoSize = false;
            iconReportes.DropDownItems.AddRange(new ToolStripItem[] { iconReporteIngreso, iconReporteSalida, iconReporteVenta });
            iconReportes.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            iconReportes.IconColor = Color.Black;
            iconReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconReportes.IconSize = 35;
            iconReportes.ImageScaling = ToolStripItemImageScaling.None;
            iconReportes.Name = "iconReportes";
            iconReportes.Size = new Size(110, 60);
            iconReportes.Text = "Reportes";
            iconReportes.TextAlign = ContentAlignment.BottomCenter;
            iconReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconReporteIngreso
            // 
            iconReporteIngreso.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            iconReporteIngreso.IconColor = Color.Black;
            iconReporteIngreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconReporteIngreso.Name = "iconReporteIngreso";
            iconReporteIngreso.Size = new Size(184, 26);
            iconReporteIngreso.Text = "Ingresos";
            iconReporteIngreso.Click += iconReporteIngreso_Click;
            // 
            // iconReporteSalida
            // 
            iconReporteSalida.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            iconReporteSalida.IconColor = Color.Black;
            iconReporteSalida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconReporteSalida.Name = "iconReporteSalida";
            iconReporteSalida.Size = new Size(184, 26);
            iconReporteSalida.Text = "Salidas";
            iconReporteSalida.Click += iconReporteSalida_Click;
            // 
            // iconReporteVenta
            // 
            iconReporteVenta.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            iconReporteVenta.IconColor = Color.Black;
            iconReporteVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconReporteVenta.Name = "iconReporteVenta";
            iconReporteVenta.Size = new Size(184, 26);
            iconReporteVenta.Text = "Ventas";
            iconReporteVenta.Click += iconReporteVenta_Click;
            // 
            // iconConfiguracion
            // 
            iconConfiguracion.AutoSize = false;
            iconConfiguracion.DropDownItems.AddRange(new ToolStripItem[] { iconDatosPersonales });
            iconConfiguracion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Gear;
            iconConfiguracion.IconColor = Color.Black;
            iconConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconConfiguracion.IconSize = 35;
            iconConfiguracion.ImageScaling = ToolStripItemImageScaling.None;
            iconConfiguracion.Name = "iconConfiguracion";
            iconConfiguracion.Size = new Size(130, 60);
            iconConfiguracion.Text = "Configuracion";
            iconConfiguracion.TextAlign = ContentAlignment.BottomCenter;
            iconConfiguracion.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconDatosPersonales
            // 
            iconDatosPersonales.IconChar = FontAwesome.Sharp.IconChar.UserSecret;
            iconDatosPersonales.IconColor = Color.Black;
            iconDatosPersonales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDatosPersonales.Name = "iconDatosPersonales";
            iconDatosPersonales.Size = new Size(180, 22);
            iconDatosPersonales.Text = "Datos Personales";
            iconDatosPersonales.Click += iconDatosPersonales_Click;
            // 
            // contenedor
            // 
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 148);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1075, 528);
            contenedor.TabIndex = 11;
            // 
            // iconLogOut
            // 
            iconLogOut.BackColor = Color.MediumSeaGreen;
            iconLogOut.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            iconLogOut.IconColor = Color.White;
            iconLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconLogOut.IconSize = 25;
            iconLogOut.ImageAlign = ContentAlignment.BottomCenter;
            iconLogOut.Location = new Point(1039, 40);
            iconLogOut.Margin = new Padding(1);
            iconLogOut.Name = "iconLogOut";
            iconLogOut.Size = new Size(36, 36);
            iconLogOut.TabIndex = 12;
            iconLogOut.UseVisualStyleBackColor = false;
            iconLogOut.Click += iconLogOut_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 676);
            Controls.Add(iconLogOut);
            Controls.Add(contenedor);
            Controls.Add(menuPropiedades);
            Controls.Add(lblBienvenido);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuPropiedades;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Menu";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosing += Menu_FormClosing;
            menuPropiedades.ResumeLayout(false);
            menuPropiedades.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconMenuItem iconIndustria;
        private MenuStrip miniToolStrip;
        private MenuStrip menuTitulo;
        private MenuStrip menuStrip1;
        private Label lblBienvenido;
        private Label label1;
        private FontAwesome.Sharp.IconMenuItem iconSemillas1;
        private FontAwesome.Sharp.IconMenuItem iconRegistroSalidas;
        private FontAwesome.Sharp.IconMenuItem iconTransporte2;
        private MenuStrip menuPropiedades;
        private FontAwesome.Sharp.IconMenuItem iconSeguridad;
        private FontAwesome.Sharp.IconMenuItem iconGestionarUsuarios;
        private FontAwesome.Sharp.IconMenuItem iconGestionarGrupos;
        private FontAwesome.Sharp.IconMenuItem iconAuditoria;
        private FontAwesome.Sharp.IconMenuItem iconIngreso;
        private FontAwesome.Sharp.IconMenuItem iconRegistroIngresos;
        private FontAwesome.Sharp.IconMenuItem iconAgricultor;
        private FontAwesome.Sharp.IconMenuItem iconTransporte1;
        private FontAwesome.Sharp.IconMenuItem iconSalida;
        private FontAwesome.Sharp.IconMenuItem iconRegistroSalida;
        private FontAwesome.Sharp.IconMenuItem iconIndustrias;
        private FontAwesome.Sharp.IconMenuItem iconTransporte;
        private FontAwesome.Sharp.IconMenuItem iconSemillas;
        private FontAwesome.Sharp.IconMenuItem iconVentas;
        private FontAwesome.Sharp.IconMenuItem iconRegistroVentas;
        private FontAwesome.Sharp.IconMenuItem iconClientes;
        private FontAwesome.Sharp.IconMenuItem iconProductos;
        private FontAwesome.Sharp.IconMenuItem iconReportes;
        private FontAwesome.Sharp.IconMenuItem iconReporteIngreso;
        private FontAwesome.Sharp.IconMenuItem iconReporteSalida;
        private FontAwesome.Sharp.IconMenuItem iconReporteVenta;
        private FontAwesome.Sharp.IconMenuItem iconConfiguracion;
        private FontAwesome.Sharp.IconMenuItem iconDatosPersonales;
        private Panel contenedor;
        private FontAwesome.Sharp.IconButton iconLogOut;
        private FontAwesome.Sharp.IconMenuItem iconAuditoriasIngresos;
        private FontAwesome.Sharp.IconMenuItem iconAuditoriasSalidas;
        private FontAwesome.Sharp.IconMenuItem iconAuditoriasVentas;
        private FontAwesome.Sharp.IconMenuItem iconAuditoriasInicioDeSesion;
    }
}