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
    internal class dbHelperConexion
    {
        protected SqlConnection conexion = new SqlConnection(Properties.Resources.cnnString);
        protected SqlCommand comando = new SqlCommand();
        protected void conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }
        protected void desconectar()
        {
            conexion.Close();
        }

    }
}
