using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoTransacc.dominio
{
    internal class cuenta
    {

        public cuenta()
        {
            CbuCuenta = 0;
            Saldo = 0;
            UltimoMovimiento = DateTime.Today;
            TipoCuenta = 0;
        }

        public cuenta(int cbuCuenta, double saldo, DateTime ultimoMovimiento, int tipoCuenta)
        {
            CbuCuenta = cbuCuenta;
            Saldo = saldo;
            UltimoMovimiento = ultimoMovimiento;
            TipoCuenta = tipoCuenta;
        }

        public int CbuCuenta { get; set; }
        public double Saldo { get; set; }
        public DateTime UltimoMovimiento { get; set; }
        public int TipoCuenta { get; set; }
        public override string ToString()
        {
            return CbuCuenta + " " + Saldo + " " + UltimoMovimiento + " " + TipoCuenta;
        }

    }
}
