using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    public class Laminadora:Producao
    {

        public double PesoEntrada { get; set; }
        public double PesoSaida { get; set; }
        public double GramaturaEntrada { get; set; }
        public double GramaturaSaida { get; set; }
        public double Metragem { get; set; }
        public int Tela { get; set; }

        public Laminadora( Data_Producao data, char turno, double quantidadeProduzida, Estoque material, double pesoEntrada, double pesoSaida, double gramaturaEntrada, double gramaturaSaida, double metragem, int tela) : base( data, turno, quantidadeProduzida, material)
        {
            PesoEntrada = pesoEntrada;
            PesoSaida = pesoSaida;
            GramaturaEntrada = gramaturaEntrada;
            GramaturaSaida = gramaturaSaida;
            Metragem = metragem;
            Tela = tela;
        }
    }
}
