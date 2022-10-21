using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    public class Estoque
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public string Tipo_estoque { get; set; }

        public Estoque(int id, int quantidade, string tipo_estoque)
        {
            Id = id;
            Quantidade = quantidade;
            Tipo_estoque = tipo_estoque;
        }
    }
}
