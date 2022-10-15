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
    public partial class fmlaminadora1 : Form
    {
        public fmlaminadora1()
        {
            InitializeComponent();
        }

        private void fmlaminadora1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QNFEHMT\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=nomus2.0");

            string sql = "INSERT INTO cad_laminadora(ID_OPERA, DATA_LAMI, TURNO_LAMI, PESO_ENTRA,PESO_SAIDA,METRAGEM,GM2_ENTR,GM2_SAIDA, TELA_LAMI) VALUES(@idope,@dataex,@turnoex, @pesoentra, @pesosair, @metragem, @gmentra, @gmsaida,@tela)";



            try
            {
                SqlCommand c = new SqlCommand(sql, conn);
                c.Parameters.Add(new SqlParameter("@idope", this.textBox1.Text));
                c.Parameters.Add(new SqlParameter("@dataex", this.maskedTextBox1.Text));
                c.Parameters.Add(new SqlParameter("@turnoex", this.comboBox1.Text));
                c.Parameters.Add(new SqlParameter("@tela", this.textBox5.Text));
                c.Parameters.Add(new SqlParameter("pesoentra", this.textBox2.Text));
                c.Parameters.Add(new SqlParameter("@pesosair", this.textBox3.Text));
                c.Parameters.Add(new SqlParameter("@metragem", this.textBox4.Text));
                c.Parameters.Add(new SqlParameter("@gmentra", this.textBox6.Text));
                c.Parameters.Add(new SqlParameter("@gmsaida", this.textBox7.Text));


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
            textBox5.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

        }
    }
}
