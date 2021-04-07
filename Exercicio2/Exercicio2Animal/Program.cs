using System;

namespace Exercicio2Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Ave("Pato");
            animal1.Mover();
            Animal animal2 = new Peixe("Tubarão");
            animal2.Mover();
            Console.ReadLine();

        }
    }
}
