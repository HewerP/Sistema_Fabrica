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
    public partial class deleteproducao : Form
    {
        public deleteproducao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
