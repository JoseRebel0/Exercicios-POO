using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Ficha05
{
    internal class Carro : Veiculo
    {
        int portas;

        public int Portas
        {
            get { return portas; }
        }

        public Carro(string m, int p) : base(m)
        {
            portas = p;
        }
    }
}
