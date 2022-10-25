using Sistema_de_Controle_de.Source.Controller;
using Sistema_de_Controle_de.Source.Model;
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
            ClienteController clienteController = new ClienteController();

            string nome = this.textBox1.Text;
            string telefone = this.maskedTextBox2.Text;
            string email = this.maskedTextBox3.Text;
            string dataNascimento = this.maskedTextBox1.Text;
            string rua = this.maskedTextBox4.Text;
            int nCasa = Convert.ToInt32(this.maskedTextBox5.Text);
            string complemento = this.maskedTextBox6.Text;
            string bairro = this.maskedTextBox7.Text;
            string cidade = this.maskedTextBox9.Text;
            string estado = this.comboBox1.Text;

            clienteController.inserirCliente(nome, telefone, email, dataNascimento, rua, nCasa, complemento, bairro, cidade, estado);

            MessageBox.Show("Cadastro efetuado com sucesso");
            

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
