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
    public partial class fmordemdeprdoucao : Form
    {
        public fmordemdeprdoucao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fmordemdeprdoucao_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QNFEHMT\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=nomus2.0");

            string sql = "INSERT INTO cad_ordemdeprod(ORDEM_PROD, ID_CLIENTE, ITEM, TELA_PROD,QNT_A_PRODU,ID_OPER,TURNO_PROD,DT_INI,DT_TERMINO,HR_INI,HR_TERMINO,QNTD_PRODU,SACOS,CENTRO_CUSTO,STATUS_OP) VALUES(@ordem,@idcli,@item,@tela, @qntdapro, @idope, @turno, @dtinicio, @dttermino, @hrinicio,@hrtermi,@qntprod,@sacos,@centro,@status)";



            try
            {
                SqlCommand c = new SqlCommand(sql, conn);
                c.Parameters.Add(new SqlParameter("@ordem", this.textBox4.Text));
                c.Parameters.Add(new SqlParameter("@idcli", this.textBox2.Text));
                c.Parameters.Add(new SqlParameter("@item", this.comboBox1.Text));
                c.Parameters.Add(new SqlParameter("@tela", this.textBox5.Text));
                c.Parameters.Add(new SqlParameter("@qntdapro", this.textBox3.Text));
                c.Parameters.Add(new SqlParameter("@idope", this.textBox1.Text));
                c.Parameters.Add(new SqlParameter("@turno", this.comboBox2.Text));
                c.Parameters.Add(new SqlParameter("@dtinicio", this.maskedTextBox1.Text));
                c.Parameters.Add(new SqlParameter("@dttermino", this.maskedTextBox2.Text));
                c.Parameters.Add(new SqlParameter("@hrinicio", this.maskedTextBox3.Text));
                c.Parameters.Add(new SqlParameter("@hrtermi", this.maskedTextBox4.Text));
                c.Parameters.Add(new SqlParameter("@qntprod", this.textBox6.Text));
                c.Parameters.Add(new SqlParameter("@sacos", this.textBox7.Text));
                c.Parameters.Add(new SqlParameter("@centro", this.comboBox4.Text));
                c.Parameters.Add(new SqlParameter("@status", this.comboBox3.Text));

                conn.Open();

                c.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Cadastro efetuado com sucesso");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
            finally
            {
                conn.Close();
            }

            textBox4.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            textBox5.Text = "";
            textBox3.Text = "";
            textBox1.Text = "";
            comboBox2.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox4.Text = "";
            comboBox3.Text = "";




        }
    }
}
