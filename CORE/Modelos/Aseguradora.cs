using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    public class Aseguradora
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int AseguradoraID { get; set; }
        
        [Column(TypeName = "VARCHAR")]
        [StringLength(200)]
        public string Nombre { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(200)]
        public string Telefono { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(200)]
        public string Direccion { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }

        public virtual ICollection<Autorizaciones> Autorizaciones { get; set; }
    }
}
