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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CORE_WinForm
{
    public partial class frmUsuarios_MOD : Form
    {
        public Usuario usuario { get; set; }
        public frmUsuarios_MOD(Usuario usuario)
        {
            InitializeComponent();
            LlamarApiGetPerfiles();
            LlamarApiGetSucursales();
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

        private async void LlamarApiGetPerfiles()
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = string.Format("https://localhost:44329/CORE/perfiles/get"); // replace with your API endpoint

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                // parse the JSON response into a collection of Usuario objects
                var perfiles = JsonConvert.DeserializeObject<List<Perfil>>(responseContent);
                cbPerfil.DataSource = perfiles;
                cbPerfil.DisplayMember = "Nombre";
                cbPerfil.ValueMember = "PerfilID";
            }
        }

        private async void LlamarApiGetSucursales()
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = string.Format("https://localhost:44329/CORE/sucursales/get"); // replace with your API endpoint

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                // parse the JSON response into a collection of Usuario objects
                var sucursales= JsonConvert.DeserializeObject<List<Sucursal>>(responseContent);
                cbSucursal.DataSource = sucursales;
                cbSucursal.DisplayMember = "Nombre";
                cbSucursal.ValueMember = "SucursalID";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            LlamarApi();
            this.Close();
        }

        private async void LlamarApi()
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = "https://localhost:44329/CORE/usuario/modificar"; // replace with your API endpoint
                var requestBody = new
                {
                    UsuarioID = this.usuario.UsuarioID,
                    Username = txtUsuario.Text,
                    Password = txtContraseña.Text,
                    Email = txtCorreo.Text,
                    SucursalID =cbSucursal.SelectedValue,
                    PerfilID = cbPerfil.SelectedValue
                }; // replace with your request parameters

                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(apiUrl, content);
                var responseContent = await response.Content.ReadAsStringAsync();

                // handle response content here
                MessageBox.Show(responseContent);
            }

        }
    }
}
