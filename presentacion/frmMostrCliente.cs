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
    public partial class frmMostrCliente : Form
    {
        public frmMostrCliente()
        {
            InitializeComponent();
        }

        public string Buscar { get; set; }
        private void frmMostrCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bancoDataSet1.BuscarCliente' Puede moverla o quitarla según sea necesario.
            this.buscarClienteTableAdapter.Fill(this.bancoDataSet1.BuscarCliente, Buscar);
            this.reportViewer1.RefreshReport();
        }
    }
}
