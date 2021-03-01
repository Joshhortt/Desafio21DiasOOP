// EXERCICIO TPC 10. Abstração e Interface
using System;

namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var fisicas = new Fisica().Todos();
            var juridicas = new Juridica().Todos();

            foreach (var item in fisicas)
            {
                Console.WriteLine(item);
            }

            foreach (var item in juridicas)
            {
                Console.WriteLine(item);
            }

            new Fisica() { Nome = "Jose Calvario", Endereco = "Rua D, 15", Id = 1 }.Salvar();
            new Juridica() { Nome = "Empresa XPTO", Endereco = "Rua A, 18", Id = 2 }.Salvar();
        }
    }
}
