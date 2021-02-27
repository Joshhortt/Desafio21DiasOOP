using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_08

{
    public class Gato : AAnimal
    {
        public override void Andar()
        {
            if (string.IsNullOrEmpty(this.Nome))
            {
                throw new AnimalException("O nome nao pode ser vazio");

            }
            throw new Exception();
        }

        public override void Correr()
        {
            throw new NotImplementedException();
        }
    }
}

