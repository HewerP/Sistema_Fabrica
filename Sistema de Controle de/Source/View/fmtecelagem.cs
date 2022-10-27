using Sistema_de_Controle_de.Source.Controller;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            TecelagemController tecelagemController = new TecelagemController();
            string dataInicio= this.maskedTextBox1.Text; 
            string dataTermino= "";
            string horarioEntrada="";
            string horarioSaida="";
            char turno= Convert.ToChar(this.comboBox1.Text);
            double quantidadeProduzida= Convert.ToDouble(this.textBox8.Text);
            string tear= this.textBox2.Text;
            double peso= Convert.ToDouble(this.textBox3.Text);
            double metragem= Convert.ToDouble(this.textBox4.Text);
            int tela= Convert.ToInt32(this.textBox5.Text);

            tecelagemController.inserirTecelagem( dataInicio, dataTermino, horarioEntrada, horarioSaida, turno, quantidadeProduzida, tear, peso, metragem, tela);

            MessageBox.Show("Cadastro efetuado com sucesso");

            maskedTextBox1.Text="";
            comboBox1.Text="";
            textBox8.Text="";
            textBox2.Text="";
            textBox3.Text="";
            textBox4.Text="";
            textBox5.Text="";

        }

        private void fmtecelagem_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
