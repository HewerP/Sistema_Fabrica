using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    internal class Movimentacao_Estoque
    {
        private Estoque materiaPrima;
        private string dataMovimentacao;
        private string tipoProcesso;

        public Movimentacao_Estoque(Estoque materiaPrima, string dataMovimentacao, string tipoProcesso)
        {
            this.materiaPrima = materiaPrima;
            this.dataMovimentacao = dataMovimentacao;
            this.tipoProcesso = tipoProcesso;
        }

        public Estoque getMateriaPrima()
        {
            return materiaPrima;
        }
        public void setMateriaPrima(Estoque materiaPrima)
        {
            this.materiaPrima = materiaPrima;
        }

        public string getDataMovimentacao()
        {
            return dataMovimentacao;
        }
        public void setDataMovimentacao(string dataMovimentacao)
        {
            this.dataMovimentacao = dataMovimentacao;
        }

        public string getTipoProcesso()
        {
            return tipoProcesso;
        }
        public void setTipoProcesso(string tipoProcesso)
        {
            this.tipoProcesso = tipoProcesso;
        }
    }
}
