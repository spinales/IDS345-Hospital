using System;

namespace API.DTOs.Views
{
    public class CuentaView
    {
        public int CuentaID { get; set; }
        
        public decimal Balance { get; set; }
        
        public bool Estado { get; set; } = true;
        
        public int PacienteID { get; set; }
        
        public DateTime? UpdatedAt { get; set; }
        
    }
}