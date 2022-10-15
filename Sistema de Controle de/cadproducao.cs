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
    public partial class cadproducao : Form
    {
        public cadproducao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Cadastro efetuado com sucesso");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fmextrusora fmextru = new fmextrusora();
            fmextru.TopLevel = false;
            fmextru.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(fmextru);
            fmextru.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            fmtecelagem fmtece = new fmtecelagem();
            fmtece.TopLevel = false;
            fmtece.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(fmtece);
            fmtece.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fmlaminadora1 fmlami = new fmlaminadora1();
            fmlami.TopLevel = false;
            fmlami.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(fmlami);
            fmlami.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fmordemdeprdoucao fmprod= new fmordemdeprdoucao();
            fmprod.TopLevel = false;
            fmprod.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(fmprod);
            fmprod.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
