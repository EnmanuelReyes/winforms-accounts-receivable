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
        Usuario usuario;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario.Rol.Nombre.Contains("Administrador"))
            {
                FrmCliente frmCliente = new FrmCliente();
                frmCliente.Show();
            }
            else
            {
                unforbidden();
            }
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tipoDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario.Rol.Nombre.Contains("Administrador"))
            {
                FrmTipoDocumento frmTipoDocumento = new FrmTipoDocumento();
                frmTipoDocumento.Show();
            }
            else
            {
                unforbidden();
            }
        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario.Rol.Nombre.Contains("Administrador"))
            {
                FrmTransaccion frmTransaccion = new FrmTransaccion();
                frmTransaccion.Show();
            } else
            {
                unforbidden();
            }
        }

        private void unforbidden()
        {
            MessageBox.Show("No tiene permiso para acceder a esta opción.", " Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void transaccionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (usuario.Rol.Nombre.Contains("Administrador") || usuario.Rol.Nombre.Contains("Visualizador"))
            {
                FrmBusquedaTransaccion frmBusquedaTransaccion = new FrmBusquedaTransaccion();
                frmBusquedaTransaccion.Show();
            }
            else
            {
                unforbidden();
            }
        }

        public void setUsuario(Usuario usuario)
        {
            this.usuario = usuario;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
