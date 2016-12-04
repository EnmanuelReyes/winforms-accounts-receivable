using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasPorCobrar
{
    public partial class FrmVisorReporte : Form
    {
        public List<TransacccionDTO> _dataSource { get; set; }
        public FrmVisorReporte()
        {
            InitializeComponent();
        }

        private void FrmVisorReporte_Load(object sender, EventArgs e)
        {

            DataTable odt = Util.ConvertToDatatable(_dataSource);

            ReportDataSource rds = new ReportDataSource();

            rds.Value = odt;
            rds.Name = "DataSet1";

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportEmbeddedResource = "Report1.rdlc";
            reportViewer1.LocalReport.ReportPath = @"Report1.rdlc";
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }
        
    }
}
