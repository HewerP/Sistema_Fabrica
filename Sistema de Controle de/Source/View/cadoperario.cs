using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Sistema_de_Controle_de.Source.Context;

namespace Sistema_de_Controle_de
{
    public partial class cadoperario : Form
    {
        public cadoperario()
        {
            
            InitializeComponent();
        }

       
    


        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L541QP2\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=nomus2.0");

            //string sql = "INSERT INTO cad_operario(ID_OPER, NOME_OPER, TURNO_OPER, SETOR_OPER) VALUES(@id,@nome,@turno,@setor)";

            using (var tb = new Nomus_System())
            {
                tb.Operarios.Add(new Source.Model.Operario { Nome = this.textBox2.Text, Setor = this.comboBox2.Text, Turno = this.comboBox1.Text });
                tb.SaveChanges();
            }

                /*try
                {
                    SqlCommand c = new SqlCommand(sql, conn);
                    c.Parameters.Add(new SqlParameter("id", this.textBox1.Text));
                    c.Parameters.Add(new SqlParameter("@nome", this.textBox2.Text));
                    c.Parameters.Add(new SqlParameter("@turno", this.comboBox1.Text));
                    c.Parameters.Add(new SqlParameter("@setor", this.comboBox2.Text));

                    conn.Open();

                    c.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Cadastro efetuado com sucesso");
                }
                catch (SqlException ex) {
                    MessageBox.Show("Ocorreu um erro: " + ex);
                }
                finally
                {
                    conn.Close();
                }*/

            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";








        }

        private void cadoperario_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
