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
    public partial class frmReporte : Form
    {
        private static frmReporte instancia = null;

        public static frmReporte obtenerInstancia()
        {
            if(instancia == null)
            {
                instancia = new frmReporte();
            }
            return instancia;
        }
        
        private frmReporte()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            frmMostrarRep mostrar = new frmMostrarRep();
            mostrar.Estado = textBox1.Text;
            mostrar.ShowDialog();
        }
    }
}
