namespace Caja
{
    partial class frFacturacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbFacturacionUsuario = new System.Windows.Forms.Label();
            this.lbFacturacionNombreCajero = new System.Windows.Forms.Label();
            this.lbFacturacionNombreSucursal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFacturacionFecha = new System.Windows.Forms.Label();
            this.lbFacturacionAperturaCaja = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFacturacionMetodoPago = new System.Windows.Forms.ComboBox();
            this.cbFacturacionServicios = new System.Windows.Forms.ComboBox();
            this.btnFacturacionSeleccionarMetodoPago = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFacturacionAgregarServicio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFacturacionCliente = new System.Windows.Forms.TextBox();
            this.lbFacturacionCliente = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbFacturacionPrecioServicio = new System.Windows.Forms.Label();
            this.lbFacturacionPrecio = new System.Windows.Forms.Label();
            this.lbFacturacionDescripcionServicio = new System.Windows.Forms.Label();
            this.lbFacturacionDescripcion = new System.Windows.Forms.Label();
            this.lbFacturacionTipoServicioSeleccionado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbFacturacionServicioSeleccionado = new System.Windows.Forms.Label();
            this.lbFacturacionDetalleServicio = new System.Windows.Forms.Label();
            this.lbFacturacionDetallesServicio = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFacturacionImprimirFactura = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturación";
            // 
            // lbFacturacionUsuario
            // 
            this.lbFacturacionUsuario.AutoSize = true;
            this.lbFacturacionUsuario.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturacionUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionUsuario.Location = new System.Drawing.Point(45, 101);
            this.lbFacturacionUsuario.Name = "lbFacturacionUsuario";
            this.lbFacturacionUsuario.Size = new System.Drawing.Size(63, 18);
            this.lbFacturacionUsuario.TabIndex = 1;
            this.lbFacturacionUsuario.Text = "Usuario:";
            // 
            // lbFacturacionNombreCajero
            // 
            this.lbFacturacionNombreCajero.AutoSize = true;
            this.lbFacturacionNombreCajero.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturacionNombreCajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionNombreCajero.Location = new System.Drawing.Point(103, 101);
            this.lbFacturacionNombreCajero.Name = "lbFacturacionNombreCajero";
            this.lbFacturacionNombreCajero.Size = new System.Drawing.Size(134, 18);
            this.lbFacturacionNombreCajero.TabIndex = 2;
            this.lbFacturacionNombreCajero.Text = "Nombre del Cajero";
            // 
            // lbFacturacionNombreSucursal
            // 
            this.lbFacturacionNombreSucursal.AutoSize = true;
            this.lbFacturacionNombreSucursal.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturacionNombreSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionNombreSucursal.Location = new System.Drawing.Point(355, 101);
            this.lbFacturacionNombreSucursal.Name = "lbFacturacionNombreSucursal";
            this.lbFacturacionNombreSucursal.Size = new System.Drawing.Size(124, 18);
            this.lbFacturacionNombreSucursal.TabIndex = 4;
            this.lbFacturacionNombreSucursal.Text = "Nombre Sucursal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(279, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sucursal:";
            // 
            // lbFacturacionFecha
            // 
            this.lbFacturacionFecha.AutoSize = true;
            this.lbFacturacionFecha.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturacionFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionFecha.Location = new System.Drawing.Point(698, 101);
            this.lbFacturacionFecha.Name = "lbFacturacionFecha";
            this.lbFacturacionFecha.Size = new System.Drawing.Size(68, 18);
            this.lbFacturacionFecha.TabIndex = 6;
            this.lbFacturacionFecha.Text = "getdate()";
            // 
            // lbFacturacionAperturaCaja
            // 
            this.lbFacturacionAperturaCaja.AutoSize = true;
            this.lbFacturacionAperturaCaja.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturacionAperturaCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionAperturaCaja.Location = new System.Drawing.Point(571, 101);
            this.lbFacturacionAperturaCaja.Name = "lbFacturacionAperturaCaja";
            this.lbFacturacionAperturaCaja.Size = new System.Drawing.Size(121, 18);
            this.lbFacturacionAperturaCaja.TabIndex = 5;
            this.lbFacturacionAperturaCaja.Text = "Apertura de caja:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbFacturacionMetodoPago);
            this.panel1.Controls.Add(this.cbFacturacionServicios);
            this.panel1.Controls.Add(this.btnFacturacionSeleccionarMetodoPago);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnFacturacionAgregarServicio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtFacturacionCliente);
            this.panel1.Controls.Add(this.lbFacturacionCliente);
            this.panel1.Location = new System.Drawing.Point(48, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 173);
            this.panel1.TabIndex = 7;
            // 
            // cbFacturacionMetodoPago
            // 
            this.cbFacturacionMetodoPago.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFacturacionMetodoPago.FormattingEnabled = true;
            this.cbFacturacionMetodoPago.Location = new System.Drawing.Point(717, 121);
            this.cbFacturacionMetodoPago.Name = "cbFacturacionMetodoPago";
            this.cbFacturacionMetodoPago.Size = new System.Drawing.Size(203, 32);
            this.cbFacturacionMetodoPago.TabIndex = 10;
            // 
            // cbFacturacionServicios
            // 
            this.cbFacturacionServicios.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFacturacionServicios.FormattingEnabled = true;
            this.cbFacturacionServicios.Location = new System.Drawing.Point(717, 36);
            this.cbFacturacionServicios.Name = "cbFacturacionServicios";
            this.cbFacturacionServicios.Size = new System.Drawing.Size(203, 32);
            this.cbFacturacionServicios.TabIndex = 9;
            // 
            // btnFacturacionSeleccionarMetodoPago
            // 
            this.btnFacturacionSeleccionarMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(75)))), ((int)(((byte)(181)))));
            this.btnFacturacionSeleccionarMetodoPago.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacionSeleccionarMetodoPago.ForeColor = System.Drawing.Color.White;
            this.btnFacturacionSeleccionarMetodoPago.Location = new System.Drawing.Point(926, 121);
            this.btnFacturacionSeleccionarMetodoPago.Name = "btnFacturacionSeleccionarMetodoPago";
            this.btnFacturacionSeleccionarMetodoPago.Size = new System.Drawing.Size(131, 34);
            this.btnFacturacionSeleccionarMetodoPago.TabIndex = 8;
            this.btnFacturacionSeleccionarMetodoPago.Text = "Seleccionar";
            this.btnFacturacionSeleccionarMetodoPago.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(559, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Metodo de Pago:";
            // 
            // btnFacturacionAgregarServicio
            // 
            this.btnFacturacionAgregarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(75)))), ((int)(((byte)(181)))));
            this.btnFacturacionAgregarServicio.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacionAgregarServicio.ForeColor = System.Drawing.Color.White;
            this.btnFacturacionAgregarServicio.Location = new System.Drawing.Point(926, 36);
            this.btnFacturacionAgregarServicio.Name = "btnFacturacionAgregarServicio";
            this.btnFacturacionAgregarServicio.Size = new System.Drawing.Size(131, 35);
            this.btnFacturacionAgregarServicio.TabIndex = 5;
            this.btnFacturacionAgregarServicio.Text = "Agregar";
            this.btnFacturacionAgregarServicio.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(614, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Servicios:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(75)))), ((int)(((byte)(181)))));
            this.button1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(310, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtFacturacionCliente
            // 
            this.txtFacturacionCliente.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacturacionCliente.Location = new System.Drawing.Point(101, 36);
            this.txtFacturacionCliente.MaxLength = 20;
            this.txtFacturacionCliente.Name = "txtFacturacionCliente";
            this.txtFacturacionCliente.Size = new System.Drawing.Size(200, 32);
            this.txtFacturacionCliente.TabIndex = 1;
            this.txtFacturacionCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbFacturacionCliente
            // 
            this.lbFacturacionCliente.AutoSize = true;
            this.lbFacturacionCliente.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturacionCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lbFacturacionCliente.Location = new System.Drawing.Point(16, 39);
            this.lbFacturacionCliente.Name = "lbFacturacionCliente";
            this.lbFacturacionCliente.Size = new System.Drawing.Size(79, 24);
            this.lbFacturacionCliente.TabIndex = 0;
            this.lbFacturacionCliente.Text = "Cliente:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbFacturacionPrecioServicio);
            this.panel2.Controls.Add(this.lbFacturacionPrecio);
            this.panel2.Controls.Add(this.lbFacturacionDescripcionServicio);
            this.panel2.Controls.Add(this.lbFacturacionDescripcion);
            this.panel2.Controls.Add(this.lbFacturacionTipoServicioSeleccionado);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbFacturacionServicioSeleccionado);
            this.panel2.Controls.Add(this.lbFacturacionDetalleServicio);
            this.panel2.Controls.Add(this.lbFacturacionDetallesServicio);
            this.panel2.Location = new System.Drawing.Point(48, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 460);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbFacturacionPrecioServicio
            // 
            this.lbFacturacionPrecioServicio.AutoSize = true;
            this.lbFacturacionPrecioServicio.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturacionPrecioServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionPrecioServicio.Location = new System.Drawing.Point(22, 354);
            this.lbFacturacionPrecioServicio.Name = "lbFacturacionPrecioServicio";
            this.lbFacturacionPrecioServicio.Size = new System.Drawing.Size(51, 18);
            this.lbFacturacionPrecioServicio.TabIndex = 8;
            this.lbFacturacionPrecioServicio.Text = "Precio";
            // 
            // lbFacturacionPrecio
            // 
            this.lbFacturacionPrecio.AutoSize = true;
            this.lbFacturacionPrecio.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturacionPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionPrecio.Location = new System.Drawing.Point(22, 336);
            this.lbFacturacionPrecio.Name = "lbFacturacionPrecio";
            this.lbFacturacionPrecio.Size = new System.Drawing.Size(55, 18);
            this.lbFacturacionPrecio.TabIndex = 7;
            this.lbFacturacionPrecio.Text = "Precio:";
            // 
            // lbFacturacionDescripcionServicio
            // 
            this.lbFacturacionDescripcionServicio.AutoSize = true;
            this.lbFacturacionDescripcionServicio.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturacionDescripcionServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionDescripcionServicio.Location = new System.Drawing.Point(22, 276);
            this.lbFacturacionDescripcionServicio.Name = "lbFacturacionDescripcionServicio";
            this.lbFacturacionDescripcionServicio.Size = new System.Drawing.Size(169, 18);
            this.lbFacturacionDescripcionServicio.TabIndex = 6;
            this.lbFacturacionDescripcionServicio.Text = "Descripcion del servicio";
            // 
            // lbFacturacionDescripcion
            // 
            this.lbFacturacionDescripcion.AutoSize = true;
            this.lbFacturacionDescripcion.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturacionDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionDescripcion.Location = new System.Drawing.Point(22, 260);
            this.lbFacturacionDescripcion.Name = "lbFacturacionDescripcion";
            this.lbFacturacionDescripcion.Size = new System.Drawing.Size(91, 18);
            this.lbFacturacionDescripcion.TabIndex = 5;
            this.lbFacturacionDescripcion.Text = "Descripcion:";
            // 
            // lbFacturacionTipoServicioSeleccionado
            // 
            this.lbFacturacionTipoServicioSeleccionado.AutoSize = true;
            this.lbFacturacionTipoServicioSeleccionado.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturacionTipoServicioSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionTipoServicioSeleccionado.Location = new System.Drawing.Point(17, 197);
            this.lbFacturacionTipoServicioSeleccionado.Name = "lbFacturacionTipoServicioSeleccionado";
            this.lbFacturacionTipoServicioSeleccionado.Size = new System.Drawing.Size(209, 18);
            this.lbFacturacionTipoServicioSeleccionado.TabIndex = 4;
            this.lbFacturacionTipoServicioSeleccionado.Text = "Tipo de servicio seleccionado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.label7.Location = new System.Drawing.Point(17, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tipo de Servicio:";
            // 
            // lbFacturacionServicioSeleccionado
            // 
            this.lbFacturacionServicioSeleccionado.AutoSize = true;
            this.lbFacturacionServicioSeleccionado.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturacionServicioSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionServicioSeleccionado.Location = new System.Drawing.Point(21, 131);
            this.lbFacturacionServicioSeleccionado.Name = "lbFacturacionServicioSeleccionado";
            this.lbFacturacionServicioSeleccionado.Size = new System.Drawing.Size(157, 18);
            this.lbFacturacionServicioSeleccionado.TabIndex = 2;
            this.lbFacturacionServicioSeleccionado.Text = "Servicio Seleccionado";
            // 
            // lbFacturacionDetalleServicio
            // 
            this.lbFacturacionDetalleServicio.AutoSize = true;
            this.lbFacturacionDetalleServicio.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturacionDetalleServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionDetalleServicio.Location = new System.Drawing.Point(21, 111);
            this.lbFacturacionDetalleServicio.Name = "lbFacturacionDetalleServicio";
            this.lbFacturacionDetalleServicio.Size = new System.Drawing.Size(74, 18);
            this.lbFacturacionDetalleServicio.TabIndex = 1;
            this.lbFacturacionDetalleServicio.Text = "Servicios:";
            // 
            // lbFacturacionDetallesServicio
            // 
            this.lbFacturacionDetallesServicio.AutoSize = true;
            this.lbFacturacionDetallesServicio.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturacionDetallesServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionDetallesServicio.Location = new System.Drawing.Point(14, 29);
            this.lbFacturacionDetallesServicio.Name = "lbFacturacionDetallesServicio";
            this.lbFacturacionDetallesServicio.Size = new System.Drawing.Size(265, 34);
            this.lbFacturacionDetallesServicio.TabIndex = 0;
            this.lbFacturacionDetallesServicio.Text = "Detalles del servicio";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(358, 336);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(768, 460);
            this.panel3.TabIndex = 9;
            // 
            // btnFacturacionImprimirFactura
            // 
            this.btnFacturacionImprimirFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnFacturacionImprimirFactura.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacionImprimirFactura.ForeColor = System.Drawing.Color.White;
            this.btnFacturacionImprimirFactura.Location = new System.Drawing.Point(939, 802);
            this.btnFacturacionImprimirFactura.Name = "btnFacturacionImprimirFactura";
            this.btnFacturacionImprimirFactura.Size = new System.Drawing.Size(187, 34);
            this.btnFacturacionImprimirFactura.TabIndex = 10;
            this.btnFacturacionImprimirFactura.Text = "Imprimir Factura";
            this.btnFacturacionImprimirFactura.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 454);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmFacturacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1176, 1024);
            this.Controls.Add(this.btnFacturacionImprimirFactura);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbFacturacionFecha);
            this.Controls.Add(this.lbFacturacionAperturaCaja);
            this.Controls.Add(this.lbFacturacionNombreSucursal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbFacturacionNombreCajero);
            this.Controls.Add(this.lbFacturacionUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturacion";
            this.Text = "frmFacturacion";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFacturacionUsuario;
        private System.Windows.Forms.Label lbFacturacionNombreCajero;
        private System.Windows.Forms.Label lbFacturacionNombreSucursal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbFacturacionFecha;
        private System.Windows.Forms.Label lbFacturacionAperturaCaja;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbFacturacionMetodoPago;
        private System.Windows.Forms.ComboBox cbFacturacionServicios;
        private System.Windows.Forms.Button btnFacturacionSeleccionarMetodoPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFacturacionAgregarServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFacturacionCliente;
        private System.Windows.Forms.Label lbFacturacionCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbFacturacionPrecioServicio;
        private System.Windows.Forms.Label lbFacturacionPrecio;
        private System.Windows.Forms.Label lbFacturacionDescripcionServicio;
        private System.Windows.Forms.Label lbFacturacionDescripcion;
        private System.Windows.Forms.Label lbFacturacionTipoServicioSeleccionado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbFacturacionServicioSeleccionado;
        private System.Windows.Forms.Label lbFacturacionDetalleServicio;
        private System.Windows.Forms.Label lbFacturacionDetallesServicio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFacturacionImprimirFactura;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}