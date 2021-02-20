
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
    public class Carro
    {
		public Carro(string marca = " ",
			string modelo = " ",
			string cor = " ",
			float preco = 0.0F)
		{
			this.Marca = marca;
			this.Modelo = modelo;
			this.Cor = cor;
			this.Preco = preco;
		}

		public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public float Preco{ get; set; }

		public string Mostrar()
		{
			return string.Format("Carro (caracteristicas) - Marca: {0}, Modelo: {1}, Cor: {2}, Preço: {3}", this.Marca, this.Modelo, this.Cor, this.Preco);
		}

	}
}