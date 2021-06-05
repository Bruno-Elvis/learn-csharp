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
    public partial class frmManCliente : Form
    {
        public frmManCliente()
        {
            InitializeComponent();
        }

        private void frmManCliente_Load(object sender, EventArgs e)
        {
            RecarregaGrid();         

        }

        private void RecarregaGrid()
        {
            //Limpa o data Grid
            dataGridView1.Rows.Clear();

            //Criando um objeto de conexão com o banco de dados;
             

            //Criando um objeto Reader;
            OracleDataReader oraReader = null;

            //Montando o SQL de consulta que preenchera o grid;
            string sCommand = "SELECT ID,NOME,ENDERECO,TELEFONE,EMAIL,OBSERVACOES FROM CLIENTE";

            OracleCommand command = new OracleCommand(sCommand, conn);
            oraReader = command.ExecuteReader();

            if (oraReader.HasRows == false)
            {
                MessageBox.Show("Não há registros.");
                return;
            }


            //Percorrendo a consulta
            while (oraReader.Read())
            {

                object[] valores = new object[oraReader.FieldCount];

                for (int i = 0; i < oraReader.FieldCount; i++)
                {
                    valores[i] = oraReader.GetValue(i);
                }

                dataGridView1.Rows.Add(valores);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pegando o código da linha selecionada.
            int codigo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //
            //Criando um objeto de conexão com o banco de dados;
            OracleConnection conn = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));User ID=system;Password=admin;");
            try
            {
                //abrindo a conexão com banco de dados;
                conn.Open();

                //Montando uma string de comando (inserção)
                string sCommand = "UPDATE CLIENTE SET NOME='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "',ENDERECO='" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "',TELEFONE='" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "',EMAIL='" + dataGridView1.CurrentRow.Cells[4].Value.ToString() + "',OBSERVACOES='" + dataGridView1.CurrentRow.Cells[5].Value.ToString() + "' WHERE ID = '" + codigo + "'";

                //Criando o objeto Command que encapsula o comando sql e a conexão como parãmetro.
                OracleCommand command = new OracleCommand(sCommand, conn);

                //Executar commando
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Cliente ATUALIZADO com sucesso!");
                    RecarregaGrid();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro:. " + ex.Message);
            }
            finally
            {
                conn.Close();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Pegando o código da linha selecionada.
            int codigo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //
            //Criando um objeto de conexão com o banco de dados;
            OracleConnection conn = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));User ID=system;Password=admin;");
            try
            {
                //abrindo a conexão com banco de dados;
                conn.Open();

                //Montando uma string de comando (inserção)
                string sCommand = "DELETE CLIENTE WHERE ID = '" + codigo + "'";

                //Criando o objeto Command que encapsula o comando sql e a conexão como parãmetro.
                OracleCommand command = new OracleCommand(sCommand, conn);

                //Executar commando
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Cliente DELETADO com sucesso!");
                    RecarregaGrid();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro:. " + ex.Message);
            }
            finally
            {
                conn.Close();

            }

        }
    }
}
