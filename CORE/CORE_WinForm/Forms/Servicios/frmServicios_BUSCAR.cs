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

namespace CORE_WinForm.Forms.Servicios
{
 
    public partial class frmServicios_BUSCAR : Form
    {
        public Usuario usuario = new Usuario();
        Modelos.Servicios servicioSeleccionado = new Modelos.Servicios();
        public frmServicios_BUSCAR()
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
            AbrirForms abrirForms = new AbrirForms();
            frmServicios_CREAR frmServiciosC = abrirForms.AbrirFormulario<frmServicios_CREAR>(typeof(frmServicios_CREAR));
        }

        private void btnMod_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LlamarApiBorrar();
        }
        private void dgvServicios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            servicioSeleccionado.ServicioID = Convert.ToInt32(dgvServicios.Rows[e.RowIndex].Cells[0].Value.ToString());
            servicioSeleccionado.TipoServicioID = Convert.ToInt32(dgvServicios.Rows[e.RowIndex].Cells[1].Value.ToString());
            servicioSeleccionado.Descripcion = dgvServicios.Rows[e.RowIndex].Cells[2].Value.ToString();
            servicioSeleccionado.Precio = Convert.ToDecimal(dgvServicios.Rows[e.RowIndex].Cells[3].Value.ToString());
            servicioSeleccionado.Impuesto = Convert.ToDecimal(dgvServicios.Rows[e.RowIndex].Cells[4].Value.ToString());
            servicioSeleccionado.Descuento = Convert.ToDecimal(dgvServicios.Rows[e.RowIndex].Cells[5].Value.ToString());
        }

        private void dgvServicios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvServicios.SelectedRows.Count == 1)
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

        private async void frmServicios_BUSCAR_Load(object sender, EventArgs e)
        {
            Validacion validacionCrear = new Validacion();
            int perfilID = this.usuario.PerfilID ?? 0;
            await validacionCrear.ConfirmarPermisos(perfilID, 5, 4);
            Validacion validacionVisualizar = new Validacion();
            await validacionVisualizar.ConfirmarPermisos(perfilID, 5, 1);
            Validacion validacionModificar = new Validacion();
            await validacionModificar.ConfirmarPermisos(perfilID, 5, 2);
            Validacion validacionBorrar = new Validacion();
            await validacionBorrar.ConfirmarPermisos(perfilID, 5, 3);

            if (validacionCrear.permiso == false) btnCrear.Visible = false;
            if (validacionVisualizar.permiso == false) btnBuscar.Visible = false;
            if (validacionModificar.permiso == false) btnMod.Visible = false;
            if (validacionBorrar.permiso == false) btnBorrar.Visible = false;
        }
        
        // APIs
        private async void LlamarApiGet()
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = "https://localhost:44329/CORE/servicio/get";

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                var servicios = JsonConvert.DeserializeObject<List<Modelos.Servicios>>(responseContent);

                var table = new DataTable();
                table.Columns.Add("ServicioID", typeof(int));
                table.Columns.Add("TipoServicioID", typeof(int));
                table.Columns.Add("Descripcion", typeof(string));
                table.Columns.Add("Precio", typeof(decimal));
                table.Columns.Add("Impuesto", typeof(decimal));
                table.Columns.Add("Descuento", typeof(decimal));
                table.Columns.Add("CreatedAt", typeof(DateTime));
                table.Columns.Add("UpdatedAt", typeof(DateTime));
                table.Columns.Add("DeletedAt", typeof(DateTime));
                table.Columns.Add("SendedAt", typeof(DateTime));

                foreach (var servicio in servicios)
                {
                    table.Rows.Add(servicio.ServicioID, servicio.TipoServicioID, servicio.Descripcion, servicio.Precio, servicio.Impuesto, servicio.Descuento, servicio.CreatedAt, servicio.UpdatedAt, servicio.DeletedAt, servicio.SendedAt);
                }

                dgvServicios.DataSource = table;
            }
        }
        private async void LlamarApiGetById(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = string.Format("https://localhost:44329/CORE/servicio/getID?id={0}", id);

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                var servicio = JsonConvert.DeserializeObject<Modelos.Servicios>(responseContent);

                var table = new DataTable();
                table.Columns.Add("ServicioID", typeof(int));
                table.Columns.Add("TipoServicioID", typeof(int));
                table.Columns.Add("Descripcion", typeof(string));
                table.Columns.Add("Precio", typeof(decimal));
                table.Columns.Add("Impuesto", typeof(decimal));
                table.Columns.Add("Descuento", typeof(decimal));
                table.Columns.Add("CreatedAt", typeof(DateTime));
                table.Columns.Add("UpdatedAt", typeof(DateTime));
                table.Columns.Add("DeletedAt", typeof(DateTime));
                table.Columns.Add("SendedAt", typeof(DateTime));

                table.Rows.Add(servicio.ServicioID, servicio.TipoServicioID, servicio.Descripcion, servicio.Precio, servicio.Impuesto, servicio.Descuento, servicio.CreatedAt, servicio.UpdatedAt, servicio.DeletedAt, servicio.SendedAt);

                dgvServicios.DataSource = table;
            }
        }
        private async void LlamarApiBorrar()
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = "https://localhost:44329/CORE/servicio/borrar";
                var requestBody = new
                {
                    ServicioID = servicioSeleccionado.ServicioID,
                };

                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(apiUrl, content);
                var responseContent = await response.Content.ReadAsStringAsync();

                MessageBox.Show(responseContent);
            }
        }
    }
}
