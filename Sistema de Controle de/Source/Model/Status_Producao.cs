using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    internal class Status_Producao
    {
        private Ordem_Producao id_producao;
        private string etapaProducao;
        private string inicioEtapa;

        public Status_Producao(Ordem_Producao id_producao, string etapaProducao, string inicioEtapa)
        {
            this.id_producao = id_producao;
            this.etapaProducao = etapaProducao;
            this.inicioEtapa = inicioEtapa;
        }

        public Ordem_Producao getID_Producao()
        {
            return id_producao;
        }
        public void setID_Producao(Ordem_Producao id_producao)
        {
            this.id_producao = id_producao;
        }

        public string getEtapaProducao()
        {
            return etapaProducao;
        }
        public void setEtapaProducao(string etapaProducao)
        {
            etapaProducao = etapaProducao.Trim();
        }

        public string getInicioEtapa()
        {
            return inicioEtapa;
        }
        public void setInicioEtapa(string inicioEtapa)
        {
            inicioEtapa = inicioEtapa.Trim();
        }
    }
}
