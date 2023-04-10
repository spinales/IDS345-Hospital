using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja
{
    public partial class frCuentaAbono : Form
    {
        public frCuentaAbono()
        {
            InitializeComponent();
        }

        private void frCuentaAbono_Load(object sender, EventArgs e)
        {

        }

        private void abonarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
