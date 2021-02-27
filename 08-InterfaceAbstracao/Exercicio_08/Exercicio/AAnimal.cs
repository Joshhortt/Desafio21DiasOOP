using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_08

{
    public abstract class AAnimal
    {
        public string Nome { get; set; }
        public abstract void Andar();
        public abstract void Correr();
    }
}
