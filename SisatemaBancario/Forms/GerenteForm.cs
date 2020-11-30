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
    public partial class GerenteForm : Form
    {
        public GerenteForm()
        {
            InitializeComponent();
        }

        public GerenteForm(string nome, double taxaJuros, long CPF)
        {
            InitializeComponent();

            lblNome.Text = nome;
            lblCPF.Text = Convert.ToString(CPF);
            lblTaxaJuros.Text = Convert.ToString(taxaJuros) + "%";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAplicarJuros_Click(object sender, EventArgs e)
        {
            long CPF = Convert.ToInt64(lblCPF.Text);

            Models.Gerente gerente = new Models.Gerente();

            gerente.CPF1 = CPF;

            gerente.aplicaJuros();

        }

        private void getValues()
        {
            Models.Gerente gerente = new Models.Gerente();

            gerente.CPF1 = Convert.ToInt64(lblCPF.Text);

            gerente.getAllData();

            lblTaxaJuros.Text = Convert.ToString(gerente.TaxaJuros1) + "%";
        }

        private void btnAlterarTaxa_Click(object sender, EventArgs e)
        {
            Models.Gerente gerente = new Models.Gerente();

            gerente.CPF1 = Convert.ToInt64(lblCPF.Text);
            gerente.TaxaJuros1 = Convert.ToDouble(txbNovoJuros.Text);

            gerente.alteraRendimento();

            getValues();
        }
    }
}
