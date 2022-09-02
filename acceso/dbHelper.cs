using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BancoTransacc.dominio;

namespace BancoTransacc.acceso
{
    internal class dbHelper
    {
        SqlConnection conexion;
        SqlCommand comando;
        

        public dbHelper()
        {
            conexion = new SqlConnection(Properties.Resources.cnnString);
            comando = new SqlCommand();
        }
        private void conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }
        private void desconectar()
        {
            conexion.Close();
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
        public void editCliente(string SP, int dni, string nombre, string apellido)
        {
            conectar();
            comando.CommandText = SP;
            comando.Parameters.AddWithValue("@dni", SqlDbType.Int).Value = dni;
            comando.Parameters.AddWithValue("@nombre", SqlDbType.NVarChar).Value = nombre;
            comando.Parameters.AddWithValue("@apellido", SqlDbType.NVarChar).Value = apellido;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
        }
        public bool elimCliente(string SP, int dni)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = SP;
                comando.Parameters.AddWithValue("@dni", SqlDbType.Int).Value = dni;
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
        public void editCuenta(string SP, int cbuCuenta, int saldo, DateTime ultimoMovimiento)
        {
            conectar();
            comando.CommandText = SP;
            comando.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = cbuCuenta;
            comando.Parameters.AddWithValue("@saldo", SqlDbType.Money).Value = saldo;
            comando.Parameters.AddWithValue("@ultimo_movimiento", SqlDbType.DateTime).Value = ultimoMovimiento;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
        }
        public bool elimCuenta(string SP, int cbuCuenta)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = SP;
                comando.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = cbuCuenta;
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
        public void inhabilitarCuenta(string SP, int cbuCuenta)
        {
            conectar();
            comando.CommandText= SP;
            comando.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = cbuCuenta;
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
        
        public bool altaCliente(string InsertCuenta, string InsertCliente, int cbuCuenta, int saldo, int tipoCuenta, DateTime ultimoMovimiento, int dni, string nombre, string apellido, int cbuCliente)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = InsertCuenta;
                comando.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = cbuCuenta;
                comando.Parameters.AddWithValue("@saldo", SqlDbType.Money).Value = saldo;
                comando.Parameters.AddWithValue("@cod_cuenta", SqlDbType.Int).Value = tipoCuenta;
                comando.Parameters.AddWithValue("@ultimo_movimiento", SqlDbType.DateTime).Value = ultimoMovimiento;
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                comando.CommandText = InsertCliente;
                comando.Parameters.AddWithValue("@dni", SqlDbType.Int).Value = dni;
                comando.Parameters.AddWithValue("@nombre", SqlDbType.NVarChar).Value = nombre;
                comando.Parameters.AddWithValue("@apellido", SqlDbType.NVarChar).Value = apellido;
                comando.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = cbuCliente;
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
