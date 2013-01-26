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
    public partial class Cad_Funcionario : Form
    {
        public Funcoes FuncoesCor = new Funcoes();
        public Cad_Funcionario()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedtxt_CPF_Enter(object sender, EventArgs e)
        {
            FuncoesCor.changeMaskedTextBoxFocusIn(sender);
        }

        private void maskedtxt_CPF_Leave(object sender, EventArgs e)
        {
            FuncoesCor.changeMaskedTextBoxFocusIOut(sender);
        }

        private void txt_Apelido_Enter(object sender, EventArgs e)
        {
            FuncoesCor.changeTextBoxFocusIn(sender);
        }

        private void txt_Apelido_Leave(object sender, EventArgs e)
        {
            FuncoesCor.changeTextBoxFocusOut(sender);
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            FuncoesCor.apresentaSalvo();
        }

        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            FuncoesCor.apresentaSalvo();
        }
        
    }
}
