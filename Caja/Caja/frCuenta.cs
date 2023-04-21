using Caja.Services;
using Modelos;
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
            SetEstadoInicial();
        }

        void SetEstadoInicial()
        {
            DateTime fechaActual = DateTime.Now;

            // Convertir la fecha a una cadena con formato
            string fechaFormateada = fechaActual.ToString("dd/MM/yyyy");

            // Asignar la cadena al TextBox
            FechaAperturalbl.Text = fechaFormateada;

        }

        private void abonarcuentabtn_Click(object sender, EventArgs e)
        {
            frCuentaAbono frCuentaAbono = new frCuentaAbono();
            frCuentaAbono.Show();
        }

        private async void Buscarbtn_Click(object sender, EventArgs e)
        {
            bool integracionRespondio = false; 

            if (integracionRespondio)
            {

            }
            else
            {
                DataService ds = new DataService(); // si integracion no responde se obtiene la informacion de los servicios locales de caja
                var personas = await ds.GetAll<Persona>(x => (x.RolPersonaID == (int)Enums.RolPersona.Pacientes && x.Documento == DocClientetxt.Text));
                var persona = personas.FirstOrDefault();

                if(persona != null)
                {
                    var cuentas = await ds.GetAll<Cuenta>(x => (x.PacienteID == persona.PersonaID && x.Estado == true));
                    Cuentacb.DataSource = cuentas;
                    Cuentacb.ValueMember = "Balance";
                    Cuentacb.SelectedIndex = 0;
                    Cuentacb.DisplayMember = "CuentaID";
                    idpacienterelleno.Text = persona.PersonaID.ToString();



                }
            }

        }

        private void Cuentacb_SelectedIndexChanged(object sender, EventArgs e)
        {
            idcuentatextolbl.Text = Cuentacb.Text.ToString();
            montoactualtxt.Text = Cuentacb.SelectedValue.ToString();
        }
    }
}
