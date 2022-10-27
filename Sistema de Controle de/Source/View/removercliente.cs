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
    public partial class removercliente : Form
    {
        public removercliente()
        {
            InitializeComponent();
            atualizarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteController clienteController = new ClienteController();

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            clienteController.deletarCliente(id);

            MessageBox.Show("Dados removido");
            atualizarGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClienteController clienteController = new ClienteController();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clienteController.buscarCliente(textBox1.Text);
            MessageBox.Show("Dados atualizados");

            textBox1.Text = "";
        }

        public void atualizarGrid()
        {
            ClienteController clienteController = new ClienteController();

            dataGridView1.DataSource = clienteController.listarCliente();
        }
    }
}
