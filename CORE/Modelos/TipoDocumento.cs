using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Modelos
{
    public class TipoDocumento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int TipoDocumentoID { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Nombre { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }

    }
}