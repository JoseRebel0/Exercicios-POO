using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Ficha05
{
    internal class Conta
    {
        decimal saldo = 0;


        public decimal Saldo
        {
            get { return saldo; }
            private set { saldo = value; }
        }
        
        public bool Depositar(decimal valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Levantar(decimal valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
      
    }
}
