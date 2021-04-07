using OCP_Extensions;
using OCP_Extensions.Extensions;
using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto(
               1,
               "Caneta",
               "Caneta Esferográfica azul",
               2.00M,
               3.40M,
               100,
               true
               );

            Console.WriteLine($"Produto = {produto1.Nome} Lucro = {produto1.MargemLucro()}");

            Console.ReadLine();
        }
    }
}
