using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Modelos
{
    public class HistoricoAcciones
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int HistoricoID { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Descripcion { get; set; }
        
        [ForeignKey("Usuario")]
        public int UsuarioID { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }
        public virtual Usuario Usuario { get; set; }

    }
}
