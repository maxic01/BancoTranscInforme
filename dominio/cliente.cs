using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoTransacc.dominio
{
    internal class cliente
    {
        public cliente()
        {
            Cbu = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Dni = 0;

        }

        public cliente(int cbu, int dni, string nombre, string apellido)
        {
            Cbu = cbu;
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
        }

        public int Cbu { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public override string ToString()
        {
            return Nombre + " " + Apellido + " " + Cbu + " " + Dni;
        }

    }
}
