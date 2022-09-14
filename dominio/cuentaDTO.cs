using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoTransacc.dominio
{
    internal class cuentaDTO
    {

        public int CbuCuenta { get; set; }
        public double Saldo { get; set; }
        public DateTime UltimoMovimiento { get; set; }
        public int TipoCuenta { get; set; }

    }
}
