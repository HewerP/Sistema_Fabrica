using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    internal class Tecelagem:Producao
    {
        private string tear;
        private double peso;
        private double metragem;
        private int tela;

        public Tecelagem(int id, Data_Producao data, char turno, double producao, Estoque material, string tear, double peso, double metragem, int tela) : base(id, data, turno, producao, material)
        {
            this.tear = tear;
            this.peso = peso;
            this.metragem = metragem;
            this.tela = tela;
        }

        private string getTear()
        {
            return tear;
        }
        private void setTear(string tear)
        {
            this.tear = tear;
        }

        private double getPeso()
        {
            return peso;
        }
        private void setPeso(double peso)
        {
            this.peso = peso;
        }

        private double getMetragem()
        {
            return metragem;
        }
        private void setMetragem(double metragem)
        {
            this.metragem = metragem;
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
