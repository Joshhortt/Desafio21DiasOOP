// 05. Herança e Polimorfismo

using System;

namespace Exercicio
{
    class Program
    {
         static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("", "");
            Pessoa pessoaUm = new Pessoa()
            {
                Nome = "",
                Endereco = "",
            };

            Fisica pessoaFisica = new Fisica();
            Juridica pessoaJuridica = new Juridica("", "", "", "");

            Console.WriteLine("Olá aula 5!");
        }
    }
}
