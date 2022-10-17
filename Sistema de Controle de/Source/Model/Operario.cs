using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    internal class Operario
    {
        private int id;
        private string nome;
        private string turno;
        private Producao setor;

        public Operario(int id, string nome, Producao setor)
        {
            this.id = id;
            this.nome = nome;
            this.setor = setor;
        }

        public int getID()
        {
            return id;
        }
        public void setID(int id)
        {
            this.id = id;
        }

        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getTurno()
        {
            return turno;
        }
        public void setTurno(string turno)
        {
            this.turno = turno;
        }

        public Producao getSetor()
        {
            return setor;
        }
        public void setSetor(Producao setor)
        {
            this.setor = setor;
        }
    }
}
