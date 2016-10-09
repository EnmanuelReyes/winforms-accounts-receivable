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
        public FrmTransaccion()
        {
            InitializeComponent();
        }

        private void transaccionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transaccionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cuentaPorCobtrarDBDataSet);

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
