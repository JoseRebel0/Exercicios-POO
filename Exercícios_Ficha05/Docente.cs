using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Ficha05
{
    internal class Docente : Pessoa
    {
        public Docente(string n) : base(n)
        {
        }

        public override string Descrever()
        {
            return base.Descrever() + " - docente";
        }
    }
}
