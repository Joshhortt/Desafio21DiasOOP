using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        protected string NomePersonalizadoProtected()
        {
            return $"\nOla {Nome} eu sou o metodo Protected:\n";
        }
        public virtual string NomePersonalizadoVirtual()
        {
            return $"\nOla {Nome} eu sou o Metodo Virtual:\n";
        }

    }
}
