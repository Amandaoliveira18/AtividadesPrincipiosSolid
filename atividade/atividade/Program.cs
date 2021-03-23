using AtividadeFundamentos;
using System;

namespace atividade
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Soma soma1 = new Soma();
            soma1.Conta();
            Soma soma2 = new Soma();
            Console.WriteLine(soma2.SomaOpcionalNumeros(5,20,50,100)); 


        }
    }
}
