using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Banco
{
    internal class TipoCuenta
    {
        public string NombreTipo { get; set; }
        public override string ToString()
        {
            return NombreTipo;
        }
    }
}
