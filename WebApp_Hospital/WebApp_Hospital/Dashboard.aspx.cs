using Caja.Services;
using LinqToDB;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static LinqToDB.Common.Configuration;
using WebApp_Hospital.Migrations;


namespace WebApp_Hospital
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Persona persona = (Persona)Session["User"];

            // Utiliza los datos como sea necesario

            using (DataService ds = new DataService())
            {
                var cuentaReciente = from c in ds.Cuenta
                    join p in ds.Persona on c.PacienteID equals p.PersonaID
                    select new { p.Nombre, c.Estado, c.CuentaID };

                List<object> datos = new List<object>();
                foreach (var item in cuentaReciente)
                {
                    datos.Add(new
                    {
                        Nombre = item.Nombre,
                        Estado = item.Estado,
                        Cuenta = item.CuentaID
                    });
                }

                CuentasRepeater.DataSource = datos;
                CuentasRepeater.DataBind();
            }
        }

        protected void btnAgendarConsulta_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consultas.aspx");
        }
    }
}