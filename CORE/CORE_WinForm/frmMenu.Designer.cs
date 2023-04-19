namespace CORE_WinForm
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.autorizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.perfilesToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.cuentasToolStripMenuItem,
            this.ingresosToolStripMenuItem,
            this.autorizaciónToolStripMenuItem,
            this.serviciosToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(140, 703);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
      
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.AutoSize = false;
            this.usuariosToolStripMenuItem.AutoToolTip = true;
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(67, 18);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // perfilesToolStripMenuItem
            // 
            this.perfilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem1,
            this.consultarToolStripMenuItem1,
            this.modificarToolStripMenuItem1,
            this.eliminarToolStripMenuItem1});
            this.perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            this.perfilesToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
            this.perfilesToolStripMenuItem.Text = "Perfiles";
            // 
            // crearToolStripMenuItem1
            // 
            this.crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            this.crearToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.crearToolStripMenuItem1.Text = "Crear";
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem2,
            this.consultarToolStripMenuItem2,
            this.modificarToolStripMenuItem2,
            this.eliminarToolStripMenuItem2});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.pacientesToolStripMenuItem.Text = "Persona";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // crearToolStripMenuItem2
            // 
            this.crearToolStripMenuItem2.Name = "crearToolStripMenuItem2";
            this.crearToolStripMenuItem2.Size = new System.Drawing.Size(154, 26);
            this.crearToolStripMenuItem2.Text = "Crear";
            this.crearToolStripMenuItem2.Click += new System.EventHandler(this.crearToolStripMenuItem2_Click);
            // 
            // consultarToolStripMenuItem2
            // 
            this.consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            this.consultarToolStripMenuItem2.Size = new System.Drawing.Size(154, 26);
            this.consultarToolStripMenuItem2.Text = "Consultar";
            // 
            // modificarToolStripMenuItem2
            // 
            this.modificarToolStripMenuItem2.Name = "modificarToolStripMenuItem2";
            this.modificarToolStripMenuItem2.Size = new System.Drawing.Size(154, 26);
            this.modificarToolStripMenuItem2.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem2
            // 
            this.eliminarToolStripMenuItem2.Name = "eliminarToolStripMenuItem2";
            this.eliminarToolStripMenuItem2.Size = new System.Drawing.Size(154, 26);
            this.eliminarToolStripMenuItem2.Text = "Eliminar";
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem3,
            this.consultarToolStripMenuItem3,
            this.modificarToolStripMenuItem3,
            this.eliminarToolStripMenuItem3});
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            // 
            // crearToolStripMenuItem3
            // 
            this.crearToolStripMenuItem3.Name = "crearToolStripMenuItem3";
            this.crearToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.crearToolStripMenuItem3.Text = "Crear";
            this.crearToolStripMenuItem3.Click += new System.EventHandler(this.crearToolStripMenuItem3_Click);
            // 
            // consultarToolStripMenuItem3
            // 
            this.consultarToolStripMenuItem3.Name = "consultarToolStripMenuItem3";
            this.consultarToolStripMenuItem3.Size = new System.Drawing.Size(154, 26);
            this.consultarToolStripMenuItem3.Text = "Consultar";
            // 
            // modificarToolStripMenuItem3
            // 
            this.modificarToolStripMenuItem3.Name = "modificarToolStripMenuItem3";
            this.modificarToolStripMenuItem3.Size = new System.Drawing.Size(154, 26);
            this.modificarToolStripMenuItem3.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem3
            // 
            this.eliminarToolStripMenuItem3.Name = "eliminarToolStripMenuItem3";
            this.eliminarToolStripMenuItem3.Size = new System.Drawing.Size(154, 26);
            this.eliminarToolStripMenuItem3.Text = "Eliminar";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem6,
            this.consultarToolStripMenuItem6,
            this.modificarToolStripMenuItem6,
            this.eliminarToolStripMenuItem6});
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            // 
            // crearToolStripMenuItem6
            // 
            this.crearToolStripMenuItem6.Name = "crearToolStripMenuItem6";
            this.crearToolStripMenuItem6.Size = new System.Drawing.Size(154, 26);
            this.crearToolStripMenuItem6.Text = "Crear";
            // 
            // consultarToolStripMenuItem6
            // 
            this.consultarToolStripMenuItem6.Name = "consultarToolStripMenuItem6";
            this.consultarToolStripMenuItem6.Size = new System.Drawing.Size(154, 26);
            this.consultarToolStripMenuItem6.Text = "Consultar";
            // 
            // modificarToolStripMenuItem6
            // 
            this.modificarToolStripMenuItem6.Name = "modificarToolStripMenuItem6";
            this.modificarToolStripMenuItem6.Size = new System.Drawing.Size(154, 26);
            this.modificarToolStripMenuItem6.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem6
            // 
            this.eliminarToolStripMenuItem6.Name = "eliminarToolStripMenuItem6";
            this.eliminarToolStripMenuItem6.Size = new System.Drawing.Size(154, 26);
            this.eliminarToolStripMenuItem6.Text = "Eliminar";
            // 
            // autorizaciónToolStripMenuItem
            // 
            this.autorizaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem7,
            this.consultarToolStripMenuItem7,
            this.modificarToolStripMenuItem7,
            this.eliminarToolStripMenuItem7});
            this.autorizaciónToolStripMenuItem.Name = "autorizaciónToolStripMenuItem";
            this.autorizaciónToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.autorizaciónToolStripMenuItem.Text = "Autorización";
            // 
            // crearToolStripMenuItem7
            // 
            this.crearToolStripMenuItem7.Name = "crearToolStripMenuItem7";
            this.crearToolStripMenuItem7.Size = new System.Drawing.Size(154, 26);
            this.crearToolStripMenuItem7.Text = "Crear";
            // 
            // consultarToolStripMenuItem7
            // 
            this.consultarToolStripMenuItem7.Name = "consultarToolStripMenuItem7";
            this.consultarToolStripMenuItem7.Size = new System.Drawing.Size(154, 26);
            this.consultarToolStripMenuItem7.Text = "Consultar";
            // 
            // modificarToolStripMenuItem7
            // 
            this.modificarToolStripMenuItem7.Name = "modificarToolStripMenuItem7";
            this.modificarToolStripMenuItem7.Size = new System.Drawing.Size(154, 26);
            this.modificarToolStripMenuItem7.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem7
            // 
            this.eliminarToolStripMenuItem7.Name = "eliminarToolStripMenuItem7";
            this.eliminarToolStripMenuItem7.Size = new System.Drawing.Size(154, 26);
            this.eliminarToolStripMenuItem7.Text = "Eliminar";
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(981, 703);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(999, 750);
            this.Name = "frmMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
    }
}

