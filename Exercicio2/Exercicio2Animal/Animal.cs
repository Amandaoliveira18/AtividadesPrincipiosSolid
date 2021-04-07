using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2Animal
{
    abstract class Animal
    {
        public string Tipo { get; set; }

        public Animal(string tipo)
        {
            Tipo = tipo;
        }

        public abstract void Mover();
      
    }
}
