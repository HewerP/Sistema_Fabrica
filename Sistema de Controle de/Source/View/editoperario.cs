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
using Sistema_de_Controle_de.Source.Controller;


namespace Sistema_de_Controle_de
{
    public partial class editoperario : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QNFEHMT\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=nomus2.0");
        public editoperario()
        {
            InitializeComponent();
            listarOperario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L541QP2\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=nomus2.0");

            for (int item = 0; item <= dataGridView1.CurrentRow.Index; item++)
            {
                OperarioController operarioController = new OperarioController();

                int id = Convert.ToInt32(dataGridView1.Rows[item].Cells[0].Value.ToString());
                string nome = dataGridView1.Rows[item].Cells[1].Value.ToString();
                string turno = dataGridView1.Rows[item].Cells[2].Value.ToString();
                string setor = dataGridView1.Rows[item].Cells[3].Value.ToString();

                operarioController.atualizarOperario(id, nome, setor, turno);

            }

            MessageBox.Show("Dados atualizados");
            

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
            MessageBox.Show("Dados atualizados");

            textBox1.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listarOperario()
        {
            OperarioController operarioController = new OperarioController();

            dataGridView1.DataSource = operarioController.listarOperario();
        }
    }
}
