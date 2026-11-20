using System;
using System.Collections.Generic;
using System.Text;


namespace Exercícios_Ficha05
{
    internal class Aluno : Pessoa
    {

        int numero;

        public Aluno(string n, int num) : base(n)
        {
            numero = num;
        }

        public int Numero
        {
            get { return numero; }
        }

    }
}
