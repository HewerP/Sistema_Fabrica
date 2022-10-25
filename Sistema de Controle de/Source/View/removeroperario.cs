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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Controle_de
{
    public partial class removeroperario : Form
    {
        public removeroperario()
        {
            InitializeComponent();
            atualizarGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperarioController operarioController = new OperarioController();

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            operarioController.deletarOperario(id);

            MessageBox.Show("Dados removido");
            atualizarGrid();


        }

        private void removeroperario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.cad_operario'. Você pode movê-la ou removê-la conforme necessário.
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        public void atualizarGrid()
        {
            OperarioController operarioController = new OperarioController();

            dataGridView1.DataSource = operarioController.listarOperario();
        }
    }
}
