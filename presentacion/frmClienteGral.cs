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
    public partial class frmClienteGral : Form
    {
        private static frmClienteGral instancia = null;
        
        public static frmClienteGral obtenerInstancia()
        {
            if(instancia == null)
            {
                instancia = new frmClienteGral();
            }
            return instancia;
        }
        private frmClienteGral()
        {
            InitializeComponent();
        }

        private void frmClienteGral_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bancoDataSet2.Clientegral' Puede moverla o quitarla según sea necesario.
            this.clientegralTableAdapter.Fill(this.bancoDataSet2.Clientegral);

            this.reportViewer1.RefreshReport();
        }
    }
}
