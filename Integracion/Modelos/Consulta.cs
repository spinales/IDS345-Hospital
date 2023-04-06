using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    public class Consulta
    {
        [Key]
        [ForeignKey("FacturaServicios")]
        public int DetalleId { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(200)] public string Descripcion { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }
        public virtual Persona Doctor { get; set; }
        public virtual FacturaServicios FacturaServicios { get; set; }
    }
}