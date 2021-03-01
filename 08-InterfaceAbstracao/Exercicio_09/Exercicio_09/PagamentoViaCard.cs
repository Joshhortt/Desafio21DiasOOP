using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_09
{
	public class PagamentoViaCard : IPagamento
	{
		
		DateTime IPagamento.Vencimento { get; set; }
		
		decimal IPagamento.Valor { get; set; }

		void IPagamento.Pagar(decimal valor)
		{
			
		}
	}
}
