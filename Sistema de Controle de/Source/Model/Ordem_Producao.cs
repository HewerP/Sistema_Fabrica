using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    internal class Ordem_Producao:Producao
    {
        private Cliente cliente;
        private double quantidadeParaProduzir;
        private double quantidadeProduzida;
        private string itemPedido;
        private int tela;

        public Ordem_Producao(int id, Data_Producao data, char turno, double producao, Estoque material, Cliente cliente, double quantidadeParaProduzir, string itemPedido, int tela) : base(id, data, turno, producao, material)
        {
            this.cliente = cliente;
            this.quantidadeParaProduzir = quantidadeParaProduzir;
            this.itemPedido = itemPedido;
            this.tela = tela;
        }

        public Cliente getCliente()
        {
            return cliente;
        }
        public void setCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public double getQuantidadeParaProduzir()
        {
            return quantidadeParaProduzir;
        }
        public void setQuantidadeParaProduzir(double quantidadeParaProduzir)
        {
            this.quantidadeParaProduzir = quantidadeParaProduzir;
        }

        public double getQuantidadeProduzida()
        {
            return quantidadeProduzida;
        }
        public void setQuantidadeProduzida(double quantidadeProduzida)
        {
            this.quantidadeProduzida = quantidadeProduzida;
        }

        public string getItemPedido()
        {
            return itemPedido;
        }
        public void setItemPedido(string itemPedido)
        {
            this.itemPedido = itemPedido;
        }

        private int getTela()
        {
            return tela;
        }
        private void setTela(int tela)
        {
            this.tela = tela;
        }
    }
}
