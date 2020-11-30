using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SisatemaBancario.DAO
{
    class GerenteDAO
    {

        private long CPF;
        private string Nome;
        private double TaxaJuros;

        private MySqlConnection con;
        private Connection.Connection connection;

        public long CPF1 { get => CPF; set => CPF = value; }
        public string Nome1 { get => Nome; set => Nome = value; }
        public double TaxaJuros1 { get => TaxaJuros; set => TaxaJuros = value; }

        public void getAllData(long CPF, string Senha)
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
                command.ExecuteNonQuery();
                command.Dispose();

                MySqlDataReader MySqlDR = command.ExecuteReader();

                MySqlDR.Read();
                this.CPF1 = Convert.ToInt64(MySqlDR.GetString(0));
                this.Nome1 = MySqlDR.GetString(1);
                this.TaxaJuros1 = Convert.ToDouble(MySqlDR.GetString(2));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: "+ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void getData(long CPF)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            string query = "CALL getGerenteData(?CPF);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?CPF", CPF);
                command.ExecuteNonQuery();
                command.Dispose();

                MySqlDataReader MySqlDR = command.ExecuteReader();

                MySqlDR.Read();
                this.CPF1 = Convert.ToInt64(MySqlDR.GetString(0));
                this.Nome1 = MySqlDR.GetString(1);
                this.TaxaJuros1 = Convert.ToDouble(MySqlDR.GetString(2));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void aplicaJuros(long CPF)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            string query = "CALL aplicaJuros(?CPF);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("?CPF", CPF);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                con.Close();
                MessageBox.Show("Juros aplicados com sucesso!", "Sucesso!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void alteraRendinento(long CPF, double valor)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            string query = "CALL alteraRendimento(?CPF, ?valor);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("?CPF",CPF);
                command.Parameters.AddWithValue("?valor", valor);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
