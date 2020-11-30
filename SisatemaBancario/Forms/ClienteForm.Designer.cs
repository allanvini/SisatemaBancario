namespace SisatemaBancario.Forms
{
    partial class ClienteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblPoupanca = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbValorTED = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTEDCC = new System.Windows.Forms.TextBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.btnDepositoPoupanca = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txbValorDepositoPoupanca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnResgatarPoupanca = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbValorResgatePoupanca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblContaCorrente = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txbValorSaque = new System.Windows.Forms.TextBox();
            this.btnSacarDinheiro = new System.Windows.Forms.Button();
            this.btnDepositarDinheiro = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txbValorDepositoCC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(101, 86);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 39);
            this.lblSaldo.TabIndex = 1;
            // 
            // lblPoupanca
            // 
            this.lblPoupanca.AutoSize = true;
            this.lblPoupanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoupanca.Location = new System.Drawing.Point(342, 86);
            this.lblPoupanca.Name = "lblPoupanca";
            this.lblPoupanca.Size = new System.Drawing.Size(0, 39);
            this.lblPoupanca.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Poupança";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(175, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 39);
            this.lblUsuario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trasferir para outra CC";
            // 
            // txbValorTED
            // 
            this.txbValorTED.Location = new System.Drawing.Point(65, 167);
            this.txbValorTED.Name = "txbValorTED";
            this.txbValorTED.Size = new System.Drawing.Size(110, 20);
            this.txbValorTED.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CC";
            // 
            // txbTEDCC
            // 
            this.txbTEDCC.Location = new System.Drawing.Point(65, 193);
            this.txbTEDCC.Name = "txbTEDCC";
            this.txbTEDCC.Size = new System.Drawing.Size(110, 20);
            this.txbTEDCC.TabIndex = 8;
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(65, 219);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(110, 23);
            this.btnTransferir.TabIndex = 10;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // btnDepositoPoupanca
            // 
            this.btnDepositoPoupanca.Location = new System.Drawing.Point(566, 219);
            this.btnDepositoPoupanca.Name = "btnDepositoPoupanca";
            this.btnDepositoPoupanca.Size = new System.Drawing.Size(110, 23);
            this.btnDepositoPoupanca.TabIndex = 16;
            this.btnDepositoPoupanca.Text = "Transferir";
            this.btnDepositoPoupanca.UseVisualStyleBackColor = true;
            this.btnDepositoPoupanca.Click += new System.EventHandler(this.btnDepositoPoupanca_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(529, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valor";
            // 
            // txbValorDepositoPoupanca
            // 
            this.txbValorDepositoPoupanca.Location = new System.Drawing.Point(566, 170);
            this.txbValorDepositoPoupanca.Name = "txbValorDepositoPoupanca";
            this.txbValorDepositoPoupanca.Size = new System.Drawing.Size(110, 20);
            this.txbValorDepositoPoupanca.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(551, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Depositar na conta poupança";
            // 
            // btnResgatarPoupanca
            // 
            this.btnResgatarPoupanca.Location = new System.Drawing.Point(742, 219);
            this.btnResgatarPoupanca.Name = "btnResgatarPoupanca";
            this.btnResgatarPoupanca.Size = new System.Drawing.Size(110, 23);
            this.btnResgatarPoupanca.TabIndex = 20;
            this.btnResgatarPoupanca.Text = "Resgatar";
            this.btnResgatarPoupanca.UseVisualStyleBackColor = true;
            this.btnResgatarPoupanca.Click += new System.EventHandler(this.btnResgatarPoupanca_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(705, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Valor";
            // 
            // txbValorResgatePoupanca
            // 
            this.txbValorResgatePoupanca.Location = new System.Drawing.Point(742, 170);
            this.txbValorResgatePoupanca.Name = "txbValorResgatePoupanca";
            this.txbValorResgatePoupanca.Size = new System.Drawing.Size(110, 20);
            this.txbValorResgatePoupanca.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(739, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Resgatar da poupança";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Conta:";
            // 
            // lblContaCorrente
            // 
            this.lblContaCorrente.AutoSize = true;
            this.lblContaCorrente.Location = new System.Drawing.Point(108, 52);
            this.lblContaCorrente.Name = "lblContaCorrente";
            this.lblContaCorrente.Size = new System.Drawing.Size(0, 13);
            this.lblContaCorrente.TabIndex = 22;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(227, 259);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 38);
            this.btnSair.TabIndex = 23;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(65, 259);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(110, 38);
            this.btnAtualizar.TabIndex = 24;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(224, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Sacar dinheiro da conta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(189, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Valor";
            // 
            // txbValorSaque
            // 
            this.txbValorSaque.Location = new System.Drawing.Point(226, 170);
            this.txbValorSaque.Name = "txbValorSaque";
            this.txbValorSaque.Size = new System.Drawing.Size(110, 20);
            this.txbValorSaque.TabIndex = 26;
            // 
            // btnSacarDinheiro
            // 
            this.btnSacarDinheiro.Location = new System.Drawing.Point(227, 219);
            this.btnSacarDinheiro.Name = "btnSacarDinheiro";
            this.btnSacarDinheiro.Size = new System.Drawing.Size(110, 23);
            this.btnSacarDinheiro.TabIndex = 28;
            this.btnSacarDinheiro.Text = "Sacar";
            this.btnSacarDinheiro.UseVisualStyleBackColor = true;
            this.btnSacarDinheiro.Click += new System.EventHandler(this.btnSacarDinheiro_Click);
            // 
            // btnDepositarDinheiro
            // 
            this.btnDepositarDinheiro.Location = new System.Drawing.Point(397, 219);
            this.btnDepositarDinheiro.Name = "btnDepositarDinheiro";
            this.btnDepositarDinheiro.Size = new System.Drawing.Size(110, 23);
            this.btnDepositarDinheiro.TabIndex = 32;
            this.btnDepositarDinheiro.Text = "Depositar";
            this.btnDepositarDinheiro.UseVisualStyleBackColor = true;
            this.btnDepositarDinheiro.Click += new System.EventHandler(this.btnDepositarDinheiro_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(359, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Valor";
            // 
            // txbValorDepositoCC
            // 
            this.txbValorDepositoCC.Location = new System.Drawing.Point(396, 170);
            this.txbValorDepositoCC.Name = "txbValorDepositoCC";
            this.txbValorDepositoCC.Size = new System.Drawing.Size(110, 20);
            this.txbValorDepositoCC.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(379, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Depositar na conta corrente";
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 309);
            this.Controls.Add(this.btnDepositarDinheiro);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbValorDepositoCC);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSacarDinheiro);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txbValorSaque);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblContaCorrente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnResgatarPoupanca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbValorResgatePoupanca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDepositoPoupanca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbValorDepositoPoupanca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbTEDCC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbValorTED);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblPoupanca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ClienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel do cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblPoupanca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbValorTED;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTEDCC;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Button btnDepositoPoupanca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbValorDepositoPoupanca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnResgatarPoupanca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbValorResgatePoupanca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblContaCorrente;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbValorSaque;
        private System.Windows.Forms.Button btnSacarDinheiro;
        private System.Windows.Forms.Button btnDepositarDinheiro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbValorDepositoCC;
        private System.Windows.Forms.Label label14;
    }
}