using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Ficha05
{
    class Retangulo : Figura
    {
         private double largura, altura;

        public Retangulo(double l, double a)
        {
            largura = l;
            altura = a;
        }

        public override double Area()
        {

            return largura * altura;

        }
    }
}
