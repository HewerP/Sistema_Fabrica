using Sistema_de_Controle_de.Source.Context;
using Sistema_de_Controle_de.Source.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void deletarOperario(int id)
        {
            using (var tb = new Nomus_System())
            {
                var operario = tb.Operarios.Find(id);

                tb.Operarios.Remove(operario);
                tb.SaveChanges();
            }
        }

        public void atualizarOperario(int id, string nome, string setor, string turno)
        {
            using (var tb = new Nomus_System())
            {
                var operario = tb.Operarios.Find(id);

                operario.Nome = nome;
                operario.Setor = setor;
                operario.Turno = turno;

                tb.Entry(operario).State = EntityState.Modified;
                tb.SaveChanges();
            }
        }

        public object listarOperario()
        {
            using (var tb = new Nomus_System())
            {
                var list = tb.Operarios.ToList();
                return list;
            }
        }

        public object buscarOperario(string nome)
        {
            using (var tb = new Nomus_System())
            {
                List<Operario> list;

                if (!String.IsNullOrEmpty(nome))
                {
                    list = tb.Operarios.Where(x => x.Nome == nome).AsEnumerable().ToList();
                }
                else
                {
                    list = tb.Operarios.ToList();
                }

                return list;
            }
        }

    }
}
