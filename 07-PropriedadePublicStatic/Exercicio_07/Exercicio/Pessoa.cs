using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public virtual string NomePersonalizado() { return $"{this.Nome} - Aula torne-se um programador"; }
    }
} 