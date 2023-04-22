namespace Caja
{
    partial class frMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMenu));
            this.PanelSideMenu = new System.Windows.Forms.Panel();
            this.Cuentabtn = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.Facturabtn = new System.Windows.Forms.Button();
            this.Cuadrebtn = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.panelFormHijo = new System.Windows.Forms.Panel();
            this.PanelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSideMenu
            // 
            this.PanelSideMenu.BackColor = System.Drawing.Color.White;
            this.PanelSideMenu.Controls.Add(this.Cuentabtn);
            this.PanelSideMenu.Controls.Add(this.logout);
            this.PanelSideMenu.Controls.Add(this.Facturabtn);
            this.PanelSideMenu.Controls.Add(this.Cuadrebtn);
            this.PanelSideMenu.Controls.Add(this.PanelLogo);
            this.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelSideMenu.Name = "PanelSideMenu";
            this.PanelSideMenu.Size = new System.Drawing.Size(210, 749);
            this.PanelSideMenu.TabIndex = 0;
            // 
            // Cuentabtn
            // 
            this.Cuentabtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cuentabtn.FlatAppearance.BorderSize = 0;
            this.Cuentabtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.Cuentabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cuentabtn.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.Cuentabtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Cuentabtn.Image = ((System.Drawing.Image)(resources.GetObject("Cuentabtn.Image")));
            this.Cuentabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cuentabtn.Location = new System.Drawing.Point(0, 259);
            this.Cuentabtn.Name = "Cuentabtn";
            this.Cuentabtn.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.Cuentabtn.Size = new System.Drawing.Size(210, 43);
            this.Cuentabtn.TabIndex = 4;
            this.Cuentabtn.Text = "Cuentas";
            this.Cuentabtn.UseVisualStyleBackColor = true;
            this.Cuentabtn.Click += new System.EventHandler(this.Cuentabtn_Click);
            // 
            // logout
            // 
            this.logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(0, 687);
            this.logout.Name = "logout";
            this.logout.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.logout.Size = new System.Drawing.Size(210, 62);
            this.logout.TabIndex = 3;
            this.logout.Text = "Salir";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Facturabtn
            // 
            this.Facturabtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Facturabtn.FlatAppearance.BorderSize = 0;
            this.Facturabtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.Facturabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Facturabtn.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.Facturabtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Facturabtn.Image = ((System.Drawing.Image)(resources.GetObject("Facturabtn.Image")));
            this.Facturabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Facturabtn.Location = new System.Drawing.Point(0, 216);
            this.Facturabtn.Name = "Facturabtn";
            this.Facturabtn.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.Facturabtn.Size = new System.Drawing.Size(210, 43);
            this.Facturabtn.TabIndex = 2;
            this.Facturabtn.Text = "Factura";
            this.Facturabtn.UseVisualStyleBackColor = true;
            this.Facturabtn.Click += new System.EventHandler(this.Facturabtn_Click);
            // 
            // Cuadrebtn
            // 
            this.Cuadrebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cuadrebtn.FlatAppearance.BorderSize = 0;
            this.Cuadrebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.Cuadrebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cuadrebtn.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.Cuadrebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Cuadrebtn.Image = ((System.Drawing.Image)(resources.GetObject("Cuadrebtn.Image")));
            this.Cuadrebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cuadrebtn.Location = new System.Drawing.Point(0, 173);
            this.Cuadrebtn.Name = "Cuadrebtn";
            this.Cuadrebtn.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.Cuadrebtn.Size = new System.Drawing.Size(210, 43);
            this.Cuadrebtn.TabIndex = 1;
            this.Cuadrebtn.Text = "Cuadre";
            this.Cuadrebtn.UseVisualStyleBackColor = true;
            this.Cuadrebtn.Click += new System.EventHandler(this.Cuadrebtn_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(210, 173);
            this.PanelLogo.TabIndex = 0;
            // 
            // panelFormHijo
            // 
            this.panelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormHijo.Location = new System.Drawing.Point(210, 0);
            this.panelFormHijo.MinimumSize = new System.Drawing.Size(1040, 671);
            this.panelFormHijo.Name = "panelFormHijo";
            this.panelFormHijo.Size = new System.Drawing.Size(1160, 749);
            this.panelFormHijo.TabIndex = 1;
            // 
            // frMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panelFormHijo);
            this.Controls.Add(this.PanelSideMenu);
            this.Name = "frMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frMenu";
            this.Load += new System.EventHandler(this.frMenu_Load);
            this.PanelSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSideMenu;
        private System.Windows.Forms.Button Facturabtn;
        private System.Windows.Forms.Button Cuadrebtn;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel panelFormHijo;
        private System.Windows.Forms.Button Cuentabtn;
    }
}