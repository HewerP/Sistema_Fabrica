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
    public partial class attestoque : Form
    {
        public attestoque()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QNFEHMT\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=nomus2.0");



            try
            {

                conn.Open();

                string sql = "SELECT * FROM cad_estoque";

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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
