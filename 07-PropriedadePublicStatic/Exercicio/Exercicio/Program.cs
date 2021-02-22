// 07. Propriedade Publica e Estatica (continuação da Herança e Polimorfismo das aulas anteriores)

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
