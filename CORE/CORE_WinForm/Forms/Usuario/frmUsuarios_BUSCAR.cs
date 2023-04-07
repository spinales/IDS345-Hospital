using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CORE_WinForm
{
    public partial class frmUsuarios_BUSCAR : Form
    {
        public frmUsuarios_BUSCAR()
        {
            InitializeComponent();
            cbFiltro.Items.Add("Todos");
            cbFiltro.Items.Add("ID");
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
    }
}
