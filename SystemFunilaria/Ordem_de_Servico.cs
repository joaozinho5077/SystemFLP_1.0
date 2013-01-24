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
    public partial class Ordem_de_Servico : Form
    {
        public Funcoes FuncoesCor = new Funcoes();
        public Ordem_de_Servico()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lista_Veiculos frm = new Lista_Veiculos();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista_CLientes frm = new Lista_CLientes();
            frm.Show();
        }

        private void txt_NomeCliente_Enter(object sender, EventArgs e)
        {
            FuncoesCor.changeTextBoxFocusIn(sender);
        }

        private void txt_NomeCliente_Leave(object sender, EventArgs e)
        {
            FuncoesCor.changeTextBoxFocusOut(sender);
        }

    }
}
