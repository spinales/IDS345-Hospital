using Caja.Enums;
using Caja.Services;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Caja
{
    public partial class frFacturacion : Form
    {
        private Factura factura= new Factura();
        public FacturaServicios[] facturaServicios = new FacturaServicios[50];
        private Persona persona;
        int i = 0;

        public frFacturacion(Persona persona)
        {
            InitializeComponent();
            this.persona = persona;
            lbFacturacionNombreCajero.Text = persona.Nombre + " " + persona.Apellido;
            lbFacturacionNombreSucursal.Text = persona.Usuario.Sucursal.Nombre;
            lbFacturacionFecha.Text = DateTime.Now.ToShortDateString();
            inicio();
            DatagView();
            factura.EmpleadoID = persona.PersonaID;
            
        }
        private async void DatagView() 
        {
            DGV.Columns.Add("Servicio", "Descripcion");
            DGV.Columns.Add("PrecioUnitario", "PrecioUnitario");
            DGV.Columns.Add("Cantidad", "Cantidad");
            DGV.Columns.Add("Impuesto", "Impuesto");
            DGV.Columns.Add("Descuento", "Descuento");

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

        private async void btnFacturacionAgregarServicio_Click(object sender, EventArgs e)
        {
            
            bool integracionRespondio = false;

            if (integracionRespondio)
            {

            }
            else
            {

                // Obtener datos del paciente y del servicio seleccionado
                var ds = new DataService();
                var pacientes = await ds.GetAll<Persona>(
                    x => (x.RolPersonaID == (int)Enums.RolPersona.Pacientes && x.Documento == txtFacturacionCliente.Text
                        && x.Estado == true), x => x.Usuario);
                var pacient = pacientes.FirstOrDefault();

                var ds2 = new DataService();
                var Dservicios = await ds2.GetAll<Servicios>(
                    x => (x.ServicioID == (int)cbFacturacionServicios.SelectedIndex + 1)
                    , x => x.TipoServicio);
                var Dservicio = Dservicios.FirstOrDefault();

                var cuentas = await ds.GetAll<Cuenta>(x => (x.PacienteID == 2 && x.Estado == true)
                    );
                var cuenta = cuentas.FirstOrDefault();

                if (pacient != null)
                {
                    factura.PacienteID = pacient.PersonaID;
                    factura.CuentaID = cuenta.CuentaID;
                    factura.MetodoPagoID = cbFacturacionMetodoPago.SelectedIndex+1;
                    
                }
                facturaServicios[i] = new FacturaServicios();
                facturaServicios[i].Cantidad = 1;
                facturaServicios[i].PrecioUnitario = Dservicio.Precio;
                facturaServicios[i].Impuesto = Dservicio.Impuesto;
                facturaServicios[i].Descuento = Dservicio.Descuento;
                
                DataService dataService = new DataService();
                var facturas = await dataService.GetAll<Factura>(x => (x.CuentaID == factura.CuentaID));
                if (facturas.Count() > 0)
                {
                    DGV.DataSource = null;
                    DGV.DataSource = facturas;
                }

                decimal totalBruto = Dservicio.Precio * 1;

                decimal totalImpuesto = totalBruto * 0.18m;

                decimal totalDescuento = totalBruto * Dservicio.Descuento;
                factura.Descuento = totalDescuento;
                facturaServicios[i].TotalDescuento = totalDescuento;

                decimal totalFinal = totalBruto + totalImpuesto - totalDescuento;
                facturaServicios[i].TotalFinal = totalFinal;
                facturaServicios[i].TotalBruto = totalBruto;
                facturaServicios[i].Descripcion = Dservicio.Descripcion;
                facturaServicios[i].ServicioID = Dservicio.ServicioID;
                facturaServicios[i].CodigoFactura = factura.CodigoFactura;
                factura.TotalBruto += totalBruto;
                factura.TotalFinal += totalFinal;
                i++;
            }
        }

        private void ImprimirFacturabtn_Click(object sender, EventArgs e)
        {
    
            DataService ds = new DataService();
            var transaccion = ds.Database.BeginTransaction();
            try
            {
                ds.Database.ExecuteSqlCommand("EXEC sp_registrar_factura @TotalFinal, @TotalDescuento, @TotalBruto, @CuentaID, @PacienteID, @EmpleadoID, @MetodoPagoID, @CreatedAt, @Estado, @CodigoFactura, @TotalAutorizado",
                    new SqlParameter("@TotalFinal", factura.TotalFinal),
                    new SqlParameter("@TotalDescuento", factura.Descuento),
                    new SqlParameter("@TotalBruto", factura.TotalBruto),
                    new SqlParameter("@CuentaID", factura.CuentaID == null ? DBNull.Value : (object)factura.CuentaID),
                    new SqlParameter("@PacienteID", factura.PacienteID),
                    new SqlParameter("@EmpleadoID", factura.EmpleadoID == null ? DBNull.Value : (object)factura.EmpleadoID),
                    new SqlParameter("@MetodoPagoID", factura.MetodoPagoID),
                    new SqlParameter("@CreatedAt", factura.CreatedAt),
                    new SqlParameter("@Estado", 1),
                    new SqlParameter("@CodigoFactura", factura.CodigoFactura),
                    new SqlParameter("@TotalAutorizado", factura.TotalAutorizado)
                    );
                foreach (var servicio in facturaServicios)
                {
                    var ID = new SqlParameter("@ID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    var PrecioUnitario = new SqlParameter("@PrecioUnitario", servicio.PrecioUnitario);
                    var Cantidad = new SqlParameter("@Cantidad", servicio.Cantidad);
                    var Impuesto = new SqlParameter("@Impuesto", servicio.Impuesto);
                    var Descuento = new SqlParameter("@Descuento", servicio.Descuento);
                    var TotalImpuesto = new SqlParameter("@TotalImpuesto", servicio.TotalImpuesto);
                    var TotalDescuento = new SqlParameter("@TotalDescuento", servicio.TotalDescuento);
                    var TotalBruto = new SqlParameter("@TotalBruto", servicio.TotalBruto);
                    var TotalFinal = new SqlParameter("@TotalFinal", servicio.TotalFinal);
                    var Descripcion = new SqlParameter("@Descripcion", servicio.Descripcion);
                    var CreatedAt = new SqlParameter("@CreatedAt", servicio.CreatedAt);
                    var ServicioID = new SqlParameter("@ServicioID", servicio.ServicioID);
                    var CodigoFactura = new SqlParameter("@CodigoFactura", factura.CodigoFactura);
                    ds.Database.ExecuteSqlCommand(
                        "EXEC sp_registrar_factura_servicio @PrecioUnitario, @Cantidad, @Impuesto, @Descuento, @TotalImpuesto, @TotalDescuento, @TotalBruto, @TotalFinal, @Descripcion, @CreatedAt, @ServicioID, @CodigoFactura, @ID OUT",
                        PrecioUnitario,
                        Cantidad,
                        Impuesto,
                        Descuento,
                        TotalImpuesto,
                        TotalDescuento,
                        TotalBruto,
                        TotalFinal,
                        Descripcion,
                        CreatedAt,
                        ServicioID,
                        CodigoFactura,
                        ID
                    );
                    //if (servicio.Consulta != null)
                    //    ds.Database.ExecuteSqlCommand("EXEC sp_registrar_consulta @CodigoFactura, @Descripcion, @DoctorID, @CreatedAt, @DetalleID",
                    //        new SqlParameter("@CodigoFactura", factura.CodigoFactura),
                    //        new SqlParameter("@DoctorID", servicio.Consulta.DoctorID),
                    //        new SqlParameter("@Descripcion", servicio.Consulta.Descripcion),
                    //        new SqlParameter("@CreatedAt", servicio.Consulta.CreatedAt),
                    //        new SqlParameter("@DetalleID", (int)ID.Value)
                    //    );

                }
                // Conectarse al Core y consumir el servicio para registrar la factura alla
                bool coreRespondio = false;
                if (coreRespondio)
                {
                    // Crear un procedure para colocar la fecha del envio al Core en la base de datos de la integracion para esa Transaccion
                }
                transaccion.Commit();
                //return Ok();
            }
            catch (Exception ex) {
                transaccion.Rollback();
               // return BadRequest("Hubo un error al resitrar la factura, intente mas tarde");
            }
        }

        private void btnFacturacionSeleccionarMetodoPago_Click(object sender, EventArgs e)
        {

        }
    }
}
