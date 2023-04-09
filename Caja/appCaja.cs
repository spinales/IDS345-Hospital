using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Caja
{
    public partial class appCaja : Form
    {
        public appCaja()
        {
            InitializeComponent();        

            this.pfLoader.Controls.Clear();
            fInicio fInicio = new fInicio() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
           // fInicio.FormBorderStyle = FormBorderStyle.None;
            this.pfLoader.Controls.Add(fInicio);
            fInicio.Show();
        
        }
        
        private void appCaja_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.pfLoader.Controls.Clear();
            fInicio fInicio = new fInicio() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
           // fInicio.FormBorderStyle = FormBorderStyle.None;
            this.pfLoader.Controls.Add(fInicio);
            fInicio.Show();
        }

        private void btnPerfil_Leave(object sender, EventArgs e)
        {
            btnPerfil.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCuadre_Click(object sender, EventArgs e)
        {

        }

        private void btnCuadre_Leave(object sender, EventArgs e)
        {
            btnCuadre.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {

        }

        private void btnCuenta_Leave(object sender, EventArgs e)
        {
            btnCuenta.BackColor = Color.FromArgb(24, 30, 54);
        }


        private void btnFacturacion_Leave(object sender, EventArgs e)
        {
            btnFacturacion.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            this.pfLoader.Controls.Clear();
            frmFacturacion facturacion = new frmFacturacion() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
           // facturacion.FormBorderStyle = FormBorderStyle.None;
            this.pfLoader.Controls.Add(facturacion);
            facturacion.Show();
        }
    }
}
