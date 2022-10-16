using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    internal class Cliente
    {
        private string nome;
        private string telefone;
        private string email;
        private string dataNascimento;
        private Endereco endereco;

        public Cliente(string nome, string telefone, string email, string dataNascimento, Endereco endereco)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.dataNascimento = dataNascimento;
            this.endereco = endereco;
        }

        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getTelefone()
        {
            return telefone;
        }
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string getEmail()
        {
            return email;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getDataNascimento()
        {
            return dataNascimento;
        }
        public void setDataNascimento(string dataNascimento)
        {
            this.dataNascimento = dataNascimento;
        }

        public Endereco getEndereco()
        {
            return endereco;
        }
        public void setEndereco(Endereco endereco)
        {
            this.endereco = endereco;
        }
    }
}
