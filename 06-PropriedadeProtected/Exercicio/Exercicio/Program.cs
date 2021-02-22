// 05. Propriedade Protected (continuação da Herança e Polimorfismo da aula anterior)

using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Fisica usuario = new Fisica("Jose");
            Console.WriteLine(usuario.Nome);
            Console.WriteLine(usuario.NomePersonalizadoProtected());
            Console.WriteLine(usuario.NomePersonalizadoVirtual());

            System.Console.ReadKey();
        }
    }
}
