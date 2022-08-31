using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Banco
{
    internal class Cuenta
    {
        public int Cbu { get; set; }
        public decimal Saldo { get; set; }
        public TipoCuenta Tipo { get; set; }
        public DateTime UltimoMovimiento { get; set; }
        public Cuenta(int cbu, decimal saldo, TipoCuenta tipo, DateTime ultimoMovimiento)
        {
            Cbu = cbu;
            Saldo = saldo;
            Tipo = tipo;
            UltimoMovimiento = ultimoMovimiento;
        }

    }
}
