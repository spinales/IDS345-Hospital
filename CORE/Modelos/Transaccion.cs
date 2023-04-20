using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    public class Transaccion {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int TransaccionID { get; set; }
        public decimal Monto { get; set; }
        public bool Estado { get; set; } = true;
        public string Descripcion { get; set; }
        public string TipoTransaccion { get; set; }

        [ForeignKey("MetodoPago")]
        public int MetodoPagoID { get; set; }
        
        [ForeignKey("Cuenta")]
        public int CuentaID { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }

        public virtual MetodoPago MetodoPago { get; set; }
        public virtual Cuenta Cuenta { get; set; }

        public string CodigoTransaccion { get; set; }
        public string Canal { get; set; }
    }
    
}