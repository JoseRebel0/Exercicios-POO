using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Ficha05
{
    internal class Autor
    {
        string nome;

        public Autor(string n)
        {
            nome = n;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
