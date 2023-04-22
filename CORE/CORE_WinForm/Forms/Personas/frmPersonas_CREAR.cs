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
            cbTipoDocumento.Items.Add("Cédula");
            cbTipoDocumento.Items.Add("Pasaporte");
            cbTipoDocumento.Items.Add("Licencia de conducir");

            cbTipoSangre.Items.Add("O+");
            cbTipoSangre.Items.Add("O-");
            cbTipoSangre.Items.Add("A+");
            cbTipoSangre.Items.Add("A-");
            cbTipoSangre.Items.Add("AB+");
            cbTipoSangre.Items.Add("AB-");
            cbTipoSangre.Items.Add("B+");
            cbTipoSangre.Items.Add("B-");

            cbNacionalidad.Items.Add("Dominicano");
            cbNacionalidad.Items.Add("Estadounidense");
            cbNacionalidad.Items.Add("Venezolano");
            cbNacionalidad.Items.Add("Estadounidense");
            cbNacionalidad.Items.Add("Colombiano");
            cbNacionalidad.Items.Add("Mexicano");
            cbNacionalidad.Items.Add("Haitiano");

            cbRol.Items.Add("Cajero");
            cbRol.Items.Add("Cliente");
            cbRol.Items.Add("Personal administrativo");
            cbRol.Items.Add("Doctor");


            //NacionalidadID = cbNacionalidad.SelectedValue,
            //RolPersonaID = cbRol.SelectedValue
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int variable = cbTipoSangre.SelectedIndex + 1;
            MessageBox.Show(variable.ToString());
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
                    //UsuarioID =int.Parse(txtUsuario.Text),
                    TipoSangreID=cbTipoSangre.SelectedIndex + 1,
                    TipoDocumentoID= cbTipoDocumento.SelectedIndex + 1,
                    NacionalidadID = cbNacionalidad.SelectedIndex + 1,
                    RolPersonaID = cbRol.SelectedIndex + 1
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
