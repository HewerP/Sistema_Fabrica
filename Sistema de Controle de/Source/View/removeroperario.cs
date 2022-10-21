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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L541QP2\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=nomus2.0");

            int item = 0;

            item = dataGridView1.CurrentRow.Index;

            SqlCommand cmd = new SqlCommand("delete FROM cad_operario where ID_OPER =@id", conn);
            cmd.Parameters.AddWithValue("@id", dataGridView1.Rows[item].Cells[0].Value);


            conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

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
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L541QP2\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=nomus2.0");

            try
            {
                conn.Open();

                string sql = "SELECT * FROM cad_operario";

                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
