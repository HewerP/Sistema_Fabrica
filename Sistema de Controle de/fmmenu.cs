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
    public partial class fmmenu : Form
    {
        public fmmenu()
        {
            InitializeComponent();
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "nomus 2.0", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmcadcadastrar cliente = new fmcadcadastrar();
            cliente.TopLevel = false;
            cliente.Dock = DockStyle.Fill;
            panelcentral.Controls.Clear();
            panelcentral.Controls.Add(cliente);
            cliente.Show();

            panelselecao.Top = button1.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fmcadconsultar operario = new fmcadconsultar();
            operario.TopLevel = false;
            operario.Dock = DockStyle.Fill;
            panelcentral.Controls.Clear();
            
            panelcentral.Controls.Add(operario);
            operario.Show();
            panelselecao.Top = button2.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fmcadestoque estoque = new fmcadestoque();
            estoque.TopLevel = false;
            estoque.Dock = DockStyle.Fill;
            panelcentral.Controls.Clear();
          
            panelcentral.Controls.Add(estoque);
            estoque.Show();
            panelselecao.Top = button3.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fmcadproducao producao = new fmcadproducao();
            producao.TopLevel = false;
            producao.Dock = DockStyle.Fill;
            panelcentral.Controls.Clear();
   
            panelcentral.Controls.Add(producao);
            producao.Show();
            panelselecao.Top = button4.Top;
        }

        private void panelcentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            fmcadrelatorio relatorio = new fmcadrelatorio();
            relatorio.TopLevel = false;
            relatorio.Dock = DockStyle.Fill;
            panelcentral.Controls.Clear();

            panelcentral.Controls.Add(relatorio);
            relatorio.Show();
            
            panelselecao.Top = button5.Top;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fminicio inicio = new fminicio();
            inicio.TopLevel = false;
            inicio.Dock = DockStyle.Fill;
            panelcentral.Controls.Clear();
            panelcentral.Controls.Add(inicio);
            inicio.Show();

            panelselecao.Top = button6.Top;
        }

        private void panelfixo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
                this.Close();
                nomus inicio = new nomus();
                inicio.Show();

        }

        private void panelcentral_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
