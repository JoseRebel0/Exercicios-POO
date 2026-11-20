using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Ficha05
{
    internal class Livro
    {
        string titulo;
        string autor;

        public Livro(string t, string a)
        {
            titulo = t;
            autor = a;
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
    }
}
