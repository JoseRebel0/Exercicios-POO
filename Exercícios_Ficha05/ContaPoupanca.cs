using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Ficha05
{
    internal class ContaPoupanca : Conta
    {
        public void AplicarJuro()
        {
            Depositar(Saldo * 0.10m);
        }
    }
}
