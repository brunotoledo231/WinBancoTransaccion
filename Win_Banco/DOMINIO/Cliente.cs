using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Banco
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public List<Cuenta> Cuentas { get; set; }
        

        public Cliente (string nombre, string apellido, int dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Cuentas = new List<Cuenta> ();
        }
        public override string ToString()
        {
            return "Nombre: "+Nombre + " Apellido: " + Apellido + " Dni: " + Dni;
        }
    }
}
