using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Ingreso
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IngresoID { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool Alta { get; set; } = false;
        public bool Estado { get; set; } = true;
        public decimal MontoIngreso { get; set; }

        [ForeignKey("Cuenta")]
        public int CuentaID { get; set; }

        [ForeignKey("Persona")]
        public int PacienteID { get; set; }

        [ForeignKey("Habitacion")]
        public int HabitacionID { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }

        public virtual Cuenta Cuenta { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual Habitacion Habitacion { get; set; }
    }
}