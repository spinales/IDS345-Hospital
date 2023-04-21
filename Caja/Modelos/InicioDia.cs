using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class InicioDia
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int InicioDiaID { get; set; }
        public decimal Balance { get; set; }

        [ForeignKey("Cajero")]
        public int CajeroID { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }

        public virtual Persona Cajero { get; set; }
    }
}
