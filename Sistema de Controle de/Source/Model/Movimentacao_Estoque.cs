using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    public class Movimentacao_Estoque
    {
        public int Id { get; set; }
        public Estoque MateriaPrima { get; set; }
        public string DataMovimentacao { get; set; }
        public string TipoProcesso { get; set; }

        public Movimentacao_Estoque(int id, Estoque materiaPrima, string dataMovimentacao, string tipoProcesso)
        {
            Id = id;
            MateriaPrima = materiaPrima;
            DataMovimentacao = dataMovimentacao;
            TipoProcesso = tipoProcesso;
        }
    }
}
