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
    public partial class frmPerfiles_CREAR : Form
    {
        public Perfil perfil { get; set; }
        public frmPerfiles_CREAR()
        {
            this.perfil = new Perfil();
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            await LlamarApiRegistrarPerfil();
            await LlamarApiGetPerfilNombre(txtNombre.Text);
            foreach (object itemChecked in chkListBoxCrear.CheckedItems)
            {
                int itemIndex = chkListBoxCrear.Items.IndexOf($"{itemChecked}");
                 await LlamarApiRegistrarPerfilRole(this.perfil.PerfilID, 4 , itemIndex + 1);
            }
            foreach (object itemChecked in chkListBoxVisualizar.CheckedItems)
            {
                int itemIndex = chkListBoxCrear.Items.IndexOf($"{itemChecked}");
                await LlamarApiRegistrarPerfilRole(this.perfil.PerfilID, 1, itemIndex + 1);
            }
            foreach (object itemChecked in chkListBoxMod.CheckedItems)
            {
                int itemIndex = chkListBoxCrear.Items.IndexOf($"{itemChecked}");
                await LlamarApiRegistrarPerfilRole(this.perfil.PerfilID, 2, itemIndex + 1);
            }
            foreach (object itemChecked in chkListBoxBorrar.CheckedItems)
            {
                int itemIndex = chkListBoxCrear.Items.IndexOf($"{itemChecked}");
                await LlamarApiRegistrarPerfilRole(this.perfil.PerfilID, 3, itemIndex + 1);
            }

        }

        private async Task LlamarApiRegistrarPerfil()
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = "https://localhost:44329/CORE/perfil/registrar"; // replace with your API endpoint
                var requestBody = new
                {
                   Nombre = txtNombre.Text
                }; // replace with your request parameters

                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(apiUrl, content);
                var responseContent = await response.Content.ReadAsStringAsync();

                // handle response content here
                MessageBox.Show(responseContent);

            }

        }

        private async Task LlamarApiRegistrarPerfilRole(int perfil, int entidad, int rol)
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = "https://localhost:44329/CORE/perfilrole/registrar"; // replace with your API endpoint
                var requestBody = new
                {
                    PerfilID = perfil,
                    EntidadID = entidad,
                    RoleID = rol
                }; // replace with your request parameters

                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(apiUrl, content);
                var responseContent = await response.Content.ReadAsStringAsync();

                // handle response content here
                MessageBox.Show(responseContent);
            }

        }

        private async Task LlamarApiGetPerfilNombre(string nombre)
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = string.Format("https://localhost:44329/CORE/perfil/getNombre?Nombre={0}", nombre); // replace with your API endpoint

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                // parse the JSON response into a collection of Usuario objects
                var perfiles = JsonConvert.DeserializeObject<Perfil>(responseContent);
                this.perfil = perfiles;
                MessageBox.Show(perfil.Nombre);
            }
        }

    }
}
