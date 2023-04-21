using Caja.Services;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_Hospital.DTOs.Inputs;

namespace WebApp_Hospital
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPagar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagos.aspx");
        }
    }
}