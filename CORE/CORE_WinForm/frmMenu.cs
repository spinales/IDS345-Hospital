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
            frmUsuarios_CREAR frmUsuariosC = FindCreateUserForm();

            if (frmUsuariosC != null)
            {
                frmUsuariosC.Activate();
                frmUsuariosC.BringToFront();
            }
            else
            {
                frmUsuariosC = new frmUsuarios_CREAR();
                frmUsuariosC.MdiParent = this;
                frmUsuariosC.Dock = DockStyle.Fill;
                int anchoRestante = this.ClientSize.Width - menuStrip1.Width;
                frmUsuariosC.Width = anchoRestante;
                frmUsuariosC.Show();
            } 
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private frmUsuarios_CREAR FindCreateUserForm()
        {
            foreach (frmUsuarios_CREAR frmHijo in this.MdiChildren)
            {
                if (frmHijo.GetType() == typeof(frmUsuarios_CREAR))
                {
                    return frmHijo;
                }
            }
            return null;
        }
    }
}
