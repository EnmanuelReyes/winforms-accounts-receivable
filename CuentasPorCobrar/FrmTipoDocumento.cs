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
    public partial class FrmTipoDocumento : Form
    {
        public FrmTipoDocumento()
        {
            InitializeComponent();
        }

        private void tipoDocumentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipoDocumentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cuentaPorCobtrarDBDataSet);

        }

        private void FrmTipoDocumento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuentaPorCobtrarDBDataSet.Estado' table. You can move, or remove it, as needed.
            this.estadoTableAdapter.Fill(this.cuentaPorCobtrarDBDataSet.Estado);
            // TODO: This line of code loads data into the 'cuentaPorCobtrarDBDataSet.TipoDocumento' table. You can move, or remove it, as needed.
            this.tipoDocumentoTableAdapter.Fill(this.cuentaPorCobtrarDBDataSet.TipoDocumento);

        }
    }
}
