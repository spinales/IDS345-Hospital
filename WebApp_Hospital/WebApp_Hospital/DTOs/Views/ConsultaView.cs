using System;

namespace WebApp_Hospital.DTOs.Views
{
    public class ConsultaView
    {
        public string CodigoFactura { get; set; }

        public string Descripcion { get; set; }

        public DateTime? UpdatedAt { get; set; }
        
        public DoctorView Doctor{ get; set; }
    }
    
}