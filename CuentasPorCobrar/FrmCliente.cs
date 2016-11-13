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
            bool valid = false;
            if(ClienteService.ValidaCedula(cedulaTextBox.Text))
            {
                valid = true;
            } else
            {

                MessageBox.Show("Cedula incorrecta", " Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            if (!valid) return valid;

            if (Double.Parse(limiteDeCreditoTextBox.Text)>=0)
            {
                valid = true;
            }
            else
            {

                MessageBox.Show("Limite de credito debe ser mayor o igual que 0", " Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            return valid;


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
