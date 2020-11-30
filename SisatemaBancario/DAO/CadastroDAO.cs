using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SisatemaBancario.DAO
{
    class CadastroDAO
    {
        private MySqlConnection con;
        private Connection.Connection connection;

        public void cadastraCliente(long CPF, string nome, string senha)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            String query = "CALL cadastraCliente(?CPF, ?Nome, ?Senha);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("?CPF", CPF);
                command.Parameters.AddWithValue("?Nome", nome);
                command.Parameters.AddWithValue("?Senha", senha);
                command.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
                try
                {
                    con.Open();
                    int conta;

                    string queryGetConta = "SELECT Conta FROM clientes WHERE CPF = ?CPF;";

                    MySqlCommand command2 = new MySqlCommand(queryGetConta, con);
                    command2.Parameters.AddWithValue("?CPF", CPF);
                    command2.ExecuteNonQuery();
                    command2.Dispose();

                    MySqlDataReader MySqlDR2 = command2.ExecuteReader();
                    MySqlDR2.Read();

                    conta = Convert.ToInt32(MySqlDR2.GetString(0));

                    MessageBox.Show("Cadastro concluído com sucesso! Sua conta é: " + conta);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
