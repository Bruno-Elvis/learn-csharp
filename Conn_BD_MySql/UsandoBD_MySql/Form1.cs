using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsandoBD_MySql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=si5;Uid=root;Pwd=root");

            try
            {
                //Abrindo a conexão com banco de dados;
                conn.Open();
                //Montando uma string de comando (inserção)
                string sCommand = "INSERT INTO CLIENTE (NOME,ENDERECO,TELEFONE,EMAIL,OBSERVACOES) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + maskedTextBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";

                //Criando o objeto Command que encapsula o comando sql e a conexão como parãmetro.
                MySqlCommand command = new MySqlCommand(sCommand, conn);

                //Executar commando
                // O método ExecuteNonQuery
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
            finally {

                conn.Close();
            }
        }
    }
}
