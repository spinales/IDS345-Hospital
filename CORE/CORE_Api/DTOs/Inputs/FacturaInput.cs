using System;
using System.Collections.Generic;

namespace CORE_Api.DTOs.Inputs
{
    public class FacturaInput
    {
        public decimal TotalFinal { get; set; }
        
        public decimal TotalDescuento { get; set; } = 0;
        
        public decimal TotalBruto { get; set; }

        public int? CuentaID { get; set; }
        
        public int PacienteID { get; set; }

        public int? EmpleadoID { get; set; }

        public int MetodoPagoID { get; set; }

        public DateTime CreatedAt { get; set; }
        
        public string CodigoFactura { get; set; }
        
        public List<FacturaServiciosInput> Servicios { get; set; }
    }
}