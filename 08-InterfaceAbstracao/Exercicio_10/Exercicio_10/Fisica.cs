using System;
using System.Collections.Generic;

namespace Exercicio_10
{
    public class Fisica : Pessoa
    {
        public string Cpf { get; set; }
        public Fisica() { }

        public override void Excluir()
        {
            Servico.Excluir(this);
        }

        public override string getDocumento()
        {
            return this.Cpf;
        }
    }
}

