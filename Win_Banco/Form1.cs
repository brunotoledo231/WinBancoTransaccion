using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Banco
{
    public partial class frmCuentas : Form
    {
        private HelperBd conexion;
        private Cuenta cuentas;
        public frmCuentas()
        {
            InitializeComponent();
            conexion=new HelperBd();
            CargarCombos(v);
        }

        private void CargarCombos()
        {
            DataTable tabla = conexion.ConsultarBd("SP_LISTAR_CLIENTES");


        }
    }
}
