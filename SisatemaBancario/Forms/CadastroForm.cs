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
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txbNome.Text;
            long CPF = Convert.ToInt64(txbCPF.Text);
            string Senha = txbSenha.Text;

            Models.Cadastro cadastro = new Models.Cadastro();

            cadastro.Nome = nome;
            cadastro.CPF1 = CPF;
            cadastro.Senha = Senha;

            cadastro.cadastraCliente();

            this.Close();
        }
    }
}
