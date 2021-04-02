using System;
using System.Collections.Generic;

namespace PolimorfismoExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            var figuras = new List<Figura> //Polimorfismo estou instanciado triangulo e circulo, pois implicitamente são figuras.
            {
                new Triangulo(),
                new Circulo()
                
            };

            foreach(var figura in figuras)
            {
                figura.Desenhar(); //Cada figura pode ter a sua própria implementação, utilizando o mesmo nome de metódo herdado da base.
            }
            Console.ReadLine();
        }
    }
}
