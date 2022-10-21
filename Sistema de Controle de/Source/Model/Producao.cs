using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    public abstract class Producao
    {
        public int Id { get; set; }
        public Data_Producao Data { get; set; }
        public char Turno { get; set; }
        public double QuantidadeProduzida { get; set; }
        public Estoque Material { get; set; }

        public Producao(int id, Data_Producao data, char turno, double quantidadeProduzida, Estoque material)
        {
            this.Id = id;
            this.Data = data;
            this.Turno = turno;
            this.QuantidadeProduzida = quantidadeProduzida;
            this.Material = material;
        }
    }
}
