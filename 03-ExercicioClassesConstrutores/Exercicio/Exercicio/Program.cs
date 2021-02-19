// 03. Exercitando Classes e Construtores

using System;
using System.Collections.Generic;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
      
            // Lista de objetos
            List<Object> objetos = new List<Object>();


            // Inicio Carro
            List<Carro> frota = new List<Carro>();
            
            Carro veiculo = new Carro();
            veiculo.Marca = "Renault";
            veiculo.Modelo = "Clio 1.9D";
            veiculo.Cor = "Cinza";
            veiculo.Preco = 13000.00F;
            frota.Add(veiculo);

            //  veiculo
            objetos.Add(veiculo);

            veiculo = new Carro();
            veiculo.Marca = "Mercedes Benz";
            veiculo.Modelo = "C220";
            veiculo.Cor = "Branco";
            veiculo.Preco = 24900.00F;
            frota.Add(veiculo);

            // veiculo
            objetos.Add(veiculo);

            veiculo = new Carro();
            veiculo.Marca = "Fiat";
            veiculo.Modelo = "Punto S";
            veiculo.Cor = "Vermelho";
            veiculo.Preco = 9600.00F;
            frota.Add(veiculo);

            // veiculo
            objetos.Add(veiculo);

            veiculo = new Carro();
            frota.Add(veiculo);

            // veiculo
            objetos.Add(veiculo);

            foreach (Carro carro in frota)
               Console.WriteLine(carro.Mostrar());
            // Fim Carro


            // INCIO ANIMAL
            List<Animal> animais = new List<Animal>();
            var animal = new Animal();
            animal.Nome = "Abelha";
            animal.Especie = "Insecto";
            animal.Sexo = "M";
            animal.Idade = 1;
            animais.Add(animal);

            // animal
            objetos.Add(animal);

            animal = new Animal();
            animal.Nome = "Cao";
            animal.Especie = "Mamifero";
            animal.Sexo = "M";
            animal.Idade = 5;
            animais.Add(animal);

            // animal
            objetos.Add(animal);

            animal = new Animal();
            animal.Nome = "Egua";
            animal.Especie = "Mamifero";
            animal.Sexo = "F";
            animal.Idade = 7;
            animais.Add(animal);

			// animal
			objetos.Add(animal);

			foreach (Animal serAnimado in animais)
				Console.WriteLine(serAnimado.Mostrar());
			// Fim Animal

			// Inicio Televisao
			List<Televisao> aparelhos = new List<Televisao>();
            var aparelho = new Televisao();
            aparelho.Marca = "Philips";
            aparelho.Tamanho = "40'";
            aparelho.Preco = 500.00;
            aparelho.Tipo = "Full HD";
            aparelhos.Add(aparelho);

            // aparelhos
            objetos.Add(aparelhos);

            aparelho = new Televisao();
            aparelho.Marca = "Sony";
            aparelho.Tamanho = "45'";
            aparelho.Preco = 600.00;
            aparelho.Tipo = "4K";
            aparelhos.Add(aparelho);

            // aparelhos
            objetos.Add(aparelhos);

            aparelho = new Televisao();
            aparelho.Marca = "grundig";
            aparelho.Tamanho = "28'";
            aparelho.Preco = 400.00;
            aparelho.Tipo = "UltraHD";
            aparelhos.Add(aparelho);

            //  aparelhos
            objetos.Add(aparelhos);

            foreach (Televisao tv in aparelhos)
                Console.WriteLine(tv.Mostrar());
            //Fim Televisao

            Console.ReadKey();
        }
    }
}