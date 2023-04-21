using System;

namespace API.DTOs.Inputs
{
    public class ConsultaInput
    {
        public string Descripcion { get; set; }
        
        public int DoctorID{ get; set; }
        
        public DateTime CreatedAt { get; set; }
    }
}