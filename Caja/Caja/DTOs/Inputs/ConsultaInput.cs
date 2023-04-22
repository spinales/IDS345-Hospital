using System;

namespace Caja.DTOs.Inputs
{
    public class ConsultaInput
    {
        public string Descripcion { get; set; }
        
        public int DoctorID{ get; set; }
        
        public DateTime CreatedAt { get; set; }
    }
}