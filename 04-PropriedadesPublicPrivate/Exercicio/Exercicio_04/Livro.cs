using System;

namespace Exercicio_04
{
	public class Livro
	{
		public string Nome { get; set; }
		private string Descricao { get; set; }
		protected string Autor { get; set; }
		internal string Versao { get; set; }  // não pode ser chamado no programa.cs
		public string Versão { get; set; }  // Agora tem acesso no programa.cs
	}
}
