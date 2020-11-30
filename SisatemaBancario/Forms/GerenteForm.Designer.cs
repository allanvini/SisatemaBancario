namespace SisatemaBancario.Forms
{
    partial class GerenteForm
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
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTaxaJuros = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNovoJuros = new System.Windows.Forms.TextBox();
            this.btnAlterarTaxa = new System.Windows.Forms.Button();
            this.btnAplicarJuros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(23, 10);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 33);
            this.lblNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taxa de Juros:";
            // 
            // lblTaxaJuros
            // 
            this.lblTaxaJuros.AutoSize = true;
            this.lblTaxaJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxaJuros.Location = new System.Drawing.Point(146, 67);
            this.lblTaxaJuros.Name = "lblTaxaJuros";
            this.lblTaxaJuros.Size = new System.Drawing.Size(0, 25);
            this.lblTaxaJuros.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alterar taxa de juros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nova taxa:";
            // 
            // txbNovoJuros
            // 
            this.txbNovoJuros.Location = new System.Drawing.Point(110, 210);
            this.txbNovoJuros.Name = "txbNovoJuros";
            this.txbNovoJuros.Size = new System.Drawing.Size(100, 20);
            this.txbNovoJuros.TabIndex = 5;
            // 
            // btnAlterarTaxa
            // 
            this.btnAlterarTaxa.Location = new System.Drawing.Point(217, 206);
            this.btnAlterarTaxa.Name = "btnAlterarTaxa";
            this.btnAlterarTaxa.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarTaxa.TabIndex = 6;
            this.btnAlterarTaxa.Text = "Alterar taxa";
            this.btnAlterarTaxa.UseVisualStyleBackColor = true;
            this.btnAlterarTaxa.Click += new System.EventHandler(this.btnAlterarTaxa_Click);
            // 
            // btnAplicarJuros
            // 
            this.btnAplicarJuros.Location = new System.Drawing.Point(100, 107);
            this.btnAplicarJuros.Name = "btnAplicarJuros";
            this.btnAplicarJuros.Size = new System.Drawing.Size(126, 55);
            this.btnAplicarJuros.TabIndex = 7;
            this.btnAplicarJuros.Text = "Aplicar Juros!";
            this.btnAplicarJuros.UseVisualStyleBackColor = true;
            this.btnAplicarJuros.Click += new System.EventHandler(this.btnAplicarJuros_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "CPF:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(48, 54);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(0, 13);
            this.lblCPF.TabIndex = 9;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(122, 253);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // GerenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 287);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAplicarJuros);
            this.Controls.Add(this.btnAlterarTaxa);
            this.Controls.Add(this.txbNovoJuros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTaxaJuros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GerenteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área do gerente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTaxaJuros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNovoJuros;
        private System.Windows.Forms.Button btnAlterarTaxa;
        private System.Windows.Forms.Button btnAplicarJuros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btnSair;
    }
}