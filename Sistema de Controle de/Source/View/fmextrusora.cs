using Sistema_de_Controle_de.Source.Controller;
using Sistema_de_Controle_de.Source.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            ExtrusaoController extrusaoController = new ExtrusaoController();

            string dataInicio = this.textBox1.Text;
            char turno = Convert.ToChar(this.comboBox1.Text);
            double quantidadeProduzida = Convert.ToDouble(this.textBox2.Text);
            double velocidade = Convert.ToDouble(this.textBox4.Text);
            string maquina = this.comboBox2.Text;
            double refugo = Convert.ToDouble(this.textBox3.Text);

            string dataTermino =""; string horarioEntrada=""; string horarioSaida="";


            extrusaoController.inserirExtrusao( dataInicio, dataTermino, horarioEntrada, horarioSaida, turno, quantidadeProduzida, velocidade, maquina, refugo);

            MessageBox.Show("Cadastro efetuado com sucesso");

            textBox1.Text= "";
            comboBox1.Text="";
            textBox2.Text="";
            textBox4.Text="";
            comboBox2.Text="";
            textBox3.Text="";

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
