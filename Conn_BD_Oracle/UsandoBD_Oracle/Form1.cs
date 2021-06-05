using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsandoBD_Oracle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cliente = new frmCadastroCliente();
            cliente.Show();
        }

        private void manutençãoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManCliente manu = new frmManCliente();
            manu.Show();
        }
    }
}
