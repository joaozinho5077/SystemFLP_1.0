namespace SystemFunilaria
{
    partial class Cad_Funcionario
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
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.bt_Gravar = new System.Windows.Forms.Button();
            this.gbx_Endereco = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_TelResidencial = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_TelCelular = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.label1_Obs = new System.Windows.Forms.Label();
            this.label_Cidade = new System.Windows.Forms.Label();
            this.cbx_Cidade = new System.Windows.Forms.ComboBox();
            this.cbx_UF = new System.Windows.Forms.ComboBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_TelResidencial = new System.Windows.Forms.Label();
            this.label_TelCelular = new System.Windows.Forms.Label();
            this.label_UF = new System.Windows.Forms.Label();
            this.txt_Observacao = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label_Numero = new System.Windows.Forms.Label();
            this.label_Rua = new System.Windows.Forms.Label();
            this.txt_Rua = new System.Windows.Forms.TextBox();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.da = new System.Windows.Forms.GroupBox();
            this.maskedtxt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.cbx_Cargo = new System.Windows.Forms.ComboBox();
            this.label_Codigo = new System.Windows.Forms.Label();
            this.label_Cargo = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label_Apelido = new System.Windows.Forms.Label();
            this.label_CPF = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label_Nome = new System.Windows.Forms.Label();
            this.txt_Apelido = new System.Windows.Forms.TextBox();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.gbx_Endereco.SuspendLayout();
            this.da.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Location = new System.Drawing.Point(507, 437);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_Salvar.TabIndex = 17;
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = true;
            // 
            // bt_Gravar
            // 
            this.bt_Gravar.Location = new System.Drawing.Point(426, 437);
            this.bt_Gravar.Name = "bt_Gravar";
            this.bt_Gravar.Size = new System.Drawing.Size(75, 23);
            this.bt_Gravar.TabIndex = 16;
            this.bt_Gravar.Text = "Gravar";
            this.bt_Gravar.UseVisualStyleBackColor = true;
            // 
            // gbx_Endereco
            // 
            this.gbx_Endereco.Controls.Add(this.maskedTextBox_TelResidencial);
            this.gbx_Endereco.Controls.Add(this.maskedTextBox_TelCelular);
            this.gbx_Endereco.Controls.Add(this.label1);
            this.gbx_Endereco.Controls.Add(this.txt_Bairro);
            this.gbx_Endereco.Controls.Add(this.label1_Obs);
            this.gbx_Endereco.Controls.Add(this.label_Cidade);
            this.gbx_Endereco.Controls.Add(this.cbx_Cidade);
            this.gbx_Endereco.Controls.Add(this.cbx_UF);
            this.gbx_Endereco.Controls.Add(this.label_Email);
            this.gbx_Endereco.Controls.Add(this.label_TelResidencial);
            this.gbx_Endereco.Controls.Add(this.label_TelCelular);
            this.gbx_Endereco.Controls.Add(this.label_UF);
            this.gbx_Endereco.Controls.Add(this.txt_Observacao);
            this.gbx_Endereco.Controls.Add(this.txt_Email);
            this.gbx_Endereco.Controls.Add(this.label_Numero);
            this.gbx_Endereco.Controls.Add(this.label_Rua);
            this.gbx_Endereco.Controls.Add(this.txt_Rua);
            this.gbx_Endereco.Controls.Add(this.txt_Numero);
            this.gbx_Endereco.Location = new System.Drawing.Point(12, 124);
            this.gbx_Endereco.Name = "gbx_Endereco";
            this.gbx_Endereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbx_Endereco.Size = new System.Drawing.Size(569, 307);
            this.gbx_Endereco.TabIndex = 18;
            this.gbx_Endereco.TabStop = false;
            this.gbx_Endereco.Text = "ENDEREÇO";
            // 
            // maskedTextBox_TelResidencial
            // 
            this.maskedTextBox_TelResidencial.Location = new System.Drawing.Point(100, 110);
            this.maskedTextBox_TelResidencial.Mask = "(00) 000000000       ";
            this.maskedTextBox_TelResidencial.Name = "maskedTextBox_TelResidencial";
            this.maskedTextBox_TelResidencial.Size = new System.Drawing.Size(88, 20);
            this.maskedTextBox_TelResidencial.TabIndex = 10;
            this.maskedTextBox_TelResidencial.Enter += new System.EventHandler(this.maskedtxt_CPF_Enter);
            this.maskedTextBox_TelResidencial.Leave += new System.EventHandler(this.maskedtxt_CPF_Leave);
            // 
            // maskedTextBox_TelCelular
            // 
            this.maskedTextBox_TelCelular.Location = new System.Drawing.Point(6, 110);
            this.maskedTextBox_TelCelular.Mask = "(00) 000000000       ";
            this.maskedTextBox_TelCelular.Name = "maskedTextBox_TelCelular";
            this.maskedTextBox_TelCelular.Size = new System.Drawing.Size(88, 20);
            this.maskedTextBox_TelCelular.TabIndex = 9;
            this.maskedTextBox_TelCelular.Enter += new System.EventHandler(this.maskedtxt_CPF_Enter);
            this.maskedTextBox_TelCelular.Leave += new System.EventHandler(this.maskedtxt_CPF_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Bairro";
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Location = new System.Drawing.Point(6, 71);
            this.txt_Bairro.MaxLength = 100;
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(557, 20);
            this.txt_Bairro.TabIndex = 8;
            this.txt_Bairro.Enter += new System.EventHandler(this.txt_Apelido_Enter);
            this.txt_Bairro.Leave += new System.EventHandler(this.txt_Apelido_Leave);
            // 
            // label1_Obs
            // 
            this.label1_Obs.AutoSize = true;
            this.label1_Obs.Location = new System.Drawing.Point(3, 173);
            this.label1_Obs.Name = "label1_Obs";
            this.label1_Obs.Size = new System.Drawing.Size(32, 13);
            this.label1_Obs.TabIndex = 24;
            this.label1_Obs.Text = "OBS:";
            // 
            // label_Cidade
            // 
            this.label_Cidade.AutoSize = true;
            this.label_Cidade.Location = new System.Drawing.Point(58, 133);
            this.label_Cidade.Name = "label_Cidade";
            this.label_Cidade.Size = new System.Drawing.Size(40, 13);
            this.label_Cidade.TabIndex = 23;
            this.label_Cidade.Text = "Cidade";
            // 
            // cbx_Cidade
            // 
            this.cbx_Cidade.FormattingEnabled = true;
            this.cbx_Cidade.Items.AddRange(new object[] {
            "FUNILEIRO",
            "MECÂNICO",
            "PINTOR",
            "TAPEÇEIRO"});
            this.cbx_Cidade.Location = new System.Drawing.Point(61, 149);
            this.cbx_Cidade.Name = "cbx_Cidade";
            this.cbx_Cidade.Size = new System.Drawing.Size(502, 21);
            this.cbx_Cidade.TabIndex = 13;
            // 
            // cbx_UF
            // 
            this.cbx_UF.FormattingEnabled = true;
            this.cbx_UF.Location = new System.Drawing.Point(6, 149);
            this.cbx_UF.Name = "cbx_UF";
            this.cbx_UF.Size = new System.Drawing.Size(49, 21);
            this.cbx_UF.TabIndex = 12;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(191, 94);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(32, 13);
            this.label_Email.TabIndex = 22;
            this.label_Email.Text = "Email";
            // 
            // label_TelResidencial
            // 
            this.label_TelResidencial.AutoSize = true;
            this.label_TelResidencial.Location = new System.Drawing.Point(97, 94);
            this.label_TelResidencial.Name = "label_TelResidencial";
            this.label_TelResidencial.Size = new System.Drawing.Size(83, 13);
            this.label_TelResidencial.TabIndex = 21;
            this.label_TelResidencial.Text = "Tel. Residencial";
            // 
            // label_TelCelular
            // 
            this.label_TelCelular.AutoSize = true;
            this.label_TelCelular.Location = new System.Drawing.Point(3, 94);
            this.label_TelCelular.Name = "label_TelCelular";
            this.label_TelCelular.Size = new System.Drawing.Size(60, 13);
            this.label_TelCelular.TabIndex = 19;
            this.label_TelCelular.Text = "Tel. Celular";
            // 
            // label_UF
            // 
            this.label_UF.AutoSize = true;
            this.label_UF.Location = new System.Drawing.Point(3, 133);
            this.label_UF.Name = "label_UF";
            this.label_UF.Size = new System.Drawing.Size(21, 13);
            this.label_UF.TabIndex = 18;
            this.label_UF.Text = "UF";
            // 
            // txt_Observacao
            // 
            this.txt_Observacao.Location = new System.Drawing.Point(6, 189);
            this.txt_Observacao.Multiline = true;
            this.txt_Observacao.Name = "txt_Observacao";
            this.txt_Observacao.Size = new System.Drawing.Size(557, 103);
            this.txt_Observacao.TabIndex = 14;
            this.txt_Observacao.Enter += new System.EventHandler(this.txt_Apelido_Enter);
            this.txt_Observacao.Leave += new System.EventHandler(this.txt_Apelido_Leave);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(194, 110);
            this.txt_Email.MaxLength = 100;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(369, 20);
            this.txt_Email.TabIndex = 11;
            this.txt_Email.Enter += new System.EventHandler(this.txt_Apelido_Enter);
            this.txt_Email.Leave += new System.EventHandler(this.txt_Apelido_Leave);
            // 
            // label_Numero
            // 
            this.label_Numero.AutoSize = true;
            this.label_Numero.Location = new System.Drawing.Point(509, 16);
            this.label_Numero.Name = "label_Numero";
            this.label_Numero.Size = new System.Drawing.Size(44, 13);
            this.label_Numero.TabIndex = 10;
            this.label_Numero.Text = "Numero";
            // 
            // label_Rua
            // 
            this.label_Rua.AutoSize = true;
            this.label_Rua.Location = new System.Drawing.Point(3, 16);
            this.label_Rua.Name = "label_Rua";
            this.label_Rua.Size = new System.Drawing.Size(27, 13);
            this.label_Rua.TabIndex = 9;
            this.label_Rua.Text = "Rua";
            // 
            // txt_Rua
            // 
            this.txt_Rua.Location = new System.Drawing.Point(6, 32);
            this.txt_Rua.MaxLength = 100;
            this.txt_Rua.Name = "txt_Rua";
            this.txt_Rua.Size = new System.Drawing.Size(500, 20);
            this.txt_Rua.TabIndex = 6;
            this.txt_Rua.Enter += new System.EventHandler(this.txt_Apelido_Enter);
            this.txt_Rua.Leave += new System.EventHandler(this.txt_Apelido_Leave);
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(512, 32);
            this.txt_Numero.MaxLength = 7;
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(51, 20);
            this.txt_Numero.TabIndex = 7;
            this.txt_Numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Numero.Enter += new System.EventHandler(this.txt_Apelido_Enter);
            this.txt_Numero.Leave += new System.EventHandler(this.txt_Apelido_Leave);
            // 
            // da
            // 
            this.da.Controls.Add(this.maskedtxt_CPF);
            this.da.Controls.Add(this.cbx_Cargo);
            this.da.Controls.Add(this.label_Codigo);
            this.da.Controls.Add(this.label_Cargo);
            this.da.Controls.Add(this.txt_Codigo);
            this.da.Controls.Add(this.label_Apelido);
            this.da.Controls.Add(this.label_CPF);
            this.da.Controls.Add(this.txt_Nome);
            this.da.Controls.Add(this.label_Nome);
            this.da.Controls.Add(this.txt_Apelido);
            this.da.Location = new System.Drawing.Point(12, 12);
            this.da.Name = "da";
            this.da.Size = new System.Drawing.Size(569, 106);
            this.da.TabIndex = 19;
            this.da.TabStop = false;
            // 
            // maskedtxt_CPF
            // 
            this.maskedtxt_CPF.Location = new System.Drawing.Point(96, 32);
            this.maskedtxt_CPF.Mask = "000.000.000-00";
            this.maskedtxt_CPF.Name = "maskedtxt_CPF";
            this.maskedtxt_CPF.Size = new System.Drawing.Size(88, 20);
            this.maskedtxt_CPF.TabIndex = 2;
            this.maskedtxt_CPF.Enter += new System.EventHandler(this.maskedtxt_CPF_Enter);
            this.maskedtxt_CPF.Leave += new System.EventHandler(this.maskedtxt_CPF_Leave);
            // 
            // cbx_Cargo
            // 
            this.cbx_Cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Cargo.FormattingEnabled = true;
            this.cbx_Cargo.Items.AddRange(new object[] {
            "Funileiro",
            "Mecânico",
            "Pintor",
            "Tapeceiro",
            "Montador"});
            this.cbx_Cargo.Location = new System.Drawing.Point(407, 70);
            this.cbx_Cargo.Name = "cbx_Cargo";
            this.cbx_Cargo.Size = new System.Drawing.Size(156, 21);
            this.cbx_Cargo.TabIndex = 5;
            // 
            // label_Codigo
            // 
            this.label_Codigo.AutoSize = true;
            this.label_Codigo.Location = new System.Drawing.Point(3, 16);
            this.label_Codigo.Name = "label_Codigo";
            this.label_Codigo.Size = new System.Drawing.Size(40, 13);
            this.label_Codigo.TabIndex = 11;
            this.label_Codigo.Text = "Código";
            // 
            // label_Cargo
            // 
            this.label_Cargo.AutoSize = true;
            this.label_Cargo.Location = new System.Drawing.Point(404, 55);
            this.label_Cargo.Name = "label_Cargo";
            this.label_Cargo.Size = new System.Drawing.Size(76, 13);
            this.label_Cargo.TabIndex = 10;
            this.label_Cargo.Text = "Cargo/Função";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_Codigo.Location = new System.Drawing.Point(6, 32);
            this.txt_Codigo.MaxLength = 10;
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(84, 20);
            this.txt_Codigo.TabIndex = 1;
            this.txt_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Apelido
            // 
            this.label_Apelido.AutoSize = true;
            this.label_Apelido.Location = new System.Drawing.Point(187, 16);
            this.label_Apelido.Name = "label_Apelido";
            this.label_Apelido.Size = new System.Drawing.Size(42, 13);
            this.label_Apelido.TabIndex = 8;
            this.label_Apelido.Text = "Apelido";
            // 
            // label_CPF
            // 
            this.label_CPF.AutoSize = true;
            this.label_CPF.Location = new System.Drawing.Point(93, 16);
            this.label_CPF.Name = "label_CPF";
            this.label_CPF.Size = new System.Drawing.Size(27, 13);
            this.label_CPF.TabIndex = 7;
            this.label_CPF.Text = "CPF";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(6, 71);
            this.txt_Nome.MaxLength = 100;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(395, 20);
            this.txt_Nome.TabIndex = 4;
            this.txt_Nome.Enter += new System.EventHandler(this.txt_Apelido_Enter);
            this.txt_Nome.Leave += new System.EventHandler(this.txt_Apelido_Leave);
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Location = new System.Drawing.Point(3, 55);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(35, 13);
            this.label_Nome.TabIndex = 1;
            this.label_Nome.Text = "Nome";
            // 
            // txt_Apelido
            // 
            this.txt_Apelido.Location = new System.Drawing.Point(190, 32);
            this.txt_Apelido.MaxLength = 40;
            this.txt_Apelido.Name = "txt_Apelido";
            this.txt_Apelido.Size = new System.Drawing.Size(373, 20);
            this.txt_Apelido.TabIndex = 3;
            this.txt_Apelido.Enter += new System.EventHandler(this.txt_Apelido_Enter);
            this.txt_Apelido.Leave += new System.EventHandler(this.txt_Apelido_Leave);
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Location = new System.Drawing.Point(345, 437);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(75, 23);
            this.bt_Limpar.TabIndex = 15;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            // 
            // Cad_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 465);
            this.Controls.Add(this.bt_Salvar);
            this.Controls.Add(this.bt_Gravar);
            this.Controls.Add(this.gbx_Endereco);
            this.Controls.Add(this.da);
            this.Controls.Add(this.bt_Limpar);
            this.Name = "Cad_Funcionario";
            this.Text = "Cad_Funcionario";
            this.gbx_Endereco.ResumeLayout(false);
            this.gbx_Endereco.PerformLayout();
            this.da.ResumeLayout(false);
            this.da.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.Button bt_Gravar;
        private System.Windows.Forms.GroupBox gbx_Endereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.Label label1_Obs;
        private System.Windows.Forms.Label label_Cidade;
        private System.Windows.Forms.ComboBox cbx_Cidade;
        private System.Windows.Forms.ComboBox cbx_UF;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_TelResidencial;
        private System.Windows.Forms.Label label_TelCelular;
        private System.Windows.Forms.Label label_UF;
        private System.Windows.Forms.TextBox txt_Observacao;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label_Numero;
        private System.Windows.Forms.Label label_Rua;
        private System.Windows.Forms.TextBox txt_Rua;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.GroupBox da;
        private System.Windows.Forms.MaskedTextBox maskedtxt_CPF;
        private System.Windows.Forms.ComboBox cbx_Cargo;
        private System.Windows.Forms.Label label_Codigo;
        private System.Windows.Forms.Label label_Cargo;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label_Apelido;
        private System.Windows.Forms.Label label_CPF;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.TextBox txt_Apelido;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_TelResidencial;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_TelCelular;
    }
}