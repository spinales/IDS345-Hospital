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

namespace CORE_WinForm.Forms.Ingresos
{
    public partial class frmIngresos_BUSCAR : Form
    {
        public  Usuario usuario = new Usuario();
        Ingreso ingresoSeleccionado = new Ingreso();
        public frmIngresos_BUSCAR()
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
            abrirForms.AbrirFormulario<frmIngresos_CREAR>(typeof(frmIngresos_CREAR));
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            // 
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LlamarApiBorrar();
        }
        private void dgvIngresos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ingresoSeleccionado.IngresoID = Convert.ToInt32(dgvIngresos.Rows[e.RowIndex].Cells[0].Value.ToString());
            ingresoSeleccionado.FechaInicio = Convert.ToDateTime(dgvIngresos.Rows[e.RowIndex].Cells[1].Value.ToString());
            ingresoSeleccionado.FechaFin = Convert.ToDateTime(dgvIngresos.Rows[e.RowIndex].Cells[2].Value.ToString());
            ingresoSeleccionado.Alta = Convert.ToBoolean(dgvIngresos.Rows[e.RowIndex].Cells[3].Value.ToString());
            ingresoSeleccionado.MontoIngreso = Convert.ToDecimal(dgvIngresos.Rows[e.RowIndex].Cells[4].Value.ToString());
            ingresoSeleccionado.CuentaID = Convert.ToInt32(dgvIngresos.Rows[e.RowIndex].Cells[5].Value.ToString());
            ingresoSeleccionado.PacienteID = Convert.ToInt32(dgvIngresos.Rows[e.RowIndex].Cells[6].Value.ToString());
            ingresoSeleccionado.HabitacionID = Convert.ToInt32(dgvIngresos.Rows[e.RowIndex].Cells[7].Value.ToString());
            ingresoSeleccionado.CreatedAt = Convert.ToDateTime(dgvIngresos.Rows[e.RowIndex].Cells[8].Value.ToString());
            ingresoSeleccionado.UpdatedAt = Convert.ToDateTime(dgvIngresos.Rows[e.RowIndex].Cells[9].Value.ToString());
            ingresoSeleccionado.DeletedAt = Convert.ToDateTime(dgvIngresos.Rows[e.RowIndex].Cells[10].Value.ToString());
            ingresoSeleccionado.SendedAt = Convert.ToDateTime(dgvIngresos.Rows[e.RowIndex].Cells[11].Value.ToString());
        }

        private void dgvIngresos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvIngresos.SelectedRows.Count == 1)
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
        private async void frmIngresos_BUSCAR_Load(object sender, EventArgs e)
        {
            Validacion validacionCrear = new Validacion();
            int perfilID = this.usuario.PerfilID ?? 0;
            await validacionCrear.ConfirmarPermisos(perfilID, 6, 4);
            Validacion validacionVisualizar = new Validacion();
            await validacionVisualizar.ConfirmarPermisos(perfilID, 6, 1);
            Validacion validacionModificar = new Validacion();
            await validacionModificar.ConfirmarPermisos(perfilID, 6, 2);
            Validacion validacionBorrar = new Validacion();
            await validacionBorrar.ConfirmarPermisos(perfilID, 6, 3);

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
                var apiUrl = "https://localhost:44329/CORE/ingreso/get";

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                var ingresos = JsonConvert.DeserializeObject<List<Ingreso>>(responseContent);

                var table = new DataTable();
                table.Columns.Add("IngresoID", typeof(int));
                table.Columns.Add("FechaInicio", typeof(DateTime));
                table.Columns.Add("FechaFin", typeof(DateTime));
                table.Columns.Add("Alta", typeof(bool));
                table.Columns.Add("MontoIngreso", typeof(decimal));
                table.Columns.Add("CuentaID", typeof(int));
                table.Columns.Add("PacienteID", typeof(int));
                table.Columns.Add("HabitacionID", typeof(int));
                table.Columns.Add("CreatedAt", typeof(DateTime));
                table.Columns.Add("UpdatedAt", typeof(DateTime));
                table.Columns.Add("DeletedAt", typeof(DateTime));
                table.Columns.Add("SendedAt", typeof(DateTime));

                foreach (var ingreso in ingresos)
                {
                    table.Rows.Add(ingreso.IngresoID, ingreso.FechaInicio, ingreso.FechaFin, ingreso.Alta, ingreso.MontoIngreso, ingreso.CuentaID, ingreso.PacienteID, ingreso.HabitacionID, ingreso.CreatedAt, ingreso.UpdatedAt, ingreso.DeletedAt, ingreso.SendedAt);
                }

                dgvIngresos.DataSource = table;
            }
        }
        private async void LlamarApiGetById(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = string.Format("https://localhost:44329/CORE/ingreso/get?id={0}", id);

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                var ingreso = JsonConvert.DeserializeObject<Ingreso>(responseContent);

                var table = new DataTable();
                table.Columns.Add("IngresoID", typeof(int));
                table.Columns.Add("FechaInicio", typeof(DateTime));
                table.Columns.Add("FechaFin", typeof(DateTime));
                table.Columns.Add("Alta", typeof(bool));
                table.Columns.Add("MontoIngreso", typeof(decimal));
                table.Columns.Add("CuentaID", typeof(int));
                table.Columns.Add("PacienteID", typeof(int));
                table.Columns.Add("HabitacionID", typeof(int));
                table.Columns.Add("CreatedAt", typeof(DateTime));
                table.Columns.Add("UpdatedAt", typeof(DateTime));
                table.Columns.Add("DeletedAt", typeof(DateTime));
                table.Columns.Add("SendedAt", typeof(DateTime));

                table.Rows.Add(ingreso.IngresoID, ingreso.FechaInicio, ingreso.FechaFin, ingreso.Alta, ingreso.MontoIngreso, ingreso.CuentaID, ingreso.PacienteID, ingreso.HabitacionID, ingreso.CreatedAt, ingreso.UpdatedAt, ingreso.DeletedAt, ingreso.SendedAt);

                dgvIngresos.DataSource = table;
            }
        }
        private async void LlamarApiBorrar()
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = "https://localhost:44329/CORE/ingreso/borrar";
                var requestBody = new
                {
                    IngresoID = ingresoSeleccionado.IngresoID,
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
