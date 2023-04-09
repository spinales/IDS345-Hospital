using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CORE_WinForm
{
    public partial class frmUsuarios_CREAR : Form
    {
        public frmUsuarios_CREAR()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            LlamarApi();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //borrar campos de todos los text box
        }

        private  async void LlamarApi()
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = "https://localhost:44329/CORE/InsertarUsuario"; // replace with your API endpoint
                var requestBody = new { Username = txtUsuario.Text, Password = txtContraseña.Text,
                                        Email = txtCorreo.Text, SucursalID= int.Parse(cbSucursal.Text),
                                        PerfilID = int.Parse(cbPerfil.Text)}; // replace with your request parameters

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
    }
}
