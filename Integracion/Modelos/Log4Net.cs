using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    public class Log4Net
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int LogID { get; set; }
        
        public DateTime Date { get; set; }
        
        [Column(TypeName = "VARCHAR(255)")]
        public string Thread { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string Level { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        public string Logger { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Message { get; set; }

        [Column(TypeName = "VARCHAR(2000)")]
        public string Exception { get; set; }
        
    }
}
