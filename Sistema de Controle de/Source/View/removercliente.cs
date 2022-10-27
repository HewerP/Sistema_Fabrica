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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strcon = "Data Source=DESKTOP-QNFEHMT\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=nomus2.0";

            if (MessageBox.Show("Deseja Excluir o cadastro?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação Cancelada!!!");
            }
            else
            {
                string comando = "delete from cad_cliente where  NOME_CLI = @nome";

                SqlConnection conn = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand(comando, conn);

                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = textBox1.Text;

                try
                {
                    conn.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente removido com sucesso");

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);

                }
                finally
                {
                    conn.Close();
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QNFEHMT\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=nomus2.0");







            try
            {

                conn.Open();

                string sql = "SELECT * FROM cad_cliente WHERE NOME_CLI='" + textBox1.Text + "'";

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
