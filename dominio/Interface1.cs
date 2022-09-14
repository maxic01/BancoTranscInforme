using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BancoTransacc.dominio;

namespace BancoTransacc.presentacion
{
    internal interface Interface1
    {
        DataTable consultarDB(string SP);
        void editCliente(string SP, clienteDTO Cliente);
        bool elimCliente(string SP, clienteDTO Cliente);
        void editCuenta(string SP, cuentaDTO Cuenta);
        bool elimCuenta(string SP, cuentaDTO Cuenta);
        bool altaCliente (string InsertCuenta, string InsertCliente ,cuentaDTO Cuenta, clienteDTO Cliente);

    }
}
