using System;
using System.Collections.Generic;
using System.Text;

namespace Alunos
{
	public class Pessoa
	{
		public Pessoa()  // Cosntrutor
		{
		}

		public int Id { get; set; }
		public string Nome { get; set; }
		public string Endereço { get; set; }
		public string Cpf { get; set; }
	}
}
