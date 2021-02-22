// 07. Propriedade Publica e Estatica (continuação da Herança e Polimorfismo das aulas anteriores)

using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            var fisica = new Fisica();
            fisica.Nome = "jose Horta";
            fisica.Endereco = "Rua D, 14";
            fisica.Cpf = "178.239.356";
            fisica.Rg = "09690543-3";

            System.Console.WriteLine(String.Format("{0} - {1} - {2} - {3}", fisica.Nome, fisica.Endereco, fisica.Cpf, fisica.Rg));

            var juridica = new Juridica();
            juridica.Nome = "AMP SERVICOS";
            juridica.Endereco = "Rua ABC, 5";
            juridica.Cnpj = "02.284.361/004-49";
            juridica.NomeFantasia = "AMP SERV";

            System.Console.WriteLine(String.Format("{0} - {1} - {2} - {3}", juridica.Nome, juridica.Endereco, juridica.Cnpj, juridica.NomeFantasia));

            System.Console.ReadKey();

            var dados = Fisica.Base;
            Fisica usuario = new Fisica("jose Horta");
            Console.WriteLine(usuario.Nome);
            Console.WriteLine(usuario.NomePersonalizadoProtected());
            Console.WriteLine(usuario.NomePersonalizadoVirtual());

			// propriedade static metodo static
			new Fisica() { Nome = "Jose", Cpf = "178" }.Salvar();
			new Fisica() { Nome = "Jose Horta", Cpf = "178.239.356-14" }.Salvar();
			new Fisica() { Nome = "Alex Rebelo", Cpf = "178.239.357-14" }.Salvar();
			new Fisica() { Nome = "Ana Calvario", Cpf = "178.239.358-14" }.Salvar();
			new Fisica() { Nome = "Sofia Rebelo", Cpf = "178.239.359-14" }.Salvar();

            foreach (var instancia in Fisica.Todas())
            {
                Console.WriteLine(instancia.Nome);
            }

            System.Console.ReadKey();
        }
    }
}
