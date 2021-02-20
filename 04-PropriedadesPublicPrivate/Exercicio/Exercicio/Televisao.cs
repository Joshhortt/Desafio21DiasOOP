

using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
	public class Televisao
	{
		public Televisao(string marca = " ",
		   string tamanho = " ",
		   string tipo = " ",
		   double preco = 0.0)
		{
			this.Marca = marca;
			this.Tamanho = tamanho;
			this.Tipo = tipo;
			this.Preco = preco;	
		}

		public string Marca { get; set; }
		public string Tamanho { get; set; }
		public string Tipo { get; set; }
		public double Preco { get; set; }
		
		public string Mostrar()
		{
			return string.Format("Televisao (Caracteristicas) Marca: {0}, Tamanho: {1}, Tipo: {2}, Preço: {3}", this.Marca, this.Tamanho, this.Tipo, this.Preco);
		}
	}
}