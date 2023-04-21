using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Movimientos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int MovimientoID { get; set; }
        public decimal BalanceActual { get; set; }
        public decimal Movimiento { get; set; }
        public bool Entrada { get; set; }

        [ForeignKey("Cajero")]
        public int CajeroID { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }

        public virtual Persona Cajero { get; set; }
    }
}
