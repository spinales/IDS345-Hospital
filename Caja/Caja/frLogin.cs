using Caja.Migrations;
using Caja.Services;
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

namespace Caja
{
    public partial class frLogin : Form
    {
        public frLogin()
        {
            InitializeComponent();
        }

        private async void btnInicioSesion_Click(object sender, EventArgs e)
        {
            /*var ds = new DataService();
            var personas = await ds.GetAll<Persona>(
                x => (x.RolPersonaID == (int)Enums.RolPersona.Cajero && x.Usuario.Username == txtUsuarioLogin.Text &&
                x.Usuario.Password == txtContraseñaLogin.Text && x.Estado == true),
                x => x.Usuario);
            var persona = personas.FirstOrDefault();

            if (persona != null)   
            {
                frMenu FrMenu = new frMenu();
                FrMenu.Show();
            }
            else
            {
                txtUsuarioLogin.Clear();
                txtContraseñaLogin.Clear();
                MessageBox.Show("El usuario ó la contraseña ingresados no son correctos", 
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */
            frMenu FrMenu = new frMenu();
            FrMenu.Show();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void frLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
