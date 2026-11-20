using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Ficha05
{
    internal class Veiculo
    {
        string marca;

        public string Marca
        {
            get { return marca; }
        }

        public Veiculo(string m)
        {
            marca = m;
        }

        public string Identificar()
        {
            return marca;

        }
    }
}
