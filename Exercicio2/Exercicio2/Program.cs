using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Transacao transacao = new Transacao();
            transacao.Conectar();
            transacao.Executa();
            transacao.Imprimir();
        }
    }
}
