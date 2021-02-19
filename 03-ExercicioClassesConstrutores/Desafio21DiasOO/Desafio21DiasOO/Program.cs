
//03. Exercicio: Exercitando Classes e Construtores
// Criar uma Instancia de uma classe chamada Bolo.
// A classe Receita tem de ter 4 Propriedades (Peso, tamanho, preço e nome.)
// A classe Receita tem de ter 2 Metodos (Salvar() e Mostrar().

using System;

namespace Desafio21DiasOO

	{
    class Program
    {
        static void Main(string[] args)
        {
            Receita boloChocolate = new Receita();

            boloChocolate.Nome = "Bolo de chocolate";
            boloChocolate.Tamanho = "Pequeno";
            boloChocolate.Peso = 1.2F;  // Float
         // boloChocolate.Peso = 1.2;  Double
            boloChocolate.Preco = 35.00F;

            Receita boloLaranja = new Receita();
            boloLaranja.Nome = "Bolo Laranja";
            boloLaranja.Peso = 1.4F;  // Float
         // boloLaranja.Peso = 1.4; Double
            boloLaranja.Tamanho = "Medio";
            boloLaranja.Preco = 40.00F;

            Receita boloMorango = new Receita();
            boloMorango.Nome = "Bolo Morango";
            boloMorango.Peso = 1.7F;  // Float
        //  boloMorango.Peso = 1.7;  Double
            boloMorango.Tamanho = "Grande";
            boloMorango.Preco = 45.00F;
        }
    }
}
