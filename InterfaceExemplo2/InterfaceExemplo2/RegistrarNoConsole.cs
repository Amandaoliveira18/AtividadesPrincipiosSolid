using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExemplo2
{
    class RegistrarNoConsole : IRegistro
    {
        public void RegistraInfo(string mensagem)
        {
            Console.WriteLine($"info: {mensagem}");
        }
    }
}
