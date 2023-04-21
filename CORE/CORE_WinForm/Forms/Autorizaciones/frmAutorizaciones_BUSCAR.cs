using Modelos;
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
                //LlamarApiGetById(int.Parse(txtID.Text));
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmAutorizaciones_CREAR frmAutorizaciones = AbrirFormulario<frmAutorizaciones_CREAR>(typeof(frmAutorizaciones_CREAR));
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
            using(var httpClient = new HttpClient())
            {
                var apiUrl = "https://localhost:44329/CORE/...";
            }
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

        private void dgvAutorizacion_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            autorizacionSeleccionado.MontoAutorizado = Convert.ToDecimal(dgvAutorizacion.Rows[e.RowIndex].Cells[0].Value.ToString());
            autorizacionSeleccionado.AseguradoraID = Convert.ToInt32(dgvAutorizacion.Rows[e.RowIndex].Cells[1].Value.ToString());
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
    }
}
