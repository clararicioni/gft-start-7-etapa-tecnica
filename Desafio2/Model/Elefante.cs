using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio2.Model
{
    public class Elefante : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Prrrrrrrrrrr!");
        }
    }
}