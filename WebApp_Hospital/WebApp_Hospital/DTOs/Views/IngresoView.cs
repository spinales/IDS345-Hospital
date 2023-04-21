using System;

namespace WebApp_Hospital.DTOs.Views
{
    public class IngresoView
    {
        public int IngresoID { get; set; }
        
        public DateTime FechaInicio { get; set; }
        
        public DateTime? FechaFin { get; set; }
        
        public bool Alta { get; set; } = false;
        
        public bool Estado { get; set; } = true;
        
        public decimal MontoIngreso { get; set; }

        public int CuentaID { get; set; }

        public int PacienteID { get; set; }

        public int HabitacionID { get; set; }
    }
}