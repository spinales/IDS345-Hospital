using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Persona
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int PersonaID { get; set; }
        
        public bool Estado { get; set; }
        public char Sexo { get; set; }
        
        [Column(TypeName = "VARCHAR(100)")]
        public string Nombre { get; set; }
        
        [Column(TypeName = "VARCHAR(100)")]
        public string Apellido { get; set; }
        
        [Column(TypeName = "VARCHAR(100)")]
        public string Documento { get; set; }
        
        [Column(TypeName = "VARCHAR(10)")]
        public string Telefono { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioID { get; set; }

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

    }
}