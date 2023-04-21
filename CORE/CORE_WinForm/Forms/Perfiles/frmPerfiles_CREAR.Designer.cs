namespace CORE_WinForm.Forms.Perfiles
{
    partial class frmPerfiles_CREAR
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.chkListBoxCrear = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkListBoxVisualizar = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkListBoxMod = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkListBoxBorrar = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(227, 53);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(190, 37);
            this.lblTitulo.TabIndex = 39;
            this.lblTitulo.Text = "Crear Perfil";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(382, 362);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 27);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(312, 123);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 20);
            this.txtNombre.TabIndex = 37;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(192, 123);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 15);
            this.lblNombre.TabIndex = 28;
            this.lblNombre.Text = "Nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(234, 362);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 27);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkListBoxCrear
            // 
            this.chkListBoxCrear.FormattingEnabled = true;
            this.chkListBoxCrear.Items.AddRange(new object[] {
            "Usuarios",
            "Perfiles",
            "Personas",
            "Autorizaciones",
            "Servicios",
            "Ingresos",
            "Cuentas"});
            this.chkListBoxCrear.Location = new System.Drawing.Point(12, 198);
            this.chkListBoxCrear.Name = "chkListBoxCrear";
            this.chkListBoxCrear.Size = new System.Drawing.Size(129, 109);
            this.chkListBoxCrear.TabIndex = 40;
            this.chkListBoxCrear.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Permisos para crear";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Permisos para visualizar";
            // 
            // chkListBoxVisualizar
            // 
            this.chkListBoxVisualizar.FormattingEnabled = true;
            this.chkListBoxVisualizar.Items.AddRange(new object[] {
            "Usuarios",
            "Perfiles",
            "Personas",
            "Autorizaciones",
            "Servicios",
            "Ingresos",
            "Cuentas"});
            this.chkListBoxVisualizar.Location = new System.Drawing.Point(192, 198);
            this.chkListBoxVisualizar.Name = "chkListBoxVisualizar";
            this.chkListBoxVisualizar.Size = new System.Drawing.Size(129, 109);
            this.chkListBoxVisualizar.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Permisos para modificar";
            // 
            // chkListBoxMod
            // 
            this.chkListBoxMod.FormattingEnabled = true;
            this.chkListBoxMod.Items.AddRange(new object[] {
            "Usuarios",
            "Perfiles",
            "Personas",
            "Autorizaciones",
            "Servicios",
            "Ingresos",
            "Cuentas"});
            this.chkListBoxMod.Location = new System.Drawing.Point(379, 198);
            this.chkListBoxMod.Name = "chkListBoxMod";
            this.chkListBoxMod.Size = new System.Drawing.Size(129, 109);
            this.chkListBoxMod.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(567, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "Permisos para eliminar";
            // 
            // chkListBoxBorrar
            // 
            this.chkListBoxBorrar.FormattingEnabled = true;
            this.chkListBoxBorrar.Items.AddRange(new object[] {
            "Usuarios",
            "Perfiles",
            "Personas",
            "Autorizaciones",
            "Servicios",
            "Ingresos",
            "Cuentas"});
            this.chkListBoxBorrar.Location = new System.Drawing.Point(570, 198);
            this.chkListBoxBorrar.Name = "chkListBoxBorrar";
            this.chkListBoxBorrar.Size = new System.Drawing.Size(129, 109);
            this.chkListBoxBorrar.TabIndex = 46;
            // 
            // frmPerfiles_CREAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 472);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkListBoxBorrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkListBoxMod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkListBoxVisualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkListBoxCrear);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPerfiles_CREAR";
            this.ShowIcon = false;
            this.Text = "Crear Perfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckedListBox chkListBoxCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chkListBoxVisualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox chkListBoxMod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox chkListBoxBorrar;
    }
}