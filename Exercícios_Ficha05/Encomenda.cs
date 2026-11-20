using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Ficha05
{
    internal class Encomenda
    {
        private Linha linha;

        public Encomenda(int quantidade, decimal preco)
        {
            linha = new Linha(quantidade, preco);
        }

        public decimal Total()
        {
            return linha.Total();
        }
    }
}
