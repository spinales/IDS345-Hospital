using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Modelos
{
    public class Cuenta
    {
      
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CuentaID { get; set; }
        public decimal Balance { get; set; }
        public bool Estado { get; set; } = true;
        
        [ForeignKey("Persona")]
        public int PacienteID { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }
        
        public virtual Persona Persona { get; set; }

    }
}
