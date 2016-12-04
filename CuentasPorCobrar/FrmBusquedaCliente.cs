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
    public partial class FrmBusquedaCliente : Form
    {
        private ClienteService _clienteService;
        public FrmBusquedaCliente()
        {
            InitializeComponent();
            _clienteService = new ClienteService();
        }

        private void CmdBuscar_Click(object sender, EventArgs e)
        {
            IEnumerable results = _clienteService.searchByCriteria(TxtBuscarCliente.Text);
            decimal total = 0;
            List<ClienteDTO> resultsDto = new List<ClienteDTO>();
            foreach(Cliente c in results)
            {
                resultsDto.Add(Mapper.Map<ClienteDTO>(c));
                total += c.LimiteDeCredito;
            }
           dataGridView2.DataSource = resultsDto;
            TxtTotalizado.Text = total.ToString();
        }

        private void FrmBusquedaTransaccion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
