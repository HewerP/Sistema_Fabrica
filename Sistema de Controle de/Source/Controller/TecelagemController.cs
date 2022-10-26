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
    internal class TecelagemController
    {
        public void inserirtTecelagem(string dataInicio, string dataTermino, string horarioEntrada, string horarioSaida, char turno, double quantidadeProduzida, Estoque material, string tear, double peso, double metragem, int tela)
        {
            using (var tb = new Nomus_System())
            {
                Data_Producao data_Producao = new Data_Producao { DataInicio = dataInicio, DataTermino = dataTermino, HorarioEntrada = horarioEntrada, HorarioSaida = horarioSaida };
                tb.Datas_Producoes.Add(data_Producao);
                tb.Tecelagens.Add(new Tecelagem(data_Producao, turno, quantidadeProduzida, material, tear, peso, metragem, tela));
                tb.SaveChanges();
            }
        }

        public void deletarTecelagem(int id)
        {
            using (var tb = new Nomus_System())
            {
                var tecelagem = tb.Tecelagens.Find(id);

                tb.Tecelagens.Remove(tecelagem);
                tb.SaveChanges();
            }
        }

        //atualizar ainda n ta feito.
        public void atualizarTecelagem(int id, string dataInicio, string dataTermino, string horarioEntrada, string horarioSaida, char turno, double quantidadeProduzida, Estoque material, string tear, double peso, double metragem, int tela)
        {
            using (var tb = new Nomus_System())
            {
                var tecelagem = tb.Tecelagens.Find(id);

                tecelagem.Data.DataInicio = dataInicio;
                tecelagem.Data.DataTermino = dataTermino;
                tecelagem.Data.HorarioEntrada = horarioEntrada;
                tecelagem.Data.HorarioSaida = horarioSaida;
                tecelagem.Turno = turno;
                tecelagem.QuantidadeProduzida = quantidadeProduzida;
                tecelagem.Material = material;
                tecelagem.Tear = tear;
                tecelagem.Peso = peso;
                tecelagem.Metragem = metragem;
                tecelagem.Tela = tela;
                

                tb.Entry(tecelagem).State = EntityState.Modified;
                tb.SaveChanges();
            }
        }

        public object listarTecelagem()
        {
            using (var tb = new Nomus_System())
            {
                var list = tb.Tecelagens.ToList();
                return list;
            }
        }

        public object buscarTecelagem(int id)
        {
            using (var tb = new Nomus_System())
            {
                List<Tecelagem> list;

                if (id !=0)
                {
                    list = tb.Tecelagens.Where(x => x.Id == id).AsEnumerable().ToList();
                }
                else
                {
                    list = tb.Tecelagens.ToList();
                }

                return list;
            }
        }
    }
}
