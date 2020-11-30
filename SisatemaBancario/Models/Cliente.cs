using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisatemaBancario.Models
{
    class Cliente
    {
        private int contaCorrente;
        private String nome;
        private Double saldo;
        private Double saldoPoupanca;

        private Double valorTransferencia;
        private int contaDestino;
        private Double valorDeposito;
        private Double valorResgate;

        private double valorSaque;

        public int ContaCorrente { get => contaCorrente; set => contaCorrente = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public double SaldoPoupanca { get => saldoPoupanca; set => saldoPoupanca = value; }
        public double ValorTransferencia { get => valorTransferencia; set => valorTransferencia = value; }
        public int ContaDestino { get => contaDestino; set => contaDestino = value; }
        public double ValorDeposito { get => valorDeposito; set => valorDeposito = value; }
        public double ValorResgate { get => valorResgate; set => valorResgate = value; }
        public double ValorSaque { get => valorSaque; set => valorSaque = value; }

        public void getData()
        {
            DAO.ClienteDAO cdao = new DAO.ClienteDAO();
            cdao.getData(ContaCorrente);
            Nome = cdao.Nome;
            Saldo = cdao.Saldo;
            saldoPoupanca = cdao.SaldoPoupanca;
        }

        public void transferirDinheiro()
        {
            DAO.ClienteDAO cdao = new DAO.ClienteDAO();
            cdao.transferirDinheiro(contaCorrente, contaDestino, valorTransferencia);
        }

        public void depositarPoupanca()
        {
            DAO.ClienteDAO cdao = new DAO.ClienteDAO();
            cdao.depositarPoupanca(contaCorrente, valorDeposito);
        }

        public void resgatarPoupanca()
        {
            DAO.ClienteDAO cdao = new DAO.ClienteDAO();
            cdao.resgatarPoupanca(contaCorrente, valorResgate);
        }

        public void sacarContaCorrente()
        {
            DAO.ClienteDAO cdao = new DAO.ClienteDAO();

            cdao.sacarContaCorrente(contaCorrente, valorSaque);
        }

        public void depositarContaCorrente()
        {
            DAO.ClienteDAO cdao = new DAO.ClienteDAO();

            cdao.depositarContaCorrente(contaCorrente, valorDeposito);
        }
    }
}
