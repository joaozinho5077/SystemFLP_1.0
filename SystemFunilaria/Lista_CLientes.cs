﻿using System;
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
    public partial class Lista_CLientes : Form
    {
        public Funcoes FuncoesCor = new Funcoes();
        public Lista_CLientes()
        {
            InitializeComponent();
        }

        private void bt_Adicionar_Click(object sender, EventArgs e)
        {
            Cad_Cliente frm = new Cad_Cliente();
            frm.Show();
        }

        public void txt_CpfCnpj_Enter(object sender, EventArgs e)
        {
            FuncoesCor.changeTextBoxFocusIn(sender);
        }

        private void txt_CpfCnpj_Leave(object sender, EventArgs e)
        {
            FuncoesCor.changeTextBoxFocusOut(sender);
        }

        private void txt_CpfCnpj_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
