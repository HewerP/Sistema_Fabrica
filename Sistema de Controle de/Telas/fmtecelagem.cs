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
    public partial class fmtecelagem : Form
    {
        public fmtecelagem()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QNFEHMT\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=nomus2.0");

            string sql = "INSERT INTO cad_tecelagem(ID_OPERA, DATA_TECE, TURNO_TECE, TIPO_MATE,TEAR_TECE,PESO_TECE,METRAGEM,TELA_TECE, GM2,REFUGO) VALUES(@idope,@data,@turno, @tipomate, @tear, @peso, @metragem, @tela,@gm, @refugo)";



            try
            {
                SqlCommand c = new SqlCommand(sql, conn);
                c.Parameters.Add(new SqlParameter("@idope", this.textBox1.Text));
                c.Parameters.Add(new SqlParameter("@data", this.maskedTextBox1.Text));
                c.Parameters.Add(new SqlParameter("@turno", this.comboBox1.Text));
                c.Parameters.Add(new SqlParameter("@tipomate", this.comboBox2.Text));
                c.Parameters.Add(new SqlParameter("tear", this.textBox2.Text));
                c.Parameters.Add(new SqlParameter("@peso", this.textBox3.Text));
                c.Parameters.Add(new SqlParameter("@metragem", this.textBox4.Text));
                c.Parameters.Add(new SqlParameter("@tela", this.textBox5.Text));
                c.Parameters.Add(new SqlParameter("@gm", this.textBox7.Text));
                c.Parameters.Add(new SqlParameter("@refugo", this.textBox6.Text));


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
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";





        }

        private void fmtecelagem_Load(object sender, EventArgs e)
        {

        }
    }
}
