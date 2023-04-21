using Caja.Enums;
using Caja.Services;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            this.persona = persona;
            lbFacturacionNombreCajero.Text = persona.Nombre + " " + persona.Apellido;
            lbFacturacionNombreSucursal.Text = persona.Usuario.Sucursal.Nombre;
            lbFacturacionFecha.Text = DateTime.Now.ToShortDateString();
            inicio();
            DatagView();
            
        }
        private async void DatagView() 
        {
            //dataGridView1.Columns.Add()
            //dataGridView1.Columns.Add("FacturaID", "ID Factura");
            //dataGridView1.Columns.Add("CuentaID", "ID Cuenta");
            //dataGridView1.Columns.Add("PacienteID", "ID Paciente");
            //dataGridView1.Columns.Add("EmpleadoID", "ID Empleado");
            //dataGridView1.Columns.Add("MetodoPagoID", "ID Método de Pago");
            //dataGridView1.Columns.Add("CreatedAt", "Fecha de Creación");
            //dataGridView1.Columns.Add("UpdatedAt", "Fecha de Actualización");
            //dataGridView1.Columns.Add("DeletedAt", "Fecha de Eliminación");
            //dataGridView1.Columns.Add("TotalBruto", "Total Bruto");
            //dataGridView1.Columns.Add("Descuento", "Descuento");
            //dataGridView1.Columns.Add("TotalAutorizado", "Total Autorizado");
            //dataGridView1.Columns.Add("TotalFinal", "Total Final");
            //dataGridView1.Columns.Add("Estado", "Estado");
            //dataGridView1.Columns.Add("SendedAt", "Fecha de Envío");

        }
        private async void inicio() 
        {
            var ds = new DataService();
            var servicios = await ds.GetAll<Servicios>();
            var descripciones = servicios.Select(s => s.Descripcion).Distinct().ToList();
            cbFacturacionServicios.DataSource = descripciones;

            var ds2 = new DataService();
            var mPago = await ds2.GetAll<Modelos.MetodoPago>();
            var NombreMetodoPago = mPago.Select(s => s.Nombre).ToList();
            cbFacturacionMetodoPago.DataSource = NombreMetodoPago;

            lbFacturacionServicioSeleccionado.Text = "Servicio";
            lbFacturacionTipoServicioSeleccionado.Text = "Tipo de servicio";
            lbFacturacionDescripcionServicio.Text = "Descripcion del servicio";
            lbFacturacionPrecioServicio.Text = "Precio del servicio";

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
                x => (x.ServicioID == (int)cbFacturacionServicios.SelectedIndex+1)
                , x => x.TipoServicio);
            var Dservicio = Dservicios.FirstOrDefault();
            

            if (Dservicio != null)
            {
                
                lbFacturacionServicioSeleccionado.Text = cbFacturacionServicios.SelectedText;
                lbFacturacionTipoServicioSeleccionado.Text = Dservicio.TipoServicio.Nombre;
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
