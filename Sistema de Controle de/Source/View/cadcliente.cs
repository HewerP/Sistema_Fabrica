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
    public partial class cadcliente : Form
    {
        public cadcliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        public static bool ValidarEmail(string strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if( System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        
            if (ValidarEmail(maskedTextBox3.Text) == false)
            {
                MessageBox.Show("Email com formato incorreto!", "ef3.Cinco");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QNFEHMT\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=nomus2.0");

            string sql = "INSERT INTO cad_cliente(NOME_CLI, DATA_CLI, TELE_CLI, EMAIL_CLI,RUA_CLI,NUMCASA_CLI,COMPLE_CLI,BAIRRO_CLI,CIDADE_CLI,UF_CLI) VALUES(@nome,@data,@telefone,@email, @rua, @nmr, @complemento, @bairro, @cidade, @uf)";



            try
            {
                SqlCommand c = new SqlCommand(sql, conn);
                c.Parameters.Add(new SqlParameter("nome", this.textBox1.Text));
                c.Parameters.Add(new SqlParameter("@data", this.maskedTextBox1.Text));
                c.Parameters.Add(new SqlParameter("@telefone", this.maskedTextBox2.Text));
                c.Parameters.Add(new SqlParameter("@email", this.maskedTextBox3.Text));
                c.Parameters.Add(new SqlParameter("@rua", this.maskedTextBox4.Text));
                c.Parameters.Add(new SqlParameter("@nmr", this.maskedTextBox5.Text));
                c.Parameters.Add(new SqlParameter("@complemento", this.maskedTextBox6.Text));
                c.Parameters.Add(new SqlParameter("@bairro", this.maskedTextBox7.Text));
                c.Parameters.Add(new SqlParameter("@cidade", this.maskedTextBox9.Text));
                c.Parameters.Add(new SqlParameter("@uf", this.comboBox1.Text));

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
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";
            maskedTextBox5.Text = "";
            maskedTextBox6.Text = "";
            maskedTextBox7.Text = "";
            maskedTextBox9.Text = "";
            comboBox1.Text = "";


        }

       
        private void cadcliente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
