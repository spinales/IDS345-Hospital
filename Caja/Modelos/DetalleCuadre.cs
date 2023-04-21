using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class DetalleCuadre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int DetalleCuadreID { get; set; }
        public decimal ResultadoCuadre { get; set; }
        public decimal ResultadoSistema { get; set; }
        public decimal ResultadoDiferencia { get; set; }


        [ForeignKey("Cuadre")]
        public int CuadreID { get; set; }

        [ForeignKey("MetodoPago")]
        public int MetodoPagoID { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }

        public virtual Cuadre Cuadre { get; set; }
        public virtual MetodoPago MetodoPago { get; set; }



    }
}
