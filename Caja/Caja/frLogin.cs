using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja
{
    public partial class frLogin : Form
    {
        public frLogin()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuarioLogin.Text == "cajero")//Cambiar la condicion por un procedure que traiga el usuario y la contraseña    
            {
                frMenu FrMenu = new frMenu();
                FrMenu.Show();
            }
            else
            {
                txtUsuarioLogin.Clear();
                txtContraseñaLogin.Clear();
                MessageBox.Show("El usuario ó la contraseña ingresados no son correctos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
