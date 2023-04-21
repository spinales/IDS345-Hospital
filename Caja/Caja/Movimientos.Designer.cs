namespace Caja
{
    partial class frMovimientos
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
            this.Movimientoslbl = new System.Windows.Forms.Label();
            this.Movimientosdgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Movimientosdgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Movimientoslbl
            // 
            this.Movimientoslbl.AutoSize = true;
            this.Movimientoslbl.Font = new System.Drawing.Font("Roboto", 27F, System.Drawing.FontStyle.Bold);
            this.Movimientoslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.Movimientoslbl.Location = new System.Drawing.Point(353, 87);
            this.Movimientoslbl.Name = "Movimientoslbl";
            this.Movimientoslbl.Size = new System.Drawing.Size(229, 43);
            this.Movimientoslbl.TabIndex = 2;
            this.Movimientoslbl.Text = "Movimientos";
            this.Movimientoslbl.UseWaitCursor = true;
            // 
            // Movimientosdgv
            // 
            this.Movimientosdgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.Movimientosdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Movimientosdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Movimientosdgv.Location = new System.Drawing.Point(61, 154);
            this.Movimientosdgv.Name = "Movimientosdgv";
            this.Movimientosdgv.Size = new System.Drawing.Size(807, 349);
            this.Movimientosdgv.TabIndex = 71;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Controls.Add(this.Movimientosdgv);
            this.panel1.Controls.Add(this.Movimientoslbl);
            this.panel1.Location = new System.Drawing.Point(111, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 537);
            this.panel1.TabIndex = 72;
            // 
            // closebtn
            // 
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.closebtn.Location = new System.Drawing.Point(900, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(28, 21);
            this.closebtn.TabIndex = 72;
            this.closebtn.Text = "x";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // frMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 710);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frMovimientos";
            this.Text = "Movimientos";
            ((System.ComponentModel.ISupportInitialize)(this.Movimientosdgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Movimientoslbl;
        private System.Windows.Forms.DataGridView Movimientosdgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closebtn;
    }
}