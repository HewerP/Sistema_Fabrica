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
    internal class ExtrusaoController
    {
        
        public void inserirExtrusao(string dataInicio, string dataTermino, string horarioEntrada, string horarioSaida, char turno, double quantidadeProduzida, Estoque material, double velocidade, string maquina, double refugo)
        {
            using (var tb = new Nomus_System())
            {
                Data_Producao data_Producao = new Data_Producao { DataInicio = dataInicio, DataTermino = dataTermino, HorarioEntrada = horarioEntrada, HorarioSaida = horarioSaida };
                tb.Datas_Producoes.Add(data_Producao);
                tb.Extrusoes.Add(new Extrusao(data_Producao, turno, quantidadeProduzida, material, velocidade, maquina, refugo));
                tb.SaveChanges();
            }
        }

        public void deletarExtrusao(int id)
        {
            using (var tb = new Nomus_System())
            {
                var extrusao = tb.Extrusoes.Find(id);

                tb.Extrusoes.Remove(extrusao);
                tb.SaveChanges();
            }
        }

        //atualizar ainda n ta feito.
        public void atualizarExtrusao(int id, string dataInicio, string dataTermino, string horarioEntrada, string horarioSaida, char turno, double quantidadeProduzida, Estoque material, double velocidade, string maquina, double refugo)
        {
            using (var tb = new Nomus_System())
            {
                var extrusao = tb.Extrusoes.Find(id);

                extrusao.Data.DataInicio = dataInicio;
                extrusao.Data.DataTermino = dataTermino;
                extrusao.Data.HorarioEntrada = horarioEntrada;
                extrusao.Data.HorarioSaida = horarioSaida;
                extrusao.Turno = turno;
                extrusao.QuantidadeProduzida = quantidadeProduzida;
                extrusao.Material = material;
                extrusao.Velocidade = velocidade;
                extrusao.Maquina = maquina;
                extrusao.Refugo = refugo;

                tb.Entry(extrusao).State = EntityState.Modified;
                tb.SaveChanges();
            }
        }

        public object listarExtrusao()
        {
            using (var tb = new Nomus_System())
            {
                var list = tb.Extrusoes.ToList();
                return list;
            }
        }

        public object buscarExtrusao(int id)
        {
            using (var tb = new Nomus_System())
            {
                List<Extrusao> list;

                if (id != 0)
                {
                    list = tb.Extrusoes.Where(x => x.Id == id).AsEnumerable().ToList();
                }
                else
                {
                    list = tb.Extrusoes.ToList();
                }

                return list;
            }
        }

    }
}
