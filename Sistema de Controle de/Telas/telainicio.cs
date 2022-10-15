using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Controle_de
{
    public partial class nomus : Form
    {
        public nomus()
        {
            InitializeComponent();
        }

        

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void telainicio_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "nomus 2.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.CharacterCasing = CharacterCasing.Upper;

            if (textBox1.Text == "ADMIN"  &&  textBox2.Text == "3006")
            {
                
                MessageBox.Show("Bem-vindo ao nomus 2.0");
                fmmenu form = new fmmenu();
                form.Show();
                this.Hide();


            }

            
            else
            {
                MessageBox.Show("usuário ou senha inválidos");
            }
            

        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
    }

}
