using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    public class Sucursal
    {
        [Key]
        public int SucursalID { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(200)]
        public string Direccion { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }
        
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
