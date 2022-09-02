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
    public partial class frmMostrarRep : Form
    {
        public frmMostrarRep()
        {
            InitializeComponent();
        }

        public string Estado { get; set; }
        private void frmMostrarRep_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bancoDataSet.Saldos' Puede moverla o quitarla según sea necesario.
            this.saldosTableAdapter.Fill(this.bancoDataSet.Saldos, Estado);

            this.reportViewer1.RefreshReport();
        }
    }
}
