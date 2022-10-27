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
    public partial class pesquisarcliente : Form
    {
        public pesquisarcliente()
        {
            InitializeComponent();
            listarCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteController clienteController = new ClienteController();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clienteController.buscarCliente(textBox1.Text);

            textBox1.Text = "";
        }

        private void listarCliente()
        {
            ClienteController clienteController = new ClienteController();

            dataGridView1.DataSource = clienteController.listarCliente();
        }
    }
}
