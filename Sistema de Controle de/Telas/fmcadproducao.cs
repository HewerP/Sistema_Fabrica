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
    public partial class fmcadproducao : Form
    {
        public fmcadproducao()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cadproducao producao = new cadproducao();
            producao.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            deleteproducao deleteprod = new deleteproducao();
            deleteprod.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaproducao listpro = new listaproducao();
            listpro.Show();
        }
    }
}
