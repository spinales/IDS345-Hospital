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
            panel3.Height = btInicio.Height;
            panel3.Top = btInicio.Top;
            panel3.Left = btInicio.Left;
            btInicio.BackColor = Color.FromArgb(46, 51, 73);

            lbheader.Text = "Inicio";
            this.pfLoader.Controls.Clear();
            fInicio fInicio = new fInicio() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fInicio.FormBorderStyle = FormBorderStyle.None;
            this.pfLoader.Controls.Add(fInicio);
            fInicio.Show();
        }

        private void appCaja_Load(object sender, EventArgs e)
        {

        }

        private void btInicio_Click(object sender, EventArgs e)
        {
            panel3.Height = btInicio.Height;
            panel3.Top = btInicio.Top;
            panel3.Left = btInicio.Left;
            btInicio.BackColor = Color.FromArgb(46, 51, 73);

            lbheader.Text = "Inicio";
            this.pfLoader.Controls.Clear();
            fInicio fInicio = new fInicio() { Dock=DockStyle.Fill,TopLevel=false,TopMost=true};
            fInicio.FormBorderStyle=FormBorderStyle.None;
            this.pfLoader.Controls.Add(fInicio);
            fInicio.Show();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            panel3.Height = btnPacientes.Height;
            panel3.Top = btnPacientes.Top;
            btnPacientes.BackColor = Color.FromArgb(46, 51, 73);

            lbheader.Text = "Pacientes";
            this.pfLoader.Controls.Clear();
            frPacientes fPacientes = new frPacientes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fPacientes.FormBorderStyle = FormBorderStyle.None;
            this.pfLoader.Controls.Add(fPacientes);
            fPacientes.Show();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            panel3.Height = btnPagos.Height;
            panel3.Top = btnPagos.Top;
            btnPagos.BackColor = Color.FromArgb(46, 51, 73);

            lbheader.Text = "Pagos";
            this.pfLoader.Controls.Clear();
            frPagos fPagos = new frPagos() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fPagos.FormBorderStyle = FormBorderStyle.None;
            this.pfLoader.Controls.Add(fPagos);
            fPagos.Show();
        }

        private void btnCuadre_Click(object sender, EventArgs e)
        {
            panel3.Height = btnCuadre.Height;
            panel3.Top = btnCuadre.Top;
            btnCuadre.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btInicio_Leave(object sender, EventArgs e)
        {
            btInicio.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPacientes_Leave(object sender, EventArgs e)
        {
            btnPacientes.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPagos_Leave(object sender, EventArgs e)
        {
            btnPagos.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCuadre_Leave(object sender, EventArgs e)
        {
            btnCuadre.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
