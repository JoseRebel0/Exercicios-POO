using System;
using System.Collections.Generic;
using System.Text;


namespace Exercícios_Ficha05
{
    internal class Pessoa
    {
        string nome;
        
        public Pessoa(string n)
        {
            nome = n;
        }

        public string Nome
        {
            get { return nome; }
        }

        public virtual string Descrever()
        {
            return nome;
        }
    }
}
