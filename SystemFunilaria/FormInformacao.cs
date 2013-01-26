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
    public partial class FormInformacao : Form
    {
        public NumericUpDown num = new NumericUpDown();

        public FormInformacao()
        {
            InitializeComponent();
        }

        private void FormInformacao_Load(object sender, EventArgs e)
        {
            apresentar();
        }

        public void apresentar()
        {
            num.Value = 1;
            int segundos = System.Convert.ToInt32(num.Value);
            timerInformacao.Stop();
            timerInformacao.Interval = (int)segundos * 1000;
            timerInformacao.Tick += new EventHandler(timerEvent);
            timerInformacao.Start();
        }

        private void timerEvent(Object sender, EventArgs e)
        {
            timerInformacao.Stop();
            this.Close();
        }
    }
}
