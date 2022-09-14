using BancoTransacc.presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoTransacc
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("desea salir?"
               , "SALIR"
               , MessageBoxButtons.YesNo
               , MessageBoxIcon.Question
               , MessageBoxDefaultButton.Button2)
               == DialogResult.Yes)
                Close();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fnc = frmCliente.obtenerInstancia();
            fnc.Show();
            fnc.Show();
        }

        private void cuentasDeshabilitadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuentasDeshab fcd = frmCuentasDeshab.obtenerInstancia();
            fcd.Show();
            fcd.Focus();
        }

        private void saldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte fmr = frmReporte.obtenerInstancia();
            fmr.Show();
            fmr.Focus();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportClientes frc = frmReportClientes.obtenerInstancia();
            frc.Show();
            frc.Focus();
        }

        private void todosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteGral fcg = frmClienteGral.obtenerInstancia();
            fcg.Show();
            fcg.Focus();
        }
    }
}
