using Caja.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            frCuadre.billeteDosMil = Convert.ToInt32(txtBilleteDosMil.Text);
            frCuadre.billeteMil = Convert.ToInt32(txtBilleteMil.Text);
            frCuadre.billeteQuinientos = Convert.ToInt32(txtBilleteQuinientos.Text);
            frCuadre.billeteDoscientos = Convert.ToInt32(txtBilleteDoscientos.Text);
            frCuadre.billeteCien = Convert.ToInt32(txtBilleteCien.Text);
            frCuadre.BilleteCincuenta = Convert.ToInt32(txtBilleteCincuenta.Text);
            frCuadre.monedaVeinticinco = Convert.ToInt32(txtMonedaVeinticinco.Text);
            frCuadre.monedaDiez = Convert.ToInt32(txtMonedaDiez.Text);
            frCuadre.monedaCinco = Convert.ToInt32(txtMonedaCinco.Text);
            frCuadre.monedaUno = Convert.ToInt32(txtMonedaUno.Text);
            // Llamar a la función registrarMontoEfectivo para calcular el total de efectivo
            frCuadre.totalEfectivo = registrarMontoEfectivo(frCuadre.billeteDosMil, frCuadre.billeteMil, frCuadre.billeteQuinientos, frCuadre.billeteDoscientos, frCuadre.billeteCien, frCuadre.BilleteCincuenta, frCuadre.monedaVeinticinco, frCuadre.monedaDiez, frCuadre.monedaCinco, frCuadre.monedaUno);
            txtTotalEfectivo.Text = frCuadre.totalEfectivo.ToString();

            if (cuadre)
            {
                //se ecribe en cuadre
                frCuadre.TotalEfectivoCuadretxt.Text = frCuadre.totalEfectivo.ToString();

            }
            else
            {
                //escribe en inicio
                frCuadre.TotalInicioDiatxt.Text = frCuadre.totalEfectivo.ToString();

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

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            var transaccion = ds.Database.BeginTransaction();
            try
            {
                var ID = new SqlParameter("@IdIngreso", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                ds.Database.ExecuteSqlCommand(
                    "EXEC sp_insert_InicioDia @Balance, @CajeroID, @IdIngreso out",
                    new SqlParameter("@Balance", frCuadre.totalEfectivo),
                    new SqlParameter("@CajeroID", frCuadre.PersonaID), ID
                    );
                ds.Database.ExecuteSqlCommand(
                    "EXEC sp_Detalle_Efectivo @DosmilPesos, @MilPesos, @QuinientosPesos, @DocientosPesos, @cienPesos, @CincuentaPesos, @VeinticincoPesos, @DiezPesos, @CincoPesos, @UnPeso, @TotalEfectivo, @InicioDiaID, @CuadreID",
                    new SqlParameter("@DosmilPesos", frCuadre.billeteDosMil),
                    new SqlParameter("@MilPesos", frCuadre.billeteMil),
                    new SqlParameter("@QuinientosPesos", frCuadre.billeteQuinientos),
                    new SqlParameter("@DocientosPesos", frCuadre.billeteDoscientos),
                    new SqlParameter("@cienPesos", frCuadre.billeteCien),
                    new SqlParameter("@CincuentaPesos", frCuadre.BilleteCincuenta),
                    new SqlParameter("@VeinticincoPesos", frCuadre.monedaVeinticinco),
                    new SqlParameter("@DiezPesos", frCuadre.monedaDiez),
                    new SqlParameter("@CincoPesos", frCuadre.billeteMil),
                    new SqlParameter("@UnPeso", frCuadre.monedaUno),
                    new SqlParameter("@TotalEfectivo", frCuadre.totalEfectivo),
                    new SqlParameter("@InicioDiaID", (int)ID.Value),
                    new SqlParameter("@CuadreID", DBNull.Value)




                    ) ;
                transaccion.Commit();


            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
                transaccion.Rollback();
            }
        }
    }
}