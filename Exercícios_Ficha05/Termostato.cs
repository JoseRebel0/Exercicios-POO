using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Ficha05
{
    internal class Termostato
    {
        int temperatura = 20;

        public int Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }

        public bool Definir( int t)
        {
            if (t >= 16 && t <= 30)
            {
                return true;
            }
            else
            {
                return false;
            }
            temperatura = t;
        }
    }
}
