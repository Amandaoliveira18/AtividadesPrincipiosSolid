using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Extensions.Extensions
{
    public static class ProdutoExtension
    {
        public static double MargemLucro(this Produto produto) // metódo de instancia devido ao this
        {
            try
            {
                var lucroLiquido = produto.Venda - produto.Custo;
                var margemLucro = (lucroLiquido / produto.Venda) * 100;
                return Convert.ToDouble(margemLucro);
            }
            catch(Exception)
            {
                throw new InvalidOperationException ("Erro ao calcular a margem a lucro");

            }
        }
    }
}
