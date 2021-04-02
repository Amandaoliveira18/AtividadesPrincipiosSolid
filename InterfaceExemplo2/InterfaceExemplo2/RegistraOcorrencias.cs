using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExemplo2
{
    class RegistraOcorrencias
    {
        private readonly IRegistro _registro;

        public RegistraOcorrencias(IRegistro registro)
        {
            _registro = registro;
        }

        public void Registrar(string mensagem)
        {
            _registro.RegistraInfo($"{mensagem }: {DateTime.Now}");
        }
    }
}
