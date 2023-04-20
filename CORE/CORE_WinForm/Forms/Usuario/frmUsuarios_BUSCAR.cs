using Modelos;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CORE_WinForm
{
    public partial class frmUsuarios_BUSCAR : Form
    {
        Usuario usuarioSeleccionado = new Usuario();
        public frmUsuarios_BUSCAR()
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
            if (cbFiltro.SelectedIndex == 0)  // Todos
            {
                txtID.Enabled = false;
            }
            else if (cbFiltro.SelectedIndex == 1)  // Filtro por ID
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
            frmUsuarios_CREAR frmUsuariosC = AbrirFormulario<frmUsuarios_CREAR>(typeof(frmUsuarios_CREAR));
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
                var apiUrl = "https://localhost:44329/CORE/usuario/get"; // replace with your API endpoint

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                // parse the JSON response into a collection of Usuario objects
                var usuarios = JsonConvert.DeserializeObject<List<Usuario>>(responseContent);

                // create a new DataTable with columns for the data
                var table = new DataTable();
                table.Columns.Add("UsuarioID", typeof(int));
                table.Columns.Add("Username", typeof(string));
                table.Columns.Add("Email", typeof(string));
                table.Columns.Add("Estado", typeof(int));
                table.Columns.Add("SucursalID", typeof(int));
                table.Columns.Add("PerfilID", typeof(int));
                table.Columns.Add("CreatedAt", typeof(DateTime));
                table.Columns.Add("UpdatedAt", typeof(DateTime));
                table.Columns.Add("DeletedAt", typeof(DateTime));
                table.Columns.Add("SendedAt", typeof(DateTime));

                // populate the DataTable with the data from the collection
                foreach (var usuario in usuarios)
                {
                    table.Rows.Add(usuario.UsuarioID, usuario.Username, usuario.Email, usuario.Estado,
                        usuario.SucursalID, usuario.PerfilID, usuario.CreatedAt, usuario.UpdatedAt, usuario.DeletedAt,
                        usuario.SendedAt);
                }

                // bind the DataTable to the DataGridView
                dgvUsuarios.DataSource = table;

            }
        }

        private async void LlamarApiGetById(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = string.Format("https://localhost:44329/CORE/usuario/getID?id={0}", id); // replace with your API endpoint

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                // parse the JSON response into a collection of Usuario objects
                var usuarios = JsonConvert.DeserializeObject<Usuario>(responseContent);

                // create a new DataTable with columns for the data
                var table = new DataTable();
                table.Columns.Add("UsuarioID", typeof(int));
                table.Columns.Add("Username", typeof(string));
                table.Columns.Add("Email", typeof(string));
                table.Columns.Add("Estado", typeof(int));
                table.Columns.Add("SucursalID", typeof(int));
                table.Columns.Add("PerfilID", typeof(int));
                table.Columns.Add("CreatedAt", typeof(DateTime));
                table.Columns.Add("UpdatedAt", typeof(DateTime));
                table.Columns.Add("DeletedAt", typeof(DateTime));
                table.Columns.Add("SendedAt", typeof(DateTime));

                // populate the DataTable with the data from the collection
               
                table.Rows.Add(usuarios.UsuarioID, usuarios.Username, usuarios.Email, usuarios.Estado,
                        usuarios.SucursalID, usuarios.PerfilID, usuarios.CreatedAt, usuarios.UpdatedAt, usuarios.DeletedAt,
                        usuarios.SendedAt);

                // bind the DataTable to the DataGridView
                dgvUsuarios.DataSource = table;
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            frmUsuarios_MOD frmUsuariosM = new frmUsuarios_MOD(usuarioSeleccionado);
            frmUsuariosM.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            frmUsuariosM.KeyPreview = true;
            frmUsuariosM.Location = new System.Drawing.Point(300, 50);
            frmUsuariosM.MaximizeBox = false;
            frmUsuariosM.MinimizeBox = false;
            frmUsuariosM.MinimumSize = new System.Drawing.Size(500, 500);
            frmUsuariosM.ShowIcon = false;
            frmUsuariosM.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            frmUsuariosM.ShowDialog();

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            usuarioSeleccionado.UsuarioID = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
            usuarioSeleccionado.Username = dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            usuarioSeleccionado.Email = dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            usuarioSeleccionado.SucursalID = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString());
            usuarioSeleccionado.PerfilID = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString());
        
        }


        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 1)
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
    }
}
