using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisatemaBancario.Models
{
    class Cadastro
    {
        private long CPF;
        private string nome;
        private string senha;

        public long CPF1 { get => CPF; set => CPF = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }

        public void cadastraCliente()
        {
            DAO.CadastroDAO cadDAO = new DAO.CadastroDAO();
            cadDAO.cadastraCliente(CPF1,Nome,Senha);
        }

    }
}
