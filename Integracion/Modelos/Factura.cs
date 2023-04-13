using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    public class Factura {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int FacturaID { get; set; }
        public bool Estado { get; set; }
        public decimal TotalFinal { get; set; }
        public decimal TotalAutorizado { get; set; } = 0;
        public decimal TotalDescuento { get; set; } = 0;
        public decimal TotalBruto { get; set; }

        [ForeignKey("Cuenta")]
        public int? CuentaID { get; set; }
        
        [ForeignKey("Paciente")]
        public int PacienteID { get; set; }

        [ForeignKey("Empleado")]
        public int? EmpleadoID { get; set; }

        [ForeignKey("MetodoPago")]
        public int MetodoPagoID { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }

        public virtual Cuenta Cuenta { get; set; }
        public virtual Persona Paciente { get; set; }
        public virtual Persona Empleado { get; set; }
        public virtual MetodoPago MetodoPago { get; set; }
        
        public string CodigoFactura { get; set; }
        
        public string Canal { get; set; } 

    }
}