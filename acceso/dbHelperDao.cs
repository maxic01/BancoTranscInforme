using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BancoTransacc.dominio;
using BancoTransacc.presentacion;

namespace BancoTransacc.acceso
{
    internal class dbHelperDao : dbHelperConexion, Interface1
    {
        private static dbHelperDao instancia;

        public static dbHelperDao obtenerInstancia()
        {
            if (instancia == null)
                instancia = new dbHelperDao();
            return instancia;
        }

        public DataTable consultarDB(string SP)
        {
            conectar();
            comando.CommandText = SP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        #region editar/eliminar cliente
        public void editCliente(string SP, clienteDTO Cliente)
        {
            conectar();
            comando.CommandText = SP;
            comando.Parameters.AddWithValue("@dni", SqlDbType.Int).Value = Cliente.Dni;
            comando.Parameters.AddWithValue("@nombre", SqlDbType.NVarChar).Value = Cliente.Nombre;
            comando.Parameters.AddWithValue("@apellido", SqlDbType.NVarChar).Value = Cliente.Apellido;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
        }
        public bool elimCliente(string SP, clienteDTO Cliente)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = SP;
                comando.Parameters.AddWithValue("@dni", SqlDbType.Int).Value = Cliente.Dni;
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                ok = false;

            }
            finally
            {
                desconectar();
            }
            return ok;

        }
        #endregion

        #region editar/eliminar cuenta
        public void editCuenta(string SP, cuentaDTO Cuenta)
        {
            conectar();
            comando.CommandText = SP;
            comando.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = Cuenta.CbuCuenta;
            comando.Parameters.AddWithValue("@saldo", SqlDbType.Money).Value = Cuenta.Saldo;
            comando.Parameters.AddWithValue("@ultimo_movimiento", SqlDbType.DateTime).Value = Cuenta.UltimoMovimiento;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
        }
        public bool elimCuenta(string SP, cuentaDTO Cuenta)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = SP;
                comando.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = Cuenta.CbuCuenta;
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                t.Commit();

            }
            catch (Exception)
            {

                t.Rollback();
                ok = false;
            }
            finally
            {
                desconectar();
            }
            return ok;

        }
        public void inhabilitarCuenta(string SP, cuentaDTO Cuenta)
        {
            conectar();
            comando.CommandText = SP;
            comando.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = Cuenta.CbuCuenta;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
        }
        public void habilitarCuenta(string SP, int cbuCuenta)
        {
            conectar();
            comando.CommandText = SP;
            comando.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = cbuCuenta;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
        }
        #endregion

        public bool altaCliente(string InsertCuenta, string InsertCliente, cuentaDTO Cuenta, clienteDTO Cliente)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = InsertCuenta;
                comando.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = Cuenta.CbuCuenta;
                comando.Parameters.AddWithValue("@saldo", SqlDbType.Money).Value = Cuenta.Saldo;
                comando.Parameters.AddWithValue("@cod_cuenta", SqlDbType.Int).Value = Cuenta.TipoCuenta;
                comando.Parameters.AddWithValue("@ultimo_movimiento", SqlDbType.DateTime).Value = Cuenta.UltimoMovimiento;
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                comando.CommandText = InsertCliente;
                comando.Parameters.AddWithValue("@dni", SqlDbType.Int).Value = Cliente.Dni;
                comando.Parameters.AddWithValue("@nombre", SqlDbType.NVarChar).Value = Cliente.Nombre;
                comando.Parameters.AddWithValue("@apellido", SqlDbType.NVarChar).Value = Cliente.Apellido;
                comando.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = Cliente.Cbu;
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                ok = false;

            }
            finally
            {
                desconectar();
            }
            return ok;
        }

    }
}
