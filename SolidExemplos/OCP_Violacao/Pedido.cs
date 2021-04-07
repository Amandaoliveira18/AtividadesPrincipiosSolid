using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Violacao
{
    //...outro codigo
    public enum TipoCliente
    {
        Comum,
        Associado,
        Especial
    };
    class Pedido
    {
        public double DescontoPedido(double valor, TipoCliente tipoCliente)
        {
            double valorFinal;

            if (tipoCliente == TipoCliente.Especial)
            {
                valorFinal = valor - 50;
            }
            else if (tipoCliente == TipoCliente.Associado)
            {
                valorFinal = valor - 10;
            }
            else
            {
                valorFinal = valor;
            }
            return valorFinal;
        }
    }
}
