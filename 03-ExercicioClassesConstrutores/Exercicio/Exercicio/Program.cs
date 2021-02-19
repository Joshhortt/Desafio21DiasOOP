// 03. Exercitando Classes e Construtores

using System;
using System.Collections.Generic;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("\n Caracteristicas de 3 diferentes Objectos\n");
            // Lista de Objetos Gerais
            List<Object> objetos = new List<Object>();


            // INICIO CARRO 
            // Lista Carro
            List<Carro> frota = new List<Carro>();

            Carro veiculo = new Carro();
            veiculo.Marca = "Renault";
            veiculo.Modelo = "Clio 1.9D";
            veiculo.Cor = "Cinza";
            veiculo.Preco = 13000.00F;
            frota.Add(veiculo);

            veiculo = new Carro();
            veiculo.Marca = "Mercedes Benz";
            veiculo.Modelo = "C220";
            veiculo.Cor = "Branco";
            veiculo.Preco = 24900.00F;
            frota.Add(veiculo);

            veiculo = new Carro();
            veiculo.Marca = "Fiat";
            veiculo.Modelo = "Punto S";
            veiculo.Cor = "Vermelho";
            veiculo.Preco = 9600.00F;
            frota.Add(veiculo);

            veiculo = new Carro();
            frota.Add(veiculo);

            foreach (Carro carro in frota)
               Console.WriteLine(carro.Mostrar());
            // FIM OBJETO CARRO

            Console.WriteLine("\n");

            // INCIO ANIMAL
            //Lista Animal
            List<Animal> animais = new List<Animal>();

            var animal = new Animal();
            animal.Nome = "Abelha";
            animal.Especie = "Insecto";
            animal.Sexo = "M";
            animal.Idade = 1;
            animais.Add(animal);

            animal = new Animal();
            animal.Nome = "Cao";
            animal.Especie = "Mamifero";
            animal.Sexo = "M";
            animal.Idade = 5;
            animais.Add(animal);

            animal = new Animal();
            animal.Nome = "Egua";
            animal.Especie = "Mamifero";
            animal.Sexo = "F";
            animal.Idade = 7;
            animais.Add(animal);

            animal = new Animal();
            animais.Add(animal);

            foreach (Animal serAnimado in animais)
				Console.WriteLine(serAnimado.Mostrar());
            // FIM ANIMAL

            Console.WriteLine("\n");

            // INICIO TELEVISAO
            // Lista Televisão
            List<Televisao> aparelhos = new List<Televisao>();

            var aparelho = new Televisao();
            aparelho.Marca = "Philips";
            aparelho.Tamanho = "40'";
            aparelho.Tipo = "Full HD";
            aparelho.Preco = 500.00;
            aparelhos.Add(aparelho);

            aparelho = new Televisao();
            aparelho.Marca = "Sony";
            aparelho.Tamanho = "45'";
            aparelho.Tipo = "4K";
            aparelho.Preco = 600.00;
            aparelhos.Add(aparelho);

            aparelho = new Televisao();
            aparelho.Marca = "grundig";
            aparelho.Tamanho = "28'";
            aparelho.Tipo = "UltraHD";
            aparelho.Preco = 400.00;
            aparelhos.Add(aparelho);

            aparelho = new Televisao();
            aparelhos.Add(aparelho);

            foreach (Televisao tv in aparelhos)
                Console.WriteLine(tv.Mostrar());
            //FIM TELEVISAO

            Console.ReadKey();
        }
    }
}