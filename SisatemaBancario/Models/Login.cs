using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SisatemaBancario.Models
{
    class Login
    {
        private String conta;
        private String senha;
        private DAO.LoginDAO ldao;

        public string Conta { get => conta; set => conta = value; }
        public string Senha { get => senha; set => senha = value; }

        public Boolean verifyLogin()
        {
            ldao = new DAO.LoginDAO();
            return ldao.verifyLogin(conta, senha);
        }
    }
}
