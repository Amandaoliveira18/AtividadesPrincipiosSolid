using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Aderente
{
    class DescontoClienteAssociado : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal - 10;
        }
    }
}
