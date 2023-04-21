using System;

namespace API.DTOs.Views
{
    public class DoctorView
    {
        public int PersonaID { get; set; }

        public bool Estado { get; set; }
        
        public string Sexo { get; set; }
        
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Documento { get; set; }

        public string Telefono { get; set; }

        public int TipoSangreID { get; set; }

        public int TipoDocumentoID { get; set; }

        public int NacionalidadID { get; set; }

        public int RolPersonaID { get; set; }
        
        public DateTime? UpdatedAt { get; set; }
    }
}