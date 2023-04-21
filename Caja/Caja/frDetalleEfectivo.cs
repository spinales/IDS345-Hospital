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
    public partial class frDetalleEfectivo : Form
    {
        public frDetalleEfectivo(frCuadre form, bool cuadre)
        {
            InitializeComponent();
            this.frCuadre = form;
            this.cuadre = cuadre;
        }

        frCuadre frCuadre;
        bool cuadre;

        private void Calcularbtn_Click(object sender, EventArgs e)
        {
            int billeteDosMil = Convert.ToInt32(txtBilleteDosMil.Text);
            int billeteMil = Convert.ToInt32(txtBilleteMil.Text);
            int billeteQuinientos = Convert.ToInt32(txtBilleteQuinientos.Text);
            int billeteDoscientos = Convert.ToInt32(txtBilleteDoscientos.Text);
            int billeteCien = Convert.ToInt32(txtBilleteCien.Text);
            int BilleteCincuenta = Convert.ToInt32(txtBilleteCincuenta.Text);
            int monedaVeinticinco = Convert.ToInt32(txtMonedaVeinticinco.Text);
            int monedaDiez = Convert.ToInt32(txtMonedaDiez.Text);
            int monedaCinco = Convert.ToInt32(txtMonedaCinco.Text);
            int monedaUno = Convert.ToInt32(txtMonedaUno.Text);
            // Llamar a la función registrarMontoEfectivo para calcular el total de efectivo
            int totalEfectivo = registrarMontoEfectivo(billeteDosMil, billeteMil, billeteQuinientos, billeteDoscientos, billeteCien, BilleteCincuenta, monedaVeinticinco, monedaDiez, monedaCinco, monedaUno);
            txtTotalEfectivo.Text = totalEfectivo.ToString();

            if (cuadre)
            {
                //pon k se ecriba en cuadre
                frCuadre.TotalEfectivoCuadretxt.Text = totalEfectivo.ToString();

            }
            else
            {
                //ekribe en inicio
                frCuadre.TotalInicioDiatxt.Text = totalEfectivo.ToString();

            }

            // Asignar el valor devuelto al campo Text del TextBox de total efectivo
            frCuadre.gbcuadre.Enabled = true;
            frCuadre.TotalInicioDiatxt.Enabled = false;

        }

        private int registrarMontoEfectivo(int billeteDosMil, int billeteMil, int billeteQuinientos, int billeteDoscientos, int billeteCien, int BilleteCincuenta, int monedaVeinticinco, int monedaDiez, int monedaCinco, int monedaUno)
        {
            // Obtener las cantidades ingresadas en los TextBox de billetes y monedas


            // Calcular el monto total
            int totalefectivo = (billeteDosMil * 2000) + (billeteMil * 1000) + (billeteQuinientos * 500) +
                             (billeteDoscientos * 200) + (billeteCien * 100) + (BilleteCincuenta * 50) +
                             (monedaVeinticinco * 25) + (monedaDiez * 10) +
                             (monedaCinco * 5) + (monedaUno * 1);

            return totalefectivo;

        }
    }
}