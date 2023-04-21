using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Modelos
{
    public class Persona
    {
        
        [Key]
        public int PersonaID { get; set; }

        public bool Estado { get; set; } = true;
        
        [Column(TypeName = "VARCHAR")]
        [StringLength(1)]

        public string Sexo { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)] 
        public string Nombre { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)] 
        public string Apellido { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)] 
        public string Documento { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Telefono { get; set; }

        [ForeignKey("Usuario")]
        public int? UsuarioID { get; set; }

        [ForeignKey("TipoSangre")]
        public int TipoSangreID { get; set; }

        [ForeignKey("TipoDocumento")]
        public int TipoDocumentoID { get; set; }

        [ForeignKey("Nacionalidad")]
        public int NacionalidadID { get; set; }

        [ForeignKey("RolPersona")]
        public int RolPersonaID { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual TipoSangre TipoSangre { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
        public virtual Nacionalidad Nacionalidad { get; set; }
        public virtual RolPersona RolPersona { get; set; }

        public virtual ICollection<Cuenta> Cuentas { get; set; }

        public virtual ICollection<Ingreso> Ingresos { get; set; }

        public virtual ICollection<Factura> Facturas { get; set; }

        public virtual ICollection<Movimientos> Movimientos { get; set; }

        public virtual ICollection<InicioDia> InicioDias { get; set; }

        public virtual ICollection<Cuadre> Cuadres { get; set; }




    }
}