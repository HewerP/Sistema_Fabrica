using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    public class Extrusao:Producao
    {

        public double Velocidade { get; set; }
        public string Maquina { get; set; }
        public double Refugo { get; set; }
        

        public Extrusao(Data_Producao data, char turno, double quantidadeProduzida, Estoque material, double velocidade, string maquina, double refugo) : base(data, turno, quantidadeProduzida, material)
        {
            Velocidade = velocidade;
            Maquina = maquina;
            Refugo = refugo;
        }
    }
}
