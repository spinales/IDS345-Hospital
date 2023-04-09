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

        private void crearToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmPacientes_CREAR frmPacientes = new frmPacientes_CREAR();
            frmPacientes.MdiParent = this;
            frmPacientes.Show();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios_CREAR frmUsuariosC = AbrirFormulario<frmUsuarios_CREAR>(typeof(frmUsuarios_CREAR));
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios_BUSCAR frmUsuariosB = AbrirFormulario<frmUsuarios_BUSCAR>(typeof(frmUsuarios_BUSCAR));

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

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
