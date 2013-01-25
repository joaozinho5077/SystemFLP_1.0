namespace SystemFunilaria
{
    partial class Comissao_Orcamento
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
            this.cbx_Funcao = new System.Windows.Forms.ComboBox();
            this.txt_Funcionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_PesquisarFuncionario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DescricaoServico = new System.Windows.Forms.TextBox();
            this.txt_Mao_de_Obra = new System.Windows.Forms.TextBox();
            this.cbx_Situacao = new System.Windows.Forms.ComboBox();
            this.bt_Adicionar = new System.Windows.Forms.Button();
            this.listView_Comissoes = new System.Windows.Forms.ListView();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.bt_Gravar = new System.Windows.Forms.Button();
            this.txt_Porcentagem = new System.Windows.Forms.TextBox();
            this.txt_Comissao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Observacoes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_Funcao
            // 
            this.cbx_Funcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Funcao.FormattingEnabled = true;
            this.cbx_Funcao.Location = new System.Drawing.Point(12, 25);
            this.cbx_Funcao.Name = "cbx_Funcao";
            this.cbx_Funcao.Size = new System.Drawing.Size(121, 21);
            this.cbx_Funcao.TabIndex = 0;
            // 
            // txt_Funcionario
            // 
            this.txt_Funcionario.Location = new System.Drawing.Point(139, 26);
            this.txt_Funcionario.MaxLength = 90;
            this.txt_Funcionario.Name = "txt_Funcionario";
            this.txt_Funcionario.Size = new System.Drawing.Size(491, 20);
            this.txt_Funcionario.TabIndex = 1;
            this.txt_Funcionario.Enter += new System.EventHandler(this.txt_Funcionario_Enter);
            this.txt_Funcionario.Leave += new System.EventHandler(this.txt_Funcionario_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cargo/Função";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funcionário";
            // 
            // bt_PesquisarFuncionario
            // 
            this.bt_PesquisarFuncionario.Location = new System.Drawing.Point(636, 23);
            this.bt_PesquisarFuncionario.Name = "bt_PesquisarFuncionario";
            this.bt_PesquisarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.bt_PesquisarFuncionario.TabIndex = 2;
            this.bt_PesquisarFuncionario.Text = "Pesquisar";
            this.bt_PesquisarFuncionario.UseVisualStyleBackColor = true;
            this.bt_PesquisarFuncionario.Click += new System.EventHandler(this.bt_PesquisarFuncionario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "M. Obra R$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Situação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descrição do Serviço";
            // 
            // txt_DescricaoServico
            // 
            this.txt_DescricaoServico.Location = new System.Drawing.Point(12, 65);
            this.txt_DescricaoServico.MaxLength = 200;
            this.txt_DescricaoServico.Name = "txt_DescricaoServico";
            this.txt_DescricaoServico.Size = new System.Drawing.Size(618, 20);
            this.txt_DescricaoServico.TabIndex = 3;
            this.txt_DescricaoServico.Enter += new System.EventHandler(this.txt_Funcionario_Enter);
            this.txt_DescricaoServico.Leave += new System.EventHandler(this.txt_Funcionario_Leave);
            // 
            // txt_Mao_de_Obra
            // 
            this.txt_Mao_de_Obra.Location = new System.Drawing.Point(393, 104);
            this.txt_Mao_de_Obra.MaxLength = 9;
            this.txt_Mao_de_Obra.Name = "txt_Mao_de_Obra";
            this.txt_Mao_de_Obra.Size = new System.Drawing.Size(75, 20);
            this.txt_Mao_de_Obra.TabIndex = 6;
            this.txt_Mao_de_Obra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Mao_de_Obra.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cbx_Situacao
            // 
            this.cbx_Situacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Situacao.FormattingEnabled = true;
            this.cbx_Situacao.Items.AddRange(new object[] {
            "Pago",
            "Devendo"});
            this.cbx_Situacao.Location = new System.Drawing.Point(636, 65);
            this.cbx_Situacao.Name = "cbx_Situacao";
            this.cbx_Situacao.Size = new System.Drawing.Size(75, 21);
            this.cbx_Situacao.TabIndex = 4;
            this.cbx_Situacao.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bt_Adicionar
            // 
            this.bt_Adicionar.Location = new System.Drawing.Point(636, 101);
            this.bt_Adicionar.Name = "bt_Adicionar";
            this.bt_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.bt_Adicionar.TabIndex = 9;
            this.bt_Adicionar.Text = "Adicionar";
            this.bt_Adicionar.UseVisualStyleBackColor = true;
            // 
            // listView_Comissoes
            // 
            this.listView_Comissoes.Location = new System.Drawing.Point(12, 130);
            this.listView_Comissoes.Name = "listView_Comissoes";
            this.listView_Comissoes.Size = new System.Drawing.Size(699, 340);
            this.listView_Comissoes.TabIndex = 15;
            this.listView_Comissoes.UseCompatibleStateImageBehavior = false;
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Location = new System.Drawing.Point(393, 476);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(75, 23);
            this.bt_Limpar.TabIndex = 10;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Location = new System.Drawing.Point(636, 476);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_Salvar.TabIndex = 12;
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = true;
            // 
            // bt_Gravar
            // 
            this.bt_Gravar.Location = new System.Drawing.Point(555, 476);
            this.bt_Gravar.Name = "bt_Gravar";
            this.bt_Gravar.Size = new System.Drawing.Size(75, 23);
            this.bt_Gravar.TabIndex = 12;
            this.bt_Gravar.Text = "Gravar";
            this.bt_Gravar.UseVisualStyleBackColor = true;
            // 
            // txt_Porcentagem
            // 
            this.txt_Porcentagem.Location = new System.Drawing.Point(474, 104);
            this.txt_Porcentagem.MaxLength = 3;
            this.txt_Porcentagem.Name = "txt_Porcentagem";
            this.txt_Porcentagem.Size = new System.Drawing.Size(75, 20);
            this.txt_Porcentagem.TabIndex = 7;
            this.txt_Porcentagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Porcentagem.Enter += new System.EventHandler(this.txt_Funcionario_Enter);
            this.txt_Porcentagem.Leave += new System.EventHandler(this.txt_Funcionario_Leave);
            // 
            // txt_Comissao
            // 
            this.txt_Comissao.Location = new System.Drawing.Point(555, 104);
            this.txt_Comissao.MaxLength = 9;
            this.txt_Comissao.Name = "txt_Comissao";
            this.txt_Comissao.Size = new System.Drawing.Size(75, 20);
            this.txt_Comissao.TabIndex = 8;
            this.txt_Comissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Comissao.Enter += new System.EventHandler(this.txt_Funcionario_Enter);
            this.txt_Comissao.Leave += new System.EventHandler(this.txt_Funcionario_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Comissão R$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Porcentagem%";
            // 
            // txt_Observacoes
            // 
            this.txt_Observacoes.Location = new System.Drawing.Point(12, 104);
            this.txt_Observacoes.MaxLength = 85;
            this.txt_Observacoes.Name = "txt_Observacoes";
            this.txt_Observacoes.Size = new System.Drawing.Size(375, 20);
            this.txt_Observacoes.TabIndex = 5;
            this.txt_Observacoes.Enter += new System.EventHandler(this.txt_Funcionario_Enter);
            this.txt_Observacoes.Leave += new System.EventHandler(this.txt_Funcionario_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Obs.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Comissao_Orcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Observacoes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Comissao);
            this.Controls.Add(this.txt_Porcentagem);
            this.Controls.Add(this.bt_Gravar);
            this.Controls.Add(this.bt_Salvar);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.listView_Comissoes);
            this.Controls.Add(this.bt_Adicionar);
            this.Controls.Add(this.cbx_Situacao);
            this.Controls.Add(this.txt_Mao_de_Obra);
            this.Controls.Add(this.txt_DescricaoServico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_PesquisarFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Funcionario);
            this.Controls.Add(this.cbx_Funcao);
            this.Name = "Comissao_Orcamento";
            this.Text = "Comissao_Orcamento";
            this.Load += new System.EventHandler(this.Comissao_Orcamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Funcao;
        private System.Windows.Forms.TextBox txt_Funcionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_PesquisarFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DescricaoServico;
        private System.Windows.Forms.TextBox txt_Mao_de_Obra;
        private System.Windows.Forms.ComboBox cbx_Situacao;
        private System.Windows.Forms.Button bt_Adicionar;
        private System.Windows.Forms.ListView listView_Comissoes;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.Button bt_Gravar;
        private System.Windows.Forms.TextBox txt_Porcentagem;
        private System.Windows.Forms.TextBox txt_Comissao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Observacoes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}