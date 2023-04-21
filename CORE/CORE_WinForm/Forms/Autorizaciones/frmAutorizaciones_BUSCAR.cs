using CORE_WinForm.Forms.Ingresos;
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

namespace CORE_WinForm.Forms.Autorizaciones
{
    public partial class frmAutorizaciones_BUSCAR : Form
    {
        Modelos.Autorizaciones autorizacionSeleccionado = new Modelos.Autorizaciones();
        public Usuario usuario = new Usuario();
        public frmAutorizaciones_BUSCAR()
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
            AbrirForms abrirForms = new AbrirForms();
            abrirForms.AbrirFormulario<frmAutorizaciones_CREAR>(typeof(frmAutorizaciones_CREAR));
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            //frmAutorizaciones_MOD frmAutorizacionM = new frmAutorizaciones_MOD(autorizacionSeleccionado);
            //frmAutorizacionM.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            //frmAutorizacionM.KeyPreview = true;
            //frmAutorizacionM.Location = new System.Drawing.Point(300, 50);
            //frmAutorizacionM.MaximizeBox = false;
            //frmAutorizacionM.MinimizeBox = false;
            //frmAutorizacionM.MinimumSize = new System.Drawing.Size(500, 500);
            //frmAutorizacionM.ShowIcon = false;
            //frmAutorizacionM.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //frmAutorizacionM.ShowDialog();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LlamarApiBorrar();
        }

        private void dgvAutorizacion_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            autorizacionSeleccionado.AutorizacionID = Convert.ToInt32(dgvAutorizacion.Rows[e.RowIndex].Cells[0].Value.ToString());
            autorizacionSeleccionado.MontoAutorizado = Convert.ToDecimal(dgvAutorizacion.Rows[e.RowIndex].Cells[1].Value.ToString());
            autorizacionSeleccionado.AseguradoraID = Convert.ToInt32(dgvAutorizacion.Rows[e.RowIndex].Cells[2].Value.ToString());
            autorizacionSeleccionado.CreatedAt = Convert.ToDateTime(dgvAutorizacion.Rows[e.RowIndex].Cells[3].Value.ToString());
            autorizacionSeleccionado.UpdatedAt = Convert.ToDateTime(dgvAutorizacion.Rows[e.RowIndex].Cells[4].Value.ToString());
            autorizacionSeleccionado.DeletedAt = Convert.ToDateTime(dgvAutorizacion.Rows[e.RowIndex].Cells[5].Value.ToString());
            autorizacionSeleccionado.SendedAt = Convert.ToDateTime(dgvAutorizacion.Rows[e.RowIndex].Cells[6].Value.ToString());
        }
        private void dgvAutorizacion_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAutorizacion.SelectedRows.Count == 1)
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

        private async void frmAutorizaciones_BUSCAR_Load(object sender, EventArgs e)
        {
            Validacion validacionCrear = new Validacion();
            int perfilID = this.usuario.PerfilID ?? 0;
            await validacionCrear.ConfirmarPermisos(perfilID, 4, 4);
            Validacion validacionVisualizar = new Validacion();
            await validacionVisualizar.ConfirmarPermisos(perfilID, 4, 1);
            Validacion validacionModificar = new Validacion();
            await validacionModificar.ConfirmarPermisos(perfilID, 4, 2);
            Validacion validacionBorrar = new Validacion();
            await validacionBorrar.ConfirmarPermisos(perfilID, 4, 3);

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
                var apiUrl = "https://localhost:44329/CORE/autorizacion/get";

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                var autorizaciones = JsonConvert.DeserializeObject<List<Modelos.Autorizaciones>>(responseContent);

                var table = new DataTable();
                table.Columns.Add("AutorizacionID", typeof(int));
                table.Columns.Add("MontoAutorizado", typeof(decimal));
                table.Columns.Add("AseguradoraID", typeof(int));
                table.Columns.Add("CreatedAt", typeof(DateTime));
                table.Columns.Add("UpdatedAt", typeof(DateTime));
                table.Columns.Add("DeletedAt", typeof(DateTime));
                table.Columns.Add("SendedAt", typeof(DateTime));

                foreach (var autorizacion in autorizaciones)
                {
                    table.Rows.Add(autorizacion.AutorizacionID, autorizacion.MontoAutorizado, autorizacion.Aseguradora, autorizacion.CreatedAt, autorizacion.UpdatedAt, autorizacion.DeletedAt, autorizacion.SendedAt);
                }

                dgvAutorizacion.DataSource = table;
            }
        }
        private async void LlamarApiGetById(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = string.Format("https://localhost:44329/CORE/autorizacion/get?id={0}", id);

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                var autorizacion = JsonConvert.DeserializeObject<Modelos.Autorizaciones>(responseContent);

                var table = new DataTable();
                table.Columns.Add("AutorizacionID", typeof(int));
                table.Columns.Add("MontoAutorizado", typeof(decimal));
                table.Columns.Add("AseguradoraID", typeof(int));
                table.Columns.Add("CreatedAt", typeof(DateTime));
                table.Columns.Add("UpdatedAt", typeof(DateTime));
                table.Columns.Add("DeletedAt", typeof(DateTime));
                table.Columns.Add("SendedAt", typeof(DateTime));

                table.Rows.Add(autorizacion.AutorizacionID, autorizacion.MontoAutorizado, autorizacion.Aseguradora, autorizacion.CreatedAt, autorizacion.UpdatedAt, autorizacion.DeletedAt, autorizacion.SendedAt);

                dgvAutorizacion.DataSource = table;
            }
        }
        private async void LlamarApiBorrar()
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = "https://localhost:44329/CORE/autorizacion/borrar";
                var requestBody = new
                {
                    AutorizacionID = autorizacionSeleccionado.AutorizacionID,
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
