using Modelos;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CORE_WinForm
{
    public partial class frmUsuarios_CREAR : Form
    {
        public frmUsuarios_CREAR()
        {
            InitializeComponent();
            LlamarApiGetPerfiles();
            LlamarApiGetSucursales();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validacion.IsPasswordStrong(txtContraseña.Text))
            {
                LlamarApi();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tu contraseña no es segura.\n" +
                    "Debe tener por lo menos 8 dígitos, letras, números y mayúsculas");
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //borrar campos de todos los text box
        }

        private async void LlamarApi()
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = "https://localhost:44329/CORE/usuario/registrar"; // replace with your API endpoint
                var requestBody = new
                {
                    Username = txtUsuario.Text,
                    Password = Validacion.HashPassword(txtContraseña.Text),
                    Email = txtCorreo.Text,
                    SucursalID = cbSucursal.SelectedValue,
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

        private void frmUsuarios_CREAR_Load(object sender, EventArgs e)
        {

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
                var sucursales = JsonConvert.DeserializeObject<List<Sucursal>>(responseContent);
                cbSucursal.DataSource = sucursales;
                cbSucursal.DisplayMember = "Nombre";
                cbSucursal.ValueMember = "SucursalID";
            }
        }

        
    }
}
