using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Cuadre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CuadreID { get; set; }
        public decimal TotalCuadre { get; set; }
        public decimal TotalSistema { get; set; }                        
        public decimal TotalDiferencia { get; set; }
        public decimal FaltanteSobrante { get; set; }

        public decimal NuevoSaldoCaja { get; set; }


        [ForeignKey("Cajero")]
        public int CajeroID { get; set; }

        [ForeignKey("InicioDia")]
        public int InicioDiaID { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }

        public virtual Persona Cajero { get; set; }
        public virtual InicioDia InicioDia { get; set; }


        public virtual ICollection<DetalleCuadre> DetalleCuadres { get; set; }



    }
}
