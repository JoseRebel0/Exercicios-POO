using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Exercícios_Ficha05
{
    internal class Veterinario
    {
        public string Ouvir(Animal animal)
        {
            return animal.EmitirSom();
        }
    }
}
