using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciocioNota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                StreamWriter sw = new StreamWriter(@"D:\pets.txt", true);

                sw.WriteLine(txtNome.Text + ", " + txtPeso.Text + ", " + txtRaca.Text + ", " + txtTamanho.Text + ", " + txtIdade.Text);
                sw.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
