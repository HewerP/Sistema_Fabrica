using Sistema_de_Controle_de.Source.Context;
using Sistema_de_Controle_de.Source.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sistema_de_Controle_de.Source.Controller
{
    internal class ClienteController
    {

        public void inserirCliente(string nome, string telefone, string email, string dataNascimento, string rua, int nCasa, string complemento, string bairro, string cidade, string estado)
        {
            using (var tb = new Nomus_System())
            {
                Endereco endereco = new Endereco { Rua = rua, NCasa = nCasa, Complemento = complemento, Bairro = bairro, Cidade = cidade, Estado = estado };
                tb.Enderecos.Add(endereco);
                tb.Clientes.Add(new Cliente { Nome = nome, Telefone = telefone, Email = email, DataNascimento = dataNascimento, Endereco = endereco });
                tb.SaveChanges();
            }
        }

        public void deletarCliente(int id)
        {
            using (var tb = new Nomus_System())
            {
                var cliente = tb.Clientes.Find(id);

                tb.Clientes.Remove(cliente);
                tb.SaveChanges();
            }
        }

        public void atualizarCliente(int id, string nome, string telefone, string email, string dataNascimento, string rua, int nCasa, string complemento, string bairro, string cidade, string estado)
        {
            using (var tb = new Nomus_System())
            {
                var cliente = tb.Clientes.Find(id);

                cliente.Nome = nome;
                cliente.Telefone = telefone;
                cliente.Email = email;
                cliente.DataNascimento = dataNascimento;
                cliente.Endereco.Rua = rua;
                cliente.Endereco.NCasa = nCasa;
                cliente.Endereco.Complemento = complemento;
                cliente.Endereco.Bairro = bairro;
                cliente.Endereco.Cidade = cidade;
                cliente.Endereco.Estado = estado;

                tb.Entry(cliente).State = EntityState.Modified;
                tb.SaveChanges();
            }
        }

        public object listarCliente()
        {
            using (var tb = new Nomus_System())
            {
                var list = tb.Clientes.ToList();
                return list;
            }
        }

        public object buscarCliente(string nome)
        {
            using (var tb = new Nomus_System())
            {
                List<Cliente> list;

                if (!String.IsNullOrEmpty(nome))
                {
                    list = tb.Clientes.Where(x => x.Nome == nome).AsEnumerable().ToList();
                }
                else
                {
                    list = tb.Clientes.ToList();
                }

                return list;
            }
        }
    }
}
