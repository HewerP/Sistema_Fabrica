using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    public class Data_Producao
    {
        public int Id { get; set; }
        public string DataInicio { get; set; }
        public string DataTermino { get; set; }
        public string HorarioEntrada { get; set; }
        public string HorarioSaida { get; set; }

        public Data_Producao(int id, string dataInicio, string dataTermino, string horarioEntrada, string horarioSaida)
        {
            Id = id;
            DataInicio = dataInicio;
            DataTermino = dataTermino;
            HorarioEntrada = horarioEntrada;
            HorarioSaida = horarioSaida;
        }
    }
}
