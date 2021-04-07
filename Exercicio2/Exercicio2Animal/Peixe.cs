using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2Animal
{
    class Peixe : Animal
    {
        public Peixe(string tipoAnimal): base(tipoAnimal)
        {

        }
        public override void Mover()
        {
            Console.WriteLine("Nadando 15 metros");
        }
    }
}
