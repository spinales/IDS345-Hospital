﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Modelos
{
    public class RolPersona
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int RolPersonaID { get; set; }
        
        [Column(TypeName = "VARCHAR(100)")]
        public string Nombre { get; set; }
        
        [Column(TypeName = "VARCHAR(200)")]
        public string Descripcion { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? SendedAt { get; set; }

        public virtual ICollection<Persona> Persona { get; set; }

    }
}