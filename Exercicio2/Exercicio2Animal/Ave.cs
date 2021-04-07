using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2Animal
{
    class Ave : Animal
    {
        public Ave(string tipoAnimal) : base(tipoAnimal)
        {

        }

        public override void Mover()
        {
            Console.WriteLine("Voando 20 metros");
        }
    }
}
