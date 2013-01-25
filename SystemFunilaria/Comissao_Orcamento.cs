using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemFunilaria
{
    public partial class Comissao_Orcamento : Form
    {
        public Funcoes FuncoesCor = new Funcoes();
        public Comissao_Orcamento()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Comissao_Orcamento_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Funcionario_Enter(object sender, EventArgs e)
        {
            FuncoesCor.changeTextBoxFocusIn(sender);
        }

        private void txt_Funcionario_Leave(object sender, EventArgs e)
        {
            FuncoesCor.changeTextBoxFocusOut(sender);
        }

        private void bt_PesquisarFuncionario_Click(object sender, EventArgs e)
        {
            Lista_Funcionarios frm = new Lista_Funcionarios();
            frm.ShowDialog();
        }
    }
}
