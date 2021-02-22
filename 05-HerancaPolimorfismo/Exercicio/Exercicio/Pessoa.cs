using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public Pessoa()
        {
         }

        public Pessoa(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }
    }
}
