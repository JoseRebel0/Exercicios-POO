using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Ficha05
{
    internal class Televisao
    {
        bool ligada = false;


        public bool Ligada
        {
            get { return ligada; }
        }

        //Métodos
        public void Ligar()
        {
            ligada = true;
        }

        public void Desligar()
        {
            ligada = false;
        }


    }
}
