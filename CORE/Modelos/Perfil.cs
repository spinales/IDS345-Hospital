using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Perfil
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int PerfilID { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Nombre { get; set; }

        public bool Estado { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }

        public virtual ICollection<PerfilRole> PerfilesRoles { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }

    }
}
