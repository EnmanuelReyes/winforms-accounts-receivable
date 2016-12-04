using System;
using System.Windows.Forms;

namespace CuentasPorCobrar
{
    public partial class FrmLogin : Form
    {
        private UsuarioService _usuarioService;
        public FrmLogin()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
        }

        private void CmbLogin_Click(object sender, EventArgs e)
        {
            //TODO: validate login
            FrmLogin frmLogin = new FrmLogin();
            FrmMenu frmMenu = new FrmMenu();
            Hide();

            try
            {
                if ((string.IsNullOrWhiteSpace(txtUser.Text)))
                {
                    MessageBox.Show("Debe introducir un usuario", " Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    frmLogin.Show();
                }
                else 
                {
                    var user = _usuarioService.getUsuario(txtUser.Text, txtPass.Text);
                    bool existe = user != null;
                    if (existe)
                    {
                        frmMenu.setUsuario(user);
                        frmMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro un usuario con los datos suministrados", " Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);

                        frmLogin.Show();

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

        private void TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CmbLogin_Click(null, null);
                e.Handled = true;
            }
        }
    }
}