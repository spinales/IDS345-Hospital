using System;

namespace CORE_Api.DTOs.Views
{
    public class UsuarioView
    {
        public int UsuarioID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
        
        public bool Estado { get; set; }
        
        public int? SucursalID { get; set; }
        
        public DateTime? UpdatedAt { get; set; }
    }
}