using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio3.Model
{
    public class Agenda
    {
        private List<Contato> contatos = new List<Contato>();

        #region AdicionarContato
        public void AdicionarContato(Contato contato)
        {
            contatos.Add(contato);
        }
        #endregion

        #region ListarContatos
        public void ListarContatos()
        {
            if (contatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato na agenda");
                return;
            }

            Console.WriteLine("Contatos na agenda:");
            foreach (var contato in contatos)
            {
                Console.WriteLine(contato);
            }
        }
        #endregion

        #region BuscarContato
        public void BuscarContato(string nome)
        {
            bool encontrado = false;
            foreach (var contato in contatos)
            {
                if (contato.Nome.Contains(nome))
                {
                    Console.WriteLine(contato);
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Nenhum contato encontrado");
            }
        }
        #endregion

        #region RemoverContato
        public void RemoverContato(string nome)
        {
            var contato = contatos.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (contato != null)
            {
                contatos.Remove(contato);
                Console.WriteLine("Contato removido com sucesso");
            }
            else
            {
                Console.WriteLine("Contato não encontrado");
            }
        }
        #endregion
    }
}