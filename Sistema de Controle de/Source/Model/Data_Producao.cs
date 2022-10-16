using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    internal class Data_Producao
    {
        private string dataInicio;
        private string dataTermino;
        private string horarioEntrada;
        private string horarioSaida;

        public Data_Producao(string dataInicio, string dataTermino, string horarioEntrada, string horarioSaida)
        {
            this.dataInicio = dataInicio;
            this.dataTermino = dataTermino;
            this.horarioEntrada = horarioEntrada;
            this.horarioSaida = horarioSaida;
        }

        public string getDataInicio()
        {
            return dataInicio;
        }
        public void setDataInicio(string dataInicio)
        {
            this.dataInicio = dataInicio;
        }

        public string getDataTermino()
        {
            return dataTermino;
        }
        public void setDataTermino(string dataTermino)
        {
            this.dataTermino = dataTermino;
        }

        public string getHorarioEntrada()
        {
            return horarioEntrada;
        }
        public void setHorarioEntrada(string horarioEntrada)
        {
            this.horarioEntrada = horarioEntrada;
        }

        public string getHorarioSaida()
        {
            return horarioSaida;
        }
        public void setHorarioSaida(string horarioSaida)
        {
            this.horarioSaida = horarioSaida;
        }
    }
}
