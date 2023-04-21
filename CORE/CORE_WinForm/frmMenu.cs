using CORE_WinForm.Forms.Autorizaciones;
using CORE_WinForm.Forms.Cuentas;
using CORE_WinForm.Forms.Ingresos;
using CORE_WinForm.Forms.Perfiles;
using CORE_WinForm.Forms.Personas;
using CORE_WinForm.Forms.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CORE_WinForm
{
    public partial class frmMenu : Form
    {
        
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                formAbrir.MdiParent = this;
                formAbrir.Dock = DockStyle.Fill; 
                int anchoRestante = this.ClientSize.Width - menuStrip1.Width;
                formAbrir.Width = anchoRestante;
                formAbrir.Show();
                return formAbrir;
            }
        }
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios_BUSCAR frmUsuariosB = AbrirFormulario<frmUsuarios_BUSCAR>(typeof(frmUsuarios_BUSCAR));
        }
        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerfiles_BUSCAR frmPerfilB = AbrirFormulario<frmPerfiles_BUSCAR>(typeof(frmPerfiles_BUSCAR));
        }
        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonas_BUSCAR frmPersonB = AbrirFormulario<frmPersonas_BUSCAR>(typeof(frmPersonas_BUSCAR));
        }
        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuentas_BUSCAR frmCuentaB = AbrirFormulario<frmCuentas_BUSCAR>(typeof(frmCuentas_BUSCAR));
        }
        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresos_BUSCAR frmIngresoB = AbrirFormulario<frmIngresos_BUSCAR>(typeof(frmIngresos_BUSCAR));
        }

        private void autorizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutorizaciones_BUSCAR frmAutorizB = AbrirFormulario<frmAutorizaciones_BUSCAR>(typeof(frmAutorizaciones_BUSCAR));
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicios_BUSCAR frmServicioB = AbrirFormulario<frmServicios_BUSCAR>(typeof(frmServicios_BUSCAR));
        }
    }
}
