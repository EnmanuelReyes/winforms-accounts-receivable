using System;
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
    public partial class FrmTransaccion : Form
    {
        ClienteService _clienteService = new ClienteService();
        public FrmTransaccion()
        {
            InitializeComponent();
        }

        public new bool Validate()
        {
            base.Validate();
            bool valid = false;

            if (Double.Parse(montoTextBox.Text) > 0)
            {
                valid = true;
            }
            else
            {

                MessageBox.Show("Monto debe ser mayor que 0", " Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            if (!valid) return valid;

            if (_clienteService.PermiteTransaccion(Decimal.Parse(montoTextBox.Text), Int32.Parse(idTipoMovimientoComboBox.Text),
               Int32.Parse(idClienteComboBox.Text)))
            {
                MessageBox.Show("Esta transacción supera el limite de credito disponible del cliente", " Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;

            }

            return valid;
        }

        private void transaccionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                this.transaccionBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cuentaPorCobtrarDBDataSet);
                _clienteService.ActualizaBalance(Decimal.Parse(montoTextBox.Text), Int32.Parse(idTipoMovimientoComboBox.Text),
               Int32.Parse(idClienteComboBox.Text));
            }
          

        }

        private void FrmTransaccion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuentaPorCobtrarDBDataSet.TipoMovimiento' table. You can move, or remove it, as needed.
            this.tipoMovimientoTableAdapter.Fill(this.cuentaPorCobtrarDBDataSet.TipoMovimiento);
            // TODO: This line of code loads data into the 'cuentaPorCobtrarDBDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.cuentaPorCobtrarDBDataSet.Cliente);
            // TODO: This line of code loads data into the 'cuentaPorCobtrarDBDataSet.TipoDocumento' table. You can move, or remove it, as needed.
            this.tipoDocumentoTableAdapter.Fill(this.cuentaPorCobtrarDBDataSet.TipoDocumento);
            // TODO: This line of code loads data into the 'cuentaPorCobtrarDBDataSet.Transaccion' table. You can move, or remove it, as needed.
            this.transaccionTableAdapter.Fill(this.cuentaPorCobtrarDBDataSet.Transaccion);

        }

        private void idTipoMovimientoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
