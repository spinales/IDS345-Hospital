namespace CORE_WinForm.Forms.Autorizaciones
{
    partial class frmAutorizaciones_BUSCAR
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblAutorizacionID = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(111, 47);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(298, 46);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Autorizaciones";
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnBuscar.Location = new System.Drawing.Point(1090, 115);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(191, 28);
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(620, 115);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 22);
            this.txtID.TabIndex = 40;
            // 
            // lblAutorizacionID
            // 
            this.lblAutorizacionID.AutoSize = true;
            this.lblAutorizacionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorizacionID.Location = new System.Drawing.Point(455, 115);
            this.lblAutorizacionID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutorizacionID.Name = "lblAutorizacionID";
            this.lblAutorizacionID.Size = new System.Drawing.Size(143, 18);
            this.lblAutorizacionID.TabIndex = 39;
            this.lblAutorizacionID.Text = "ID de la Autorización";
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(188, 115);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(139, 24);
            this.cbFiltro.TabIndex = 38;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(116, 115);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(45, 18);
            this.lblFiltro.TabIndex = 37;
            this.lblFiltro.Text = "Filtrar";
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(120, 160);
            this.dgvPersonas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.RowHeadersWidth = 51;
            this.dgvPersonas.Size = new System.Drawing.Size(1161, 698);
            this.dgvPersonas.TabIndex = 42;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(1340, 500);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 70);
            this.btnBorrar.TabIndex = 45;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(1340, 400);
            this.btnMod.Margin = new System.Windows.Forms.Padding(4);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(100, 70);
            this.btnMod.TabIndex = 44;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(1340, 300);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 70);
            this.btnCrear.TabIndex = 43;
            this.btnCrear.Text = "Nuevo";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // frmAutorizaciones_BUSCAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 901);
            this.ControlBox = false;
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblAutorizacionID);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAutorizaciones_BUSCAR";
            this.Text = "Autorizaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblAutorizacionID;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnCrear;
    }
}