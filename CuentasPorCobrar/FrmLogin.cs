using System;
using System.Windows.Forms;

namespace CuentasPorCobrar
{
    public partial class FrmLogin : Form
    {
        private string _client;
        private string _idIdentification;
        public FrmLogin()
        {
            InitializeComponent();
            _client = "test";
            _idIdentification = "1234";
        }

        private void CmbLogin_Click(object sender, EventArgs e)
        {
            //TODO: validate login
            FrmLogin frmLogin = new FrmLogin();
            FrmMenu frmMenu = new FrmMenu();
            Hide();

            try
            {
                if ((string.IsNullOrWhiteSpace(txtUser.Text) &&
                    string.IsNullOrWhiteSpace(txtPass.Text)) ||
                    _client != txtUser.Text && _idIdentification != txtPass.Text)
                {
                    MessageBox.Show("Credenciales incorrectas", " Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    frmLogin.Show();
                }
                else
                {
                    if (txtUser.Text != null && txtPass.Text != null)
                    {
                        if (_client != null && _idIdentification != null)
                        {
                            if (_client == txtUser.Text && _idIdentification == txtPass.Text)
                            {
                                frmMenu.Show();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public void Validateuser(string client, string idIdentification)
        {

            //Todo: Crear mejor implementacion para validar credenciales.
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}