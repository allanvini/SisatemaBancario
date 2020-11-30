using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SisatemaBancario.DAO
{
    class ClienteDAO
    {
        private MySqlConnection con;
        private Connection.Connection connection;

        private string nome;
        private double saldo;
        private double saldoPoupanca;

        public string Nome { get => nome; set => nome = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public double SaldoPoupanca { get => saldoPoupanca; set => saldoPoupanca = value; }

        public void getData(int CC)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            String query = "CALL getUserData(?CC);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("?CC", CC);
                command.ExecuteNonQuery();
                command.Dispose();

                MySqlDataReader MySqlDR = command.ExecuteReader();
                MySqlDR.Read();
                
                this.Nome = MySqlDR.GetString(0);
                this.Saldo = Convert.ToDouble(MySqlDR.GetString(1));
                this.SaldoPoupanca = Convert.ToDouble(MySqlDR.GetString(2));
            }
            finally
            {
                con.Close();
            }
        }


        public void transferirDinheiro(int ccInicial, int ccDestino, Double valor)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            String query = "CALL transferMoney(?CCInicial, ?CCDestino, ?Valor);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("?CCInicial", ccInicial);
                command.Parameters.AddWithValue("?CCDestino", ccDestino);
                command.Parameters.AddWithValue("?Valor", valor);
                command.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }


        public void depositarPoupanca(int CC, double valor)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            String query = "CALL depositaPoupanca(?CC,?valor);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("?CC", CC);
                command.Parameters.AddWithValue("?valor", valor);
                command.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }





        public void resgatarPoupanca(int CC, double valor)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            String query = "CALL resgataPoupanca(?CC,?valor);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("?CC", CC);
                command.Parameters.AddWithValue("?valor", valor);
                command.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }


        public void sacarContaCorrente(int CC, double valor)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            string query = "CALL sacarDinheiro(?CC, ?valor);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("?CC", CC);
                command.Parameters.AddWithValue("?valor", valor);
                command.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void depositarContaCorrente(int CC, double valor)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            string query = "CALL depositarDinheiro(?CC, ?valor);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("?CC", CC);
                command.Parameters.AddWithValue("?valor", valor);
                command.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
