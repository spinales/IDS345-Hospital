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
                
            



        }
           
           

            

        
    }
}