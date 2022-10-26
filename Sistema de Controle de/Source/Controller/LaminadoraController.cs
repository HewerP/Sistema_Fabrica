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
    internal class LaminadoraController
    {

        public void inserirLaminadora(string dataInicio, string dataTermino, string horarioEntrada, string horarioSaida, char turno, double quantidadeProduzida, Estoque material, double pesoEntrada, double pesoSaida, double gramaturaEntrada, double gramaturaSaida, double metragem, int tela)
        {
            using (var tb = new Nomus_System())
            {
                Data_Producao data_Producao = new Data_Producao { DataInicio = dataInicio, DataTermino = dataTermino, HorarioEntrada = horarioEntrada, HorarioSaida = horarioSaida };
                tb.Datas_Producoes.Add(data_Producao);
                tb.Laminadoras.Add(new Laminadora(data_Producao, turno, quantidadeProduzida, material, pesoEntrada, pesoSaida, gramaturaEntrada, gramaturaSaida, metragem, tela));
                tb.SaveChanges();
            }
        }

        public void deletarLaminadora(int id)
        {
            using (var tb = new Nomus_System())
            {
                var laminadora = tb.Laminadoras.Find(id);

                tb.Laminadoras.Remove(laminadora);
                tb.SaveChanges();
            }
        }

        public void atualizarLaminadora(int id, string dataInicio, string dataTermino, string horarioEntrada, string horarioSaida, char turno, double quantidadeProduzida, Estoque material, double pesoEntrada, double pesoSaida, double gramaturaEntrada, double gramaturaSaida, double metragem, int tela)
        {
            using (var tb = new Nomus_System())
            {
                var laminadora = tb.Laminadoras.Find(id);


                laminadora.Data.DataInicio = dataInicio;
                laminadora.Data.DataTermino = dataTermino;
                laminadora.Data.HorarioEntrada = horarioEntrada;
                laminadora.Data.HorarioSaida = horarioSaida;
                laminadora.Turno = turno;
                laminadora.QuantidadeProduzida = quantidadeProduzida;
                laminadora.Material = material;
                laminadora.PesoEntrada = pesoEntrada;
                laminadora.PesoSaida = pesoSaida;
                laminadora.GramaturaEntrada = gramaturaEntrada;
                laminadora.GramaturaSaida = gramaturaSaida;
                laminadora.Metragem = metragem;
                laminadora.Tela = tela;

                tb.Entry(laminadora).State = EntityState.Modified;
                tb.SaveChanges();
            }
        }

        public object listarLaminadora()
        {
            using (var tb = new Nomus_System())
            {
                var list = tb.Laminadoras.ToList();
                return list;
            }
        }

        public object buscarLaminadora(int id)
        {
            using (var tb = new Nomus_System())
            {
                List<Laminadora> list;

                if (id != 0)
                {
                    list = tb.Laminadoras.Where(x => x.Id == id).AsEnumerable().ToList();
                }
                else
                {
                    list = tb.Laminadoras.ToList();
                }

                return list;
            }
        }
    }
}
