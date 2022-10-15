using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Controle_de
{
    public partial class fmcadcadastrar : Form
    {
        public fmcadcadastrar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadoperario cadoper = new cadoperario();
            cadoper.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadcliente cadcli = new cadcliente();
            cadcli.Show();
        }

        private void fmcadcadastrar_Load(object sender, EventArgs e)
        {

        }
    }
}
