using System;
using System.Collections.Generic;
using System.Text;

namespace PolimorfismoExemplo
{
    class Circulo : Figura
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando circulo...");
        }
    }
}
