namespace Caja
{
    partial class frCuentaAbono
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
            this.Panel = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Button();
            this.abonarbtn = new System.Windows.Forms.Button();
            this.MetodoPagocb = new System.Windows.Forms.ComboBox();
            this.Montoabonarlbl = new System.Windows.Forms.Label();
            this.montoabonartxt = new System.Windows.Forms.TextBox();
            this.metodopagolbl = new System.Windows.Forms.Label();
            this.Cuentalbl = new System.Windows.Forms.Label();
            this.gbEfectivo = new System.Windows.Forms.GroupBox();
            this.montorecibidotxt = new System.Windows.Forms.TextBox();
            this.Montorecibidolbl = new System.Windows.Forms.Label();
            this.montodevueltotxt = new System.Windows.Forms.TextBox();
            this.Montodevueltolbl = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            this.gbEfectivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.Controls.Add(this.closebtn);
            this.Panel.Controls.Add(this.abonarbtn);
            this.Panel.Controls.Add(this.MetodoPagocb);
            this.Panel.Controls.Add(this.Montoabonarlbl);
            this.Panel.Controls.Add(this.montoabonartxt);
            this.Panel.Controls.Add(this.metodopagolbl);
            this.Panel.Controls.Add(this.Cuentalbl);
            this.Panel.Controls.Add(this.gbEfectivo);
            this.Panel.Location = new System.Drawing.Point(178, 79);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(780, 600);
            this.Panel.TabIndex = 0;
            // 
            // closebtn
            // 
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.closebtn.Location = new System.Drawing.Point(747, 3);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(28, 21);
            this.closebtn.TabIndex = 11;
            this.closebtn.Text = "x";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // abonarbtn
            // 
            this.abonarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(75)))), ((int)(((byte)(181)))));
            this.abonarbtn.FlatAppearance.BorderSize = 0;
            this.abonarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abonarbtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.abonarbtn.ForeColor = System.Drawing.Color.White;
            this.abonarbtn.Location = new System.Drawing.Point(244, 453);
            this.abonarbtn.Name = "abonarbtn";
            this.abonarbtn.Size = new System.Drawing.Size(220, 36);
            this.abonarbtn.TabIndex = 70;
            this.abonarbtn.Text = "Abonar";
            this.abonarbtn.UseVisualStyleBackColor = false;
            this.abonarbtn.UseWaitCursor = true;
            this.abonarbtn.Click += new System.EventHandler(this.abonarbtn_Click);
            // 
            // MetodoPagocb
            // 
            this.MetodoPagocb.BackColor = System.Drawing.Color.White;
            this.MetodoPagocb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetodoPagocb.FormattingEnabled = true;
            this.MetodoPagocb.Items.AddRange(new object[] {
            "Tarjeta",
            "Efectivo"});
            this.MetodoPagocb.Location = new System.Drawing.Point(111, 223);
            this.MetodoPagocb.Name = "MetodoPagocb";
            this.MetodoPagocb.Size = new System.Drawing.Size(194, 30);
            this.MetodoPagocb.TabIndex = 12;
            this.MetodoPagocb.UseWaitCursor = true;
            this.MetodoPagocb.SelectedIndexChanged += new System.EventHandler(this.MetodoPagocb_SelectedIndexChanged);
            // 
            // Montoabonarlbl
            // 
            this.Montoabonarlbl.AutoSize = true;
            this.Montoabonarlbl.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Montoabonarlbl.Location = new System.Drawing.Point(113, 322);
            this.Montoabonarlbl.Name = "Montoabonarlbl";
            this.Montoabonarlbl.Size = new System.Drawing.Size(115, 18);
            this.Montoabonarlbl.TabIndex = 68;
            this.Montoabonarlbl.Text = "Monto a abonar:";
            this.Montoabonarlbl.UseWaitCursor = true;
            // 
            // montoabonartxt
            // 
            this.montoabonartxt.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoabonartxt.Location = new System.Drawing.Point(112, 360);
            this.montoabonartxt.Multiline = true;
            this.montoabonartxt.Name = "montoabonartxt";
            this.montoabonartxt.Size = new System.Drawing.Size(210, 36);
            this.montoabonartxt.TabIndex = 66;
            this.montoabonartxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.montoabonartxt.UseWaitCursor = true;
            // 
            // metodopagolbl
            // 
            this.metodopagolbl.AutoSize = true;
            this.metodopagolbl.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metodopagolbl.Location = new System.Drawing.Point(113, 179);
            this.metodopagolbl.Name = "metodopagolbl";
            this.metodopagolbl.Size = new System.Drawing.Size(119, 18);
            this.metodopagolbl.TabIndex = 64;
            this.metodopagolbl.Text = "Metodo de pago:";
            this.metodopagolbl.UseWaitCursor = true;
            // 
            // Cuentalbl
            // 
            this.Cuentalbl.AutoSize = true;
            this.Cuentalbl.Font = new System.Drawing.Font("Roboto", 27F, System.Drawing.FontStyle.Bold);
            this.Cuentalbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.Cuentalbl.Location = new System.Drawing.Point(180, 92);
            this.Cuentalbl.Name = "Cuentalbl";
            this.Cuentalbl.Size = new System.Drawing.Size(319, 43);
            this.Cuentalbl.TabIndex = 2;
            this.Cuentalbl.Text = "Abonar a la cuenta";
            this.Cuentalbl.UseWaitCursor = true;
            // 
            // gbEfectivo
            // 
            this.gbEfectivo.BackColor = System.Drawing.Color.Transparent;
            this.gbEfectivo.Controls.Add(this.montorecibidotxt);
            this.gbEfectivo.Controls.Add(this.Montorecibidolbl);
            this.gbEfectivo.Controls.Add(this.montodevueltotxt);
            this.gbEfectivo.Controls.Add(this.Montodevueltolbl);
            this.gbEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbEfectivo.Location = new System.Drawing.Point(354, 154);
            this.gbEfectivo.Name = "gbEfectivo";
            this.gbEfectivo.Size = new System.Drawing.Size(277, 268);
            this.gbEfectivo.TabIndex = 71;
            this.gbEfectivo.TabStop = false;
            // 
            // montorecibidotxt
            // 
            this.montorecibidotxt.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montorecibidotxt.Location = new System.Drawing.Point(35, 64);
            this.montorecibidotxt.Multiline = true;
            this.montorecibidotxt.Name = "montorecibidotxt";
            this.montorecibidotxt.Size = new System.Drawing.Size(210, 36);
            this.montorecibidotxt.TabIndex = 63;
            this.montorecibidotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.montorecibidotxt.UseWaitCursor = true;
            // 
            // Montorecibidolbl
            // 
            this.Montorecibidolbl.AutoSize = true;
            this.Montorecibidolbl.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Montorecibidolbl.Location = new System.Drawing.Point(43, 26);
            this.Montorecibidolbl.Name = "Montorecibidolbl";
            this.Montorecibidolbl.Size = new System.Drawing.Size(116, 18);
            this.Montorecibidolbl.TabIndex = 65;
            this.Montorecibidolbl.Text = "Monto Recibido:";
            this.Montorecibidolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Montorecibidolbl.UseWaitCursor = true;
            // 
            // montodevueltotxt
            // 
            this.montodevueltotxt.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montodevueltotxt.Location = new System.Drawing.Point(35, 207);
            this.montodevueltotxt.Multiline = true;
            this.montodevueltotxt.Name = "montodevueltotxt";
            this.montodevueltotxt.Size = new System.Drawing.Size(210, 36);
            this.montodevueltotxt.TabIndex = 67;
            this.montodevueltotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.montodevueltotxt.UseWaitCursor = true;
            // 
            // Montodevueltolbl
            // 
            this.Montodevueltolbl.AutoSize = true;
            this.Montodevueltolbl.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Montodevueltolbl.Location = new System.Drawing.Point(43, 169);
            this.Montodevueltolbl.Name = "Montodevueltolbl";
            this.Montodevueltolbl.Size = new System.Drawing.Size(115, 18);
            this.Montodevueltolbl.TabIndex = 69;
            this.Montodevueltolbl.Text = "Monto devuelto:";
            this.Montodevueltolbl.UseWaitCursor = true;
            // 
            // frCuentaAbono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1160, 749);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frCuentaAbono";
            this.Text = "frCuentaAbono";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.gbEfectivo.ResumeLayout(false);
            this.gbEfectivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label Cuentalbl;
        private System.Windows.Forms.Label Montodevueltolbl;
        private System.Windows.Forms.Label Montoabonarlbl;
        private System.Windows.Forms.TextBox montodevueltotxt;
        private System.Windows.Forms.TextBox montoabonartxt;
        private System.Windows.Forms.Label Montorecibidolbl;
        private System.Windows.Forms.Label metodopagolbl;
        private System.Windows.Forms.TextBox montorecibidotxt;
        private System.Windows.Forms.ComboBox MetodoPagocb;
        private System.Windows.Forms.Button abonarbtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.GroupBox gbEfectivo;
    }
}