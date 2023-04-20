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

namespace CORE_WinForm.Forms.Personas
{
    public partial class frmPersonas_BUSCAR : Form
    {
        Persona personaSeleccionada = new Persona();
        public frmPersonas_BUSCAR()
        {
            InitializeComponent();
            cbFiltro.Items.Add("Todos");
            cbFiltro.Items.Add("ID");
            cbFiltro.SelectedIndex = 0;
            btnMod.Enabled = false;
            btnBorrar.Enabled = false;
            LlamarApiGet();
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltro.SelectedIndex == 0)
            {
                txtID.Enabled = false;
            }
            else if (cbFiltro.SelectedIndex == 1)
            {
                txtID.Enabled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbFiltro.SelectedIndex == 0)
            {
                LlamarApiGet();
            }
            else if (cbFiltro.SelectedIndex == 1)
            {
                LlamarApiGetById(int.Parse(txtID.Text));
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmPersonas_CREAR frmPersonas_CREAR = AbrirFormulario<frmPersonas_CREAR>(typeof(frmPersonas_CREAR));
        }
        public T AbrirFormulario<T>(Type buscarTipo) where T : Form, new()
        {
            var formBuscar = Application.OpenForms.OfType<T>().FirstOrDefault();

            if (formBuscar != null)
            {
                formBuscar.Activate();
                formBuscar.BringToFront();
                return formBuscar;
            }
            else
            {
                var formAbrir = new T();
                formAbrir.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                formAbrir.KeyPreview = true;
                formAbrir.Location = new System.Drawing.Point(300, 50);
                formAbrir.MaximizeBox = false;
                formAbrir.MinimizeBox = false;
                formAbrir.MinimumSize = new System.Drawing.Size(500, 500);
                formAbrir.ShowIcon = false;
                formAbrir.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                formAbrir.ShowDialog();
                return formAbrir;
            }
        }

        private async void LlamarApiGet()
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = "https://localhost:44329/CORE/persona/get";

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                var personas = JsonConvert.DeserializeObject<List<Persona>>(responseContent);

                var table = new DataTable();
                table.Columns.Add("PersonaID", typeof(int));
                table.Columns.Add("Estado", typeof(int));
                table.Columns.Add("Sexo", typeof(string));
                table.Columns.Add("Nombre", typeof(string));
                table.Columns.Add("Apellido", typeof(string));
                table.Columns.Add("Documento", typeof(string));
                table.Columns.Add("Telefono", typeof(string));
                table.Columns.Add("UsuarioID", typeof(int));
                table.Columns.Add("TipoSangreID", typeof(int));
                table.Columns.Add("TipoDocumentoID", typeof(int));
                table.Columns.Add("NacionalidadID", typeof(int));
                table.Columns.Add("RolPersonaID", typeof(int));

                foreach (var persona in personas)
                {
                    table.Rows.Add(persona.PersonaID, persona.Estado, persona.Sexo, persona.Nombre, persona.Apellido, persona.Documento, persona.Telefono, persona.UsuarioID, persona.TipoSangreID, persona.TipoDocumentoID, persona.NacionalidadID, persona.RolPersonaID);
                }

                dgvPersonas.DataSource = table;
            }
        }
        private async void LlamarApiGetById(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = string.Format("https://localhost:44329/CORE/persona/getID?id={0}", id);

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                var personas = JsonConvert.DeserializeObject<Persona>(responseContent);

                var table = new DataTable();
                table.Columns.Add("PersonaID", typeof(int));
                table.Columns.Add("Estado", typeof(int));
                table.Columns.Add("Sexo", typeof(string));
                table.Columns.Add("Nombre", typeof(string));
                table.Columns.Add("Apellido", typeof(string));
                table.Columns.Add("Documento", typeof(string));
                table.Columns.Add("Telefono", typeof(string));
                table.Columns.Add("UsuarioID", typeof(int));
                table.Columns.Add("TipoSangreID", typeof(int));
                table.Columns.Add("TipoDocumentoID", typeof(int));
                table.Columns.Add("NacionalidadID", typeof(int));
                table.Columns.Add("RolPersonaID", typeof(int));

                table.Rows.Add(personas.PersonaID, personas.Estado, personas.Sexo, personas.Nombre, personas.Apellido, personas.Documento, personas.Telefono, personas.UsuarioID, personas.TipoSangreID, personas.TipoDocumentoID, personas.NacionalidadID, personas.RolPersonaID);

                dgvPersonas.DataSource = table;
            }
        }
    }
}
