using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Modelos
{
    public class Entidad
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EntidadId { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(200)] 
        public string Descripcion { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }
        
        public virtual ICollection<PerfilRole> PerfilesRoles { get; set; }

    }
}
