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
    public partial class fmextrusora : Form
    {
        public fmextrusora()
        {
            InitializeComponent();
        }

        private void fmextrusora_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QNFEHMT\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=nomus2.0");

            string sql = "INSERT INTO cad_extrusora(ID_OPERA, DATA_EXTRU, TURNO_EXTRU, TIPO_MATER,MAQ_EXTRU,VELO_EXTRU,QNT_PRODU,REFUGO_EXTRU) VALUES(@idope,@dataex,@turnoex,@tipomate, @maquina, @velocidade, @qntdproduzida, @refugo)";



            try
            {
                SqlCommand c = new SqlCommand(sql, conn);
                c.Parameters.Add(new SqlParameter("@idope", this.textBox1.Text));
                c.Parameters.Add(new SqlParameter("@dataex", this.maskedTextBox1.Text));
                c.Parameters.Add(new SqlParameter("@turnoex", this.comboBox1.Text));
                c.Parameters.Add(new SqlParameter("@tipomate", this.comboBox2.Text));
                c.Parameters.Add(new SqlParameter("@maquina", this.comboBox3.Text));
                c.Parameters.Add(new SqlParameter("@velocidade", this.textBox4.Text));
                c.Parameters.Add(new SqlParameter("@qntdproduzida", this.textBox2.Text));
                c.Parameters.Add(new SqlParameter("@refugo", this.textBox3.Text));
                

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

            textBox1.Text = "";
            maskedTextBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox4.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";





        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
