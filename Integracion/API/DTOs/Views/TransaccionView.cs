using System;

namespace API.DTOs.Views
{
    public class TransaccionView
    {   
        public decimal Monto { get; set; }
        
        public bool Estado { get; set; } = true;
        
        public string Descripcion { get; set; }
        
        public string TipoTransaccion { get; set; }

        public int MetodoPagoID { get; set; }
        
        public int CuentaID { get; set; }
        
        public int? EmpleadoID { get; set; }

        public DateTime CreatedAt { get; set; }
        
        public string CodigoTransaccion { get; set; }
    }
}