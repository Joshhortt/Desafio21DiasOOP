using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
	// public class Pessoa : IPessoa  // IPessoa aparece como erro pq vou ter que fazer a implementação*. 
	   public abstract class Pessoa : IPessoa  // ** Para que seja possivel as implementações tornar a classe abstrata permite outra flexibilidade
	{
        public Pessoa()
        {
        }

        public string Nome { get; set; }
        public string Endereco { get; set; }

		public virtual string NomePersonalizado() { return $"{this.Nome} - Aula torne-se um programador"; }

		public abstract void Buscar();  // ** como ja nao precisamos da implementação incluimos o abstract
		//{
		//	throw new NotImplementedException();  // *Implementaçao do inteface gerado pelo Intellisense
		//}

		public abstract void Excluir(); // ** como ja nao precisamos da implementação incluimos o abstract
		//{
		//	throw new NotImplementedException(); // *Implementaçao do inteface gerado pelo Intellisense
		//}

		public abstract void Salvar();  // ** como ja nao precisamos da implementação incluimos o abstract
		//{
		//	throw new NotImplementedException(); // *Implementaçao do inteface gerado pelo Intellisense
		//}
	}
}