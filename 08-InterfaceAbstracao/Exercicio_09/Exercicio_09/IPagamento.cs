using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_09
{
	public interface IPagamento // Interface é um contrato. só permite assinaturas. não permite metodos...
	{
		DateTime Vencimento { get; set; }

		decimal Valor { get; set; }

		void Pagar(decimal valor);
	}
}
