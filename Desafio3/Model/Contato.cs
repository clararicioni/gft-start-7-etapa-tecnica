using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio3.Model
{
    public class Contato
    {
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }
}