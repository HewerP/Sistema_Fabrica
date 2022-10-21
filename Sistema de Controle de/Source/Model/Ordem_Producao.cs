using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    public class Ordem_Producao:Producao
    {
        public Cliente Cliente { get; set; }
        public double QuantidadeParaProduzir { get; set; }
        public string ItemPedido { get; set; }
        public int Tela { get; set; }

        public Ordem_Producao(int id, Data_Producao data, char turno, double quantidadeProduzida, Estoque material, Cliente cliente, double quantidadeParaProduzir, string itemPedido, int tela) : base(id, data, turno, quantidadeProduzida, material)
        {
            Cliente = cliente;
            QuantidadeParaProduzir = quantidadeParaProduzir;
            ItemPedido = itemPedido;
            Tela = tela;
        }
    }
}
