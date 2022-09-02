using BancoTransacc.acceso;
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
    public partial class frmCuentasDeshab : Form
    {
        dbHelper oDBHelper;
        public frmCuentasDeshab()
        {
            InitializeComponent();
            oDBHelper = new dbHelper();
        }

        private void frmCuentasDeshab_Load(object sender, EventArgs e)
        {
            cargarGrillaDesh();
            limpiar();
            txtCBUCuenta.Focus();
        }

        private void cargarGrillaDesh()
        {
            DataTable tabla = oDBHelper.consultarDB("GrillaDeshab");
            grillaDeshab.DataSource = tabla;
        }

        #region funciones
        public void limpiar()
        {
            txtCBUCuenta.Text = string.Empty;
        }

        public bool validar()
        {
            if (txtCBUCuenta.Text == string.Empty)
            {
                MessageBox.Show("debe ingresar un cbu");
                txtCBUCuenta.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtCBUCuenta.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("debe ingresar valores numericos");
                    txtCBUCuenta.Focus();
                    return false;
                }
            }
            return true;
        }
        #endregion

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if(validar())
            if (MessageBox.Show("Esta seguro de habilitar esta cuenta?"
               , "HABILITAR"
               , MessageBoxButtons.YesNo
               , MessageBoxIcon.Warning
               , MessageBoxDefaultButton.Button2)
               == DialogResult.Yes)
            {
                int cbuCuenta = Convert.ToInt32(txtCBUCuenta.Text);
                oDBHelper.elimCuenta("AltaLog", cbuCuenta);
                MessageBox.Show("Cuenta habilitada");
                cargarGrillaDesh();
                limpiar();
            }
        }

        #region botones
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("desea salir?"
              , "SALIR"
              , MessageBoxButtons.YesNo
              , MessageBoxIcon.Question
              , MessageBoxDefaultButton.Button2)
              == DialogResult.Yes)
                Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        #endregion
    }
}
