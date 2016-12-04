using AutoMapper;
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
    public partial class FrmBusquedaTransaccion : Form
    {
        private TransaccionService _transaccionService;
        List<TransacccionDTO> resultsDto;
        public FrmBusquedaTransaccion()
        {
            InitializeComponent();
            _transaccionService = new TransaccionService();
        }

        private void CmdBuscar_Click(object sender, EventArgs e)
        {
            IEnumerable results = _transaccionService.searchByCriteria(TxtBuscar.Text);
            resultsDto = new List<TransacccionDTO>();
            foreach(Transaccion tr in results)
            {
                resultsDto.Add(Mapper.Map<TransacccionDTO>(tr));
            }
           dataGridView1.DataSource = resultsDto;
        }

        private void FrmBusquedaTransaccion_Load(object sender, EventArgs e)
        {

        }

        private void CmdImprimir_Click(object sender, EventArgs e)
        {
            if (resultsDto != null)
            {
                FrmVisorReporte frmVisorReporte = new FrmVisorReporte();
                frmVisorReporte._dataSource = resultsDto;
                frmVisorReporte.ShowDialog();
            }
            
        }
    }
}
