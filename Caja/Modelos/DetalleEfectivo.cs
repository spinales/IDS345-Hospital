using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class DetalleEfectivo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int DetalleEfectivoID { get; set; }
        public int DosmilPesos { get; set; }
        public int MilPesos { get; set; }
        public int QuinientosPesos { get; set; }
        public int DocientosPesos { get; set; }
        public int cienPesos { get; set; }
        public int CincuentaPesos { get; set; }
        public int VeinticincoPesos { get; set; }
        public int DiezPesos { get; set; }
        public int CincoPesos { get; set; }
        public int UnPeso { get; set; }
        public int TotalEfectivo { get; set; }


        [ForeignKey("InicioDia")]
        public int InicioDiaID { get; set; }

        [ForeignKey("Cuadre")]
        public int? CuadreID { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }

        public virtual InicioDia InicioDia { get; set; }
        public virtual Cuadre Cuadre { get; set; }

    }
}
