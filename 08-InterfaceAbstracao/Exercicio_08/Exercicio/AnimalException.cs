using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_08

{
    public class AnimalException : Exception
    {
        private string mensagem;
        public AnimalException(string mensagem)
        {
            this.mensagem = mensagem;
        }
        public override string ToString()
        {
            return this.mensagem;
        }
        public override string Message => this.mensagem;
    }
}
