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

namespace CORE_WinForm.Forms.Perfiles
{
    public partial class frmPerfiles_MOD : Form
    {
        public Perfil perfil { get; set; } = new Perfil();
        public frmPerfiles_MOD(Perfil perfil)
        {
            InitializeComponent();
            this.perfil = perfil;
            txtPerfil.Text = this.perfil.Nombre;
        }

        private void frmPerfiles_MOD_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            LlamarApiModificar();
            this.Close();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }


        private async void LlamarApiModificar()
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = "https://localhost:44329/CORE/perfil/modificar"; // replace with your API endpoint
                var requestBody = new
                {
                    PerfilID = this.perfil.PerfilID,
                    Nombre = txtPerfil.Text
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
