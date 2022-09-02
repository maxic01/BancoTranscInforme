using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoTransacc.presentacion
{
    public partial class frmReportClientes : Form
    {
        public frmReportClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMostrCliente fmc = new frmMostrCliente();
            fmc.Buscar = txtBuscar.Text;
            fmc.ShowDialog();
        }
    }
}
