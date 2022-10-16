using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    internal abstract class Producao
    {
        private int id;
        private Data_Producao data;
        private char turno;
        private double producao;
        private Estoque material;

        public Producao(int id, Data_Producao data, char turno, double producao, Estoque material)
        {
            this.id = id;
            this.data = data;
            this.turno = turno;
            this.producao = producao;
            this.material = material;
        }

        public int getID()
        {
            return id;
        }
        public void setID(int id)
        {
            this.id = id;
        }

        public Data_Producao getData()
        {
            return data;
        }
        public void setData(Data_Producao data)
        {
            this.data = data;
        }

        public char getTurno()
        {
            return turno;
        }
        public void setTurno(char turno)
        {
            this.turno = turno;
        }

        public double getProducao()
        {
            return producao;
        }
        public void setProducao(double producao)
        {
            this.producao = producao;
        }

        public Estoque getMaterial()
        {
            return material;
        }
        public void setMaterial(Estoque material)
        {
            this.material = material;
        }
    }
}
