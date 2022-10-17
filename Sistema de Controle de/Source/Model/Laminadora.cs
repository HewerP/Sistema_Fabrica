using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    internal class Laminadora:Producao
    {
        private double pesoEntrada;
        private double pesoSaida;
        private double gramaturaEntrada;
        private double gramaturaSaida;
        private double metragem;
        private int tela;

        public Laminadora(int id, Data_Producao data, char turno, double producao, Estoque material, double pesoEntrada, double gramaturaEntrada, double metragem, int tela) : base(id, data, turno, producao, material)
        {
            this.pesoEntrada = pesoEntrada;
            this.gramaturaEntrada = gramaturaEntrada;
            this.metragem = metragem;
            this.tela = tela;
        }

        private double getPesoEntrada()
        {
            return pesoEntrada;
        }
        private void setPesoEntrada(double pesoEntrada)
        {
            this.pesoEntrada = pesoEntrada;
        }

        private double getPesoSaida()
        {
            return pesoSaida;
        }
        private void setPesoSaida(double pesoSaida)
        {
            this.pesoSaida = pesoSaida;
        }

        private double getGramaturaEntrada()
        {
            return gramaturaEntrada;
        }
        private void setGramaturaEntrada(double gramaturaEntrada)
        {
            this.gramaturaEntrada = gramaturaEntrada;
        }

        private double getGramaturaSaida()
        {
            return gramaturaSaida;
        }
        private void setGramaturaSaida(double gramaturaSaida)
        {
            this.gramaturaSaida = gramaturaSaida;
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
