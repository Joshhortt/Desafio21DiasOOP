

using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
	public class Televisao
	{

		public Televisao(string marca = " ",
		   string tamanho = " ",
		   double preco = 0.0,
		   string tipo = " ")
		{
			this.Marca = marca;
			this.Tamanho = tamanho;
			this.Preco = preco;
			this.Tipo = tipo;
		}

		public string Marca { get; set; }
		public string Tamanho { get; set; }
		public double Preco { get; set; }
		public string Tipo { get; set; }

		public string Mostrar()
		{
			return string.Format("Televisao (Caracteristicas) {0}, Tamanho: {1}, Preço: {2}, Tipo: {3}", this.Marca, this.Tamanho, this.Preco, this.Tipo);
		}
	}
}