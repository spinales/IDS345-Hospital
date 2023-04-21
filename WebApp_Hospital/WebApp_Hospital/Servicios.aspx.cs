using Caja.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_Hospital.Enums;

namespace WebApp_Hospital
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataService ds = new DataService())
            {
                var servicios = from s in ds.Servicios
                                select new { Descripcion = s.Descripcion, Precio = s.Precio, TipoServicio = s.TipoServicio.Nombre };

                ServiciosRepeater.DataSource = servicios.ToList();
                ServiciosRepeater.DataBind();
            }


        }
    }
}