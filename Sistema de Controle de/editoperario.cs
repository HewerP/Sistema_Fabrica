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
    public partial class editoperario : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QNFEHMT\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=nomus2.0");
        public editoperario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QNFEHMT\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=nomus2.0");
          



            for (int item = 0; item <= dataGridView1.Rows.Count-1; item++)
            {
                SqlCommand cmd = new SqlCommand("UPDATE cad_operario SET ID_OPER = @id, NOME_OPER=@nome, TURNO_OPER=@turno,SETOR_OPER=@setor WHERE NOME_OPER='" + textBox1.Text+ "'", conn);
                cmd.Parameters.AddWithValue("@nome", dataGridView1.Rows[item].Cells[1].Value);
                cmd.Parameters.AddWithValue("@turno", dataGridView1.Rows[item].Cells[2].Value);
                cmd.Parameters.AddWithValue("@setor", dataGridView1.Rows[item].Cells[3].Value);
                cmd.Parameters.AddWithValue("@id", dataGridView1.Rows[item].Cells[0].Value);


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
               

            }

            MessageBox.Show("Dados atualizados");
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QNFEHMT\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=nomus2.0");







            try
            {

                conn.Open();

                string sql = "SELECT * FROM cad_operario WHERE NOME_OPER='" + textBox1.Text + "'";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
