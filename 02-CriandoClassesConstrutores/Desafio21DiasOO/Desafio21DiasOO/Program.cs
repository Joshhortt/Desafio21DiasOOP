//02. Desafio 21 Dias de POO. Classes e Construtores
using Alunos;
using System;
using System.Collections.Generic;

namespace Alunos
{
	class Program
	{
		static void Main(string[] args)
		{
			Pessoa jose = new Pessoa();    // criando uma nova instancia atraves do modelo. Tipagem estatica
			// caracteristicas do objeto.
			jose.Id = 1;                   // ao escrver 'jose.' aparecem as variaveis dentro do objeto jose disponiveis.
			jose.Nome = "Joshhortt";
			jose.Endereço = "Rua D";
			jose.Cpf = "096905463";

			Pessoa wagner = new Pessoa();
			wagner.Id = 2;                   // Outra instancia
			wagner.Nome = "waggi";
			wagner.Endereço = "Rua B";
			wagner.Cpf = "096905461";

			Pessoa marcos = new Pessoa();
			marcos.Id = 3;                   //  Outra instancia
			marcos.Nome = "marcci";
			marcos.Endereço = "Rua C";
			marcos.Cpf = "096905462";

			var suzi = new Pessoa();  // Outra instancia, usando o 'var' em vez de 'Pessoa' tb podemos. Chama se tipagem dinamica.
			suzi.Id = 4;                   // 
			suzi.Nome = "suazii";
			suzi.Endereço = "Rua C";
			suzi.Cpf = "096905462";

			List<Pessoa> pessoas = new List<Pessoa>(); // Criando uma nova Lista de Pessoa onde colocaria todas as Pessoas

			pessoas.Add(jose);
			pessoas.Add(wagner);
			pessoas.Add(marcos);

			Console.WriteLine("Olá 2ª aula do Desafio 21 dias de POO!");
		}
	}
}
