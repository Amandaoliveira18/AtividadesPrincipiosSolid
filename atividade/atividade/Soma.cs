using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeFundamentos
{
    public class Soma
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public Soma(int numero1, int numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }
        public Soma()
        {
            
        }

        public int Conta(int numero1, int numero2)
        {
            return (numero1 + numero2);
        }

        public void Conta()
        {
            Console.WriteLine("Nenhum número informado");
        }
       

        public int SomaOpcionalNumeros(int x, int y=20,int z=30,int w = 10)
        {
            return x + y + z + w;
        }
    }
}
