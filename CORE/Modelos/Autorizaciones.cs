using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    public class Autorizaciones
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int AutorizacionID { get; set; }
        public decimal MontoAutorizado { get; set; }
        public bool Estado { get; set; } = true;
        
        [ForeignKey("Aseguradora")]
        public int AseguradoraID { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }
        
        public virtual Aseguradora Aseguradora { get; set; }
        public virtual ICollection<FacturaServicios> FacturaServicios { get; set; }

    }
}
