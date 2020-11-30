using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisatemaBancario.Forms
{
    public partial class LoginGerente : Form
    {
        public LoginGerente()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Models.Gerente gerente = new Models.Gerente();

            gerente.CPF1 = Convert.ToInt64(txbCPF.Text);
            gerente.Senha1 = txbSenha.Text;

            if (gerente.loginGerente() != false)
            {
                this.Hide();
                gerente.getAllData();
                Forms.GerenteForm gerenteForm = new Forms.GerenteForm(gerente.Nome1, gerente.TaxaJuros1, gerente.CPF1);
                gerenteForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ou senha incorreto", "Erro ao autenticar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearFields();
            }
        }

        private void clearFields()
        {
            txbCPF.Text = "";
            txbSenha.Text = "";
        }
    }
}
