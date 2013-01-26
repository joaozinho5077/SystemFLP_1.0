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
    public partial class Cad_Cliente : Form
    {
        public Funcoes FuncoesCor = new Funcoes();
        public Cad_Cliente()
        {
            InitializeComponent();
        }
        private void txt_Nome_Enter(object sender, EventArgs e)
        {
            FuncoesCor.changeTextBoxFocusIn(sender);
        }

        private void txt_Nome_Leave(object sender, EventArgs e)
        {
            FuncoesCor.changeTextBoxFocusOut(sender);
        }

        private void maskedtxt_CPF_Enter(object sender, EventArgs e)
        {
            FuncoesCor.changeMaskedTextBoxFocusIn(sender);
        }

        private void maskedtxt_CPF_Leave(object sender, EventArgs e)
        {
            FuncoesCor.changeMaskedTextBoxFocusIOut(sender);
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
