using Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CORE_WinForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LlamarApiLogin(txtUsuario.Text, Validacion.HashPassword(txtContraseña.Text));
        }
        private async void LlamarApiLogin(string username, string password)
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = string.Format($"https://localhost:44329/CORE/usuario/login?username={0}?password={1}", username, password); // replace with your API endpoint

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (responseContent == null)
                {
                    MessageBox.Show("Esta combinacion de usuario y contraseña no es correcta");
                }
                else
                {
                    // parse the JSON response into a collection of Usuario objects
                    var usuarios = JsonConvert.DeserializeObject<Usuario>(responseContent);
                    frmMenu menu = new frmMenu();
                }
                

            }
        }

    }
}
