using System;
using System.Collections.Generic;
using System.Text;

namespace PolimorfismoExemplo
{
    class Triangulo : Figura
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um triangulo...");
        }
    }
}
