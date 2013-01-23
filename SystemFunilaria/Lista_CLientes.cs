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
    public partial class Lista_CLientes : Form
    {
        public Lista_CLientes()
        {
            InitializeComponent();
        }

        private void bt_Adicionar_Click(object sender, EventArgs e)
        {
            Cad_Cliente frm = new Cad_Cliente();
            frm.Show();
        }
    }
}
