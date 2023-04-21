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
using System.Xml.Linq;

namespace CORE_WinForm.Forms.Personas
{

    public partial class frmPersonas_CREAR : Form
    {
        public frmPersonas_CREAR()
        {
            InitializeComponent();
            cbTipoSangre.Items.Add("Cédula");
            cbTipoSangre.Items.Add("Pasaporte");
            cbTipoSangre.Items.Add("Licencia de conducir");


            //NacionalidadID = cbNacionalidad.SelectedValue,
            //RolPersonaID = cbRol.SelectedValue
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
                var apiUrl = "https://localhost:44329/CORE/persona/registrar"; // replace with your API endpoint
                var requestBody = new
                {
                    Sexo= txtSexo.Text,
                    Nombre = txtNombre.Text,
                    Apellido= txtApellido,
                    Documento = txtDocumento.Text,
                    Telefono= txtTelefono.Text,
                    UsuarioID =txtUsuario.Text,
                    TipoSangreID=cbTipoSangre.SelectedValue,
                    TipoDocumentoID= cbTipoDocumento.SelectedValue,
                    NacionalidadID = cbNacionalidad.SelectedValue,
                    RolPersonaID = cbRol.SelectedValue
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
