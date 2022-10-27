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
    public partial class fmcadconsultar : Form
    {
        public fmcadconsultar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            editoperario editoperario = new editoperario();
            editoperario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           removeroperario removeroperario = new removeroperario();
            removeroperario.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisaroperario pesquisaroperario = new pesquisaroperario();  
            pesquisaroperario.Show();   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pesquisarcliente pesquisarcliente = new pesquisarcliente();
            pesquisarcliente.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            editarcliente editarcliente = new editarcliente();
            editarcliente.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            removercliente removercliente = new removercliente();
            removercliente.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pesquisarproducao pesquisarproducao = new pesquisarproducao();
            pesquisarproducao.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            editarproducao editarproducao = new editarproducao();
            editarproducao.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            removerproducao removerproducao = new removerproducao();
            removerproducao.Show();
        }
    }
}
