using Sistema_de_Controle_de.Source.Context;
using Sistema_de_Controle_de.Source.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Sistema_de_Controle_de.Source.Controller
{
    internal class Ordem_ProducaoController
    {

        public void inserirOrdem_Producao(string dataInicio, string dataTermino, string horarioEntrada, string horarioSaida, char turno, double quantidadeProduzida, Estoque material, Cliente cliente, double quantidadeParaProduzir, string itemPedido, int tela)
        {
            using (var tb = new Nomus_System())
            {
                Data_Producao data_Producao = new Data_Producao { DataInicio = dataInicio, DataTermino = dataTermino, HorarioEntrada = horarioEntrada, HorarioSaida = horarioSaida };
                Ordem_Producao ordem_Producao = new Ordem_Producao(data_Producao, turno, quantidadeProduzida, cliente, quantidadeParaProduzir, itemPedido, tela);
                //Status_Producao status_Producao = new Status_Producao(ordem_Producao, etapaProducao, inicioEtapa);
                tb.Datas_Producoes.Add(data_Producao);
                tb.Ordens_Producao.Add(ordem_Producao);
                tb.SaveChanges();
            }
        }

        public void deletarOrdem_Producao(int id)
        {
            using (var tb = new Nomus_System())
            {
                var ordem_Producao = tb.Ordens_Producao.Find(id);

                tb.Ordens_Producao.Remove(ordem_Producao);
                tb.SaveChanges();
            }
        }

        public void atualizarOrdem_Producao(int id, string dataInicio, string dataTermino, string horarioEntrada, string horarioSaida, char turno, double quantidadeProduzida, Estoque material, Cliente cliente, double quantidadeParaProduzir, string itemPedido, int tela)
        {
            using (var tb = new Nomus_System())
            {
                var ordem_Producao = tb.Ordens_Producao.Find(id);


                ordem_Producao.Data.DataInicio = dataInicio;
                ordem_Producao.Data.DataTermino = dataTermino;
                ordem_Producao.Data.HorarioEntrada = horarioEntrada;
                ordem_Producao.Data.HorarioSaida = horarioSaida;
                ordem_Producao.Turno = turno;
                ordem_Producao.QuantidadeProduzida = quantidadeProduzida;
                ordem_Producao.Material = material;
                ordem_Producao.Cliente = cliente;
                ordem_Producao.QuantidadeParaProduzir = quantidadeParaProduzir;
                ordem_Producao.ItemPedido = itemPedido;
                ordem_Producao.Tela = tela;

                tb.Entry(ordem_Producao).State = EntityState.Modified;
                tb.SaveChanges();
            }
        }

        public object listarOrdem_Producao()
        {
            using (var tb = new Nomus_System())
            {
                var list = tb.Ordens_Producao.ToList();
                return list;
            }
        }

        public object buscarOrdem_Producao(int id)
        {
            using (var tb = new Nomus_System())
            {
                List<Ordem_Producao> list;

                if (id != 0)
                {
                    list = tb.Ordens_Producao.Where(x => x.Id == id).AsEnumerable().ToList();
                }
                else
                {
                    list = tb.Ordens_Producao.ToList();
                }

                return list;
            }
        }
    }
}
