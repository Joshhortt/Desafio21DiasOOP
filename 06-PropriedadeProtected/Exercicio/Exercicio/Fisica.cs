using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
    class Fisica : Pessoa
    {
        public Fisica(string nome)
        {
            this.Nome = nome;
            this.Nome = this.NomePersonalizadoProtected();
            this.Nome = this.NomePersonalizadoVirtual();
        }

        //sobrescreve um metodo protected na herança - 'new' é considerado polimorfismo
        public new string NomePersonalizadoProtected()
        {
            return $"{base.NomePersonalizadoProtected()} --- sobrescrevendo meu nome --- \n";
        }

        //inclui outra assinatura para o metodo protected na heranca.
        public string NomePersonalizadoProtected(string nome)
        {
            return $"{base.NomePersonalizadoProtected()} {nome}\n";
        }
        
        //sobrescreve o metodo virtual na herança com o override
        public override string NomePersonalizadoVirtual()
        {
            return $" {base.NomePersonalizadoVirtual()}\n";
        }

        // inclui outra assinatura para o metodo virtual.
        public string NomePersonalizadoVirtual(string nome)
        {
            return $"{base.NomePersonalizadoVirtual()} --- sobrescrevendo meu nome outraves ---  {nome}";
        }
    }
}
