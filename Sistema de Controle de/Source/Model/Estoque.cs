using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    internal class Estoque
    {
        private int id;
        private int quantidade;
        private string tipo_estoque;

        public Estoque(int id, int quantidade, string tipo_estoque)
        {
            this.id = id;
            this.quantidade = quantidade;
            this.tipo_estoque = tipo_estoque;
        }

        public int getID()
        {
            return id;
        }
        public void setID(int id)
        {
            this.id = id;
        }

        public int getQuantidade()
        {
            return quantidade;
        }
        public void setQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }

        public string getTipo_Estoque()
        {
            return tipo_estoque;
        }
        public void setTipo_Estoque(string tipo_estoque)
        {
            this.tipo_estoque = tipo_estoque.Trim();
        }
    }
}
