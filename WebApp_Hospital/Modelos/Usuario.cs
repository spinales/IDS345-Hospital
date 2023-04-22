using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Modelos
{
    public class Usuario
    {
        [Key] public int UsuarioID { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Username { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Password { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Email { get; set; }

        public bool Estado { get; set; }

        [ForeignKey("Sucursal")] public int? SucursalID { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }

        public virtual Sucursal Sucursal { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
        public virtual ICollection<HistoricoAcciones> HistoricosAcciones { get; set; }
    }
}