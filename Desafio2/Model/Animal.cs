using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio2.Model
{
    public class Animal
    {
        private string? Nome { get; set; }
        private string? Som { get; set; }

        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal faz um som");
        }
    };

}