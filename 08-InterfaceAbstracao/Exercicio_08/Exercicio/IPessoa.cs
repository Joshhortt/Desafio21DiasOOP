using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_08
{
	public interface IPessoa
	{
		void Salvar();
		void Buscar(string nome);
		void Excluir();
	}
}
