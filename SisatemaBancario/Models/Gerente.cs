using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisatemaBancario.Models
{
    class Gerente
    {
        private long CPF;
        private string Senha;
        private string Nome;
        private double TaxaJuros;
        private DAO.LoginDAO ldao;
        private DAO.GerenteDAO gdao;

        public long CPF1 { get => CPF; set => CPF = value; }
        public string Senha1 { get => Senha; set => Senha = value; }
        public string Nome1 { get => Nome; set => Nome = value; }
        public double TaxaJuros1 { get => TaxaJuros; set => TaxaJuros = value; }

        public Boolean loginGerente()
        {
            ldao = new DAO.LoginDAO();
            ldao.loginGerente(CPF, Senha);

            return ldao.loginGerente(CPF, Senha);
        }

        public void getAllData()
        {
            gdao = new DAO.GerenteDAO();

            gdao.getData(CPF);

            this.CPF = gdao.CPF1;
            this.Nome = gdao.Nome1;
            this.TaxaJuros = gdao.TaxaJuros1;
        }

        public void getData()
        {
            gdao = new DAO.GerenteDAO();

            gdao.getData(this.CPF);
        }

        public void aplicaJuros()
        {
            gdao = new DAO.GerenteDAO();

            gdao.aplicaJuros(CPF);
        }

        public void alteraRendimento()
        {
            gdao = new DAO.GerenteDAO();

            gdao.alteraRendinento(CPF, TaxaJuros);
        }
    }
}
