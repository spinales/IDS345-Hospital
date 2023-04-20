using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CORE_WinForm
{
    public partial class frmUsuarios_MOD : Form
    {
        public Usuario usuario { get; set; }
        public frmUsuarios_MOD(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            txtUsuario.Text = this.usuario.Username;
            txtCorreo.Text = this.usuario.Email;
            cbSucursal.SelectedValue= this.usuario.SucursalID;
            cbPerfil.SelectedItem = this.usuario.Perfil;
            txtContraseña.Enabled = false;
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked == true)
            {
                txtContraseña.Enabled = true;
            }
            else
            {
                txtContraseña.Enabled = false;
            }
        }
    }
}
