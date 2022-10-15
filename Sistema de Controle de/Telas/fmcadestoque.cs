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
    public partial class fmcadestoque : Form
    {
        public fmcadestoque()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaesto listpro = new listaesto();
            listpro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            attestoque attesto = new attestoque();
            attesto.Show();
        }
    }
}
