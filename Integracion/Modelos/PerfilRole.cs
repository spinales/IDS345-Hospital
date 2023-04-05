using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    public class PerfilRole
    {
        [Key]
        [ForeignKey("Perfil")]
        public int PerfilID { get; set; }
        
        [Key]
        [ForeignKey("Entidad")]
        public int EntidadID { get; set; }
        
        [Key]
        [ForeignKey("Role")]
        public int RoleID { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }

        public virtual Perfil Perfil { get; set; }
        public virtual Entidad Entidad { get; set; }
        public virtual Role Role { get; set; }
    }
}
