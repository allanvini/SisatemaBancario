using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SisatemaBancario.DAO
{
    class LoginDAO
    {
        private MySqlConnection con;
        private Connection.Connection connection;

        public Boolean verifyLogin(String conta, String senha)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            String query = "CALL getLoginInfo(?conta, ?senha)";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?conta", conta);
                command.Parameters.AddWithValue("?senha", senha);

                MySqlDataReader MySqlDR = command.ExecuteReader();
                return MySqlDR.Read();
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean loginGerente(long CPF, string Senha)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            string query = "CALL loginGerente(?CPF, ?Senha);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?CPF", CPF);
                command.Parameters.AddWithValue("?Senha", Senha);

                MySqlDataReader MySqlDR = command.ExecuteReader();
                return MySqlDR.Read();
            }
            finally
            {
                con.Close();
            }
        }

    }
}
