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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.Show();
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tipoDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoDocumento frmTipoDocumento = new FrmTipoDocumento();
            frmTipoDocumento.Show();
        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransaccion frmTransaccion = new FrmTransaccion();
            frmTransaccion.Show();
        }
    }
}
