using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    public class Tecelagem:Producao
    {

        public string Tear { get; set; }
        public double Peso { get; set; }
        public double Metragem { get; set; }
        public int Tela { get; set; }

        public Tecelagem( Data_Producao data, char turno, double quantidadeProduzida, string tear, double peso, double metragem, int tela) : base(data, turno, quantidadeProduzida)
        {
            Tear = tear;
            Peso = peso;
            Metragem = metragem;
            Tela = tela;
        }
    }
}
