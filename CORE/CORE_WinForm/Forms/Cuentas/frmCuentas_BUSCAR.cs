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

namespace CORE_WinForm.Forms.Cuentas
{
    public partial class frmCuentas_BUSCAR : Form
    {
        public Usuario usuario = new Usuario();
        Cuenta cuentaSeleccionada = new Cuenta();
        public frmCuentas_BUSCAR()
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
            abrirForms.AbrirFormulario<frmCuentas_CREAR>(typeof(frmCuentas_CREAR));
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            // 
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LlamarApiBorrar();
        }
        private void dgvCuentas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cuentaSeleccionada.CuentaID = Convert.ToInt32(dgvCuentas.Rows[e.RowIndex].Cells[0].Value.ToString());
            cuentaSeleccionada.Balance = Convert.ToDecimal(dgvCuentas.Rows[e.RowIndex].Cells[1].Value.ToString());
            cuentaSeleccionada.PacienteID = Convert.ToInt32(dgvCuentas.Rows[e.RowIndex].Cells[2].Value.ToString());
            cuentaSeleccionada.CreatedAt = Convert.ToDateTime(dgvCuentas.Rows[e.RowIndex].Cells[3].Value.ToString());
            cuentaSeleccionada.UpdatedAt = Convert.ToDateTime(dgvCuentas.Rows[e.RowIndex].Cells[4].Value.ToString());
            cuentaSeleccionada.DeletedAt = Convert.ToDateTime(dgvCuentas.Rows[e.RowIndex].Cells[5].Value.ToString());
            cuentaSeleccionada.SendedAt = Convert.ToDateTime(dgvCuentas.Rows[e.RowIndex].Cells[6].Value.ToString());
        }
        private void dgvCuentas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count == 1)
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
        private async void frmCuentas_BUSCAR_Load(object sender, EventArgs e)
        {
            Validacion validacionCrear = new Validacion();
            int perfilID = this.usuario.PerfilID ?? 0;
            await validacionCrear.ConfirmarPermisos(perfilID, 7, 4);
            Validacion validacionVisualizar = new Validacion();
            await validacionVisualizar.ConfirmarPermisos(perfilID, 7, 1);
            Validacion validacionModificar = new Validacion();
            await validacionModificar.ConfirmarPermisos(perfilID, 7, 2);
            Validacion validacionBorrar = new Validacion();
            await validacionBorrar.ConfirmarPermisos(perfilID, 7, 3);

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
                var apiUrl = "https://localhost:44329/CORE/cuenta/get";

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                var cuentas = JsonConvert.DeserializeObject<List<Cuenta>>(responseContent);

                var table = new DataTable();
                table.Columns.Add("CuentaID", typeof(int));
                table.Columns.Add("Balance", typeof(decimal));
                table.Columns.Add("PacienteID", typeof(int));
                table.Columns.Add("CreatedAt", typeof(DateTime));
                table.Columns.Add("UpdatedAt", typeof(DateTime));
                table.Columns.Add("DeletedAt", typeof(DateTime));
                table.Columns.Add("SendedAt", typeof(DateTime));

                foreach (var cuenta in cuentas)
                {
                    table.Rows.Add(cuenta.CuentaID, cuenta.Balance, cuenta.PacienteID, cuenta.CreatedAt, cuenta.UpdatedAt, cuenta.DeletedAt, cuenta.SendedAt);
                }

                dgvCuentas.DataSource = table;
            }
        }
        private async void LlamarApiGetById(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = string.Format("https://localhost:44329/CORE/cuenta/get?id={0}", id);

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                var cuenta = JsonConvert.DeserializeObject<Cuenta>(responseContent);

                var table = new DataTable();
                table.Columns.Add("CuentaID", typeof(int));
                table.Columns.Add("Balance", typeof(decimal));
                table.Columns.Add("PacienteID", typeof(int));
                table.Columns.Add("CreatedAt", typeof(DateTime));
                table.Columns.Add("UpdatedAt", typeof(DateTime));
                table.Columns.Add("DeletedAt", typeof(DateTime));
                table.Columns.Add("SendedAt", typeof(DateTime));

                table.Rows.Add(cuenta.CuentaID, cuenta.Balance, cuenta.PacienteID, cuenta.CreatedAt, cuenta.UpdatedAt, cuenta.DeletedAt, cuenta.SendedAt);

                dgvCuentas.DataSource = table;
            }
        }
        private async void LlamarApiBorrar()
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = "https://localhost:44329/CORE/cuenta/borrar";
                var requestBody = new
                {
                    CuentaID = cuentaSeleccionada.CuentaID,
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
