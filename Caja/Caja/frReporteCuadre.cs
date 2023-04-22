using Caja.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja
{
    public partial class frReporteCuadre : Form
    {
        public frReporteCuadre()
        {
            InitializeComponent();
        }

        private void frReporteCuadre_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

            DataService ds = new DataService();
            var data = ds.DetalleCuadre.ToList();
            var reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource1.Name = "DSCuadre";
            reportDataSource1.Value = data;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.RefreshReport();
        }
    }
}
