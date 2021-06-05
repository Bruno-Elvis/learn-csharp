using Oracle.DataAccess.Client;
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
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Criando um objeto de conexão com o banco de dados;
            OracleConnection conn = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));User ID=system;Password=admin;");
            try
            {
               //abrindo a conexão com banco de dados;
                conn.Open();

                //Montando uma string de comando (inserção)
                string sCommand = "INSERT INTO CLIENTE (NOME,ENDERECO,TELEFONE,EMAIL,OBSERVACOES) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + maskedTextBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";

                //Criando o objeto Command que encapsula o comando sql e a conexão como parãmetro.
                OracleCommand command = new OracleCommand(sCommand, conn);

                //Executar commando
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro:. " + ex.Message);
            }
            finally {
                conn.Close();

            }
           
        }
    }
}
