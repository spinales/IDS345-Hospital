namespace CORE_WinForm.Forms.Autorizaciones
{
    partial class frmAutorizaciones_MOD
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
            this.cbAseguradora = new System.Windows.Forms.ComboBox();
            this.lblAseguradora = new System.Windows.Forms.Label();
            this.txtMontoAutorizado = new System.Windows.Forms.TextBox();
            this.lblMontoAutorizado = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbAseguradora
            // 
            this.cbAseguradora.FormattingEnabled = true;
            this.cbAseguradora.Location = new System.Drawing.Point(294, 190);
            this.cbAseguradora.Margin = new System.Windows.Forms.Padding(4);
            this.cbAseguradora.Name = "cbAseguradora";
            this.cbAseguradora.Size = new System.Drawing.Size(185, 24);
            this.cbAseguradora.TabIndex = 64;
            // 
            // lblAseguradora
            // 
            this.lblAseguradora.AutoSize = true;
            this.lblAseguradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAseguradora.Location = new System.Drawing.Point(134, 190);
            this.lblAseguradora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAseguradora.Name = "lblAseguradora";
            this.lblAseguradora.Size = new System.Drawing.Size(92, 18);
            this.lblAseguradora.TabIndex = 63;
            this.lblAseguradora.Text = "Aseguradora";
            // 
            // txtMontoAutorizado
            // 
            this.txtMontoAutorizado.Location = new System.Drawing.Point(294, 130);
            this.txtMontoAutorizado.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoAutorizado.Name = "txtMontoAutorizado";
            this.txtMontoAutorizado.Size = new System.Drawing.Size(185, 22);
            this.txtMontoAutorizado.TabIndex = 62;
            // 
            // lblMontoAutorizado
            // 
            this.lblMontoAutorizado.AutoSize = true;
            this.lblMontoAutorizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAutorizado.Location = new System.Drawing.Point(134, 130);
            this.lblMontoAutorizado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoAutorizado.Name = "lblMontoAutorizado";
            this.lblMontoAutorizado.Size = new System.Drawing.Size(126, 18);
            this.lblMontoAutorizado.TabIndex = 61;
            this.lblMontoAutorizado.Text = "Monto Autorizado";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(318, 260);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(152, 33);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(127, 260);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(152, 33);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(97, 40);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(438, 46);
            this.lblTitulo.TabIndex = 58;
            this.lblTitulo.Text = "Modificar Autorización";
            // 
            // frmAutorizaciones_MOD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 334);
            this.Controls.Add(this.cbAseguradora);
            this.Controls.Add(this.lblAseguradora);
            this.Controls.Add(this.txtMontoAutorizado);
            this.Controls.Add(this.lblMontoAutorizado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAutorizaciones_MOD";
            this.ShowIcon = false;
            this.Text = "Modificar Autorización";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAseguradora;
        private System.Windows.Forms.Label lblAseguradora;
        private System.Windows.Forms.TextBox txtMontoAutorizado;
        private System.Windows.Forms.Label lblMontoAutorizado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTitulo;
    }
}