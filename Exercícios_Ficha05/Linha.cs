using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Ficha05
{
    internal class Linha
    {
        int quantidade;
        decimal preco;

        public Linha(int q, decimal p)
        {
            quantidade = q;
            preco = p;
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public decimal Total()
        {
            return quantidade * preco;
        }
    }
}
