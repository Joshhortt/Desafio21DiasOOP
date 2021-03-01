using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_09
{
	public class Pagamento : IPagamento

	{
		//public DateTime Vencimento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public DateTime Vencimento { get; set; }
		//public decimal Valor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public decimal Valor { get; set; }

		public void Pagar(decimal valor)
		{
			//throw new NotImplementedException();
		}
	}
}
