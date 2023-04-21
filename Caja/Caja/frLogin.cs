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

            string usuario = txtUsuarioLogin.Text;
            string contrasena = txtContraseñaLogin.Text;

            // Convertir la contraseña ingresada en hash
            string contrasenaHash = Validacion.HashPassword(contrasena);

            var ds = new DataService();
            var personas = await ds.GetAll<Persona>(
                x => (x.RolPersonaID == (int)Enums.RolPersona.Cajero && x.Usuario.Username == usuario &&
                x.Usuario.Password == contrasenaHash && x.Estado == true),
                x => x.Usuario);
            var persona = personas.FirstOrDefault();

            if (persona != null)
            {
                frMenu FrMenu = new frMenu(persona);
                FrMenu.Show();
            }
            else
            {
                txtUsuarioLogin.Clear();
                txtContraseñaLogin.Clear();
                MessageBox.Show("El usuario ó la contraseña ingresados no son correctos",
                    "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
