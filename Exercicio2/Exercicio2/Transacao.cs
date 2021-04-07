using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2
{
    class Transacao : ConectarBancoDados, IRelatorio, ITransacao
    {
        public void Executa()
        {
            Console.WriteLine("Processando Transição");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimindo relatorio");
        }
    }
}
