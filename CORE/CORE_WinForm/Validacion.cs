using Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CORE_WinForm
{
    public class Validacion
    {
        public bool permiso { get; set; }
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        public static bool IsPasswordStrong(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{8,}$");
        }

        public async Task ConfirmarPermisos(int perfil, int entidad, int role)
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = string.Format("https://localhost:44329/CORE/perfilrole/getPerfilEntidadRole?perfil={0}&entidad={1}&role={2}", perfil, entidad, role); // replace with your API endpoint

                var response = await httpClient.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                // parse the JSON response into a collection of Usuario objects
                var perfilrole = JsonConvert.DeserializeObject<PerfilRole>(responseContent);
                if (perfilrole == null)
                {
                    this.permiso = false;
                }
                else
                {
                    this.permiso = true;
                }
                   
            }
        }
    }
}
