using System;

namespace Caja.DTOs.Views
{
    public class ServiciosView
    {
        public int ServicioID { get; set; }
        
        public string Descripcion { get; set; }
        
        public decimal Precio { get; set; }
        
        public decimal Impuesto { get; set; }

        public decimal Descuento { get; set; } = 0;
        
        public bool Estado { get; set; } = true;
        
        public DateTime? UpdatedAt { get; set; }
        
        public TipoServicioView TipoServicio { get; set; }
        
    }
}