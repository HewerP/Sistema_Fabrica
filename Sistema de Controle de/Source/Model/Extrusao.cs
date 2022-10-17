using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    internal class Extrusao:Producao
    {
        private double velocidade;
        private string maquina;
        private double refugo;

        public Extrusao(int id, Data_Producao data, char turno, double producao, Estoque material, double velocidade, string maquina, double refugo) : base(id, data, turno, producao, material)
        {
            this.velocidade = velocidade;
            this.maquina = maquina;
            this.refugo = refugo;
        }

        public double getVelocidade()
        {
            return velocidade;
        }
        public void setVelocidade(double velocidade)
        {
            this.velocidade = velocidade;
        }

        public string getMaquina()
        {
            return maquina;
        }
        public void setMaquina(string maquina)
        {
            this.maquina = maquina;
        }

        public double getRefugo()
        {
            return refugo;
        }
        public void setRefugo(double refugo)
        {
            this.refugo = refugo;
        }
    }
}
