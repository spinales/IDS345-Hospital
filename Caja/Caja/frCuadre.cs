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
    public partial class frCuadre : Form
    {
        public frCuadre()
        {
            InitializeComponent();
            SetEstadoInicial();
        }

        void SetEstadoInicial()
        {
            gbcuadre.Enabled = false;
            TotalInicioDiatxt.Enabled = false;
            DateTime fechaActual = DateTime.Now;

            // Convertir la fecha a una cadena con formato
            string fechaFormateada = fechaActual.ToString("dd/MM/yyyy");

            // Asignar la cadena al TextBox
            FechaActualtxt.Text = fechaFormateada;

        }

        private void Seleccionarbtn_Click(object sender, EventArgs e)
        {
            frMovimientos frMovimientos = new frMovimientos();
            frMovimientos.Show();
        }


        private void Ingresarbtn_Click(object sender, EventArgs e)
        {
            frDetalleEfectivo frDetalleEfectivo = new frDetalleEfectivo(this,  false);
            frDetalleEfectivo.Show();

        }

        private void CuadreEfectivoDetallebtn_Click(object sender, EventArgs e)
        {
            frDetalleEfectivo frDetalleEfectivo = new frDetalleEfectivo(this, true);
            frDetalleEfectivo.Show();

        }
    }
}
