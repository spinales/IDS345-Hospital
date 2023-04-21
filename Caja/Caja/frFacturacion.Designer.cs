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
            this.label5 = new System.Windows.Forms.Label();
            this.cbFacturacionMetodoPago = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbFacturacionServicios = new System.Windows.Forms.ComboBox();
            this.btnFacturacionSeleccionarMetodoPago = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFacturacionAgregarServicio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFacturacionBuscarCliente = new System.Windows.Forms.Button();
            this.txtFacturacionCliente = new System.Windows.Forms.TextBox();
            this.lbFacturacionCliente = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbFacturacionPrecioServicio = new System.Windows.Forms.Label();
            this.lbFacturacionPrecio = new System.Windows.Forms.Label();
            this.lbFacturacionDescripcionServicio = new System.Windows.Forms.Label();
            this.lbFacturacionDescripcion = new System.Windows.Forms.Label();
            this.lbFacturacionTipoServicioSeleccionado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbFacturacionServicioSeleccionado = new System.Windows.Forms.Label();
            this.lbFacturacionDetalleServicio = new System.Windows.Forms.Label();
            this.lbFacturacionDetallesServicio = new System.Windows.Forms.Label();
            this.btnFacturacionImprimirFactura = new System.Windows.Forms.Button();
            this.ImprimirFacturabtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(60, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturación";
            // 
            // lbFacturacionUsuario
            // 
            this.lbFacturacionUsuario.AutoSize = true;
            this.lbFacturacionUsuario.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.lbFacturacionUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionUsuario.Location = new System.Drawing.Point(65, 110);
            this.lbFacturacionUsuario.Name = "lbFacturacionUsuario";
            this.lbFacturacionUsuario.Size = new System.Drawing.Size(84, 24);
            this.lbFacturacionUsuario.TabIndex = 1;
            this.lbFacturacionUsuario.Text = "Usuario:";
            // 
            // lbFacturacionNombreCajero
            // 
            this.lbFacturacionNombreCajero.AutoSize = true;
            this.lbFacturacionNombreCajero.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbFacturacionNombreCajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionNombreCajero.Location = new System.Drawing.Point(135, 110);
            this.lbFacturacionNombreCajero.Name = "lbFacturacionNombreCajero";
            this.lbFacturacionNombreCajero.Size = new System.Drawing.Size(177, 24);
            this.lbFacturacionNombreCajero.TabIndex = 2;
            this.lbFacturacionNombreCajero.Text = "Nombre del Cajero";
            // 
            // lbFacturacionNombreSucursal
            // 
            this.lbFacturacionNombreSucursal.AutoSize = true;
            this.lbFacturacionNombreSucursal.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturacionNombreSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionNombreSucursal.Location = new System.Drawing.Point(403, 110);
            this.lbFacturacionNombreSucursal.Name = "lbFacturacionNombreSucursal";
            this.lbFacturacionNombreSucursal.Size = new System.Drawing.Size(164, 24);
            this.lbFacturacionNombreSucursal.TabIndex = 4;
            this.lbFacturacionNombreSucursal.Text = "Nombre Sucursal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(327, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sucursal:";
            // 
            // lbFacturacionFecha
            // 
            this.lbFacturacionFecha.AutoSize = true;
            this.lbFacturacionFecha.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbFacturacionFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionFecha.Location = new System.Drawing.Point(726, 110);
            this.lbFacturacionFecha.Name = "lbFacturacionFecha";
            this.lbFacturacionFecha.Size = new System.Drawing.Size(93, 24);
            this.lbFacturacionFecha.TabIndex = 6;
            this.lbFacturacionFecha.Text = "getdate()";
            // 
            // lbFacturacionAperturaCaja
            // 
            this.lbFacturacionAperturaCaja.AutoSize = true;
            this.lbFacturacionAperturaCaja.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.lbFacturacionAperturaCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionAperturaCaja.Location = new System.Drawing.Point(591, 110);
            this.lbFacturacionAperturaCaja.Name = "lbFacturacionAperturaCaja";
            this.lbFacturacionAperturaCaja.Size = new System.Drawing.Size(163, 24);
            this.lbFacturacionAperturaCaja.TabIndex = 5;
            this.lbFacturacionAperturaCaja.Text = "Apertura de caja:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbFacturacionMetodoPago);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbFacturacionServicios);
            this.panel1.Controls.Add(this.btnFacturacionSeleccionarMetodoPago);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnFacturacionAgregarServicio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnFacturacionBuscarCliente);
            this.panel1.Controls.Add(this.txtFacturacionCliente);
            this.panel1.Controls.Add(this.lbFacturacionCliente);
            this.panel1.Location = new System.Drawing.Point(48, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 143);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(140)))), ((int)(((byte)(150)))));
            this.label5.Location = new System.Drawing.Point(-1, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1253, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_________________";
            this.label5.UseWaitCursor = true;
            // 
            // cbFacturacionMetodoPago
            // 
            this.cbFacturacionMetodoPago.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFacturacionMetodoPago.FormattingEnabled = true;
            this.cbFacturacionMetodoPago.Location = new System.Drawing.Point(717, 94);
            this.cbFacturacionMetodoPago.Name = "cbFacturacionMetodoPago";
            this.cbFacturacionMetodoPago.Size = new System.Drawing.Size(203, 32);
            this.cbFacturacionMetodoPago.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(140)))), ((int)(((byte)(150)))));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1253, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_________________";
            this.label8.UseWaitCursor = true;
            // 
            // cbFacturacionServicios
            // 
            this.cbFacturacionServicios.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFacturacionServicios.FormattingEnabled = true;
            this.cbFacturacionServicios.Location = new System.Drawing.Point(717, 36);
            this.cbFacturacionServicios.Name = "cbFacturacionServicios";
            this.cbFacturacionServicios.Size = new System.Drawing.Size(203, 32);
            this.cbFacturacionServicios.TabIndex = 9;
            this.cbFacturacionServicios.SelectedIndexChanged += new System.EventHandler(this.cbFacturacionServicios_SelectedIndexChanged);
            // 
            // btnFacturacionSeleccionarMetodoPago
            // 
            this.btnFacturacionSeleccionarMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(75)))), ((int)(((byte)(181)))));
            this.btnFacturacionSeleccionarMetodoPago.FlatAppearance.BorderSize = 0;
            this.btnFacturacionSeleccionarMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacionSeleccionarMetodoPago.Font = new System.Drawing.Font("Roboto", 12.2F, System.Drawing.FontStyle.Bold);
            this.btnFacturacionSeleccionarMetodoPago.ForeColor = System.Drawing.Color.White;
            this.btnFacturacionSeleccionarMetodoPago.Location = new System.Drawing.Point(926, 89);
            this.btnFacturacionSeleccionarMetodoPago.Name = "btnFacturacionSeleccionarMetodoPago";
            this.btnFacturacionSeleccionarMetodoPago.Size = new System.Drawing.Size(131, 34);
            this.btnFacturacionSeleccionarMetodoPago.TabIndex = 8;
            this.btnFacturacionSeleccionarMetodoPago.Text = "Seleccionar";
            this.btnFacturacionSeleccionarMetodoPago.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.label4.Location = new System.Drawing.Point(548, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Metodo de Pago:";
            // 
            // btnFacturacionAgregarServicio
            // 
            this.btnFacturacionAgregarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(75)))), ((int)(((byte)(181)))));
            this.btnFacturacionAgregarServicio.FlatAppearance.BorderSize = 0;
            this.btnFacturacionAgregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacionAgregarServicio.Font = new System.Drawing.Font("Roboto", 12.2F, System.Drawing.FontStyle.Bold);
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
            this.label2.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(614, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Servicios:";
            // 
            // btnFacturacionBuscarCliente
            // 
            this.btnFacturacionBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(75)))), ((int)(((byte)(181)))));
            this.btnFacturacionBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnFacturacionBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacionBuscarCliente.Font = new System.Drawing.Font("Roboto", 12.2F, System.Drawing.FontStyle.Bold);
            this.btnFacturacionBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnFacturacionBuscarCliente.Location = new System.Drawing.Point(310, 36);
            this.btnFacturacionBuscarCliente.Name = "btnFacturacionBuscarCliente";
            this.btnFacturacionBuscarCliente.Size = new System.Drawing.Size(131, 32);
            this.btnFacturacionBuscarCliente.TabIndex = 2;
            this.btnFacturacionBuscarCliente.Text = "Buscar";
            this.btnFacturacionBuscarCliente.UseVisualStyleBackColor = false;
            this.btnFacturacionBuscarCliente.Click += new System.EventHandler(this.btnFacturacionBuscarCliente_Click);
            // 
            // txtFacturacionCliente
            // 
            this.txtFacturacionCliente.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacturacionCliente.Location = new System.Drawing.Point(101, 36);
            this.txtFacturacionCliente.MaxLength = 20;
            this.txtFacturacionCliente.Multiline = true;
            this.txtFacturacionCliente.Name = "txtFacturacionCliente";
            this.txtFacturacionCliente.Size = new System.Drawing.Size(200, 32);
            this.txtFacturacionCliente.TabIndex = 1;
            this.txtFacturacionCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbFacturacionCliente
            // 
            this.lbFacturacionCliente.AutoSize = true;
            this.lbFacturacionCliente.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold);
            this.lbFacturacionCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionCliente.Location = new System.Drawing.Point(16, 39);
            this.lbFacturacionCliente.Name = "lbFacturacionCliente";
            this.lbFacturacionCliente.Size = new System.Drawing.Size(100, 30);
            this.lbFacturacionCliente.TabIndex = 0;
            this.lbFacturacionCliente.Text = "Cliente:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbFacturacionPrecioServicio);
            this.panel2.Controls.Add(this.lbFacturacionPrecio);
            this.panel2.Controls.Add(this.lbFacturacionDescripcionServicio);
            this.panel2.Controls.Add(this.lbFacturacionDescripcion);
            this.panel2.Controls.Add(this.lbFacturacionTipoServicioSeleccionado);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbFacturacionServicioSeleccionado);
            this.panel2.Controls.Add(this.lbFacturacionDetalleServicio);
            this.panel2.Controls.Add(this.lbFacturacionDetallesServicio);
            this.panel2.Location = new System.Drawing.Point(53, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 303);
            this.panel2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(140)))), ((int)(((byte)(150)))));
            this.label6.Location = new System.Drawing.Point(28, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "_____________________________________________";
            this.label6.UseWaitCursor = true;
            // 
            // lbFacturacionPrecioServicio
            // 
            this.lbFacturacionPrecioServicio.AutoSize = true;
            this.lbFacturacionPrecioServicio.Font = new System.Drawing.Font("Roboto", 9.5F);
            this.lbFacturacionPrecioServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionPrecioServicio.Location = new System.Drawing.Point(36, 267);
            this.lbFacturacionPrecioServicio.Name = "lbFacturacionPrecioServicio";
            this.lbFacturacionPrecioServicio.Size = new System.Drawing.Size(53, 19);
            this.lbFacturacionPrecioServicio.TabIndex = 8;
            this.lbFacturacionPrecioServicio.Text = "Precio";
            // 
            // lbFacturacionPrecio
            // 
            this.lbFacturacionPrecio.AutoSize = true;
            this.lbFacturacionPrecio.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbFacturacionPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionPrecio.Location = new System.Drawing.Point(36, 249);
            this.lbFacturacionPrecio.Name = "lbFacturacionPrecio";
            this.lbFacturacionPrecio.Size = new System.Drawing.Size(60, 19);
            this.lbFacturacionPrecio.TabIndex = 7;
            this.lbFacturacionPrecio.Text = "Precio:";
            // 
            // lbFacturacionDescripcionServicio
            // 
            this.lbFacturacionDescripcionServicio.AutoSize = true;
            this.lbFacturacionDescripcionServicio.Font = new System.Drawing.Font("Roboto", 9.5F);
            this.lbFacturacionDescripcionServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionDescripcionServicio.Location = new System.Drawing.Point(36, 217);
            this.lbFacturacionDescripcionServicio.Name = "lbFacturacionDescripcionServicio";
            this.lbFacturacionDescripcionServicio.Size = new System.Drawing.Size(175, 19);
            this.lbFacturacionDescripcionServicio.TabIndex = 6;
            this.lbFacturacionDescripcionServicio.Text = "Descripcion del servicio";
            // 
            // lbFacturacionDescripcion
            // 
            this.lbFacturacionDescripcion.AutoSize = true;
            this.lbFacturacionDescripcion.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbFacturacionDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionDescripcion.Location = new System.Drawing.Point(36, 201);
            this.lbFacturacionDescripcion.Name = "lbFacturacionDescripcion";
            this.lbFacturacionDescripcion.Size = new System.Drawing.Size(98, 19);
            this.lbFacturacionDescripcion.TabIndex = 5;
            this.lbFacturacionDescripcion.Text = "Descripcion:";
            // 
            // lbFacturacionTipoServicioSeleccionado
            // 
            this.lbFacturacionTipoServicioSeleccionado.AutoSize = true;
            this.lbFacturacionTipoServicioSeleccionado.Font = new System.Drawing.Font("Roboto", 9.5F);
            this.lbFacturacionTipoServicioSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionTipoServicioSeleccionado.Location = new System.Drawing.Point(36, 166);
            this.lbFacturacionTipoServicioSeleccionado.Name = "lbFacturacionTipoServicioSeleccionado";
            this.lbFacturacionTipoServicioSeleccionado.Size = new System.Drawing.Size(217, 19);
            this.lbFacturacionTipoServicioSeleccionado.TabIndex = 4;
            this.lbFacturacionTipoServicioSeleccionado.Text = "Tipo de servicio seleccionado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.label7.Location = new System.Drawing.Point(36, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tipo de Servicio:";
            // 
            // lbFacturacionServicioSeleccionado
            // 
            this.lbFacturacionServicioSeleccionado.AutoSize = true;
            this.lbFacturacionServicioSeleccionado.Font = new System.Drawing.Font("Roboto", 9.5F);
            this.lbFacturacionServicioSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionServicioSeleccionado.Location = new System.Drawing.Point(36, 115);
            this.lbFacturacionServicioSeleccionado.Name = "lbFacturacionServicioSeleccionado";
            this.lbFacturacionServicioSeleccionado.Size = new System.Drawing.Size(164, 19);
            this.lbFacturacionServicioSeleccionado.TabIndex = 2;
            this.lbFacturacionServicioSeleccionado.Text = "Servicio Seleccionado";
            // 
            // lbFacturacionDetalleServicio
            // 
            this.lbFacturacionDetalleServicio.AutoSize = true;
            this.lbFacturacionDetalleServicio.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbFacturacionDetalleServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionDetalleServicio.Location = new System.Drawing.Point(36, 96);
            this.lbFacturacionDetalleServicio.Name = "lbFacturacionDetalleServicio";
            this.lbFacturacionDetalleServicio.Size = new System.Drawing.Size(80, 19);
            this.lbFacturacionDetalleServicio.TabIndex = 1;
            this.lbFacturacionDetalleServicio.Text = "Servicios:";
            // 
            // lbFacturacionDetallesServicio
            // 
            this.lbFacturacionDetallesServicio.AutoSize = true;
            this.lbFacturacionDetallesServicio.Font = new System.Drawing.Font("Roboto", 15.2F, System.Drawing.FontStyle.Bold);
            this.lbFacturacionDetallesServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.lbFacturacionDetallesServicio.Location = new System.Drawing.Point(63, 34);
            this.lbFacturacionDetallesServicio.Name = "lbFacturacionDetallesServicio";
            this.lbFacturacionDetallesServicio.Size = new System.Drawing.Size(249, 32);
            this.lbFacturacionDetallesServicio.TabIndex = 0;
            this.lbFacturacionDetallesServicio.Text = "Detalles del servicio";
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
            // ImprimirFacturabtn
            // 
            this.ImprimirFacturabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ImprimirFacturabtn.FlatAppearance.BorderSize = 0;
            this.ImprimirFacturabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimirFacturabtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.ImprimirFacturabtn.ForeColor = System.Drawing.Color.White;
            this.ImprimirFacturabtn.Location = new System.Drawing.Point(867, 647);
            this.ImprimirFacturabtn.Name = "ImprimirFacturabtn";
            this.ImprimirFacturabtn.Size = new System.Drawing.Size(259, 36);
            this.ImprimirFacturabtn.TabIndex = 16;
            this.ImprimirFacturabtn.Text = "Imprimir Factura";
            this.ImprimirFacturabtn.UseVisualStyleBackColor = false;
            this.ImprimirFacturabtn.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(408, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(717, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // frFacturacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1160, 749);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ImprimirFacturabtn);
            this.Controls.Add(this.btnFacturacionImprimirFactura);
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
            this.Name = "frFacturacion";
            this.Text = "frmFacturacion";
            this.Load += new System.EventHandler(this.frFacturacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button btnFacturacionBuscarCliente;
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
        private System.Windows.Forms.Button btnFacturacionImprimirFactura;
        private System.Windows.Forms.Button ImprimirFacturabtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}