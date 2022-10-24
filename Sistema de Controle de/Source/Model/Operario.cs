using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    public class Operario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Turno { get; set; }
        public string Setor { get; set; }

        /*public Operario(int id, string nome, string turno, string setor)
        {
            Id = id;
            Nome = nome;
            Turno = turno;
            Setor = setor;
        }*/
    }
}
