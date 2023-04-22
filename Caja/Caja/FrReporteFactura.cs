using Caja.Services;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja
{
    public partial class FrReporteFactura : Form
    {
        public FrReporteFactura()
        {
            InitializeComponent();
        }

        private void FrReporteFactura_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            // Crear instancia del objeto DataService
            DataService ds = new DataService();

            // Obtener datos de la factura
            var data = ds.Factura.ToList();

            // Agregar datos al origen de datos del informe
            var reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource1.Name = "Factura";
            reportDataSource1.Value = data;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

            // Especificar el archivo RDL que contiene el informe
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReporteFactura.rdlc";

            // Actualizar el informe
            this.reportViewer1.RefreshReport();
        }
    }
}
