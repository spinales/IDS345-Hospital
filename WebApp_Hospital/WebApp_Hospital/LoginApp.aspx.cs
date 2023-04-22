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
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace WebApp_Hospital
{
    public partial class LoginApp : System.Web.UI.Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
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

       private async void login(string Usuario, string Clave)
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = "https://localhost:44348/WEB/login";
                var requestBody = new
                {
                    Username = Usuario,
                    Password = Clave
                };

                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "Application/json");

                var response = await httpClient.PostAsync(apiUrl, content);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    if(response != null)
                    {
                        Response.Redirect("Dashboard.aspx");
                    }
                    else
                    {
                        txtUserName.Text = "";
                        txtPassword.Text = ""
                    }
                    

                }

                else
                {
                    bool integracionRespondio = false;
                    string hashedPassword = HashPassword(txtPassword.Text);

                    if (integracionRespondio)
                    {
                        login(txtUserName.Text, hashedPassword);

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

        async protected void LoginButton_Click(object sender, EventArgs e)
        {
            login(txtUserName.Text, txtPassword.Text);

        }
    }
}
