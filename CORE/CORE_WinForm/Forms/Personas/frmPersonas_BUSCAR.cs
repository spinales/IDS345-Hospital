using CORE_WinForm.Forms.Servicios;
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
        public Usuario usuario = new Usuario();
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

        private async void btnCrear_Click(object sender, EventArgs e)
        {
                var abrirForms = new AbrirForms();
                frmPersonas_CREAR frmPersonasC = abrirForms.AbrirFormulario<frmPersonas_CREAR>(typeof(frmPersonas_CREAR));

        }
        

        private async void LlamarApiGet()
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = "https://localhost:44329/CORE/persona/get";

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Antes de serializar");
                MessageBox.Show(responseContent);
                var personas = JsonConvert.DeserializeObject<List<Persona>>(responseContent);
                MessageBox.Show("Despues de serializar");

                var table = new DataTable();
                table.Columns.Add("PersonaID", typeof(int));
                table.Columns.Add("Estado", typeof(int));

                table.Columns.Add("Nombre", typeof(string));
                table.Columns.Add("Apellido", typeof(string));
                table.Columns.Add("Documento", typeof(string));
                table.Columns.Add("Telefono", typeof(string));
                table.Columns.Add("UsuarioID", typeof(int));
                table.Columns.Add("TipoSangreID", typeof(int));
                table.Columns.Add("TipoDocumentoID", typeof(int));
                table.Columns.Add("NacionalidadID", typeof(int));
                table.Columns.Add("RolPersonaID", typeof(int));
                //table.Columns.Add("Sexo", typeof(string));

                foreach (var persona in personas)
                {
                    table.Rows.Add(persona.PersonaID, persona.Estado, persona.Nombre, persona.Apellido, persona.Documento, persona.Telefono, persona.UsuarioID, persona.TipoSangreID, persona.TipoDocumentoID, persona.NacionalidadID, persona.RolPersonaID);
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
                
                table.Columns.Add("Nombre", typeof(string));
                table.Columns.Add("Apellido", typeof(string));
                table.Columns.Add("Documento", typeof(string));
                table.Columns.Add("Telefono", typeof(string));
                table.Columns.Add("UsuarioID", typeof(int));
                table.Columns.Add("TipoSangreID", typeof(int));
                table.Columns.Add("TipoDocumentoID", typeof(int));
                table.Columns.Add("NacionalidadID", typeof(int));
                table.Columns.Add("RolPersonaID", typeof(int));
                //table.Columns.Add("Sexo", typeof(char));

                table.Rows.Add(personas.PersonaID, personas.Estado,
                    personas.Nombre, personas.Apellido, personas.Documento,

                    personas.Telefono, personas.UsuarioID, personas.TipoSangreID,
                    personas.TipoDocumentoID, personas.NacionalidadID, personas.RolPersonaID);

                dgvPersonas.DataSource = table;
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            //frmPersonas_MOD frmPersonasM = new frmPersonas_MOD(personaSeleccionada);
            //frmPersonasM.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            //frmPersonasM.KeyPreview = true;
            //frmPersonasM.Location = new System.Drawing.Point(300, 50);
            //frmPersonasM.MaximizeBox = false;
            //frmPersonasM.MinimizeBox = false;
            //frmPersonasM.MinimumSize = new System.Drawing.Size(500, 500);
            //frmPersonasM.ShowIcon = false;
            //frmPersonasM.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //frmPersonasM.ShowDialog();
        }
        private void dgvPersonas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            personaSeleccionada.PersonaID = Convert.ToInt32(dgvPersonas.Rows[e.RowIndex].Cells[0].Value.ToString());
            personaSeleccionada.Nombre = dgvPersonas.Rows[e.RowIndex].Cells[2].Value.ToString();
            personaSeleccionada.Apellido = dgvPersonas.Rows[e.RowIndex].Cells[3].Value.ToString();
            personaSeleccionada.Documento = dgvPersonas.Rows[e.RowIndex].Cells[4].Value.ToString();
            personaSeleccionada.Telefono = dgvPersonas.Rows[e.RowIndex].Cells[5].Value.ToString();
            personaSeleccionada.UsuarioID = Convert.ToInt32(dgvPersonas.Rows[e.RowIndex].Cells[6].Value.ToString());
            personaSeleccionada.TipoSangreID = Convert.ToInt32(dgvPersonas.Rows[e.RowIndex].Cells[7].Value.ToString());
            personaSeleccionada.TipoDocumentoID = Convert.ToInt32(dgvPersonas.Rows[e.RowIndex].Cells[8].Value.ToString());
            personaSeleccionada.NacionalidadID = Convert.ToInt32(dgvPersonas.Rows[e.RowIndex].Cells[9].Value.ToString());
            personaSeleccionada.RolPersonaID = Convert.ToInt32(dgvPersonas.Rows[e.RowIndex].Cells[10].Value.ToString());
            //personaSeleccionada.Sexo = Convert.ToChar(dgvPersonas.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        private void dgvPersonas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count == 1)
            {
                btnMod.Enabled = true;
                btnBorrar.Enabled = true;
            }
            else
            {
                btnMod.Enabled = false;
                btnBorrar.Enabled = false;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LlamarApiBorrar();
        }

        private async void frmPersonas_BUSCAR_Load(object sender, EventArgs e)
        {
            Validacion validacionCrear = new Validacion();
            int perfilID = this.usuario.PerfilID ?? 0;
            await validacionCrear.ConfirmarPermisos(perfilID, 3, 4);
            Validacion validacionVisualizar = new Validacion();
            await validacionVisualizar.ConfirmarPermisos(perfilID, 3, 1);
            Validacion validacionModificar = new Validacion();
            await validacionModificar.ConfirmarPermisos(perfilID, 3, 2);
            Validacion validacionBorrar = new Validacion();
            await validacionBorrar.ConfirmarPermisos(perfilID, 3, 3);

            if (validacionCrear.permiso == false) btnCrear.Visible = false;
            if (validacionVisualizar.permiso == false) btnBuscar.Visible = false;
            if (validacionModificar.permiso == false) btnMod.Visible = false;
            if (validacionBorrar.permiso == false) btnBorrar.Visible = false;
        }

        private async void LlamarApiBorrar()
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = "https://localhost:44329/CORE/persona/borrar"; // replace with your API endpoint
                var requestBody = new
                {
                   PersonaID = personaSeleccionada.PersonaID,
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
