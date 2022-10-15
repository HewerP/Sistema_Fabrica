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
    }
}
