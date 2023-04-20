using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    public class FacturaServicios {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int DetalleID { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; } = 1;
        public decimal Impuesto { get; set; }
        public decimal Descuento { get; set; } = 0;
        public decimal TotalImpuesto { get; set; }
        public decimal TotalBruto { get; set; }
        public decimal TotalAutorizado { get; set; } = 0;
        public decimal TotalFinal { get; set; }
        public string CodigoFactura { get; set; }
        public decimal TotalDescuento { get; set; } = 0;

        [Column(TypeName = "VARCHAR")]
        [StringLength(200)]
        public string Descripcion { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }

        [ForeignKey("Autorizacion")]
        public int? AutorizacionID { get; set; }

        [ForeignKey("Servicio")]
        public int ServicioID { get; set; }

        [ForeignKey("Factura")]
        public int FacturaID { get; set; }

        public virtual Autorizaciones Autorizacion { get; set; }
        public virtual Servicios Servicio { get; set; }
        public virtual Factura Factura { get; set; }
    }
}