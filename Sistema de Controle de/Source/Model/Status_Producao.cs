using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    public class Status_Producao
    {
        public Ordem_Producao Id_producao { get; set; }
        public string EtapaProducao { get; set; }
        public string InicioEtapa { get; set; }

        public Status_Producao(Ordem_Producao id_producao, string etapaProducao, string inicioEtapa)
        {
            Id_producao = id_producao;
            EtapaProducao = etapaProducao;
            InicioEtapa = inicioEtapa;
        }
    }
}
