using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
    class Fisica : Pessoa
    {
        public string CC { get; set; }
        public string NIF { get; set; }

        public Fisica() : base()
        {

        }

        public Fisica(string cc, string nif)
        {
            CC = cc;
            NIF = nif;
        }
    }
}
