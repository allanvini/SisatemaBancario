using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisatemaBancario
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void clearFields()
        {
            txbConta.Text = "";
            txbSenha.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Models.Login login = new Models.Login();

            login.Conta = txbConta.Text;
            login.Senha = txbSenha.Text;

            if (login.verifyLogin())
            {
                this.Hide();
                Forms.ClienteForm clienteForm = new Forms.ClienteForm(txbConta.Text);
                clienteForm.ShowDialog();

            } else
            {
                MessageBox.Show("Email ou senha incorreto", "Erro ao autenticar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearFields();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Forms.CadastroForm cadastroForm = new Forms.CadastroForm();
            cadastroForm.ShowDialog();
        }

        private void btnGerenteLogin_Click(object sender, EventArgs e)
        {
            Forms.LoginGerente loginGerengteForm = new Forms.LoginGerente();
            loginGerengteForm.ShowDialog();
        }
    }
}
