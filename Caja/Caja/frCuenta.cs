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
    public partial class frCuenta : Form
    {
        public frCuenta()
        {
            InitializeComponent();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abonarcuentabtn_Click(object sender, EventArgs e)
        {
            frCuentaAbono frCuentaAbono = new frCuentaAbono();
            frCuentaAbono.Show();
        }
    }
}
