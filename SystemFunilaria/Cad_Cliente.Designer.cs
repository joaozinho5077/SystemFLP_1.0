namespace SystemFunilaria
{
    partial class Cad_Cliente
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
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedtxt_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.maskedtxt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_Nome = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label_CpfCnpj = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.txt_Rua = new System.Windows.Forms.TextBox();
            this.maskedTextBox_TelResidencial = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_TelComercial = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_TelCelular = new System.Windows.Forms.MaskedTextBox();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_UF = new System.Windows.Forms.Label();
            this.label_OBS = new System.Windows.Forms.Label();
            this.label_TelCelular = new System.Windows.Forms.Label();
            this.txt_Observacao = new System.Windows.Forms.TextBox();
            this.label_Rua = new System.Windows.Forms.Label();
            this.label_TelComercial = new System.Windows.Forms.Label();
            this.cbx_Cidade = new System.Windows.Forms.ComboBox();
            this.label_TelResidencial = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label_Cidade = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.cbx_UF = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Location = new System.Drawing.Point(674, 438);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_Salvar.TabIndex = 16;
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = true;
            // 
            // bt_Gravar
            // 
            this.bt_Gravar.Location = new System.Drawing.Point(593, 438);
            this.bt_Gravar.Name = "bt_Gravar";
            this.bt_Gravar.Size = new System.Drawing.Size(75, 23);
            this.bt_Gravar.TabIndex = 15;
            this.bt_Gravar.Text = "Gravar";
            this.bt_Gravar.UseVisualStyleBackColor = true;
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Location = new System.Drawing.Point(512, 438);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(75, 23);
            this.bt_Limpar.TabIndex = 14;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedtxt_CNPJ);
            this.groupBox1.Controls.Add(this.maskedtxt_CPF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Label_Nome);
            this.groupBox1.Controls.Add(this.txt_Nome);
            this.groupBox1.Controls.Add(this.label_CpfCnpj);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // maskedtxt_CNPJ
            // 
            this.maskedtxt_CNPJ.Location = new System.Drawing.Point(622, 32);
            this.maskedtxt_CNPJ.Mask = "00.000.000/0000-00";
            this.maskedtxt_CNPJ.Name = "maskedtxt_CNPJ";
            this.maskedtxt_CNPJ.Size = new System.Drawing.Size(109, 20);
            this.maskedtxt_CNPJ.TabIndex = 3;
            this.maskedtxt_CNPJ.Tag = "";
            this.maskedtxt_CNPJ.Enter += new System.EventHandler(this.maskedtxt_CPF_Enter);
            this.maskedtxt_CNPJ.Leave += new System.EventHandler(this.maskedtxt_CPF_Leave);
            // 
            // maskedtxt_CPF
            // 
            this.maskedtxt_CPF.Location = new System.Drawing.Point(528, 32);
            this.maskedtxt_CPF.Mask = "000.000.000-00";
            this.maskedtxt_CPF.Name = "maskedtxt_CPF";
            this.maskedtxt_CPF.Size = new System.Drawing.Size(88, 20);
            this.maskedtxt_CPF.TabIndex = 2;
            this.maskedtxt_CPF.Tag = "";
            this.maskedtxt_CPF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.maskedtxt_CPF.Enter += new System.EventHandler(this.maskedtxt_CPF_Enter);
            this.maskedtxt_CPF.Leave += new System.EventHandler(this.maskedtxt_CPF_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "CPF";
            // 
            // Label_Nome
            // 
            this.Label_Nome.AutoSize = true;
            this.Label_Nome.Location = new System.Drawing.Point(6, 16);
            this.Label_Nome.Name = "Label_Nome";
            this.Label_Nome.Size = new System.Drawing.Size(82, 13);
            this.Label_Nome.TabIndex = 8;
            this.Label_Nome.Text = "Nome Completo";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(6, 32);
            this.txt_Nome.MaxLength = 100;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(516, 20);
            this.txt_Nome.TabIndex = 1;
            this.txt_Nome.Tag = "";
            this.txt_Nome.Enter += new System.EventHandler(this.txt_Nome_Enter);
            this.txt_Nome.Leave += new System.EventHandler(this.txt_Nome_Leave);
            // 
            // label_CpfCnpj
            // 
            this.label_CpfCnpj.AutoSize = true;
            this.label_CpfCnpj.Location = new System.Drawing.Point(622, 16);
            this.label_CpfCnpj.Name = "label_CpfCnpj";
            this.label_CpfCnpj.Size = new System.Drawing.Size(34, 13);
            this.label_CpfCnpj.TabIndex = 9;
            this.label_CpfCnpj.Text = "CNPJ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_Numero);
            this.groupBox2.Controls.Add(this.txt_Rua);
            this.groupBox2.Controls.Add(this.maskedTextBox_TelResidencial);
            this.groupBox2.Controls.Add(this.maskedTextBox_TelComercial);
            this.groupBox2.Controls.Add(this.maskedTextBox_TelCelular);
            this.groupBox2.Controls.Add(this.txt_Bairro);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label_UF);
            this.groupBox2.Controls.Add(this.label_OBS);
            this.groupBox2.Controls.Add(this.label_TelCelular);
            this.groupBox2.Controls.Add(this.txt_Observacao);
            this.groupBox2.Controls.Add(this.label_Rua);
            this.groupBox2.Controls.Add(this.label_TelComercial);
            this.groupBox2.Controls.Add(this.cbx_Cidade);
            this.groupBox2.Controls.Add(this.label_TelResidencial);
            this.groupBox2.Controls.Add(this.txt_Email);
            this.groupBox2.Controls.Add(this.label_Cidade);
            this.groupBox2.Controls.Add(this.label_Email);
            this.groupBox2.Controls.Add(this.cbx_UF);
            this.groupBox2.Location = new System.Drawing.Point(13, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 353);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ENDEREÇO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(677, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Número";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(680, 33);
            this.txt_Numero.MaxLength = 7;
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(50, 20);
            this.txt_Numero.TabIndex = 5;
            this.txt_Numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Numero.Enter += new System.EventHandler(this.txt_Nome_Enter);
            this.txt_Numero.Leave += new System.EventHandler(this.txt_Nome_Leave);
            // 
            // txt_Rua
            // 
            this.txt_Rua.Location = new System.Drawing.Point(6, 33);
            this.txt_Rua.MaxLength = 200;
            this.txt_Rua.Name = "txt_Rua";
            this.txt_Rua.Size = new System.Drawing.Size(668, 20);
            this.txt_Rua.TabIndex = 4;
            this.txt_Rua.Tag = "";
            this.txt_Rua.Enter += new System.EventHandler(this.txt_Nome_Enter);
            this.txt_Rua.Leave += new System.EventHandler(this.txt_Nome_Leave);
            // 
            // maskedTextBox_TelResidencial
            // 
            this.maskedTextBox_TelResidencial.Location = new System.Drawing.Point(99, 111);
            this.maskedTextBox_TelResidencial.Mask = "(00) 000000000       ";
            this.maskedTextBox_TelResidencial.Name = "maskedTextBox_TelResidencial";
            this.maskedTextBox_TelResidencial.Size = new System.Drawing.Size(88, 20);
            this.maskedTextBox_TelResidencial.TabIndex = 8;
            this.maskedTextBox_TelResidencial.Enter += new System.EventHandler(this.maskedtxt_CPF_Enter);
            this.maskedTextBox_TelResidencial.Leave += new System.EventHandler(this.maskedtxt_CPF_Leave);
            // 
            // maskedTextBox_TelComercial
            // 
            this.maskedTextBox_TelComercial.Location = new System.Drawing.Point(193, 111);
            this.maskedTextBox_TelComercial.Mask = "(00) 000000000       ";
            this.maskedTextBox_TelComercial.Name = "maskedTextBox_TelComercial";
            this.maskedTextBox_TelComercial.Size = new System.Drawing.Size(88, 20);
            this.maskedTextBox_TelComercial.TabIndex = 9;
            this.maskedTextBox_TelComercial.Enter += new System.EventHandler(this.maskedtxt_CPF_Enter);
            this.maskedTextBox_TelComercial.Leave += new System.EventHandler(this.maskedtxt_CPF_Leave);
            // 
            // maskedTextBox_TelCelular
            // 
            this.maskedTextBox_TelCelular.Location = new System.Drawing.Point(5, 111);
            this.maskedTextBox_TelCelular.Mask = "(00) 000000000       ";
            this.maskedTextBox_TelCelular.Name = "maskedTextBox_TelCelular";
            this.maskedTextBox_TelCelular.Size = new System.Drawing.Size(88, 20);
            this.maskedTextBox_TelCelular.TabIndex = 7;
            this.maskedTextBox_TelCelular.Enter += new System.EventHandler(this.maskedtxt_CPF_Enter);
            this.maskedTextBox_TelCelular.Leave += new System.EventHandler(this.maskedtxt_CPF_Leave);
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Location = new System.Drawing.Point(6, 72);
            this.txt_Bairro.MaxLength = 200;
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(724, 20);
            this.txt_Bairro.TabIndex = 6;
            this.txt_Bairro.Enter += new System.EventHandler(this.txt_Nome_Enter);
            this.txt_Bairro.Leave += new System.EventHandler(this.txt_Nome_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Bairro";
            // 
            // label_UF
            // 
            this.label_UF.AutoSize = true;
            this.label_UF.Location = new System.Drawing.Point(2, 134);
            this.label_UF.Name = "label_UF";
            this.label_UF.Size = new System.Drawing.Size(21, 13);
            this.label_UF.TabIndex = 12;
            this.label_UF.Text = "UF";
            // 
            // label_OBS
            // 
            this.label_OBS.AutoSize = true;
            this.label_OBS.Location = new System.Drawing.Point(3, 174);
            this.label_OBS.Name = "label_OBS";
            this.label_OBS.Size = new System.Drawing.Size(32, 13);
            this.label_OBS.TabIndex = 23;
            this.label_OBS.Text = "OBS:";
            // 
            // label_TelCelular
            // 
            this.label_TelCelular.AutoSize = true;
            this.label_TelCelular.Location = new System.Drawing.Point(2, 95);
            this.label_TelCelular.Name = "label_TelCelular";
            this.label_TelCelular.Size = new System.Drawing.Size(60, 13);
            this.label_TelCelular.TabIndex = 18;
            this.label_TelCelular.Text = "Tel. Celular";
            // 
            // txt_Observacao
            // 
            this.txt_Observacao.Location = new System.Drawing.Point(6, 190);
            this.txt_Observacao.Multiline = true;
            this.txt_Observacao.Name = "txt_Observacao";
            this.txt_Observacao.Size = new System.Drawing.Size(725, 157);
            this.txt_Observacao.TabIndex = 13;
            this.txt_Observacao.Enter += new System.EventHandler(this.txt_Nome_Enter);
            this.txt_Observacao.Leave += new System.EventHandler(this.txt_Nome_Leave);
            // 
            // label_Rua
            // 
            this.label_Rua.AutoSize = true;
            this.label_Rua.Location = new System.Drawing.Point(2, 17);
            this.label_Rua.Name = "label_Rua";
            this.label_Rua.Size = new System.Drawing.Size(27, 13);
            this.label_Rua.TabIndex = 11;
            this.label_Rua.Text = "Rua";
            // 
            // label_TelComercial
            // 
            this.label_TelComercial.AutoSize = true;
            this.label_TelComercial.Location = new System.Drawing.Point(190, 95);
            this.label_TelComercial.Name = "label_TelComercial";
            this.label_TelComercial.Size = new System.Drawing.Size(74, 13);
            this.label_TelComercial.TabIndex = 20;
            this.label_TelComercial.Text = "Tel. Comercial";
            // 
            // cbx_Cidade
            // 
            this.cbx_Cidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Cidade.FormattingEnabled = true;
            this.cbx_Cidade.Location = new System.Drawing.Point(56, 150);
            this.cbx_Cidade.Name = "cbx_Cidade";
            this.cbx_Cidade.Size = new System.Drawing.Size(674, 21);
            this.cbx_Cidade.TabIndex = 12;
            // 
            // label_TelResidencial
            // 
            this.label_TelResidencial.AutoSize = true;
            this.label_TelResidencial.Location = new System.Drawing.Point(96, 95);
            this.label_TelResidencial.Name = "label_TelResidencial";
            this.label_TelResidencial.Size = new System.Drawing.Size(83, 13);
            this.label_TelResidencial.TabIndex = 19;
            this.label_TelResidencial.Text = "Tel. Residencial";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(287, 111);
            this.txt_Email.MaxLength = 100;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(443, 20);
            this.txt_Email.TabIndex = 10;
            this.txt_Email.Enter += new System.EventHandler(this.txt_Nome_Enter);
            this.txt_Email.Leave += new System.EventHandler(this.txt_Nome_Leave);
            // 
            // label_Cidade
            // 
            this.label_Cidade.AutoSize = true;
            this.label_Cidade.Location = new System.Drawing.Point(53, 134);
            this.label_Cidade.Name = "label_Cidade";
            this.label_Cidade.Size = new System.Drawing.Size(40, 13);
            this.label_Cidade.TabIndex = 13;
            this.label_Cidade.Text = "Cidade";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(284, 95);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(32, 13);
            this.label_Email.TabIndex = 16;
            this.label_Email.Text = "Email";
            // 
            // cbx_UF
            // 
            this.cbx_UF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_UF.FormattingEnabled = true;
            this.cbx_UF.Location = new System.Drawing.Point(6, 150);
            this.cbx_UF.Name = "cbx_UF";
            this.cbx_UF.Size = new System.Drawing.Size(44, 21);
            this.cbx_UF.TabIndex = 11;
            // 
            // Cad_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 471);
            this.Controls.Add(this.bt_Salvar);
            this.Controls.Add(this.bt_Gravar);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Cad_Cliente";
            this.Text = "Cad_Cliente";
            this.Load += new System.EventHandler(this.Cad_Cliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.Button bt_Gravar;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedtxt_CNPJ;
        private System.Windows.Forms.MaskedTextBox maskedtxt_CPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_Nome;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label_CpfCnpj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_TelResidencial;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_TelComercial;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_TelCelular;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_UF;
        private System.Windows.Forms.Label label_OBS;
        private System.Windows.Forms.Label label_TelCelular;
        private System.Windows.Forms.TextBox txt_Observacao;
        private System.Windows.Forms.Label label_Rua;
        private System.Windows.Forms.Label label_TelComercial;
        private System.Windows.Forms.ComboBox cbx_Cidade;
        private System.Windows.Forms.Label label_TelResidencial;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label_Cidade;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.ComboBox cbx_UF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.TextBox txt_Rua;
    }
}