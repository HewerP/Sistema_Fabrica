using Sistema_de_Controle_de.Source.Context;
using Sistema_de_Controle_de.Source.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Sistema_de_Controle_de.Source.Controller
{
    public class OperarioController
    {

        public void inserirOperario(string nome, string setor, string turno)
        {
            using (var tb = new Nomus_System())
            {
                tb.Operarios.Add(new Operario { Nome = nome, Setor = setor, Turno = turno });
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
