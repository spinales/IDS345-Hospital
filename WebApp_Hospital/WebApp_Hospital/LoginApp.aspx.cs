using Caja.Services;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_Hospital
{
    public partial class LoginApp : System.Web.UI.Page
    {
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
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        async protected void LoginButton_Click(object sender, EventArgs e)
        {
            bool integracionRespondio = false;
            string hashedPassword = HashPassword(txtPassword.Text);

            if (integracionRespondio)
            {

            }
            else
            {
                var ds = new DataService();
                var personas = await ds.GetAll<Persona>(
                    x => (x.RolPersonaID == (int)Enums.RolPersona.Pacientes && x.Usuario.Username == txtUserName.Text &&
                    x.Usuario.Password == hashedPassword && x.Estado == true),
                    x => x.Usuario);
                var persona = personas.FirstOrDefault();

                if (persona != null)
                {

                    Session["user"] = persona;
                    Response.Redirect("Dashboard.aspx");

                }
                else
                {
                    txtUserName.Text = "";
                    txtPassword.Text = "";


                }
            }
        }
    }
}
