using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Ficha05
{
    internal class Stock
    {

        int quantidade = 0;

        public int Quantidade
        {
            get { return quantidade; }
        }

        public bool Repor(int n)
        {
            if (n > 0)
            {
                quantidade += n;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Retirar(int n)
        {
            if (n > 0 && n <= quantidade)
            {
                quantidade -= n;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
