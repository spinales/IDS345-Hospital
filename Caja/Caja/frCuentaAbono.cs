using Caja.DTOs.Inputs;
using Caja.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Newtonsoft.Json;

namespace Caja
{
    public partial class frCuentaAbono : Form
    {
        int CuentaID = 0;
        int EmpleadoID = 0;
        
        decimal montoDevolucion = 0;
        
        decimal montoAbono = 0;

        private decimal montoRecibido = 0;
        
        public frCuentaAbono(int CuentaID, int EmpleadoID)
        {
            InitializeComponent();
            gbEfectivo.Enabled = false;
            this.CuentaID = CuentaID;
            this.EmpleadoID = EmpleadoID;
            this.montodevueltotxt.ReadOnly = true;
        }

        private async void abonarbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea confirmar el abono de la cuenta?", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                montoAbono = string.IsNullOrWhiteSpace(montoabonartxt.Text) == true
                    ? 0
                    : Convert.ToDecimal(montoabonartxt.Text);
                
                montoRecibido = string.IsNullOrWhiteSpace(montorecibidotxt.Text)
                    ? 0
                    : Convert.ToDecimal(montorecibidotxt.Text);
                
                montoDevolucion = montoRecibido - montoAbono;

                var transaccionCuenta = new TransaccionInput()
                {
                    Monto = montoAbono,
                    Descripcion = "Pago realizado a la cuenta",
                    TipoTransaccion = "Pago",
                    MetodoPagoID = MetodoPagocb.SelectedIndex + 2,
                    CuentaID = CuentaID,
                    EmpleadoID = EmpleadoID,
                    CodigoTransaccion = new Guid().ToString(),
                    CreatedAt = DateTime.Now
                };

                DataService ds = new DataService();
                var transaccion = ds.Database.BeginTransaction();
                try
                {
                    if (MetodoPagocb.Text == "Efectivo")
                    {
                        var movimiento = ds.Movimientos.OrderByDescending(x=>x.CreatedAt).Take(1).FirstOrDefault();
                        var balanceActual = 0m;
                        if (movimiento == null)
                        {
                            var ingresodia = ds.InicioDia.OrderByDescending(x => x.CreatedAt).Take(1).FirstOrDefault();
                            balanceActual = ingresodia == null ? 0 : ingresodia.Balance;
                        }
                        else
                        {
                            balanceActual = movimiento.BalanceActual;
                        }
                        await ds.Add<Movimientos>(new Movimientos()
                        {
                            CreatedAt = DateTime.Now,
                            Entrada = true,
                            CajeroID = EmpleadoID,
                            Movimiento = montoRecibido,
                            BalanceActual = balanceActual + montoRecibido,
                        });
                        balanceActual = balanceActual + montoRecibido;
                        
                        await ds.Add<Movimientos>(new Movimientos()
                        {
                            CreatedAt = DateTime.Now,
                            Entrada = false,
                            CajeroID = EmpleadoID,
                            Movimiento = montoDevolucion,
                            BalanceActual = balanceActual - montoDevolucion,
                        });
                    }
                    ds.Database.ExecuteSqlCommand(
                        "EXEC [dbo].sp_registrar_transaccion @Monto, @Descripcion, @TipoTransaccion, @MetodoPagoID, @CuentaID, @EmpleadoID, @CreatedAt, @CodigoTransaccion",
                        new SqlParameter("@Monto", transaccionCuenta.Monto),
                        new SqlParameter("@Descripcion", transaccionCuenta.Descripcion),
                        new SqlParameter("@TipoTransaccion", transaccionCuenta.TipoTransaccion),
                        new SqlParameter("@MetodoPagoID", transaccionCuenta.MetodoPagoID),
                        new SqlParameter("@CuentaID", transaccionCuenta.CuentaID),
                        new SqlParameter("@EmpleadoID", transaccionCuenta.EmpleadoID == null ? DBNull.Value : (object)transaccionCuenta.EmpleadoID),
                        new SqlParameter("@CreatedAt", transaccionCuenta.CreatedAt),
                        new SqlParameter("@CodigoTransaccion", transaccionCuenta.CodigoTransaccion)
                    );
                    
                    transaccion.Commit();
                    

                    MessageBox.Show("Abono a la cuenta realizado con exito", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show("Hubo un error al intentar realizar el abono a la cuenta", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    transaccion.Rollback();
                }
            }
        }
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MetodoPagocb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MetodoPagocb.Text == "Efectivo")
            {
                gbEfectivo.Enabled = true;

            }
            else
            {
                gbEfectivo.Enabled = false;
            }

        }
    }
}
