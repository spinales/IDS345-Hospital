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

    public partial class frmPerfiles_BUSCAR : Form
    {
        Perfil perfilSeleccionado = new Perfil();
        public Usuario usuario = new Usuario();
        public frmPerfiles_BUSCAR()
        {
            InitializeComponent();
            cbFiltro.Items.Add("Todos");
            cbFiltro.Items.Add("ID");
            cbFiltro.SelectedIndex = 0;
            btnMod.Enabled = false;
            btnBorrar.Enabled = false;
            LlamarApiGetPerfiles();
        }
        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltro.SelectedIndex == 0)  // Todos
            {
                txtID.Enabled = false;
            }
            else if (cbFiltro.SelectedIndex == 1)  // Filtro por ID
            {
                txtID.Enabled = true;
            }
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            AbrirForms abrirForms = new AbrirForms();
            abrirForms.AbrirFormulario<frmPerfiles_CREAR>(typeof(frmPerfiles_CREAR));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbFiltro.SelectedIndex == 0)
            {
                LlamarApiGetPerfiles();
            }
            else if (cbFiltro.SelectedIndex == 1)
            {
                LlamarApiGetPerfilById(int.Parse(txtID.Text));
            }

        }


        private async void frmPerfiles_BUSCAR_Load(object sender, EventArgs e)
        {
            Validacion validacionCrear = new Validacion();
            int perfilID = this.usuario.PerfilID ?? 0;
            await validacionCrear.ConfirmarPermisos(perfilID, 2, 4);
            Validacion validacionVisualizar = new Validacion();
            await validacionVisualizar.ConfirmarPermisos(perfilID, 2, 1);
            Validacion validacionModificar = new Validacion();
            await validacionModificar.ConfirmarPermisos(perfilID, 2, 2);
            Validacion validacionBorrar = new Validacion();
            await validacionBorrar.ConfirmarPermisos(perfilID, 2, 3);

            if (validacionCrear.permiso == false) btnCrear.Visible = false;
            if (validacionVisualizar.permiso == false) btnBuscar.Visible = false;
            if (validacionModificar.permiso == false) btnMod.Visible = false;
            if (validacionBorrar.permiso == false) btnBorrar.Visible = false;
        }

        private async void LlamarApiGetPerfiles()
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = string.Format("https://localhost:44329/CORE/perfil/get"); // replace with your API endpoint

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                // parse the JSON response into a collection of Usuario objects
                var perfiles = JsonConvert.DeserializeObject<List<Perfil>>(responseContent);
                // create a new DataTable with columns for the data
                var table = new DataTable();
                table.Columns.Add("PerfilID", typeof(int));
                table.Columns.Add("Nombre", typeof(string));
                table.Columns.Add("CreatedAt", typeof(DateTime));
                table.Columns.Add("UpdatedAt", typeof(DateTime));
                table.Columns.Add("DeletedAt", typeof(DateTime));
                table.Columns.Add("SendedAt", typeof(DateTime));

                // populate the DataTable with the data from the collection
                foreach (var perfil in perfiles)
                {

                    table.Rows.Add(perfil.PerfilID, perfil.Nombre, perfil.CreatedAt, perfil.UpdatedAt, perfil.DeletedAt, perfil.SendedAt);
                }

                // bind the DataTable to the DataGridView
                dgvPerfiles.DataSource = table;
            }
        }

        private async void LlamarApiGetPerfilById(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = string.Format("https://localhost:44329/CORE/perfil/getID?id={0}", id); // replace with your API endpoint

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                // parse the JSON response into a collection of Usuario objects
                var perfil = JsonConvert.DeserializeObject<Perfil>(responseContent);
                // create a new DataTable with columns for the data
                var table = new DataTable();
                table.Columns.Add("PerfilID", typeof(int));
                table.Columns.Add("Nombre", typeof(string));
                table.Columns.Add("CreatedAt", typeof(DateTime));
                table.Columns.Add("UpdatedAt", typeof(DateTime));
                table.Columns.Add("DeletedAt", typeof(DateTime));
                table.Columns.Add("SendedAt", typeof(DateTime));

                // populate the DataTable with the data from the collection

                 table.Rows.Add(perfil.PerfilID, perfil.Nombre, perfil.CreatedAt, perfil.UpdatedAt, perfil.DeletedAt, perfil.SendedAt);

                // bind the DataTable to the DataGridView
                dgvPerfiles.DataSource = table;
            }
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            frmPerfil_MOD frmPerfilM = new frmPerfil_MOD(perfilSeleccionado);
            frmPerfilM.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            frmPerfilM.KeyPreview = true;
            frmPerfilM.Location = new System.Drawing.Point(300, 50);
            frmPerfilM.MaximizeBox = false;
            frmPerfilM.MinimizeBox = false;
            frmPerfilM.MinimumSize = new System.Drawing.Size(500, 500);
            frmPerfilM.ShowIcon = false;
            frmPerfilM.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            frmPerfilM.ShowDialog();

        }
    }
}
