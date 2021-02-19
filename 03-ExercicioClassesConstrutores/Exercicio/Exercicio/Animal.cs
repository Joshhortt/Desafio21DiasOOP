
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
	public class Animal
	{
		public Animal(string nome = " ",
		   string especie = " ",
		   string sexo = " ",
		   int idade = 0)
		{
			this.Nome = nome;
			this.Especie = especie;
			this.Sexo = sexo;
			this.Idade = idade;
		}

		public string Nome { get; set; }
		public string Especie { get; set; }
		public string Sexo { get; set; }
		public int Idade { get; set; }

		public string Mostrar()
		{
			return string.Format("Animal (Caracteristicas) Nome: {0}, Tipo: {1}, Sexo: {2}, Idade: {3}", this.Nome, this.Especie, this.Sexo, this.Idade);
		}
	}
}