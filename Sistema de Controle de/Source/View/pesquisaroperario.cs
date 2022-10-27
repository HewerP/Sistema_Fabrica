using Sistema_de_Controle_de.Source.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Controle_de
{
    public partial class pesquisaroperario : Form
    {
        public pesquisaroperario()
        {
            InitializeComponent();
            listarOperario();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperarioController operarioController = new OperarioController();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = operarioController.buscarOperario(textBox1.Text);

            textBox1.Text = "";

        }
        private void listarOperario()
        {
            OperarioController operarioController = new OperarioController();

            dataGridView1.DataSource = operarioController.listarOperario();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OperarioController operarioController = new OperarioController();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = operarioController.buscarOperario(textBox1.Text);

            textBox1.Text = "";
        }
    }
}
