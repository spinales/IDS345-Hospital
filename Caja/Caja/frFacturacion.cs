using Caja.Enums;
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
    public partial class frFacturacion : Form
    {
        private Persona persona;
        public frFacturacion(Persona persona)
        {
            InitializeComponent();
            //this.persona = persona;
            //lbFacturacionNombreCajero.Text = persona.Nombre + " " + persona.Apellido;
            //lbFacturacionNombreSucursal.Text = persona.Usuario.Sucursal.Nombre;
            //lbFacturacionFecha.Text = DateTime.Now.ToShortDateString();
            //cbFacturacionServicios.DataSource = Enum.GetValues(typeof(Enums.TipoServicio));
            //cbFacturacionMetodoPago.DataSource = Enum.GetValues(typeof(Enums.MetodoPago));
        }

        private void frFacturacion_Load(object sender, EventArgs e)
        {

        }

        private async void btnFacturacionBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txtFacturacionCliente.Text != "")
            {
                var ds = new DataService();
                var clientes = await ds.GetAll<Persona>(
                    x => (x.RolPersonaID == (int)Enums.RolPersona.Pacientes && x.Documento == txtFacturacionCliente.Text
                    && x.Estado == true), x=>x.Usuario);
                var cliente = clientes.FirstOrDefault();
                frBusquedaCliente frBusquedaCliente = new frBusquedaCliente(cliente);
                frBusquedaCliente.Show();
            }
            else {
                MessageBox.Show("No ha ingresado un documento",
                    "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void cbFacturacionServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ds = new DataService();
            var Dservicios = await ds.GetAll<Servicios>(
                x => (x.TipoServicioID == (int)cbFacturacionServicios.SelectedIndex+1)
                , x => x.TipoServicio);
            var Dservicio = Dservicios.FirstOrDefault();
            lbFacturacionTipoServicioSeleccionado.Text = cbFacturacionServicios.Text;

            if (Dservicio != null)
            {
                //lbFacturacionServicioSeleccionado.Text = Dservicio.
                lbFacturacionDescripcionServicio.Text = Dservicio.Descripcion;
                lbFacturacionPrecioServicio.Text = Dservicio.Precio.ToString();
                
            }
            else
            {
                lbFacturacionPrecioServicio.Text = "0"; // o cualquier otro valor predeterminado
            }
        }
    }
}
