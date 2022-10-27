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
    public partial class editarcliente : Form
    {
        public editarcliente()
        {
            InitializeComponent();
            listarCliente();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClienteController clienteController = new ClienteController();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clienteController.buscarCliente(textBox1.Text);
            MessageBox.Show("Dados atualizados");

            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int item = 0; item <= dataGridView1.CurrentRow.Index; item++)
            {
                ClienteController operarioController = new ClienteController();

                int id = Convert.ToInt32(dataGridView1.Rows[item].Cells[0].Value.ToString());
                string nome = dataGridView1.Rows[item].Cells[1].Value.ToString();
                string telefone = dataGridView1.Rows[item].Cells[2].Value.ToString();
                string email = dataGridView1.Rows[item].Cells[3].Value.ToString();
                string dataNascimento = dataGridView1.Rows[item].Cells[4].Value.ToString();
                string rua = null; //dataGridView1.Rows[item].Cells[5].Value.ToString();
                int nCasa = 0; //Convert.ToInt32(dataGridView1.Rows[item].Cells[6].Value.ToString());
                string complemento = null; // dataGridView1.Rows[item].Cells[7].Value.ToString();
                string bairro = null; //dataGridView1.Rows[item].Cells[8].Value.ToString();
                string cidade = null; //dataGridView1.Rows[item].Cells[9].Value.ToString();
                string estado = null; // dataGridView1.Rows[item].Cells[10].Value.ToString();

                operarioController.atualizarCliente(id, nome, telefone, email, dataNascimento, rua, nCasa, complemento, bairro, cidade, estado);

            }

            MessageBox.Show("Dados atualizados");

        }

        public void listarCliente()
        {
            ClienteController cliente = new ClienteController();

            dataGridView1.DataSource = cliente.listarCliente();
        }
    }
}
