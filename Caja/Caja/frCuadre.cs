using Caja.Services;
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
        public int billeteDosMil = 0;
        public int billeteMil = 0;
        public int billeteQuinientos = 0;
        public int billeteDoscientos = 0;
        public int billeteCien = 0;
        public int BilleteCincuenta = 0;
        public int monedaVeinticinco = 0;
        public int monedaDiez = 0;
        public int monedaCinco = 0;
        public int monedaUno = 0;
        public int totalEfectivo = 0;
        
        public int PersonaID = 0;
        public frCuadre(int PersonaID)
        {

            InitializeComponent();
            SetEstadoInicial();
            this.PersonaID = PersonaID;
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

        private void frCuadre_Load(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            var iniciodia = ds.InicioDia.OrderByDescending(x=>x.CreatedAt).Take(1).FirstOrDefault();
            var FechaInicioDia = iniciodia == null ? "" : iniciodia.CreatedAt.ToShortDateString();
            if (FechaInicioDia != DateTime.Today.ToShortDateString())
            {   
                gbcuadre.Enabled = false;
            }
            else
            {
                gbcuadre.Enabled = true;
                
            }
        }
    }
}
