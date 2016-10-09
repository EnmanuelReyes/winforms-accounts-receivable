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
    public partial class FrmCliente : Form
    {

        public FrmCliente()
        {
            InitializeComponent();
        }

        public new bool Validate()
        {
            base.Validate();

            if(ClienteService.ValidaCedula(cedulaTextBox.Text))
            {
                return true;
            } else
            {

                MessageBox.Show("Cedula incorrecta", " Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                this.clienteBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cuentaPorCobtrarDBDataSet);
            }
            
           

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuentaPorCobtrarDBDataSet.Estado' table. You can move, or remove it, as needed.
            this.estadoTableAdapter.Fill(this.cuentaPorCobtrarDBDataSet.Estado);
            // TODO: This line of code loads data into the 'cuentaPorCobtrarDBDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.cuentaPorCobtrarDBDataSet.Cliente);

        }
    }
}
