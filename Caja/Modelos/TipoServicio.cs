using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class TipoServicio
    {
        [Key]
        public int TipoServicioID { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Descripcion { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }

        public virtual ICollection<Servicios> Servicios { get; set; }
    }
}