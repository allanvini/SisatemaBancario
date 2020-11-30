using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SisatemaBancario.Forms
{
    public partial class ClienteForm : Form
    {

        

        public ClienteForm()
        {
            InitializeComponent();
        }

        public ClienteForm(String ID)
        {
            InitializeComponent();

            lblContaCorrente.Text = ID;
            getAllData();
        }

        public void getAllData()
        {
            int contaConrrente = Convert.ToInt32(lblContaCorrente.Text);

            Models.Cliente cliente = new Models.Cliente();

            cliente.ContaCorrente = contaConrrente;

            cliente.getData();

            lblUsuario.Text = cliente.Nome;
            lblPoupanca.Text = Convert.ToString(cliente.SaldoPoupanca);
            lblSaldo.Text = Convert.ToString(cliente.Saldo);
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            Double valor = Convert.ToDouble(txbValorTED.Text);
            int CC = Convert.ToInt32(txbTEDCC.Text);
            int CCInicial = Convert.ToInt32(lblContaCorrente.Text);

            Models.Cliente cliente = new Models.Cliente();


            cliente.ValorTransferencia = valor;
            cliente.ContaDestino = CC;
            cliente.ContaCorrente = CCInicial;

            cliente.transferirDinheiro();

            clearFields();
            getAllData();
        }

        private void clearFields()
        {
            txbValorTED.Text = "";
            txbTEDCC.Text = "";
            txbValorDepositoPoupanca.Text = "";
            txbValorResgatePoupanca.Text = "";
            txbValorSaque.Text = "";
            txbValorDepositoCC.Text = "";
        }

        private void btnDepositoPoupanca_Click(object sender, EventArgs e)
        {
            int ContaCorrente = Convert.ToInt32(lblContaCorrente.Text);
            double valorDeposito = Convert.ToDouble(txbValorDepositoPoupanca.Text);

            Models.Cliente cliente = new Models.Cliente();

            cliente.ContaCorrente = ContaCorrente;
            cliente.ValorDeposito = valorDeposito;

            cliente.depositarPoupanca();

            clearFields();
            getAllData();
        }

        private void btnResgatarPoupanca_Click(object sender, EventArgs e)
        {
            int ContaCorrente = Convert.ToInt32(lblContaCorrente.Text);
            double valorResgate = Convert.ToDouble(txbValorResgatePoupanca.Text);

            Models.Cliente cliente = new Models.Cliente();

            cliente.ContaCorrente = ContaCorrente;
            cliente.ValorResgate = valorResgate;

            cliente.resgatarPoupanca();

            clearFields();
            getAllData();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            getAllData();
        }

        private void btnSacarDinheiro_Click(object sender, EventArgs e)
        {
            double valorSaque = Convert.ToDouble(txbValorSaque.Text);
            int ContaCorrente = Convert.ToInt32(lblContaCorrente.Text);

            Models.Cliente cliente = new Models.Cliente();

            cliente.ValorSaque = valorSaque;
            cliente.ContaCorrente = ContaCorrente;

            cliente.sacarContaCorrente();

            getAllData();
            clearFields();
        }

        private void btnDepositarDinheiro_Click(object sender, EventArgs e)
        {
            double valorDeposito = Convert.ToDouble(txbValorDepositoCC.Text);
            int ContaCorrente = Convert.ToInt32(lblContaCorrente.Text);

            Models.Cliente cliente = new Models.Cliente();

            cliente.ValorDeposito = valorDeposito;
            cliente.ContaCorrente = ContaCorrente;

            cliente.depositarContaCorrente();
            getAllData();
            clearFields();
        }
    }
}
