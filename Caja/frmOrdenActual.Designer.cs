namespace Caja
{
    partial class frmOrdenActual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenActual));
            this.lbOrdenActual = new System.Windows.Forms.Label();
            this.lbOrdenActualNumeroFactura = new System.Windows.Forms.Label();
            this.lbOrdenActualFecha = new System.Windows.Forms.Label();
            this.lbOrdenActualGetNumeroFactura = new System.Windows.Forms.Label();
            this.lbOrdenActualGetDate = new System.Windows.Forms.Label();
            this.lbOrdenActualNombreCliente = new System.Windows.Forms.Label();
            this.lbOrdenActualClienteID = new System.Windows.Forms.Label();
            this.lbOrdenActualGetIDCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbOrdenActualTotal = new System.Windows.Forms.Label();
            this.lbOrdenActualPrecioTotal = new System.Windows.Forms.Label();
            this.btnOrdenActualImprimirFactura = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOrdenActual
            // 
            this.lbOrdenActual.AutoSize = true;
            this.lbOrdenActual.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrdenActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.lbOrdenActual.Location = new System.Drawing.Point(51, 40);
            this.lbOrdenActual.Name = "lbOrdenActual";
            this.lbOrdenActual.Size = new System.Drawing.Size(175, 34);
            this.lbOrdenActual.TabIndex = 0;
            this.lbOrdenActual.Text = "Orden actual";
            // 
            // lbOrdenActualNumeroFactura
            // 
            this.lbOrdenActualNumeroFactura.AutoSize = true;
            this.lbOrdenActualNumeroFactura.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrdenActualNumeroFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.lbOrdenActualNumeroFactura.Location = new System.Drawing.Point(57, 78);
            this.lbOrdenActualNumeroFactura.Name = "lbOrdenActualNumeroFactura";
            this.lbOrdenActualNumeroFactura.Size = new System.Drawing.Size(119, 15);
            this.lbOrdenActualNumeroFactura.TabIndex = 1;
            this.lbOrdenActualNumeroFactura.Text = "Número de factura:";
            // 
            // lbOrdenActualFecha
            // 
            this.lbOrdenActualFecha.AutoSize = true;
            this.lbOrdenActualFecha.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrdenActualFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.lbOrdenActualFecha.Location = new System.Drawing.Point(57, 97);
            this.lbOrdenActualFecha.Name = "lbOrdenActualFecha";
            this.lbOrdenActualFecha.Size = new System.Drawing.Size(45, 15);
            this.lbOrdenActualFecha.TabIndex = 2;
            this.lbOrdenActualFecha.Text = "Fecha:";
            // 
            // lbOrdenActualGetNumeroFactura
            // 
            this.lbOrdenActualGetNumeroFactura.AutoSize = true;
            this.lbOrdenActualGetNumeroFactura.Location = new System.Drawing.Point(173, 78);
            this.lbOrdenActualGetNumeroFactura.Name = "lbOrdenActualGetNumeroFactura";
            this.lbOrdenActualGetNumeroFactura.Size = new System.Drawing.Size(95, 16);
            this.lbOrdenActualGetNumeroFactura.TabIndex = 4;
            this.lbOrdenActualGetNumeroFactura.Text = "numero factura";
            // 
            // lbOrdenActualGetDate
            // 
            this.lbOrdenActualGetDate.AutoSize = true;
            this.lbOrdenActualGetDate.Location = new System.Drawing.Point(100, 97);
            this.lbOrdenActualGetDate.Name = "lbOrdenActualGetDate";
            this.lbOrdenActualGetDate.Size = new System.Drawing.Size(61, 16);
            this.lbOrdenActualGetDate.TabIndex = 3;
            this.lbOrdenActualGetDate.Text = "getdate()";
            // 
            // lbOrdenActualNombreCliente
            // 
            this.lbOrdenActualNombreCliente.AutoSize = true;
            this.lbOrdenActualNombreCliente.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrdenActualNombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.lbOrdenActualNombreCliente.Location = new System.Drawing.Point(56, 179);
            this.lbOrdenActualNombreCliente.Name = "lbOrdenActualNombreCliente";
            this.lbOrdenActualNombreCliente.Size = new System.Drawing.Size(149, 24);
            this.lbOrdenActualNombreCliente.TabIndex = 5;
            this.lbOrdenActualNombreCliente.Text = "Nombre Cliente";
            // 
            // lbOrdenActualClienteID
            // 
            this.lbOrdenActualClienteID.AutoSize = true;
            this.lbOrdenActualClienteID.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrdenActualClienteID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.lbOrdenActualClienteID.Location = new System.Drawing.Point(57, 203);
            this.lbOrdenActualClienteID.Name = "lbOrdenActualClienteID";
            this.lbOrdenActualClienteID.Size = new System.Drawing.Size(23, 15);
            this.lbOrdenActualClienteID.TabIndex = 6;
            this.lbOrdenActualClienteID.Text = "ID:";
            // 
            // lbOrdenActualGetIDCliente
            // 
            this.lbOrdenActualGetIDCliente.AutoSize = true;
            this.lbOrdenActualGetIDCliente.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrdenActualGetIDCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.lbOrdenActualGetIDCliente.Location = new System.Drawing.Point(87, 203);
            this.lbOrdenActualGetIDCliente.Name = "lbOrdenActualGetIDCliente";
            this.lbOrdenActualGetIDCliente.Size = new System.Drawing.Size(58, 15);
            this.lbOrdenActualGetIDCliente.TabIndex = 7;
            this.lbOrdenActualGetIDCliente.Text = "id cliente";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(60, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 329);
            this.panel1.TabIndex = 8;
            // 
            // lbOrdenActualTotal
            // 
            this.lbOrdenActualTotal.AutoSize = true;
            this.lbOrdenActualTotal.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.lbOrdenActualTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.lbOrdenActualTotal.Location = new System.Drawing.Point(56, 594);
            this.lbOrdenActualTotal.Name = "lbOrdenActualTotal";
            this.lbOrdenActualTotal.Size = new System.Drawing.Size(54, 24);
            this.lbOrdenActualTotal.TabIndex = 9;
            this.lbOrdenActualTotal.Text = "Total";
            // 
            // lbOrdenActualPrecioTotal
            // 
            this.lbOrdenActualPrecioTotal.AutoSize = true;
            this.lbOrdenActualPrecioTotal.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.lbOrdenActualPrecioTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.lbOrdenActualPrecioTotal.Location = new System.Drawing.Point(362, 594);
            this.lbOrdenActualPrecioTotal.Name = "lbOrdenActualPrecioTotal";
            this.lbOrdenActualPrecioTotal.Size = new System.Drawing.Size(111, 24);
            this.lbOrdenActualPrecioTotal.TabIndex = 10;
            this.lbOrdenActualPrecioTotal.Text = "PrecioTotal";
            // 
            // btnOrdenActualImprimirFactura
            // 
            this.btnOrdenActualImprimirFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(75)))), ((int)(((byte)(181)))));
            this.btnOrdenActualImprimirFactura.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenActualImprimirFactura.ForeColor = System.Drawing.Color.White;
            this.btnOrdenActualImprimirFactura.Location = new System.Drawing.Point(60, 723);
            this.btnOrdenActualImprimirFactura.Name = "btnOrdenActualImprimirFactura";
            this.btnOrdenActualImprimirFactura.Size = new System.Drawing.Size(400, 43);
            this.btnOrdenActualImprimirFactura.TabIndex = 11;
            this.btnOrdenActualImprimirFactura.Text = "Imprimir Factura";
            this.btnOrdenActualImprimirFactura.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(437, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmOrdenActual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 805);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOrdenActualImprimirFactura);
            this.Controls.Add(this.lbOrdenActualPrecioTotal);
            this.Controls.Add(this.lbOrdenActualTotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbOrdenActualGetIDCliente);
            this.Controls.Add(this.lbOrdenActualClienteID);
            this.Controls.Add(this.lbOrdenActualNombreCliente);
            this.Controls.Add(this.lbOrdenActualGetNumeroFactura);
            this.Controls.Add(this.lbOrdenActualGetDate);
            this.Controls.Add(this.lbOrdenActualFecha);
            this.Controls.Add(this.lbOrdenActualNumeroFactura);
            this.Controls.Add(this.lbOrdenActual);
            this.Name = "frmOrdenActual";
            this.Text = "frmOrdenActual";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOrdenActual;
        private System.Windows.Forms.Label lbOrdenActualNumeroFactura;
        private System.Windows.Forms.Label lbOrdenActualFecha;
        private System.Windows.Forms.Label lbOrdenActualGetNumeroFactura;
        private System.Windows.Forms.Label lbOrdenActualGetDate;
        private System.Windows.Forms.Label lbOrdenActualNombreCliente;
        private System.Windows.Forms.Label lbOrdenActualClienteID;
        private System.Windows.Forms.Label lbOrdenActualGetIDCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbOrdenActualTotal;
        private System.Windows.Forms.Label lbOrdenActualPrecioTotal;
        private System.Windows.Forms.Button btnOrdenActualImprimirFactura;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}