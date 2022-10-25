using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string DataNascimento { get; set; }
        public Endereco Endereco { get; set; }

        /*public Cliente(string nome, string telefone, string email, string dataNascimento, Endereco endereco)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            DataNascimento = dataNascimento;
            Endereco = endereco;
        }*/
    }
}
