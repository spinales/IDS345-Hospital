using Caja.Services;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_Hospital
{
    public partial class LoginApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        async protected void LoginButton_Click(object sender, EventArgs e)
        {
            bool integracionRespondio = false;

            if (integracionRespondio)
            {

            }
            else {
                var ds = new DataService();
                var personas = await ds.GetAll<Persona>(
                    x => (x.RolPersonaID == (int)Enums.RolPersona.Pacientes && x.Usuario.Username == txtUserName.Text &&
                    x.Usuario.Password == txtPassword.Text && x.Estado == true),
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