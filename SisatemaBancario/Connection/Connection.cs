using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SisatemaBancario.Connection
{
    class Connection
    {
        private String connectionString;

        public String getConnectionString()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SistemaBancario.Properties.Settings.bankConnectionString"].ConnectionString;
            return connectionString;
        }
    }
}
