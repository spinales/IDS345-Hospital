﻿using System;

namespace CORE_Api.DTOs.Inputs
{
    public class FacturaServiciosInput
    {
        public decimal PrecioUnitario { get; set; }
        
        public int Cantidad { get; set; } = 1;
        
        public decimal Impuesto { get; set; }
        
        public decimal Descuento { get; set; } = 0;
        
        public decimal TotalImpuesto { get; set; } 

        public decimal TotalDescuento { get; set; } = 0;
        
        public decimal TotalBruto { get; set; }
        
        public decimal TotalFinal { get; set; }
        
        public string Descripcion { get; set; }

        public DateTime CreatedAt { get; set; }
        
        public int ServicioID { get; set; }
        
        public ConsultaInput Consulta { get; set; }
        
    }
}