using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de.Source.Model
{
    internal class Endereco
    {
        private string rua;
        private int nCasa;
        private string complemento;
        private string bairro;
        private string cidade;
        private string estado;

        public Endereco(string rua, int nCasa, string complemento, string bairro, string cidade, string estado)
        {
            this.rua = rua;
            this.nCasa = nCasa;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
        }

        public string getRua()
        {
            return rua;
        }
        public void setRua(string rua)
        {
            this.rua = rua;
        }

        public int getNCasa()
        {
            return nCasa;
        }
        public void setNCasa(int nCasa)
        {
            this.nCasa = nCasa;
        }

        public string getComplemento()
        {
            return complemento;
        }
        public void setComplemento(string complemento)
        {
            this.complemento = complemento;
        }

        public string getBairro()
        {
            return bairro;
        }
        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public string getCidade()
        {
            return cidade;
        }
        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public string getEstado()
        {
            return estado;
        }
        public void setEstado(string estado)
        {
            this.estado = estado;
        }
    }
}
