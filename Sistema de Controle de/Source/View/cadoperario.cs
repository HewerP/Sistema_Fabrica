using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Sistema_de_Controle_de.Source.Controller;

namespace Sistema_de_Controle_de
{
    public partial class cadoperario : Form
    {
        public cadoperario()
        {
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OperarioController operarioController = new OperarioController();
            operarioController.inserirOperario(this.textBox2.Text, this.comboBox2.Text, this.comboBox1.Text);
            MessageBox.Show("Cadastro efetuado com sucesso");

            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void cadoperario_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
