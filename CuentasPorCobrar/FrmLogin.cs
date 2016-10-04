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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void CmbLogin_Click(object sender, EventArgs e)
        {
            //TODO: validate login

            FrmMenu frmMenu = new FrmMenu();
            Hide();

            frmMenu.Show();
        }
    }
}
