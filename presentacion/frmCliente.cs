using BancoTransacc.acceso;
using BancoTransacc.dominio;
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
    public partial class frmCliente : Form
    {
        clienteDTO oCliente;
        cuentaDTO oCuenta;

        private static frmCliente instancia = null;
        public static frmCliente obtenerInstancia()
        {
            if(instancia == null)
            {
                instancia = new frmCliente();
            }
            return instancia;
        }

        private frmCliente()
        {
            InitializeComponent();
            oCliente = new clienteDTO();
            oCuenta = new cuentaDTO();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            cargarGrillaCliente();
            cargarGrillaCuenta();
            cargarCombo();
            habilitar(false);
            limpiar();

        }

        #region select
        private void cargarGrillaCliente()
        {
            DataTable tabla = dbHelperDao.obtenerInstancia().consultarDB("Grilla");
            dataGridView1.DataSource = tabla;
        }
        private void cargarCombo()
        {
            DataTable tabla = dbHelperDao.obtenerInstancia().consultarDB("Combo");
            cboTipo.DataSource = tabla;
            cboTipo.DisplayMember = "tipo";
            cboTipo.ValueMember = "cod_cuenta";
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void cargarGrillaCuenta()
        {
            DataTable tabla = dbHelperDao.obtenerInstancia().consultarDB("GrillaCuenta");
            grillaCuenta.DataSource = tabla;
        }
        #endregion

        #region funciones
        private void limpiar()
        {
            txtSaldo.Text = string.Empty;
            txtCBUCuenta.Text = string.Empty;
            txtCBU2.Text = string.Empty;
            cboTipo.SelectedIndex = -1;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCBU.Text = string.Empty;
            txtDNI.Text = string.Empty;
            dtpUltimoMov.Value = DateTime.Today;
            txtDniCliente.Text = string.Empty;

        }
        private void habilitar(bool v)
        {
            btnInhabilitar.Enabled = v;
            btnEliminarCuent.Enabled = v;
            btnActualizarCuent.Enabled = v;
            btnEliminarClient.Enabled = v;
            btnActualizarClient.Enabled = v;
            btnEditClient.Enabled = !v;
            btnNuevoClient.Enabled = !v;
            btnAddClient.Enabled = v;
            grillaCuenta.Enabled = v;
            dataGridView1.Enabled = v;
            txtNombre.Enabled = v;
            txtApellido.Enabled = v;
            txtCBU.Enabled = v;
            txtDNI.Enabled = v;
            txtDniCliente.Enabled = v;
            txtCBU2.Enabled = v;
            txtCBUCuenta.Enabled = v;
            txtSaldo.Enabled = v;
            dtpUltimoMov.Enabled = v;
            btnCancelar.Enabled = v;
            btnSalir.Enabled = !v;
            cboTipo.Enabled = v;
        }
        private void nuevoCliente(bool v)
        {
            btnNuevoClient.Enabled = !v;
            btnAddClient.Enabled = v;
            btnCancelar.Enabled = v;
            btnEditClient.Enabled = !v;
            btnEditCuent.Enabled = !v;
            txtCBU2.Enabled = v;
            txtSaldo.Enabled = v;
            cboTipo.Enabled = v;
            dtpUltimoMov.Enabled = v;
            txtApellido.Enabled = v;
            txtNombre.Enabled = v;
            txtDNI.Enabled = v;
            txtCBU.Enabled = v;
            grillaCuenta.Enabled = v;
            dataGridView1.Enabled = v;
            btnSalir.Enabled = !v;
        }
        private void editarCuenta(bool v)
        {
            btnNuevoClient.Enabled = !v;
            btnEditClient.Enabled = !v;
            btnCancelar.Enabled = v;
            btnEditCuent.Enabled = !v;
            btnEliminarCuent.Enabled = v;
            btnActualizarCuent.Enabled = v;
            txtCBUCuenta.Enabled = v;
            txtSaldo.Enabled = v;
            cboTipo.Enabled = !v;
            dtpUltimoMov.Enabled = v;
            grillaCuenta.Enabled = v;
            btnSalir.Enabled = !v;
        }
        private void editarCliente(bool v)
        {
            btnCancelar.Enabled = v;
            btnNuevoClient.Enabled = !v;
            btnEditClient.Enabled = !v;
            btnEliminarClient.Enabled = v;
            btnActualizarClient.Enabled = v;
            btnEditCuent.Enabled = !v;
            txtNombre.Enabled = v;
            txtApellido.Enabled = v;
            txtDNI.Enabled = !v;
            txtCBU.Enabled = !v;
            txtDniCliente.Enabled = v;
            dataGridView1.Enabled = v;
            btnSalir.Enabled = !v;
        }
        private bool validarCuenta()
        {
            if (txtCBU2.Text == string.Empty)
            {
                MessageBox.Show("debe ingresar un cbu", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCBU2.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtCBU2.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("debe ingresar valores numericos", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCBU2.Focus();
                    return false;
                }
            }
            if (txtSaldo.Text == string.Empty)
            {
                MessageBox.Show("debe ingresar un saldo para la cuenta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSaldo.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtSaldo.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("debe ingresar valores numericos", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSaldo.Focus();
                    return false;
                }
            }
            if (cboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("debe seleccionar un tipo de cuenta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTipo.Focus();
                return false;
            }
            return true;
        }
        private bool validarCliente()
        {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("debe ingresar un nombre", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text == string.Empty)
            {
                MessageBox.Show("debe ingresar un apellido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApellido.Focus();
                return false;
            }
            if (txtCBU.Text == string.Empty)
            {
                MessageBox.Show("debe ingresar un cbu", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCBU.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtCBU.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("debe ingresar valores numericos", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCBU.Focus();
                    return false;
                }
            }
            if (txtDNI.Text == string.Empty)
            {
                MessageBox.Show("debe ingresar un dni", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDNI.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtDNI.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("debe ingresar valores numericos", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDNI.Focus();
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region sentencias
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (validarCliente() && validarCuenta())
            {
                oCuenta.CbuCuenta = Convert.ToInt32(txtCBU2.Text);
                oCuenta.Saldo = Convert.ToInt32(txtSaldo.Text);
                oCuenta.TipoCuenta = Convert.ToInt32(cboTipo.SelectedValue);
                oCuenta.UltimoMovimiento = dtpUltimoMov.Value;
                oCliente.Dni = Convert.ToInt32(txtDNI.Text);
                oCliente.Nombre = txtNombre.Text;
                oCliente.Apellido = txtApellido.Text;
                oCliente.Cbu = Convert.ToInt32(txtCBU.Text);
                if (dbHelperDao.obtenerInstancia().altaCliente("AddCuenta", "AddCliente", oCuenta, oCliente))
                {
                    MessageBox.Show("cliente agregado");
                    cargarGrillaCuenta();
                    cargarGrillaCliente();
                    nuevoCliente(false);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("no se pudo agregar, ingrese nuevamente en la ventana de altas e intente nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Dispose();
                }               
            }
        }
        private void btnActualizarClient_Click(object sender, EventArgs e)
        {
            oCliente.Dni = Convert.ToInt32(txtDniCliente.Text);
            oCliente.Nombre = txtNombre.Text;
            oCliente.Apellido = txtApellido.Text;
            dbHelperDao.obtenerInstancia().editCliente("ActCliente", oCliente);
            MessageBox.Show("Cliente actualizado");
            cargarGrillaCliente();
            limpiar();
            editarCliente(false);
        }

        private void btnEliminarClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar este cliente?"
                , "ELIMINAR"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning
                , MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                oCliente.Dni = Convert.ToInt32(txtDniCliente.Text);
                if (dbHelperDao.obtenerInstancia().elimCliente("EliminarCliente", oCliente))
                {
                    MessageBox.Show("Cliente elimnado");
                    cargarGrillaCliente();
                    limpiar();
                    editarCliente(false);
                }
                else
                {
                    MessageBox.Show("no se pudo eliminar, ingrese nuevamente en la ventana de altas e intente nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Dispose();
                }

            }
        }
        private void btnActualizarCuent_Click(object sender, EventArgs e)
        {
            oCuenta.CbuCuenta = Convert.ToInt32(txtCBUCuenta.Text);
            oCuenta.Saldo = Convert.ToInt32(txtSaldo.Text);
            oCuenta.UltimoMovimiento = dtpUltimoMov.Value;
            dbHelperDao.obtenerInstancia().editCuenta("ActCuenta", oCuenta);
            MessageBox.Show("Cuenta actualizada");
            cargarGrillaCuenta();
            limpiar();
            editarCuenta(false);
        }

        private void btnEliminarCuent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar esta cuenta?"
               , "ELIMINAR"
               , MessageBoxButtons.YesNo
               , MessageBoxIcon.Warning
               , MessageBoxDefaultButton.Button2)
               == DialogResult.Yes)
            {
                oCuenta.CbuCuenta = Convert.ToInt32(txtCBUCuenta.Text);
                if (dbHelperDao.obtenerInstancia().elimCuenta("EliminarCuent", oCuenta))
                {
                    MessageBox.Show("Cuenta eliminada");
                    cargarGrillaCuenta();
                    limpiar();
                    editarCuenta(false);
                }
                else
                {
                    MessageBox.Show("no se pudo eliminar, ingrese nuevamente en la ventana de altas e intente nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Dispose();
                }

            }
        }
        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de deshabilitar esta cuenta?"
               , "DESHABILITAR"
               , MessageBoxButtons.YesNo
               , MessageBoxIcon.Warning
               , MessageBoxDefaultButton.Button2)
               == DialogResult.Yes)
            {
                oCuenta.CbuCuenta = Convert.ToInt32(txtCBUCuenta.Text);
                dbHelperDao.obtenerInstancia().elimCuenta("BajaLog", oCuenta);
                MessageBox.Show("Cuenta deshabilitada");
                cargarGrillaCuenta();
                limpiar();
                editarCuenta(false);
            }
        }
        #endregion

        #region botones
        private void btnNuevoClient_Click(object sender, EventArgs e)
        {
            nuevoCliente(true);
            txtCBU2.Focus();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            editarCliente(true);
            txtDniCliente.Focus();
        }

        private void btnEditCuent_Click(object sender, EventArgs e)
        {
            editarCuenta(true);
            txtCBUCuenta.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitar(false);
            btnNuevoClient.Enabled = true;
            btnEditCuent.Enabled = true;
            btnEditClient.Enabled = true;
            limpiar();
        }
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

        #endregion


    }
}
