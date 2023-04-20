namespace Caja
{
    partial class frLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbImagenLogin = new System.Windows.Forms.PictureBox();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.txtContraseñaLogin = new System.Windows.Forms.TextBox();
            this.lbContraseñaLogin = new System.Windows.Forms.Label();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.pbImagenLogin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 512);
            this.panel1.TabIndex = 0;
            // 
            // pbImagenLogin
            // 
            this.pbImagenLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImagenLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbImagenLogin.Image")));
            this.pbImagenLogin.Location = new System.Drawing.Point(0, 0);
            this.pbImagenLogin.Name = "pbImagenLogin";
            this.pbImagenLogin.Size = new System.Drawing.Size(356, 512);
            this.pbImagenLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenLogin.TabIndex = 0;
            this.pbImagenLogin.TabStop = false;
            // 
            // lbWelcome
            // 
            this.lbWelcome.Font = new System.Drawing.Font("Roboto", 30F, System.Drawing.FontStyle.Bold);
            this.lbWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.lbWelcome.Location = new System.Drawing.Point(386, 57);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(314, 116);
            this.lbWelcome.TabIndex = 1;
            this.lbWelcome.Text = "Bienvenido de nuevo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(390, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicia sesión para acceder a la aplicación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.label2.Location = new System.Drawing.Point(390, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "USUARIO";
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.txtUsuarioLogin.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioLogin.Location = new System.Drawing.Point(386, 247);
            this.txtUsuarioLogin.Multiline = true;
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(314, 32);
            this.txtUsuarioLogin.TabIndex = 4;
            this.txtUsuarioLogin.TextChanged += new System.EventHandler(this.txtUsuarioLogin_TextChanged);
            // 
            // txtContraseñaLogin
            // 
            this.txtContraseñaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.txtContraseñaLogin.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaLogin.Location = new System.Drawing.Point(386, 330);
            this.txtContraseñaLogin.Multiline = true;
            this.txtContraseñaLogin.Name = "txtContraseñaLogin";
            this.txtContraseñaLogin.PasswordChar = '*';
            this.txtContraseñaLogin.Size = new System.Drawing.Size(314, 32);
            this.txtContraseñaLogin.TabIndex = 6;
            this.txtContraseñaLogin.UseSystemPasswordChar = true;
            // 
            // lbContraseñaLogin
            // 
            this.lbContraseñaLogin.AutoSize = true;
            this.lbContraseñaLogin.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContraseñaLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.lbContraseñaLogin.Location = new System.Drawing.Point(390, 305);
            this.lbContraseñaLogin.Name = "lbContraseñaLogin";
            this.lbContraseñaLogin.Size = new System.Drawing.Size(92, 15);
            this.lbContraseñaLogin.TabIndex = 5;
            this.lbContraseñaLogin.Text = "CONTRASEÑA";
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(75)))), ((int)(((byte)(181)))));
            this.btnInicioSesion.FlatAppearance.BorderSize = 0;
            this.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioSesion.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnInicioSesion.ForeColor = System.Drawing.Color.White;
            this.btnInicioSesion.Location = new System.Drawing.Point(386, 400);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(314, 39);
            this.btnInicioSesion.TabIndex = 9;
            this.btnInicioSesion.Text = "INICIAR SESION";
            this.btnInicioSesion.UseVisualStyleBackColor = false;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // closebtn
            // 
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.closebtn.Location = new System.Drawing.Point(712, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(28, 21);
            this.closebtn.TabIndex = 10;
            this.closebtn.Text = "x";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // frLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 512);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.btnInicioSesion);
            this.Controls.Add(this.txtContraseñaLogin);
            this.Controls.Add(this.lbContraseñaLogin);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frLogin";
            this.Text = "frmLogin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.TextBox txtContraseñaLogin;
        private System.Windows.Forms.Label lbContraseñaLogin;
        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.PictureBox pbImagenLogin;
        private System.Windows.Forms.Button closebtn;
    }
}